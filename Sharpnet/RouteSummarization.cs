using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharpnet
{
    public partial class RouteSummarization : Form
    {
        public RouteSummarization()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numLines = richTextBox1.Lines.Count();
            uint[] IPs = new uint[numLines];
            string[] lines = richTextBox1.Text.Split('\n');

            //Fetches the first IP from the list, converts it to unsigned int and switches byte order due to endiannes
            uint firstIP = BitConverter.ToUInt32(IPAddress.Parse(lines[0]).GetAddressBytes(), 0);
            byte[] endian = BitConverter.GetBytes(firstIP);
            Array.Reverse(endian);
            firstIP = BitConverter.ToUInt32(endian, 0);
            uint currentIP = 0, xorIP = 0, summedIP = 0;


            for (int i = 1; i < numLines; i++)
            {
                currentIP = BitConverter.ToUInt32(IPAddress.Parse(lines[i]).GetAddressBytes(), 0);
                endian = BitConverter.GetBytes(currentIP);
                Array.Reverse(endian);
                currentIP = BitConverter.ToUInt32(endian, 0);
                xorIP = xorIP | (firstIP ^ currentIP);
            }

            //Finds the most significant bit in the xorIP, creates a subnet mask and sets label value
            uint msb = 1, sm = 0;
            while (msb <= xorIP)
            {
                msb = msb * 2;
                sm++;
            }
            sm = 32 - sm;
            msb = uint.MaxValue^(msb - 1);
            summedIP = firstIP & msb;
            endian = BitConverter.GetBytes(summedIP);
            Array.Reverse(endian);
            summedIP = BitConverter.ToUInt32(endian, 0);
            label_sum.Text = new IPAddress(BitConverter.GetBytes(summedIP)).ToString();
            smlabel.Text = "/" + sm.ToString();
        }
    }
}
