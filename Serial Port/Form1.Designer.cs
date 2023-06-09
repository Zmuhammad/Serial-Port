﻿using System;
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
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            ASCIIEncoding asciiEncoding1 = new ASCIIEncoding();
            DecoderReplacementFallback decoderReplacementFallback1 = new DecoderReplacementFallback();
            EncoderReplacementFallback encoderReplacementFallback1 = new EncoderReplacementFallback();
            groupBox1 = new GroupBox();
            cBoxPARITYBITS = new ComboBox();
            cBoxSTOPBITS = new ComboBox();
            cBoxDATABITS = new ComboBox();
            cBoxBAUDRATE = new ComboBox();
            cBoxCOMPORT = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            lblStatusCom = new Label();
            progressBar1 = new ProgressBar();
            btnClose = new Button();
            btnOpen = new Button();
            btnSendData = new Button();
            tBoxDataOut = new TextBox();
            serialPort1 = new SerialPort(components);
            groupBox3 = new GroupBox();
            btnClearDataOut = new Button();
            groupBox6 = new GroupBox();
            btClearDataIN = new Button();
            tBoxDataIN = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cBoxPARITYBITS);
            groupBox1.Controls.Add(cBoxSTOPBITS);
            groupBox1.Controls.Add(cBoxDATABITS);
            groupBox1.Controls.Add(cBoxBAUDRATE);
            groupBox1.Controls.Add(cBoxCOMPORT);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 18);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(357, 261);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Com Port Control";
            // 
            // cBoxPARITYBITS
            // 
            cBoxPARITYBITS.FormattingEnabled = true;
            cBoxPARITYBITS.Items.AddRange(new object[] { "None ", "Odd", "Even" });
            cBoxPARITYBITS.Location = new Point(130, 192);
            cBoxPARITYBITS.Margin = new Padding(4, 5, 4, 5);
            cBoxPARITYBITS.Name = "cBoxPARITYBITS";
            cBoxPARITYBITS.Size = new Size(200, 28);
            cBoxPARITYBITS.TabIndex = 9;
            cBoxPARITYBITS.Text = "None";
            // 
            // cBoxSTOPBITS
            // 
            cBoxSTOPBITS.FormattingEnabled = true;
            cBoxSTOPBITS.Items.AddRange(new object[] { "One ", "Two" });
            cBoxSTOPBITS.Location = new Point(130, 154);
            cBoxSTOPBITS.Margin = new Padding(4, 5, 4, 5);
            cBoxSTOPBITS.Name = "cBoxSTOPBITS";
            cBoxSTOPBITS.Size = new Size(200, 28);
            cBoxSTOPBITS.TabIndex = 8;
            cBoxSTOPBITS.Text = "One";
            // 
            // cBoxDATABITS
            // 
            cBoxDATABITS.FormattingEnabled = true;
            cBoxDATABITS.Items.AddRange(new object[] { "6", "7", "8" });
            cBoxDATABITS.Location = new Point(130, 116);
            cBoxDATABITS.Margin = new Padding(4, 5, 4, 5);
            cBoxDATABITS.Name = "cBoxDATABITS";
            cBoxDATABITS.Size = new Size(200, 28);
            cBoxDATABITS.TabIndex = 7;
            cBoxDATABITS.Text = "8";
            // 
            // cBoxBAUDRATE
            // 
            cBoxBAUDRATE.FormattingEnabled = true;
            cBoxBAUDRATE.Items.AddRange(new object[] { "2400", "4800", "9600" });
            cBoxBAUDRATE.Location = new Point(131, 74);
            cBoxBAUDRATE.Margin = new Padding(4, 5, 4, 5);
            cBoxBAUDRATE.Name = "cBoxBAUDRATE";
            cBoxBAUDRATE.Size = new Size(200, 28);
            cBoxBAUDRATE.TabIndex = 6;
            cBoxBAUDRATE.Text = "9600";
            // 
            // cBoxCOMPORT
            // 
            cBoxCOMPORT.FormattingEnabled = true;
            cBoxCOMPORT.Location = new Point(130, 33);
            cBoxCOMPORT.Margin = new Padding(4, 5, 4, 5);
            cBoxCOMPORT.Name = "cBoxCOMPORT";
            cBoxCOMPORT.Size = new Size(200, 28);
            cBoxCOMPORT.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 191);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 158);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "STOP BITS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 116);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "DATA BITS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "COM PORT";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(btnOpen);
            groupBox2.Location = new Point(16, 289);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(357, 165);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblStatusCom);
            groupBox4.Location = new Point(162, 14);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(174, 100);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "COM PORT STATUS";
            // 
            // lblStatusCom
            // 
            lblStatusCom.AutoSize = true;
            lblStatusCom.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblStatusCom.Location = new Point(41, 33);
            lblStatusCom.Name = "lblStatusCom";
            lblStatusCom.Size = new Size(73, 41);
            lblStatusCom.TabIndex = 0;
            lblStatusCom.Text = "OFF";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(8, 124);
            progressBar1.Margin = new Padding(4, 5, 4, 5);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(323, 31);
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(8, 69);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(145, 45);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(8, 14);
            btnOpen.Margin = new Padding(4, 5, 4, 5);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(145, 45);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSendData
            // 
            btnSendData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSendData.Location = new Point(69, 291);
            btnSendData.Margin = new Padding(4, 5, 4, 5);
            btnSendData.Name = "btnSendData";
            btnSendData.Size = new Size(188, 37);
            btnSendData.TabIndex = 2;
            btnSendData.Text = "Send Data";
            btnSendData.UseVisualStyleBackColor = true;
            btnSendData.Click += btnSendData_Click;
            // 
            // tBoxDataOut
            // 
            tBoxDataOut.Location = new Point(24, 28);
            tBoxDataOut.Margin = new Padding(4, 5, 4, 5);
            tBoxDataOut.Multiline = true;
            tBoxDataOut.Name = "tBoxDataOut";
            tBoxDataOut.Size = new Size(288, 253);
            tBoxDataOut.TabIndex = 3;
            // 
            // serialPort1
            // 
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.DiscardNull = false;
            serialPort1.DtrEnable = false;
/*            asciiEncoding1.DecoderFallback = decoderReplacementFallback1;
            asciiEncoding1.EncoderFallback = encoderReplacementFallback1;
            serialPort1.Encoding = asciiEncoding1;*/
            serialPort1.Handshake = Handshake.None;
            serialPort1.NewLine = "\n";
            serialPort1.Parity = Parity.None;
            serialPort1.ParityReplace = 63;
            serialPort1.PortName = "COM1";
            serialPort1.ReadBufferSize = 4096;
            serialPort1.ReadTimeout = -1;
            serialPort1.ReceivedBytesThreshold = 1;
            serialPort1.RtsEnable = false;
            serialPort1.StopBits = StopBits.One;
            serialPort1.WriteBufferSize = 2048;
            serialPort1.WriteTimeout = -1;
            serialPort1.DataReceived += serialPort1_DataReceived;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnClearDataOut);
            groupBox3.Controls.Add(btnSendData);
            groupBox3.Controls.Add(tBoxDataOut);
            groupBox3.Location = new Point(380, 18);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(343, 436);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Transmitter Control";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // btnClearDataOut
            // 
            btnClearDataOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearDataOut.Location = new Point(69, 363);
            btnClearDataOut.Margin = new Padding(4, 5, 4, 5);
            btnClearDataOut.Name = "btnClearDataOut";
            btnClearDataOut.Size = new Size(188, 37);
            btnClearDataOut.TabIndex = 3;
            btnClearDataOut.Text = "Clear Data OUT";
            btnClearDataOut.UseVisualStyleBackColor = true;
            btnClearDataOut.Click += btnClearDataOut_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btClearDataIN);
            groupBox6.Controls.Add(tBoxDataIN);
            groupBox6.Location = new Point(729, 18);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(353, 436);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Receiver Control";
            // 
            // btClearDataIN
            // 
            btClearDataIN.Location = new Point(71, 308);
            btClearDataIN.Name = "btClearDataIN";
            btClearDataIN.Size = new Size(199, 77);
            btClearDataIN.TabIndex = 1;
            btClearDataIN.Text = "Clear Data IN";
            btClearDataIN.UseVisualStyleBackColor = true;
            btClearDataIN.Click += btClearDataIN_Click;
            // 
            // tBoxDataIN
            // 
            tBoxDataIN.Location = new Point(23, 28);
            tBoxDataIN.Multiline = true;
            tBoxDataIN.Name = "tBoxDataIN";
            tBoxDataIN.Size = new Size(312, 253);
            tBoxDataIN.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 501);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Serial Com Port";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private GroupBox groupBox1;
        private ComboBox cBoxPARITYBITS;
        private ComboBox cBoxSTOPBITS;
        private ComboBox cBoxDATABITS;
        private ComboBox cBoxBAUDRATE;
        private ComboBox cBoxCOMPORT;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ProgressBar progressBar1;
        private Button btnClose;
        private Button btnOpen;
        private Button btnSendData;
        private TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private GroupBox groupBox3;
        private Button btnClearDataOut;
        private GroupBox groupBox4;
        private Label lblStatusCom;
        private GroupBox groupBox5;
        private Button button1;
        private Button button;
        private TextBox textBox1;
        private Button btnClearDataIN;
        private GroupBox groupBox6;
        private Button btClearDataIN;
        private TextBox tBoxDataIN;
    }
}