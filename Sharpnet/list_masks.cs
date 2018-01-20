using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public struct maska
{
    public int o1;
    public int o2;
    public int o3;
    public int o4;
}
namespace Sharpnet
{
    public partial class list_masks : Form
    {
        public list_masks()
        {
            InitializeComponent();
            maska sub_mask;
            sub_mask.o1 = 0;
            sub_mask.o2 = 0;
            sub_mask.o3 = 0;
            sub_mask.o4 = 0;
            Label labela0 = new Label();
            labela0.Text = Iptotext(0, sub_mask);
            labela0.AutoSize = true;
            flowLayoutPanel1.Controls.Add(labela0);
            for (uint i = 1; i <= 32; i++)
            {
                if (i <= 8)
                {
                    sub_mask.o1 = sub_mask.o1 + (int)Math.Pow(2, 8 - i);
                }
                else if (i <= 16)
                {
                    sub_mask.o2 = sub_mask.o2 + (int)Math.Pow(2, 16 - i);
                }
                else if (i <= 24)
                {
                    sub_mask.o3 = sub_mask.o3 + (int)Math.Pow(2, 24 - i);
                }
                else if (i <= 32)
                {
                    sub_mask.o4 = sub_mask.o4 + (int)Math.Pow(2, 32 - i);
                }
                Label labela = new Label();
                labela.Text = Iptotext(i, sub_mask);
                labela.AutoSize = true;
                flowLayoutPanel1.Controls.Add(labela);
            }

        }

        public string Iptotext(uint iter, maska sub)
        {
            string povrat ="/" + Convert.ToString(iter) + "\n" + Convert.ToString(sub.o1, 2).PadLeft(8, '0') + '.' + 
                Convert.ToString(sub.o2, 2).PadLeft(8, '0') + '.' + Convert.ToString(sub.o3, 2).PadLeft(8, '0') + '.' + 
                Convert.ToString(sub.o4, 2).PadLeft(8, '0') + '\n' + Convert.ToString(sub.o1) + '.' + 
                Convert.ToString(sub.o2) + '.' + Convert.ToString(sub.o3) + '.' + Convert.ToString(sub.o4);
            return povrat;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
