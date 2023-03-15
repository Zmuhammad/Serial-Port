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
            progressBar1 = new ProgressBar();
            btnClose = new Button();
            btnOpen = new Button();
            btnSendData = new Button();
            tBoxDataOut = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 259);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Com Port Control";
            // 
            // cBoxPARITYBITS
            // 
            cBoxPARITYBITS.FormattingEnabled = true;
            cBoxPARITYBITS.Location = new Point(143, 210);
            cBoxPARITYBITS.Name = "cBoxPARITYBITS";
            cBoxPARITYBITS.Size = new Size(151, 28);
            cBoxPARITYBITS.TabIndex = 9;
            // 
            // cBoxSTOPBITS
            // 
            cBoxSTOPBITS.FormattingEnabled = true;
            cBoxSTOPBITS.Location = new Point(143, 167);
            cBoxSTOPBITS.Name = "cBoxSTOPBITS";
            cBoxSTOPBITS.Size = new Size(151, 28);
            cBoxSTOPBITS.TabIndex = 8;
            // 
            // cBoxDATABITS
            // 
            cBoxDATABITS.FormattingEnabled = true;
            cBoxDATABITS.Location = new Point(143, 127);
            cBoxDATABITS.Name = "cBoxDATABITS";
            cBoxDATABITS.Size = new Size(151, 28);
            cBoxDATABITS.TabIndex = 7;
            // 
            // cBoxBAUDRATE
            // 
            cBoxBAUDRATE.FormattingEnabled = true;
            cBoxBAUDRATE.Location = new Point(143, 85);
            cBoxBAUDRATE.Name = "cBoxBAUDRATE";
            cBoxBAUDRATE.Size = new Size(151, 28);
            cBoxBAUDRATE.TabIndex = 6;
            // 
            // cBoxCOMPORT
            // 
            cBoxCOMPORT.FormattingEnabled = true;
            cBoxCOMPORT.Location = new Point(143, 39);
            cBoxCOMPORT.Name = "cBoxCOMPORT";
            cBoxCOMPORT.Size = new Size(151, 28);
            cBoxCOMPORT.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 207);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 167);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "STOP BITS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 124);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "DATA BITS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 82);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 39);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "COM PORT";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(btnOpen);
            groupBox2.Location = new Point(12, 277);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(216, 145);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(6, 87);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(197, 29);
            progressBar1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(122, 27);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(9, 27);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(94, 29);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSendData
            // 
            btnSendData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSendData.Location = new Point(243, 288);
            btnSendData.Name = "btnSendData";
            btnSendData.Size = new Size(94, 134);
            btnSendData.TabIndex = 2;
            btnSendData.Text = "Send Data";
            btnSendData.UseVisualStyleBackColor = true;
            // 
            // tBoxDataOut
            // 
            tBoxDataOut.Location = new Point(359, 25);
            tBoxDataOut.Multiline = true;
            tBoxDataOut.Name = "tBoxDataOut";
            tBoxDataOut.Size = new Size(411, 397);
            tBoxDataOut.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(tBoxDataOut);
            Controls.Add(btnSendData);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "COM PORT SERIAL";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
    }
}