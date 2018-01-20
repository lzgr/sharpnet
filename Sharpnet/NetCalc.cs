using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Sharpnet
{
    public partial class NetCalc : Form
    {

        public NetCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SM_binTB.Text = null;
            IP_binTB.Text = null;
            NetID_binTB.Text = null;
            FirstUsable_binTB.Text = null;
            LastUsable_binTB.Text = null;
            Broadcast_binTB.Text = null;

            int sm_shrt = 0;
            uint sm = 0, NetID, FirstUs, LastUs, Broadc;
            
            //Converts IP from string to 32 bit unsigned int and reverses byte order due to endianness
            uint ipInt = BitConverter.ToUInt32(IPAddress.Parse(tbIP.Text).GetAddressBytes(), 0);
            byte[] endian = BitConverter.GetBytes(ipInt);
            Array.Reverse(endian);
            ipInt = BitConverter.ToUInt32(endian, 0);

            //Converts "/XX" SM format to decimal int (sm_shrt) and binary value of SM (sm)
            if (!Int32.TryParse(tbSM.Text.Substring(1), out sm_shrt))
            {
                MessageBox.Show("Invalid subnet mask", "Sharpnet - Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            for (int i = 32; i >= (32 - sm_shrt) ; i--)
            {
                sm = sm + (uint)Math.Pow(2, i);
            }
            
            NetID = ipInt & sm;
            FirstUs = NetID + 1;
            LastUs = (NetID + (~sm)) - 1;
            Broadc = NetID + (~sm);
            
            //Sets the colour delimiter depending on the octet
            int delimiter = 0;
            if (sm_shrt < 8) delimiter = sm_shrt;
            else if (sm_shrt < 16) delimiter = sm_shrt + 1;
            else if (sm_shrt < 24) delimiter = sm_shrt + 2;
            else if (sm_shrt < 32) delimiter = sm_shrt + 3;
            
            IPadd_dec.Text = tbIP.Text;
            SM_dec.Text = tbSM.Text;
            NetID_dec.Text = UintToDecString(NetID);
            FirstUsable_dec.Text = UintToDecString(FirstUs);
            LastUsable_dec.Text = UintToDecString(LastUs);
            Broadcast_dec.Text = UintToDecString(Broadc);

            SM_binTB.AppendText(UintToBinString(sm).Substring(0, delimiter), Color.Red);
            SM_binTB.AppendText(UintToBinString(sm).Substring(delimiter), Color.Blue);
            IP_binTB.AppendText(UintToBinString(ipInt).Substring(0, delimiter), Color.Red);
            IP_binTB.AppendText(UintToBinString(ipInt).Substring(delimiter), Color.Blue);
            NetID_binTB.AppendText(UintToBinString(NetID).Substring(0, delimiter), Color.Red);
            NetID_binTB.AppendText(UintToBinString(NetID).Substring(delimiter), Color.Blue);
            FirstUsable_binTB.AppendText(UintToBinString(FirstUs).Substring(0, delimiter), Color.Red);
            FirstUsable_binTB.AppendText(UintToBinString(FirstUs).Substring(delimiter), Color.Blue);
            LastUsable_binTB.AppendText(UintToBinString(LastUs).Substring(0, delimiter), Color.Red);
            LastUsable_binTB.AppendText(UintToBinString(LastUs).Substring(delimiter), Color.Blue);
            Broadcast_binTB.AppendText(UintToBinString(Broadc).Substring(0, delimiter), Color.Red);
            Broadcast_binTB.AppendText(UintToBinString(Broadc).Substring(delimiter), Color.Blue);
        }
        
        private string UintToBinString(uint intIPvalue)
        {
            byte[] convert = BitConverter.GetBytes(intIPvalue);
            Array.Reverse(convert);
            return (Convert.ToString(convert[0], 2).PadLeft(8, '0') + "." + Convert.ToString(convert[1], 2).PadLeft(8, '0') + "." 
                    + Convert.ToString(convert[2], 2).PadLeft(8, '0') + "." + Convert.ToString(convert[3], 2).PadLeft(8, '0'));
        }

        private string UintToDecString(uint intIPvalue)
        {
            byte[] convert = BitConverter.GetBytes(intIPvalue);
            Array.Reverse(convert);
            return Convert.ToString(convert[0]) + "." + Convert.ToString(convert[1]) + "." 
                   + Convert.ToString(convert[2]) + "." + Convert.ToString(convert[3]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
