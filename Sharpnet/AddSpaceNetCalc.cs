using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharpnet
{
    public partial class AddSpaceNetCalc : Form
    {
        public AddSpaceNetCalc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "10.0.0.0";
            textBox2.Text = "/8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "172.16.0.0";
            textBox2.Text = "/12";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "192.168.0.0";
            textBox2.Text = "/16";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adsm = 0;
            int sm = 0;
            int subntwrks, comp;
            if (Int32.TryParse(textBox2.Text.Substring(1), out adsm))
            {
                if (Int32.TryParse(textBox3.Text.Substring(1), out sm))
                {
                    subntwrks = ((int)Math.Pow(2, sm - adsm));
                    comp = ((int)Math.Pow(2, 32 - sm)) - 2;
                    label7.Text = Convert.ToString(subntwrks);
                    label8.Text = Convert.ToString(comp);
                }
                else
                {
                    MessageBox.Show("Invalid subnet mask", "Sharpnet - Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid address space subnet mask", "Sharpnet - Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
