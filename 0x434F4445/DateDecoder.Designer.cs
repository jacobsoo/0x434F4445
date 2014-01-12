namespace _0x434F4445
{
    partial class DateDecoder
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
            this.DecodeButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.txtValueToDecode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbWindowTop = new System.Windows.Forms.CheckBox();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBias = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(194, 176);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(75, 23);
            this.DecodeButton.TabIndex = 28;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(271, 176);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 27;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(114, 141);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(308, 20);
            this.txtDateTime.TabIndex = 26;
            // 
            // txtValueToDecode
            // 
            this.txtValueToDecode.Location = new System.Drawing.Point(114, 113);
            this.txtValueToDecode.Name = "txtValueToDecode";
            this.txtValueToDecode.Size = new System.Drawing.Size(308, 20);
            this.txtValueToDecode.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Date && Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Value to Decode:";
            // 
            // txtExample
            // 
            this.txtExample.Location = new System.Drawing.Point(114, 85);
            this.txtExample.Name = "txtExample";
            this.txtExample.ReadOnly = true;
            this.txtExample.Size = new System.Drawing.Size(308, 20);
            this.txtExample.TabIndex = 22;
            this.txtExample.Text = "FF03D2315FE1C701";
            // 
            // cbFormat
            // 
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "Windows: 64Bit Hex Value - Little Endian",
            "Windows: 64Bit Hex Value - Big Endian",
            "Windows: IE Cookie Date (Lo Value, Hi Value)",
            "Windows: 32bit FileTime [xxxxxxxx:xxxxxxxx]",
            "Windows: OLE Automation Format (64bit Double)",
            "Windows: 128 bit System Structure",
            "Unix: 32 bit Hex Value - Little Endian",
            "Unix: 32 bit Hex Value - Big Endian",
            "Unix: Numeric Value",
            "Unix: Milisecond Value",
            "Google ChromeWebKit Value",
            "Google Chrome",
            "MAC: Absolute Time",
            "MS-DOS: 32 bit Hex Value",
            "MS-DOS: wFatDate wFatTime",
            "HFS: 32 bit Hex Value - Little Endian",
            "HFS: 32 bit Hex Value - Big Endian",
            "HFS+: 32 bit Hex Value - Little Endian",
            "HFS+: 32 bit Hex Value - Big Endian",
            "Mozilla Firefox PRTime",
            "Safari DateTime"});
            this.cbFormat.Location = new System.Drawing.Point(114, 56);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(308, 21);
            this.cbFormat.TabIndex = 21;
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormat_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Example:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Decode Format:";
            // 
            // ckbWindowTop
            // 
            this.ckbWindowTop.AutoSize = true;
            this.ckbWindowTop.Location = new System.Drawing.Point(283, 32);
            this.ckbWindowTop.Name = "ckbWindowTop";
            this.ckbWindowTop.Size = new System.Drawing.Size(102, 17);
            this.ckbWindowTop.TabIndex = 18;
            this.ckbWindowTop.Text = "Window on Top";
            this.ckbWindowTop.UseVisualStyleBackColor = true;
            this.ckbWindowTop.CheckedChanged += new System.EventHandler(this.ckbWindowTop_CheckedChanged);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(347, 176);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Add Bias: ";
            // 
            // cbBias
            // 
            this.cbBias.FormattingEnabled = true;
            this.cbBias.Items.AddRange(new object[] {
            "UTC -12:00",
            "UTC -11:00",
            "UTC -10:00",
            "UTC -09:00",
            "UTC -08:00",
            "UTC -07:00",
            "UTC -06:00",
            "UTC -05:00",
            "UTC -04:00",
            "UTC -03:30",
            "UTC -03:00",
            "UTC -02:00",
            "UTC -01:00",
            "UTC 00:00",
            "UTC +01:00",
            "UTC +02:00",
            "UTC +03:00",
            "UTC +03:30",
            "UTC +04:00",
            "UTC +04:30",
            "UTC +05:00",
            "UTC +05:30",
            "UTC +05:45",
            "UTC +06:00",
            "UTC +06:30",
            "UTC +07:00",
            "UTC +08:00",
            "UTC +09:00",
            "UTC +09:30",
            "UTC +10:00",
            "UTC +11:00",
            "UTC +12:00",
            "UTC +13:00"});
            this.cbBias.Location = new System.Drawing.Point(114, 28);
            this.cbBias.Name = "cbBias";
            this.cbBias.Size = new System.Drawing.Size(163, 21);
            this.cbBias.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 194);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 194);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Add Bias: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Decode Format:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Example:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Value to Decode:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Date && Time";
            // 
            // DateDecoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 218);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.txtValueToDecode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExample);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckbWindowTop);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBias);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DateDecoder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateDecoder";
            this.Load += new System.EventHandler(this.DateDecoder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtValueToDecode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExample;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbWindowTop;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}