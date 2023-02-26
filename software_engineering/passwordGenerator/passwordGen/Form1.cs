using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string generate_Password()
        {
            Random rand = new Random();

            // Choosing the size of string
            // Using Next() string
            int stringlen = rand.Next(8, 10);
            int randValue;
            string str = "";
            char letter;
            for (int i = 0; i < stringlen; i++)
            {

                // Generating a random number.
                randValue = rand.Next(0, 26);

                // Generating random character by converting
                // the random number into character.
                letter = Convert.ToChar(randValue + 65);

                // Appending the letter to string.
                str = str + letter;
            }
                
                return str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = generate_Password();
            textBox1.Text = password; 
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
