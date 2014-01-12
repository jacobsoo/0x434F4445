using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _0x434F4445
{
    public partial class UnixEpoch : Form
    {
        public UnixEpoch()
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
            // Specify exactly how to interpret the string.
            IFormatProvider culture = new System.Globalization.CultureInfo("en-US", true);

            DateTime enteredDate = DateTime.Parse(txtInputValue.Text);
            txtOutputValue.Text = ToUnixTime(enteredDate).ToString();
        }

        public static long ToUnixTime(DateTime date)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToInt64((date.ToUniversalTime() - epoch).TotalSeconds);
        }
    }
}
