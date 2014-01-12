namespace _0x434F4445
{
    partial class IPConverter
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
            this.txtInputValue = new System.Windows.Forms.TextBox();
            this.txtOutputValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputValue
            // 
            this.txtInputValue.Location = new System.Drawing.Point(170, 40);
            this.txtInputValue.Name = "txtInputValue";
            this.txtInputValue.Size = new System.Drawing.Size(141, 20);
            this.txtInputValue.TabIndex = 0;
            // 
            // txtOutputValue
            // 
            this.txtOutputValue.Location = new System.Drawing.Point(170, 62);
            this.txtOutputValue.Name = "txtOutputValue";
            this.txtOutputValue.Size = new System.Drawing.Size(141, 20);
            this.txtOutputValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Convert Dotted Quad to/from Decimal Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Address (dotted or decimal) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Converted Value : ";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(67, 95);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(149, 95);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // IPConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 123);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutputValue);
            this.Controls.Add(this.txtInputValue);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Convert IP Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputValue;
        private System.Windows.Forms.TextBox txtOutputValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnConvert;
    }
}