using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//step1. reference nmodbuspc.dll, and using the namespaces.
using Modbus.Device;      //for modbus master
using System.Net;         //for tcp client
using System.Net.Sockets;
using System.Threading;
using System.Runtime.InteropServices;

namespace ModbusTCP_Master
{
    public partial class Form1 : Form
    {
        [DllImport("WININET", CharSet = CharSet.Auto)]
        static extern bool InternetGetConnectedState(ref InternetConnectionState lpdwFlags, int dwReserved);
        enum InternetConnectionState : int
        {
            INTERNET_CONNECTION_MODEM = 0x1,
            INTERNET_CONNECTION_LAN = 0x2,
            INTERNET_CONNECTION_PROXY = 0x4,
            INTERNET_RAS_INSTALLED = 0x10,
            INTERNET_CONNECTION_OFFLINE = 0x20,
            INTERNET_CONNECTION_CONFIGURED = 0x40
        }
        TcpClient tcpClient;
        ModbusIpMaster master;
        string ipAddress;
        int tcpPort = 502;
        DateTime dtDisconnect = new DateTime();
        DateTime dtNow = new DateTime();
        //int iError = 0;
        List<PictureBox> listDI = new List<PictureBox>();
        List<PictureBox> listDO = new List<PictureBox>();
        List<TextBox> listAI = new List<TextBox>();
        List<TextBox> listAO = new List<TextBox>();

        bool NetworkIsOk = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            dtDisconnect = DateTime.Now;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            // connect to Modbus TCP Server
            NetworkIsOk = Connect();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            btStart.Enabled = false;
            btStop.Enabled = true;   
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (master != null)
                master.Dispose();
            if (tcpClient != null)
                tcpClient.Close();
            btStart.Enabled = true;
            btStop.Enabled = false;
        }
        private bool Connect()
        {
            ipAddress = txtIP.Text;
            if (master != null)
                master.Dispose();
            if (tcpClient != null)
                tcpClient.Close();

            if (CheckInternet())
            {
                try
                {
                    tcpClient = new TcpClient();
                    IAsyncResult asyncResult = tcpClient.BeginConnect(ipAddress, tcpPort, null, null);
                    asyncResult.AsyncWaitHandle.WaitOne(3000, true); //wait for 3 sec
                    if (!asyncResult.IsCompleted)
                    {
                        tcpClient.Close();
                        Console.WriteLine(DateTime.Now.ToString() + ":Cannot connect to server.");
                        return false;
                    }
                    //tcpClient = new TcpClient(ipAddress, tcpPort);

                    // create Modbus TCP Master by the tcp client
                    //document->Modbus.Device.Namespace->ModbusIpMaster Class->Create Method
                    master = ModbusIpMaster.CreateIp(tcpClient);
                    master.Transport.Retries = 0;   //don't have to do retries
                    master.Transport.ReadTimeout = 1500;
                    this.Text = "On line " + DateTime.Now.ToString();
                    Console.WriteLine(DateTime.Now.ToString() + ":Connect to server.");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(DateTime.Now.ToString() + ":Connect process " + ex.StackTrace + "==>" + ex.Message);
                    return false;
                }
            }
            return false;

        }

        private bool CheckInternet()
        {
            //http://msdn.microsoft.com/en-us/library/windows/desktop/aa384702(v=vs.85).aspx
            InternetConnectionState flag = InternetConnectionState.INTERNET_CONNECTION_LAN;
            return InternetGetConnectedState(ref flag, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (NetworkIsOk)
                {
                    #region Master to Slave
                    byte slaveID = 1;
                    //read DI(1xxxx), start address=0, points=4
                    bool[] status = master.ReadInputs(slaveID, 0, 4);
                    for (int index = 0; index < 4; index++)
                    {
                        if (status[index] == true)
                            listDI[index].BackColor = Color.Lime;
                        else
                            listDI[index].BackColor = Color.Green;
                    }
                    //read DO(0xxxx), start address=0, points=4
                    bool[] coils = master.ReadCoils(slaveID, 0, 4);
                    for (int index = 0; index < 4; index++)
                    {
                        if (coils[index] == true)
                            listDO[index].BackColor = Color.Red;
                        else
                            listDO[index].BackColor = Color.Maroon;
                    }
                    //read AI(3xxxx), start address=0, points=4
                    ushort[] register = master.ReadInputRegisters(1, 0, 4);
                    for (int index = 0; index < 4; index++)
                    {
                        //listAI[index].Text = register[index].ToString();

                        //If you need to show the value with other unit, you have to caculate the gain and offset
                        //eq. 0 to 0kg, 32767 to 1000kg
                        //0 (kg) = gain * 0 + offset
                        //1000 (kg) = gain *32767 + offset
                        //=> gain=1000/32767, offset=0
                        double value = (double)register[index] * 1000.0 / 32767;
                        listAI[index].Text = value.ToString("0.00");

                        //Convert ushort array to Float 

                    }
                    //read AO(4xxxx), start address=0, points=4
                    ushort[] holding_register = master.ReadHoldingRegisters(1, 0, 4);
                    for (int index = 0; index < 4; index++)
                    {
                        //listAO[index].Text = holding_register[index].ToString();

                        //If you need to show the value with other unit, you have to caculate the gain and offset
                        //eq. 0 to 0 mA, 32767 to 20 mA
                        //0 (mA) = gain * 0 + offset
                        //20 (mA) = gain *32767 + offset
                        //=> gain=20/32767, offset=0
                        double value = (double)holding_register[index] * 20.0 / 32767;
                        listAO[index].Text = value.ToString("0.00");
                        
                    }
                    #endregion
                }
                else
                {
                    dtNow = DateTime.Now;

                    if ((dtNow - dtDisconnect) > TimeSpan.FromSeconds(10))
                    {
                        Console.WriteLine(DateTime.Now.ToString() + ":Start connecting");
                        NetworkIsOk = Connect();
                        if (!NetworkIsOk)
                        {
                            Console.WriteLine(DateTime.Now.ToString() + ":Connecting fail. Wait for retry");

                            dtDisconnect = DateTime.Now;
                        }
                    }
                    else
                    {
                        Console.WriteLine(DateTime.Now.ToString() + ":Wait for retry connecting");
                    }

                }

            }
            catch (Exception exception)
            {
                //Connection exception
                //No response from server.
                //The server maybe close the connection, or response timeout.
                if (exception.Source.Equals("System"))
                {
                    NetworkIsOk = false;
                    Console.WriteLine(exception.Message);
                    this.Text = "Off line " + DateTime.Now.ToString();
                    dtDisconnect = DateTime.Now;
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
                          
                         06       SLAVE DEVICE BUSY                           The server (or slave) is engaged in processing a long¡Vduration program command , and the 
                                                                              client (or master) should retransmit the message later when the server (or slave) is free.
                             
                         08       MEMORY PARITY ERROR                         The server (or slave) attempted to read record file, but detected a parity error in the memory.
                             
                         0A       GATEWAY PATH UNAVAILABLE                    The gateway is misconfigured or overloaded.
                             
                         0B       GATEWAY TARGET DEVICE FAILED TO RESPOND     No response was obtained from the target device. Usually means that the device is not present on the network.

                     */
                }
            }
        }

        private void DO_Click(object sender, EventArgs e)
        {
            // Set DO
            ushort index = ushort.Parse(((PictureBox)sender).Tag.ToString());
            if (NetworkIsOk)
            {
                if (((PictureBox)sender).BackColor == Color.Maroon)
                    master.WriteSingleCoil(1, index, true);
                else
                    master.WriteSingleCoil(1, index, false);
            }
        }

        private void AO_Click(object sender, EventArgs e)
        {
            //set AO
            ushort index = ushort.Parse(((TextBox)sender).Tag.ToString());
            frmInputValue inputvalue = new frmInputValue();
            inputvalue.StringValue = ((TextBox)sender).Text;
            inputvalue.ShowDialog();
            if (inputvalue.DialogResult == DialogResult.OK)
            {
                double value = inputvalue.Value;
                //use gain=20/32767, offset=0
                ushort output_value = (ushort)(value * 32767 / 20.0);
                master.WriteSingleRegister(1, index, output_value);


            }
        }        
    }
}