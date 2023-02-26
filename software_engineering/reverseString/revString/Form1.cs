using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string reverseString(string s)
        {
            // Converting string to character array
            char[] charArray = s.ToCharArray();

            // Declaring an empty string
            string reversedString = String.Empty;

            // Iterating the each character from right to left
            for (int i = charArray.Length - 1; i > -1; i--)
            {

                // Append each character to the reversedstring.
                reversedString += charArray[i];
            }

            // Return the reversed string.
            return reversedString;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string reverse = textBox1.Text;
            string reveresd = reverseString(reverse);
            textBox2.Text = reveresd;

        }
    }
}
