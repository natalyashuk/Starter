using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVariable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("від 0 до 255", "BYTE");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("від -128 до +127","SBYTE");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("від 0 до 65535","USHORT");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("від -32768 до +32767", "SHORT");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("від -2147483648 до +2147483647", "INT");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("від -0 до +4294967295", "UINT");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("від -9223372036854775808 до +9223372036854775807", "LONG");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("від -0 до +18446744073709551615", "ULONG");
        }
    }
}