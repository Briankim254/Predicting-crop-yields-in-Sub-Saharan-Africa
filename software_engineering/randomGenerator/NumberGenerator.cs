using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luna
{
    public partial class NumberGenerator : Form
    {
        public NumberGenerator()
        {
            InitializeComponent();
        }

        public int randomNumberGenerator()
        {
            Random rand = new Random();
            int num;
            num = rand.Next(0,999);
            return num;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num2;
            num2 = randomNumberGenerator();
            textBox1.Text = num2.ToString();
        }
    }
}
