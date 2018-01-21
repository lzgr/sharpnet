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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list_masks smlist = new list_masks();
            this.Hide();
            smlist.ShowDialog();
            smlist = null;
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSpaceNetCalc addcalc = new AddSpaceNetCalc();
            this.Hide();
            addcalc.ShowDialog();
            addcalc = null;
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NetCalc netcalculate = new NetCalc();
            this.Hide();
            netcalculate.ShowDialog();
            netcalculate = null;
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RouteSummarization routesummar = new RouteSummarization();
            this.Hide();
            routesummar.ShowDialog();
            routesummar = null;
            Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumHosts hostnum = new NumHosts();
            this.Hide();
            hostnum.ShowDialog();
            hostnum = null;
            Show();
        }
    }
}
