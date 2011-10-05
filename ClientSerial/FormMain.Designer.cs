namespace WindowsFormsApplication1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txHistory = new System.Windows.Forms.TextBox();
            this.btFlush = new System.Windows.Forms.Button();
            this.txCommand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txBytes = new System.Windows.Forms.ComboBox();
            this.ckCr = new System.Windows.Forms.CheckBox();
            this.ckLf = new System.Windows.Forms.CheckBox();
            this.btEnumerate = new System.Windows.Forms.Button();
            this.cbComs = new System.Windows.Forms.ComboBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFlowControl = new System.Windows.Forms.ComboBox();
            this.nmRead = new System.Windows.Forms.NumericUpDown();
            this.nmWrite = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmRead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWrite)).BeginInit();
            this.SuspendLayout();
            // 
            // txHistory
            // 
            this.txHistory.Location = new System.Drawing.Point(13, 137);
            this.txHistory.Multiline = true;
            this.txHistory.Name = "txHistory";
            this.txHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txHistory.Size = new System.Drawing.Size(653, 234);
            this.txHistory.TabIndex = 1;
            // 
            // btFlush
            // 
            this.btFlush.Location = new System.Drawing.Point(13, 378);
            this.btFlush.Name = "btFlush";
            this.btFlush.Size = new System.Drawing.Size(104, 23);
            this.btFlush.TabIndex = 2;
            this.btFlush.Text = "Flush from buffer";
            this.btFlush.UseVisualStyleBackColor = true;
            this.btFlush.Click += new System.EventHandler(this.btFlush_Click);
            // 
            // txCommand
            // 
            this.txCommand.FormattingEnabled = true;
            this.txCommand.Location = new System.Drawing.Point(14, 110);
            this.txCommand.Name = "txCommand";
            this.txCommand.Size = new System.Drawing.Size(231, 21);
            this.txCommand.TabIndex = 0;
            this.txCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCommand_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ASCII string command";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hex bytes command";
            // 
            // txBytes
            // 
            this.txBytes.FormattingEnabled = true;
            this.txBytes.Location = new System.Drawing.Point(251, 110);
            this.txBytes.Name = "txBytes";
            this.txBytes.Size = new System.Drawing.Size(231, 21);
            this.txBytes.TabIndex = 4;
            this.txBytes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txBytes_KeyDown);
            // 
            // ckCr
            // 
            this.ckCr.AutoSize = true;
            this.ckCr.Checked = true;
            this.ckCr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckCr.Location = new System.Drawing.Point(499, 112);
            this.ckCr.Name = "ckCr";
            this.ckCr.Size = new System.Drawing.Size(73, 17);
            this.ckCr.TabIndex = 6;
            this.ckCr.Text = "append \\r";
            this.ckCr.UseVisualStyleBackColor = true;
            // 
            // ckLf
            // 
            this.ckLf.AutoSize = true;
            this.ckLf.Location = new System.Drawing.Point(578, 112);
            this.ckLf.Name = "ckLf";
            this.ckLf.Size = new System.Drawing.Size(76, 17);
            this.ckLf.TabIndex = 7;
            this.ckLf.Text = "append \\n";
            this.ckLf.UseVisualStyleBackColor = true;
            // 
            // btEnumerate
            // 
            this.btEnumerate.Location = new System.Drawing.Point(17, 62);
            this.btEnumerate.Name = "btEnumerate";
            this.btEnumerate.Size = new System.Drawing.Size(75, 23);
            this.btEnumerate.TabIndex = 8;
            this.btEnumerate.Text = "Enum";
            this.btEnumerate.UseVisualStyleBackColor = true;
            this.btEnumerate.Click += new System.EventHandler(this.btEnumerate_Click);
            // 
            // cbComs
            // 
            this.cbComs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComs.FormattingEnabled = true;
            this.cbComs.Location = new System.Drawing.Point(98, 64);
            this.cbComs.Name = "cbComs";
            this.cbComs.Size = new System.Drawing.Size(121, 21);
            this.cbComs.TabIndex = 9;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(228, 62);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(52, 23);
            this.btStart.TabIndex = 10;
            this.btStart.Text = "||>";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(286, 62);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(52, 23);
            this.btStop.TabIndex = 11;
            this.btStop.Text = "0";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cbBaudRate.Location = new System.Drawing.Point(17, 30);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(86, 21);
            this.cbBaudRate.TabIndex = 12;
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(109, 30);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(86, 21);
            this.cbDataBits.TabIndex = 12;
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None",
            "Mark",
            "Space"});
            this.cbParity.Location = new System.Drawing.Point(201, 30);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(86, 21);
            this.cbParity.TabIndex = 12;
            // 
            // cbStopBits
            // 
            this.cbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.cbStopBits.Location = new System.Drawing.Point(293, 30);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(86, 21);
            this.cbStopBits.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Baud Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Parity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stop Bits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Flow Control";
            // 
            // cbFlowControl
            // 
            this.cbFlowControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFlowControl.FormattingEnabled = true;
            this.cbFlowControl.Items.AddRange(new object[] {
            "None",
            "RequestToSend",
            "RequestToSendXOnXOff",
            "XOnXOff"});
            this.cbFlowControl.Location = new System.Drawing.Point(385, 30);
            this.cbFlowControl.Name = "cbFlowControl";
            this.cbFlowControl.Size = new System.Drawing.Size(86, 21);
            this.cbFlowControl.TabIndex = 14;
            // 
            // nmRead
            // 
            this.nmRead.Location = new System.Drawing.Point(480, 30);
            this.nmRead.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmRead.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nmRead.Name = "nmRead";
            this.nmRead.Size = new System.Drawing.Size(73, 20);
            this.nmRead.TabIndex = 16;
            this.nmRead.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nmWrite
            // 
            this.nmWrite.Location = new System.Drawing.Point(559, 31);
            this.nmWrite.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmWrite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nmWrite.Name = "nmWrite";
            this.nmWrite.Size = new System.Drawing.Size(73, 20);
            this.nmWrite.TabIndex = 16;
            this.nmWrite.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Read Timeout";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(556, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Write Timeout";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 413);
            this.Controls.Add(this.nmWrite);
            this.Controls.Add(this.nmRead);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbFlowControl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbStopBits);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.cbDataBits);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.cbComs);
            this.Controls.Add(this.btEnumerate);
            this.Controls.Add(this.ckLf);
            this.Controls.Add(this.ckCr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txBytes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txCommand);
            this.Controls.Add(this.btFlush);
            this.Controls.Add(this.txHistory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmRead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWrite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txHistory;
        private System.Windows.Forms.Button btFlush;
        private System.Windows.Forms.ComboBox txCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txBytes;
        private System.Windows.Forms.CheckBox ckCr;
        private System.Windows.Forms.CheckBox ckLf;
        private System.Windows.Forms.Button btEnumerate;
        private System.Windows.Forms.ComboBox cbComs;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbFlowControl;
        private System.Windows.Forms.NumericUpDown nmRead;
        private System.Windows.Forms.NumericUpDown nmWrite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

