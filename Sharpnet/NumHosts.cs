using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sharpnet
{
    public partial class NumHosts : Form
    {
        public NumHosts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hosts = 0, i = 0;
            Int32.TryParse(smTb.Text, out hosts);
            do
            {
                i++;
            } while (((int) Math.Pow(2, i) - 2) < hosts);
            sMask.Text = "/" + (32-i).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }
