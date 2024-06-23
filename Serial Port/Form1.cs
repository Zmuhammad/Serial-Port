using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial_Port
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string dataIN;
        public Form1()
        {
            InitializeComponent();
        }

        //form loading parameters

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);

        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            //open COM PORT and configs

            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDATABITS.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxSTOPBITS.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxPARITYBITS.Text);

                serialPort1.Open();
                progressBar1.Value = 100;

                lblStatusCom.Text = " ON ";

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lblStatusCom.Text = "OFF";
            }


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close seial connection

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;

                lblStatusCom.Text = "OFF";

            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            // sending data 

            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                serialPort1.WriteLine(dataOUT + Environment.NewLine);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnClearDataOut_Click(object sender, EventArgs e)
        {
            if (tBoxDataOut.Text != " ")
            {
                tBoxDataOut.Text = " ";
            }
        }

        private void btClearDataIN_Click(object sender, EventArgs e)
        {
            if (tBoxDataIN.Text != " ")
            {
                tBoxDataIN.Text = " ";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //receiving data ...
            
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object? sender, EventArgs e)
        {
            //show received data

            tBoxDataIN.Text += dataIN;
        }
    }
}
