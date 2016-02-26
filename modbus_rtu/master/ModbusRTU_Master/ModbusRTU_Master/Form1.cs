using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//step1. reference nmodbuspc.dll, and using the namespaces.
using Modbus.Device;    //for modbus master
using System.IO.Ports;  //for serial port

namespace ModbusRTU_Master
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort(); //create a new SerialPort object with default settings.
        ModbusSerialMaster master;
        
        List<TextBox> listAI = new List<TextBox>();
        List<TextBox> listAO = new List<TextBox>();
        List<PictureBox> listDI = new List<PictureBox>();
        List<PictureBox> listDO = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();  
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comcmb.SelectedIndex = 2;
            baudcmb.SelectedIndex = 0;
            dbcmb.SelectedIndex = 0;
            ptycmb.SelectedIndex = 0;
            sbcmb.SelectedIndex = 0;

            listDI.Add(DI0);
            listDI.Add(DI1);
            listDI.Add(DI2);
            listDI.Add(DI3);

            listDO.Add(DO0);
            listDO.Add(DO1);
            listDO.Add(DO2);
            listDO.Add(DO3);

            listAI.Add(AI0);
            listAI.Add(AI1);
            listAI.Add(AI2);
            listAI.Add(AI3);

            listAO.Add(AO0);
            listAO.Add(AO1);
            listAO.Add(AO2);
            listAO.Add(AO3);

            openbtn.Enabled = true;
            closebtn.Enabled = false;
        }
        //open port
        private void openbtn_Click(object sender, EventArgs e)
        {           
            serialPort.PortName = comcmb.SelectedItem.ToString();
            serialPort.BaudRate = int.Parse(baudcmb.SelectedItem.ToString());
            serialPort.DataBits = int.Parse(dbcmb.SelectedItem.ToString());
            //get parity
            if (ptycmb.SelectedIndex == 0)  
                serialPort.Parity = Parity.None;
            else if (ptycmb.SelectedIndex == 1) 
                serialPort.Parity = Parity.Even;
            else 
                serialPort.Parity = Parity.Odd;
            //get stopBit 
            if (sbcmb.SelectedIndex == 0)   
                serialPort.StopBits = StopBits.One;
            else 
                serialPort.StopBits = StopBits.Two;

            try
            {
                serialPort.Open();
                master = ModbusSerialMaster.CreateRtu(serialPort);
                master.Transport.Retries = 0;   //don't have to do retries
                master.Transport.ReadTimeout = 300; //milliseconds
                Console.WriteLine(DateTime.Now.ToString() + " =>Open " + serialPort.PortName + " sucessfully!");
                openbtn.Enabled = false;
                closebtn.Enabled = true;
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }               
        }
        //close port
        private void closebtn_Click(object sender, EventArgs e)
        {  
            timer1.Enabled = false;
            serialPort.Close();
            Console.WriteLine(DateTime.Now.ToString() + " =>Disconnect " + serialPort.PortName);
            openbtn.Enabled = true;
            closebtn.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                byte slaveID = 1;
                ushort startAddress = 0;
                ushort numofPoints = 4;
                //read DI(1xxxx)
                //bool[] status = master.ReadInputs(slaveID, startAddress, numofPoints);
                //for (int i = 0; i < numofPoints; i++)
                //{
                //    if (status[i] == true) 
                //        listDI[i].BackColor = Color.DodgerBlue;
                //    else 
                //        listDI[i].BackColor = Color.Navy;
                //}
                ////read DO(0xxxx)
                //bool[] coilstatus = master.ReadCoils(slaveID, startAddress, numofPoints);
                //for (int i = 0; i < numofPoints; i++)
                //{
                //    if (coilstatus[i] == true)
                //        listDO[i].BackColor = Color.Red;
                //    else 
                //        listDO[i].BackColor = Color.DarkRed;
                //}
                ////read AI(3xxxx)                        
                //ushort[] register = master.ReadInputRegisters(slaveID, startAddress, numofPoints);
                //for (int i = 0; i < numofPoints; i++)
                //{
                //    listAI[i].Text = register[i].ToString();

                //    //If you need to show the value with other unit, you have to caculate the gain and offset
                //    //eq. 0 to 0kg, 32767 to 1000kg
                //    //0 (kg) = gain * 0 + offset
                //    //1000 (kg) = gain *32767 + offset
                //    //=> gain=1000/32767, offset=0
                //    //double value = (double)register[i] * 10.0 / 32767;
                //    //listAI[i].Text = value.ToString("0.00");
                //}
                //read AO(4xxxx)
                ushort[] holdingregister = master.ReadHoldingRegisters(slaveID, startAddress, numofPoints);
                for (int i = 0; i < numofPoints; i++)
                {
                    listAO[i].Text = holdingregister[i].ToString();

                    //If you need to show the value with other unit, you have to caculate the gain and offset
                    //eq. 0 to 0 mA, 32767 to 20 mA
                    //0 (mA) = gain * 0 + offset
                    //20 (mA) = gain *32767 + offset
                    //=> gain=20/32767, offset=0
                    //double holdvalue = (double)holdingregister[i] * 20.0 / 32767;
                    //listAO[i].Text = holdvalue.ToString("0.00");
                }
          }
            catch (Exception exception)
            {
                //Connection exception
                //No response from server.
                //The server maybe close the com port, or response timeout.
                if (exception.Source.Equals("System"))
                {
                    Console.WriteLine(DateTime.Now.ToString() + " " + exception.Message);
                }
                //The server return error code.
                //You can get the function code and exception code.
                if (exception.Source.Equals("nModbusPC"))
                {
                    string str = exception.Message;
                    int FunctionCode;
                    string ExceptionCode;

                    str = str.Remove(0, str.IndexOf("\r\n") + 17);
                    FunctionCode = Convert.ToInt16(str.Remove(str.IndexOf("\r\n")));
                    Console.WriteLine("Function Code: " + FunctionCode.ToString("X"));

                    str = str.Remove(0, str.IndexOf("\r\n") + 17);
                    ExceptionCode = str.Remove(str.IndexOf("-"));
                    switch (ExceptionCode.Trim())
                    {
                        case "1":
                            Console.WriteLine("Exception Code: " + ExceptionCode.Trim() + "----> Illegal function!");
                            break;
                        case "2":
                            Console.WriteLine("Exception Code: " + ExceptionCode.Trim() + "----> Illegal data address!");
                            break;
                        case "3":
                            Console.WriteLine("Exception Code: " + ExceptionCode.Trim() + "----> Illegal data value!");
                            break;
                        case "4":
                            Console.WriteLine("Exception Code: " + ExceptionCode.Trim() + "----> Slave device failure!");
                            break;
                    }
                    /*
                       //Modbus exception codes definition                            
                       * Code   * Name                                      * Meaning
                         01       ILLEGAL FUNCTION                            The function code received in the query is not an allowable action for the server.
                         
                         02       ILLEGAL DATA ADDRESS                        The data addrdss received in the query is not an allowable address for the server.
                         
                         03       ILLEGAL DATA VALUE                          A value contained in the query data field is not an allowable value for the server.
                           
                         04       SLAVE DEVICE FAILURE                        An unrecoverable error occurred while the server attempting to perform the requested action.
                             
                         05       ACKNOWLEDGE                                 This response is returned to prevent a timeout error from occurring in the client (or master)
                                                                              when the server (or slave) needs a long duration of time to process accepted request.
                          
                         06       SLAVE DEVICE BUSY                           The server (or slave) is engaged in processing a long–duration program command , and the
                                                                              client (or master) should retransmit the message later when the server (or slave) is free.
                             
                         08       MEMORY PARITY ERROR                         The server (or slave) attempted to read record file, but detected a parity error in the memory.
                             
                         0A       GATEWAY PATH UNAVAILABLE                    The gateway is misconfigured or overloaded.
                             
                         0B       GATEWAY TARGET DEVICE FAILED TO RESPOND     No response was obtained from the target device. Usually means that the device is not present on the network.
                     */
                }
            }
        }
        //set DO
        private void DO_click(object sender, EventArgs e)
        {
            byte slaveID = 1;
            if (serialPort.IsOpen == true)
            {
                ushort index = ushort.Parse(((PictureBox)sender).Tag.ToString());
                if (((PictureBox)sender).BackColor == Color.DarkRed)
                    master.WriteSingleCoil(slaveID, index, true);
                else
                    master.WriteSingleCoil(slaveID, index, false);
            }            
        }
        //set AO
        private void AO_click(object sender, EventArgs e)
        {
            byte slaveID = 1;            
            frmInputValue inputvalue = new frmInputValue();            
            if (serialPort.IsOpen == true)
            {
                ushort index = ushort.Parse(((TextBox)sender).Tag.ToString());
                inputvalue.StringValue = ((TextBox)sender).Text;
                inputvalue.ShowDialog();
                if (inputvalue.DialogResult == DialogResult.OK)
                {
                    double value = inputvalue.Value;
                    ushort aovalue = (ushort)value;

                    //use gain=20/32767, offset=0
                    //ushort aovalue = (ushort)(value * 32767 / 20.0);
                    master.WriteSingleRegister(slaveID, index, aovalue);
                }
            }
        }
    }
}