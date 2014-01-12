using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace _0x434F4445
{
    public partial class IPConverter : Form
    {
        public IPConverter()
        {
            InitializeComponent();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtInputValue.ResetText();
            txtOutputValue.ResetText();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            txtOutputValue.Text = BitConverter.ToUInt32(IPAddress.Parse(txtInputValue.Text).GetAddressBytes().Reverse().ToArray(), 0).ToString();
        }
    }
}
