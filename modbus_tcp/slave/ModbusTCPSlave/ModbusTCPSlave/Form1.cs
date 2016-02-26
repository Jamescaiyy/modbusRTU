using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modbus;
using Modbus.Device;
using Modbus.Data;
using Modbus.Message;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ModbusTCPSlave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpListener slaveTcpListener;
        Modbus.Device.ModbusSlave slave;

        private byte slaveID = 1;
        private int port = 502;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Get host IP

            //IPAddress addr;    
            //addr = new IPAddress(Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].Address);
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = ipEntry.AddressList;

            labServerName.Text = "Host IP=" + addr[0].ToString();
            //txtServerName.Text = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
        }
        private void Modbus_Request_Event(object sender, Modbus.Device.ModbusSlaveRequestEventArgs e)
        {
            //request from master//disassemble packet from master
            byte fc = e.Message.FunctionCode;
            byte[] data = e.Message.MessageFrame;
            byte[] byteStartAddress = new byte[] { data[3], data[2] };
            byte[] byteNum = new byte[] { data[5], data[4] };
            Int16 StartAddress = BitConverter.ToInt16(byteStartAddress, 0);
            Int16 NumOfPoint = BitConverter.ToInt16(byteNum, 0);

            //Console.WriteLine(fc.ToString() + "," + StartAddress.ToString() + "," + NumOfPoint.ToString());
        }

        private void Modbus_DataStoreWriteTo(object sender, Modbus.Data.DataStoreEventArgs e)
        {
            //this.Text = "DataType=" + e.ModbusDataType.ToString() + "  StartAdress=" + e.StartAddress;
            int iAddress = e.StartAddress;//e.StartAddress;

            switch (e.ModbusDataType)
            {
                case ModbusDataType.HoldingRegister:
                    
                    for (int i = 0; i < e.Data.B.Count; i++)
                    {   
                        //Set AO                 
                        
                        //e.Data.B[i] already write to slave.DataStore.HoldingRegisters[e.StartAddress + i + 1]
                        //e.StartAddress starts from 0
                        //You can set AO value to hardware here

                        DoAOUpdate(iAddress, e.Data.B[i].ToString());
                        iAddress++;
                    }
                    break;

                case ModbusDataType.Coil:
                    for (int i = 0; i < e.Data.A.Count; i++)
                    {
                        //Set DO
                        //e.Data.A[i] already write to slave.DataStore.CoilDiscretes[e.StartAddress + i + 1]
                        //e.StartAddress starts from 0
                        //You can set DO value to hardware here

                        DoDOUpdate(iAddress, e.Data.A[i]);
                        iAddress++;
                        if (e.Data.A.Count == 1)
                        {
                            break;
                        }                    
                    }
                    break;
            }
        }
        #region "Set AO"
        private delegate void UpdateAOStatusDelegate(int index, String message);
        private void DoAOUpdate(int index, String message)
        {
            if (this.InvokeRequired)
            {
                // we were called on a worker thread
                // marshal the call to the user interface thread
                this.Invoke(new UpdateAOStatusDelegate(DoAOUpdate),
                            new object[] { index, message });
                return;
            }

            // this code can only be reached
            // by the user interface thread
            switch (index)
            {
                case 0:
                    this.txtAO1.Text = message;
                    break;
                case 1:
                    this.txtAO2.Text = message;
                    break;
                case 2:
                    this.txtAO3.Text = message;
                    break;
                case 3:
                    this.txtAO4.Text = message;
                    break;
            }

        }
        #endregion

        #region "Set DO"
        private delegate void UpdateDOStatusDelegate(int index, bool value);
        private void DoDOUpdate(int index, bool value)
        {
            if (this.InvokeRequired)
            {
                // we were called on a worker thread
                // marshal the call to the user interface thread
                this.Invoke(new UpdateDOStatusDelegate(DoDOUpdate),
                            new object[] { index, value });
                return;
            }

            // this code can only be reached
            // by the user interface thread
            switch (index)
            {
                case 0:
                    this.chkDO1.Checked = value;
                    break;
                case 1:
                    this.chkDO2.Checked = value;
                    break;
                case 2:
                    this.chkDO3.Checked = value;
                    break;
                case 3:
                    this.chkDO4.Checked = value;
                    break;
            }

        }
        #endregion

        private void btnStart_Click(object sender, EventArgs e)
        {
            // create and start the TCP slave

            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = ipEntry.AddressList;
            slaveTcpListener = new TcpListener(addr[0], port);
            slaveTcpListener.Start();

            slave = Modbus.Device.ModbusTcpSlave.CreateTcp(slaveID, slaveTcpListener);
            slave.ModbusSlaveRequestReceived += new EventHandler<ModbusSlaveRequestEventArgs>(Modbus_Request_Event);
            slave.DataStore = Modbus.Data.DataStoreFactory.CreateDefaultDataStore();
            slave.DataStore.DataStoreWrittenTo += new EventHandler<DataStoreEventArgs>(Modbus_DataStoreWriteTo);
            slave.Listen();

            timer1.Enabled = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            slaveTcpListener.Stop();
            slaveTcpListener = null;
            slave.Stop();            
            slave.Dispose();                        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //update input values to datastore
            //DI
            slave.DataStore.InputDiscretes[1] = chkDI1.Checked;
            slave.DataStore.InputDiscretes[2] = chkDI2.Checked;
            slave.DataStore.InputDiscretes[3] = chkDI3.Checked;
            slave.DataStore.InputDiscretes[4] = chkDI4.Checked;
            //AI
            slave.DataStore.InputRegisters[1] = Convert.ToUInt16(txtAI1.Text);
            slave.DataStore.InputRegisters[2] = Convert.ToUInt16(txtAI2.Text);
            slave.DataStore.InputRegisters[3] = Convert.ToUInt16(txtAI3.Text);
            slave.DataStore.InputRegisters[4] = Convert.ToUInt16(txtAI4.Text);
            //AO
            slave.DataStore.HoldingRegisters[1] = Convert.ToUInt16(txtAO1.Text);
            slave.DataStore.HoldingRegisters[2] = Convert.ToUInt16(txtAO2.Text);
            slave.DataStore.HoldingRegisters[3] = Convert.ToUInt16(txtAO3.Text);
            slave.DataStore.HoldingRegisters[4] = Convert.ToUInt16(txtAO4.Text);
            //DO
            slave.DataStore.CoilDiscretes[1] = chkDO1.Checked;
            slave.DataStore.CoilDiscretes[2] = chkDO2.Checked;
            slave.DataStore.CoilDiscretes[3] = chkDO3.Checked;
            slave.DataStore.CoilDiscretes[4] = chkDO4.Checked;
        }
        
    }
}