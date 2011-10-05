using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class FormMain : Form
    {
        SerialPort port;

        const int BAUD_RATE = 9600;
        const int DATA_BITS = 8;
        const Parity PARITY = Parity.None;
        const StopBits STOP_BITS = StopBits.One;
        const Handshake HANDSHAKE = Handshake.None;
        const int READ_TIMEOUT = -1;
        const int WRITE_TIMEOUT = -1;

        const int SLEEP = 750;

        delegate void PlainMethod();

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // fill defaults
            cbBaudRate.Text = BAUD_RATE.ToString();
            cbDataBits.Text = DATA_BITS.ToString();
            cbParity.Text = PARITY.ToString();
            cbStopBits.Text = STOP_BITS.ToString();
            cbFlowControl.Text = HANDSHAKE.ToString();
            nmRead.Value = READ_TIMEOUT;
            nmWrite.Value = WRITE_TIMEOUT;

            btEnumerate_Click(null, null);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
            }
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            PlainMethod callMethod = new PlainMethod(notificationDataReceived);
            this.Invoke(callMethod);
        }

        private void notificationDataReceived()
        {
            txHistory.AppendText("<Data Received!>" + Environment.NewLine);
            txHistory.AppendText(port.ReadExisting());
            txHistory.ScrollToCaret();
        }

        private void txCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string command = txCommand.Text;

                if (ckCr.Checked)
                {
                    command += "\r";
                }
                if (ckLf.Checked)
                {
                    command += "\n";
                }

                // insert into history

                txCommand.Items.Insert(0, txCommand.Text);
                txHistory.AppendText(
                        "<Issued command!> " +
                        txCommand.Text +
                        (ckCr.Checked ? @"{\r}" : "") +
                        (ckLf.Checked ? @"{\n}" : "") +
                        Environment.NewLine);

                txHistory.ScrollToCaret();

                // submit command to port

                Byte[] buffer = Encoding.ASCII.GetBytes(command);

                port.Write(buffer, 0, buffer.Length);

                // Wait response ...

                txCommand.Text = "";
            }
        }

        private void btFlush_Click(object sender, EventArgs e)
        {            
            txHistory.AppendText("<Issued Flush from Buffer!>" + Environment.NewLine);
            txHistory.AppendText(port.ReadExisting());
            txHistory.ScrollToCaret();
        }

        private void btEnumerate_Click(object sender, EventArgs e)
        {
            // Fill cbComs with com ports ...

            String[] ports = SerialPort.GetPortNames();
            String value = cbComs.Text;

            cbComs.Items.Clear();
            foreach (String _port in ports)
            {
                cbComs.Items.Add(_port);
            }
            cbComs.Text = value;

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbComs.Text))
            {
                return;
            }

            if (port != null && port.IsOpen)
            {
                port.Close();
                txHistory.AppendText("<Stop!>" + Environment.NewLine);
                txHistory.ScrollToCaret();
            }

            // -------------------
            port = new SerialPort(
                        cbComs.Text, 
                        int.Parse(cbBaudRate.Text), 
                        (Parity) Enum.Parse(typeof(Parity), cbParity.Text),
                        int.Parse(cbDataBits.Text),
                        (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text));

            port.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cbFlowControl.Text);
            
            port.Encoding = Encoding.ASCII;
            
            port.ReadTimeout = (int)nmRead.Value;
            port.WriteTimeout = (int)nmWrite.Value;

            port.DataReceived += port_DataReceived;
                        
            port.Open();

            txHistory.AppendText(
                    String.Format("<Start in {0} (BaudRate={1}, Parity={2}, DataBits={3}, StopBits={4}, FlowControl={5}, ReadTimeout={6}, WriteTimeout={7})!>", 
                        cbComs.Text, cbBaudRate.Text, cbParity.Text, cbDataBits.Text, cbStopBits.Text, cbFlowControl.Text, nmRead.Value, nmWrite.Value) +
                    Environment.NewLine);
            // --
            txHistory.ScrollToCaret();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
                txHistory.AppendText("<Stop!>" + Environment.NewLine);
                txHistory.ScrollToCaret();
            }
        }

        private void txBytes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string command = txBytes.Text;

                if (ckCr.Checked)
                {
                    command += "D"; // \r == charcode 13
                }
                if (ckLf.Checked)
                {
                    command += "A"; // \n == charcode 10
                }

                if (command.Length % 2 != 0)
                {
                    command = "0" + command;
                }


                List<Byte> bytes = new List<byte>();
                for (int i = 0; i < command.Length; i += 2)
                {
                    bytes.Add(Convert.ToByte(command.Substring(i, 2), 16));
                }

                // insert into history

                txCommand.Items.Insert(0, txCommand.Text);
                txHistory.AppendText(
                        "<Issued command!> " +
                        command +
                        Environment.NewLine);

                txHistory.ScrollToCaret();

                // submit command to port

                Byte[] buffer = bytes.ToArray();

                port.Write(buffer, 0, buffer.Length);

                // Wait response ...

                txCommand.Text = "";
            }
        }

    }
}
