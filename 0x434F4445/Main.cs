using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace _0x434F4445
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CenterToScreen();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtInput.ResetText();
            txtOutput.ResetText();
        }

        private void dateDecoderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateDecoder dc = new DateDecoder();
            dc.ShowDialog();
        }

        #region “Hex Conversions”
        private void HexToText_Click(object sender, EventArgs e)
        {
            string szOutSep = SelectedOutoutFormat();
            string szInSep = SelectedInputFormat();
            char[] chInSep = szInSep.ToCharArray();

            // Convert the argument to a char value.
            try
            {
                string szBinOutput = "";
                string[] words = txtInput.Text.Split(chInSep, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    if (word == null || word == "")
                    {
                        break;
                    }
                    else
                    {
                        if (OnlyHexInString(word) != true)
                        {
                            MessageBox.Show("You have entered an invalid number for Hex to Binary conversion.");
                        }
                        else
                        {
                            byte raw;
                            raw = Convert.ToByte(word, 16);
                            szBinOutput += String.Format("{0}{1}", (char)Convert.ToByte(word, 16), szOutSep);
                            txtOutput.Text = szBinOutput;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string szEX = GetExceptionType(ex);
                MessageBox.Show(szEX);
            }
        }

        private void HexToBinary_Click(object sender, EventArgs e)
        {
            string szOutSep = SelectedOutoutFormat();
            string szInSep = SelectedInputFormat();
            char[] chInSep = szInSep.ToCharArray();

            // Convert the argument to a char value.
            try
            {
                string szBinOutput = "";
                string[] words = txtInput.Text.Split(chInSep, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words){
                    if (word == null || word == ""){
                        break;
                    }else{
                        if (OnlyHexInString(word) != true){
                            MessageBox.Show("You have entered an invalid number for Hex to Binary conversion.");
                        }else{
                            byte raw;
                            raw = Convert.ToByte(word, 16);
                            szBinOutput += String.Format("{0}{1}", Convert.ToString(raw, 2).PadLeft(8, '0'), szOutSep);
                            txtOutput.Text = szBinOutput;
                        }
                    }
                }
            }catch (Exception ex){
                string szEX = GetExceptionType(ex);
                MessageBox.Show(szEX);
            }
        }

        private void Hex2Decimal_Click(object sender, EventArgs e)
        {
            string szOutSep = SelectedOutoutFormat();
            string szInSep = SelectedInputFormat();
            char[] chInSep = szInSep.ToCharArray();

            // Convert the argument to a char value.
            try
            {
                string szBinOutput = "";
                string[] words = txtInput.Text.Split(chInSep, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    if (word == null || word == "")
                    {
                        break;
                    }
                    else
                    {
                        if (OnlyHexInString(word) != true)
                        {
                            MessageBox.Show("You have entered an invalid number for Hex to Binary conversion.");
                        }
                        else
                        {
                            byte raw;
                            raw = Convert.ToByte(word, 16);
                            szBinOutput += String.Format("{0:D}{1}", Convert.ToInt32(word, 16), szOutSep);
                            txtOutput.Text = szBinOutput;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string szEX = GetExceptionType(ex);
                MessageBox.Show(szEX);
            }
        }

        public bool OnlyHexInString(string test)
        {
            // For C-style hex notation (0xFF) you can use @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z"
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        private void Hex2Octal_Click(object sender, EventArgs e)
        {
            string szOutSep = SelectedOutoutFormat();
            string szInSep = SelectedInputFormat();
            char[] chInSep = szInSep.ToCharArray();

            // Convert the argument to a char value.
            try
            {
                string szBinOutput = "";
                string[] words = txtInput.Text.Split(chInSep, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    if (word == null || word == "")
                    {
                        break;
                    }
                    else
                    {
                        if (OnlyHexInString(word) != true)
                        {
                            MessageBox.Show("You have entered an invalid number for Hex to Binary conversion.");
                        }
                        else
                        {
                            byte raw;
                            raw = Convert.ToByte(word, 16);
                            szBinOutput += String.Format("{0}{1}", Convert.ToString(Convert.ToInt32(word, 16), 8), szOutSep);
                            txtOutput.Text = szBinOutput;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string szEX = GetExceptionType(ex);
                MessageBox.Show(szEX);
            }
        }
        #endregion

        #region "Octal Conversions"
        private void Oct2Bin_Click(object sender, EventArgs e)
        {
            int iDecimal = System.Convert.ToInt32(txtInput.Text, 8);
            txtOutput.Text = String.Format("{0}", System.Convert.ToString(iDecimal, 2));
        }

        private void Oct2Dec_Click(object sender, EventArgs e)
        {
            int iDecimal = System.Convert.ToInt32(txtInput.Text, 8);
            txtOutput.Text = String.Format("{0}", System.Convert.ToString(iDecimal, 10));
        }

        private void Oct2Hex_Click(object sender, EventArgs e)
        {
            int iDecimal = System.Convert.ToInt32(txtInput.Text, 8);
            txtOutput.Text = String.Format("{0:X8}", System.Convert.ToString(iDecimal, 16));
        }

        private void Oct2Text_Click(object sender, EventArgs e)
        {
            int iDecimal = System.Convert.ToInt32(txtInput.Text, 8);
            txtOutput.Text = String.Format("{0}", Convert.ToChar(iDecimal));
        }
        #endregion

        #region “String Conversions”
        private void TextToDecimal_Click(object sender, EventArgs e)
        {
            string szSep = SelectedOutoutFormat();
            char[] values = txtInput.Text.ToCharArray();
            string szDecOutput = "";
            foreach (char letter in values)
            {
                // Get the integral value of the character. 
                int value = Convert.ToInt32(letter);
                // Convert the decimal value to a hexadecimal value in string form. 
                szDecOutput += String.Format("{0:d}{1}", value, szSep);
            }
            txtOutput.Text = szDecOutput;
        }

        private void TextToBinary_Click(object sender, EventArgs e)
        {
            string szSep = SelectedOutoutFormat();
            char[] values = txtInput.Text.ToCharArray();
            string szDecOutput = "";
            foreach (char c in values)
            {
                for (int i = 128; i >= 1; i /= 2)
                {
                    if (((int)c & i) > 0)
                    {
                        szDecOutput += "1";
                    }else{
                        szDecOutput += "0";
                    }
                }
                szDecOutput += String.Format("{0}", szSep);
            }
            txtOutput.Text = szDecOutput;
        }

        private void TextToHex_Click(object sender, EventArgs e)
        {
            string szSep = SelectedOutoutFormat();
            char[] values = txtInput.Text.ToCharArray();
            string szHexOutput = "";
            foreach (char letter in values)
            {
                // Get the integral value of the character. 
                int value = Convert.ToInt32(letter);
                // Convert the decimal value to a hexadecimal value in string form. 
                szHexOutput += String.Format("{0:X}{1}", value, szSep);
            }
            txtOutput.Text = szHexOutput;
        }

        private void TextToOctal_Click(object sender, EventArgs e)
        {
            string szSep = SelectedOutoutFormat();
            char[] values = txtInput.Text.ToCharArray();
            string szOctalOutput = "";
            foreach (char c in values)
            {
                string value = Convert.ToString(c,8);
                szOctalOutput += String.Format("{0:d}{1}", value, szSep);
            }
            txtOutput.Text = szOctalOutput;
        }
        #endregion

        #region “Decimal Conversions”
        private void DecimalToBinary_Click(object sender, EventArgs e)
        {
            string szOutSep = SelectedOutoutFormat();
            string szInSep = SelectedInputFormat();
            char[] chInSep = szInSep.ToCharArray();
            // Convert the argument to a char value.
            try
            {
                string[] words = txtInput.Text.Split(chInSep, StringSplitOptions.RemoveEmptyEntries);
                string szOutput = "";
                foreach (string word in words)
                {
                    if (word == null || word == "")
                    {
                        break;
                    }
                    else
                    {
                        int val = int.Parse(word);
                        if (val < 0 || val > 127)
                        {
                            MessageBox.Show("You have entered an invalid number for Decimal to Binary conversion.");
                        }
                        else
                        {
                            Int64 DecimalNumber = Convert.ToInt64(word);
                            Int64 BinaryNumber;
                            char[] BinaryArray;
                            string BinaryResult = "";

                            while (DecimalNumber > 0)
                            {
                                BinaryNumber = DecimalNumber % 2;
                                BinaryResult += BinaryNumber;
                                DecimalNumber = DecimalNumber / 2;
                            }
                            BinaryArray = BinaryResult.ToCharArray();
                            Array.Reverse(BinaryArray);
                            BinaryResult = new string(BinaryArray);
                            szOutput += String.Format("{0}{1}", BinaryResult.ToString().PadLeft(8, '0'), szOutSep);
                        }
                    }
                }
                txtOutput.Text = szOutput;
            }
            catch (Exception ex)
            {
                string szEX = GetExceptionType(ex);
                MessageBox.Show(szEX);
            }
        }

        private void DecimalToHex_Click(object sender, EventArgs e)
        {
            string szOutSep = SelectedOutoutFormat();
            string szInSep = SelectedInputFormat();
            char[] chInSep = szInSep.ToCharArray();
            // Convert the argument to a char value.
            try
            {
                string[] words = txtInput.Text.Split(chInSep, StringSplitOptions.RemoveEmptyEntries);
                string szOutput = "";
                foreach (string word in words)
                {
                    if (word == null || word == "")
                    {
                        break;
                    }
                    else
                    {
                        int val = int.Parse(word);
                        if (val < 0 || val > 127)
                        {
                            MessageBox.Show("You have entered an invalid number for Decimal to Hex conversion.");
                        }
                        else
                        {
                            int DecimalValue = Convert.ToInt32(word);
                            string HexValue = DecimalValue.ToString("X");
                            szOutput += String.Format("{0}{1}", HexValue, szOutSep);
                        }
                    }
                }
                txtOutput.Text = String.Format("{0}", szOutput);
            }
            catch (Exception ex)
            {
                string szEX = GetExceptionType(ex);
                MessageBox.Show(szEX);
            }
        }

        private void DecimalToOctal_Click(object sender, EventArgs e)
        {
            string szOutSep = SelectedOutoutFormat();
            string szInSep = SelectedInputFormat();
            char[] chInSep = szInSep.ToCharArray();
            // Convert the argument to a char value.
            try
            {
                string[] words = txtInput.Text.Split(chInSep, StringSplitOptions.RemoveEmptyEntries);
                string szOutput = "";
                foreach (string word in words)
                {
                    if (word == null || word == "")
                    {
                        break;
                    }
                    else
                    {
                        int val = int.Parse(word);
                        if (val < 0 || val > 127)
                        {
                            MessageBox.Show("You have entered an invalid number for Decimal to Octal conversion.");
                        }
                        else
                        {
                            Int64 iOctal = Convert.ToInt64(word);
                            szOutput += String.Format("{0}{1}", Convert.ToString(iOctal, 8), szOutSep);
                            
                        }
                    }
                }
                txtOutput.Text = String.Format("{0}", szOutput);
            }
            catch (Exception ex)
            {
                string szEX = GetExceptionType(ex);
                MessageBox.Show(szEX);
            }
        }

        private void Decimal2Char_Click(object sender, EventArgs e)
        {
            string szInSep = SelectedInputFormat();
            char[] chInSep = szInSep.ToCharArray();
            // Convert the argument to a char value.
            try
            {
                string[] words = txtInput.Text.Split(chInSep, StringSplitOptions.RemoveEmptyEntries);
                string szOutput = "";
                foreach (string word in words)
                {
                    if (word == null || word == "")
                    {
                        break;
                    }
                    else
                    {
                        int val = int.Parse(word);
                        if (val < 0 || val > 127)
                        {
                            MessageBox.Show("The number is either too small or too big.");
                        }
                        else
                        {
                            szOutput += Convert.ToChar(val);
                        }
                    }
                }
                txtOutput.Text = String.Format("{0}", szOutput);
            }
            catch (Exception ex)
            {
                string szEX = GetExceptionType(ex);
                MessageBox.Show(szEX);
            }
        }

        // Get the exception type name; remove the namespace prefix.
        public static string GetExceptionType(Exception ex)
        {
            string exceptionType = ex.GetType().ToString();
            return exceptionType.Substring(
                exceptionType.LastIndexOf('.') + 1);
        }

        bool IsNumber(string text)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }
        #endregion

        #region “Binary Conversions”
        private void BinaryToDecimal_Click(object sender, EventArgs e)
        {
            string szOutSep = SelectedOutoutFormat();
            string szInSep = SelectedInputFormat();
            char[] chInSep = szInSep.ToCharArray();
            // Convert the argument to a char value.
            try
            {
                string[] words = txtInput.Text.Split(chInSep, StringSplitOptions.RemoveEmptyEntries);
                string szOutput = "";
                foreach (string word in words)
                {
                    if (word == null || word == "")
                    {
                        break;
                    }
                    else
                    {
                        string StringToConvert = ReverseString(word);//Reverse String
                        int Counter = StringToConvert.Length;
                        double Results = 0;

                        ulong binaryValue = 1;
                        if (!BinaryChecker(StringToConvert))
                        {
                            MessageBox.Show("A binary digit can only be a 1 or a 0!");
                        }
                        else
                        {
                            foreach (char CharToConvert in StringToConvert)
                            {
                                Results += ulong.Parse(CharToConvert.ToString()) * binaryValue;
                                binaryValue *= 2;
                            }
                            szOutput += String.Format("{0}{1}", Results, szOutSep);
                        }
                    }
                }
                txtOutput.Text = szOutput;
            }
            catch (Exception ex)
            {
                string szEX = GetExceptionType(ex);
                MessageBox.Show(szEX);
            }
        }

        private void Binary2Hex_Click(object sender, EventArgs e)
        {
            string szOutSep = SelectedOutoutFormat();
            string szInSep = SelectedInputFormat();
            char[] chInSep = szInSep.ToCharArray();
            // Convert the argument to a char value.
            try
            {
                string[] words = txtInput.Text.Split(chInSep, StringSplitOptions.RemoveEmptyEntries);
                string szOutput = "";
                foreach (string word in words)
                {
                    if (word == null || word == "")
                    {
                        break;
                    }
                    else
                    {
                        if (!BinaryChecker(word))
                        {
                            MessageBox.Show("A binary digit can only be a 1 or a 0!");
                        }
                        else
                        {
                            szOutput += String.Format("{0}{1}", Binary2OtherBase(word, 16), szOutSep);
                        }
                    }
                }
                txtOutput.Text = szOutput;
            }
            catch (Exception ex)
            {
                string szEX = GetExceptionType(ex);
                MessageBox.Show(szEX);
            }
        }

        private void Binary2Octal_Click(object sender, EventArgs e)
        {
            string szOutSep = SelectedOutoutFormat();
            string szInSep = SelectedInputFormat();
            char[] chInSep = szInSep.ToCharArray();
            // Convert the argument to a char value.
            try
            {
                string[] words = txtInput.Text.Split(chInSep, StringSplitOptions.RemoveEmptyEntries);
                string szOutput = "";
                foreach (string word in words)
                {
                    if (word == null || word == "")
                    {
                        break;
                    }
                    else
                    {
                        if (!BinaryChecker(word))
                        {
                            MessageBox.Show("A binary digit can only be a 1 or a 0!");
                        }
                        else
                        {
                            szOutput += String.Format("{0}{1}", Binary2OtherBase(word, 8), szOutSep);
                        }
                    }
                }
                txtOutput.Text = szOutput;
            }
            catch (Exception ex)
            {
                string szEX = GetExceptionType(ex);
                MessageBox.Show(szEX);
            }
        }

        private void Binary2Text_Click(object sender, EventArgs e)
        {
            string szOutSep = SelectedOutoutFormat();
            string szInSep = SelectedInputFormat();
            char[] chInSep = szInSep.ToCharArray();
            byte[] data;
            // Convert the argument to a char value.
            try
            {
                string[] words = txtInput.Text.Split(chInSep, StringSplitOptions.RemoveEmptyEntries);
                string szOutput = "";
                foreach (string word in words)
                {
                    if (word == null || word == "")
                    {
                        break;
                    }
                    else
                    {
                        if (!BinaryChecker(word))
                        {
                            MessageBox.Show("A binary digit can only be a 1 or a 0!");
                        }
                        else
                        {
                            data = GetBytesFromBinaryString(word);
                            szOutput += String.Format("{0}", Encoding.ASCII.GetString(data));
                        }
                    }
                }
                txtOutput.Text = String.Format("{0}", szOutput);
            }
            catch (Exception ex)
            {
                string szEX = GetExceptionType(ex);
                MessageBox.Show(szEX);
            }
        }

        public Byte[] GetBytesFromBinaryString(String binary)
        {
            var list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                String t = binary.Substring(i, 8);

                list.Add(Convert.ToByte(t, 2));
            }

            return list.ToArray();
        }

        public static bool BinaryChecker(string s)
        {
            foreach (char CharToConvert in s)
            {
                if (CharToConvert.ToString() != "0" && CharToConvert.ToString() != "1")
                {
                    return false;
                }
            }
            return true;
        }

        public static string Binary2OtherBase(string s, int iBase)
        {
            int integer = Convert.ToInt32(s, 2);
            if (iBase == 16)
            {
                return String.Format("0x{0:X}", Convert.ToString(integer, iBase));
            }
            else
            {
                return String.Format("{0}", Convert.ToString(integer, iBase));
            }
        }
        #endregion

        #region “Conversions/Transformation”
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        private void Input2Output_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtInput.Text;
        }

        private void Output2Input_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtOutput.Text;
        }

        private void Clipboard2Input_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();
            // Determines whether the data is in a format you can use. 
            if (iData.GetDataPresent(DataFormats.Text))
            {
                // Yes it is, so display it in a text box.
                txtInput.Text = (String)iData.GetData(DataFormats.Text);
            }else{
                // No it is not.
                MessageBox.Show("Could not retrieve data off the clipboard.");
            }
        }

        private void Output2Clipboard_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "")
            {
                Clipboard.SetDataObject(txtOutput.Text);
            }else{
                MessageBox.Show("No text in Output.");
            }
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            // The user wants to exit the application. Close everything down.
            Application.Exit();
        }

        private void ReverseAString_Click(object sender, EventArgs e)
        {
            string szInput = txtInput.Text;
            string szOutput = "";
            szOutput = ReverseString(szInput);
            txtOutput.Text = String.Format("{0}", szOutput);
        }

        private void String2Uppercase_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtInput.Text.ToUpper();
        }

        private void String2Lowercase_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtInput.Text.ToLower();
        }
        #endregion

        #region “Encodings”
        private void MorseCodeEncode_Click(object sender, EventArgs e)
        {
            MorseCode mc = new MorseCode();
            string szInputString = txtInput.Text;
            string szOutputString = "";
            szOutputString = mc.ConvertTextToMorse(szInputString);
            txtOutput.Text = String.Format("{0}", szOutputString);
        }

        private void MorseCodeDecode_Click(object sender, EventArgs e)
        {
            MorseCode mc = new MorseCode();
            string szInputString = txtInput.Text;
            string szOutputString = "";
            szOutputString = mc.ConvertMorseToText(szInputString);
            txtOutput.Text = String.Format("{0}", szOutputString);
        }

        private void HTMLEncode_Click(object sender, EventArgs e)
        {
            string szInputString = txtInput.Text;
            string szOutputString = "";
            szOutputString = System.Net.WebUtility.HtmlEncode(szInputString);
            txtOutput.Text = String.Format("{0}", szOutputString);
        }

        private void HTMLDecode_Click(object sender, EventArgs e)
        {
            string szInputString = txtInput.Text;
            string szOutputString = "";
            szOutputString = System.Net.WebUtility.HtmlDecode(szInputString);
            txtOutput.Text = String.Format("{0}", szOutputString);
        }

        private void URLencode_Click(object sender, EventArgs e)
        {
            string szInputString = txtInput.Text;
            String DataString = Uri.EscapeDataString(szInputString);
            txtOutput.Text = String.Format("{0}", DataString);
        }

        private void URLdecode_Click(object sender, EventArgs e)
        {
            string szInputString = txtInput.Text;
            String DataString = Uri.UnescapeDataString(szInputString);
            txtOutput.Text = String.Format("{0}", DataString);
        }

        private void URIencode_Click(object sender, EventArgs e)
        {
            string szInputString = txtInput.Text;
            String DataString = Uri.EscapeUriString(szInputString);
            txtOutput.Text = String.Format("{0}", DataString);
        }

        private void URIdecode_Click(object sender, EventArgs e)
        {
            string szInputString = txtInput.Text;
            String DataString = Uri.UnescapeDataString(szInputString);
            txtOutput.Text = String.Format("{0}", DataString);
        }

        private void B64encode_Click(object sender, EventArgs e)
        {
            byte[] toEncodeAsBytes = System.Text.Encoding.Unicode.GetBytes(txtInput.Text);
            string szBase64Output = System.Convert.ToBase64String(toEncodeAsBytes);
            txtOutput.Text = szBase64Output;
        }

        private void B64decode_Click(object sender, EventArgs e)
        {
            byte[] encodedDataAsBytes = System.Convert.FromBase64String(txtInput.Text);
            string szBase64Output = System.Text.Encoding.Unicode.GetString(encodedDataAsBytes);
            txtOutput.Text = szBase64Output;
        }

        private void ToUnicodeEscape_Click(object sender, EventArgs e)
        {
            string szInputString = txtInput.Text;
            String DataString = "";
            foreach (char s in szInputString)
            {
                DataString += String.Format("\\u{0:x4}", (int)s);
            }
            txtOutput.Text = String.Format("{0}", DataString);
        }

        private void FromUnicodeEscape_Click(object sender, EventArgs e)
        {
            string temp = txtInput.Text.Replace(@"\u00", "");
            string hex = temp;
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            txtOutput.Text = Encoding.UTF7.GetString(raw);
        }

        private void ToUnicodeEscape2_Click(object sender, EventArgs e)
        {
            string szInputString = txtInput.Text;
            String DataString = "";
            foreach (char s in szInputString)
            {
                DataString += String.Format("&#x{0:x4};", (int)s);
            }
            txtOutput.Text = String.Format("{0}", DataString);
        }

        private void FromUnicodeEscape2_Click(object sender, EventArgs e)
        {
            string temp = txtInput.Text.Replace(@"&#x00", "");
            temp = temp.Replace(";", "");
            string hex = temp;
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            txtOutput.Text = Encoding.UTF7.GetString(raw);
        }
        #endregion

        #region “Hashing”
        private void Adler32_Click(object sender, EventArgs e)
        {
            byte[] szInput = Encoding.ASCII.GetBytes(txtInput.Text);
            byte[] szOutput = _0x434F4445.Adler32.ComputeChecksum(szInput,0,szInput.Length);
            StringBuilder sb = new StringBuilder(szOutput.Length * 2);
            foreach (byte b in szOutput){
                sb.AppendFormat("{0:x2}", b);
            }
            txtOutput.Text = String.Format("{0}", sb.ToString().ToUpper());
        }

        private void CRC16_Click(object sender, EventArgs e)
        {
            CRC16 crc16 = new CRC16();
            byte[] szInput = Encoding.ASCII.GetBytes(txtInput.Text);
            crc16.Crc16();
            int szOutput = crc16.ComputeChecksum(szInput);
            txtOutput.Text = String.Format("0x{0:X}", szOutput.ToString("X"));
        }

        private void CRC16ccitt_Click(object sender, EventArgs e)
        {
            CRC16ccitt crc16ccitt = new CRC16ccitt();
            byte[] szInput = Encoding.ASCII.GetBytes(txtInput.Text);
            crc16ccitt.Crc16Ccitt(InitialCrcValue.NonZero1);
            ushort szOutput = crc16ccitt.ComputeChecksum(szInput);
            txtOutput.Text = String.Format("0x{0:X}", szOutput.ToString("X"));
        }

        private void CRC32_Click(object sender, EventArgs e)
        {
            CRC32 crc32 = new CRC32();
            byte[] szInput = Encoding.ASCII.GetBytes(txtInput.Text);
            crc32.Crc32();
            uint szOutput = crc32.ComputeChecksum(szInput);
            txtOutput.Text = String.Format("0x{0:X}", szOutput.ToString("X"));
        }

        private void MD5_Click(object sender, EventArgs e)
        {
            string hash = ComputeHash(txtInput.Text, new MD5CryptoServiceProvider()).Replace("-", "");
            txtOutput.Text = String.Format("{0:X}", hash);
        }

        private void SHA1_Click(object sender, EventArgs e)
        {
            string hash = ComputeHash(txtInput.Text, new SHA1CryptoServiceProvider()).Replace("-", "");
            txtOutput.Text = String.Format("{0:X}", hash);
        }

        private void SHA256_Click(object sender, EventArgs e)
        {
            string hash = ComputeHash(txtInput.Text, new SHA256CryptoServiceProvider()).Replace("-", "");
            txtOutput.Text = String.Format("{0:X}", hash);
        }

        public string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
        #endregion

        private string SelectedOutoutFormat(){
            string szSeparator = "";
            switch( cbOutPutFormat.SelectedIndex ){
                case 0:
                    szSeparator = "";
                    break;
                case 1:
                    szSeparator = ",";
                    break;
                case 2:
                    szSeparator = " ";
                    break;
                case 3:
                    szSeparator = "\\";
                    break;
                case 4:
                    szSeparator = "%";
                    break;
            }
            return szSeparator;
        }

        private string SelectedInputFormat()
        {
            string szSeparator = "";
            switch (cbInputSep.SelectedIndex)
            {
                case 0:
                    szSeparator = "";
                    break;
                case 1:
                    szSeparator = ",";
                    break;
                case 2:
                    szSeparator = " ";
                    break;
                case 3:
                    szSeparator = "\\";
                    break;
                case 4:
                    szSeparator = "%";
                    break;
            }
            return szSeparator;
        }

        private void about0x434F4445ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0x434F4445", "0x434F4445 v0.1");
        }

        private void ConvertIPAddress_Click(object sender, EventArgs e)
        {
            IPConverter ipc = new IPConverter();
            ipc.ShowDialog();
        }

        private void convertToUnixEpochToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnixEpoch UE = new UnixEpoch();
            UE.ShowDialog();
        }

        private void mySQL5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string hash = GenerateMySQ5LHash(txtInput.Text);
            txtOutput.Text = hash;
        }

        public string GenerateMySQ5LHash(string key)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(key);
            SHA1Managed enc = new SHA1Managed();
            byte[] encodedKey = enc.ComputeHash(enc.ComputeHash(keyArray));
            StringBuilder myBuilder = new StringBuilder(encodedKey.Length);

            foreach (byte b in encodedKey)
                myBuilder.Append(b.ToString("X2"));

            return "*" + myBuilder.ToString();
        }
    }
}
