namespace Sharpnet
{
    partial class NetCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetCalc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbSM = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NetID_dec = new System.Windows.Forms.Label();
            this.FirstUsable_dec = new System.Windows.Forms.Label();
            this.LastUsable_dec = new System.Windows.Forms.Label();
            this.Broadcast_dec = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IPadd_dec = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SM_dec = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.IP_binTB = new System.Windows.Forms.RichTextBox();
            this.SM_binTB = new System.Windows.Forms.RichTextBox();
            this.NetID_binTB = new System.Windows.Forms.RichTextBox();
            this.FirstUsable_binTB = new System.Windows.Forms.RichTextBox();
            this.LastUsable_binTB = new System.Windows.Forms.RichTextBox();
            this.Broadcast_binTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter IP address and subnet mask";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subnet mask:";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(118, 73);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(119, 22);
            this.tbIP.TabIndex = 3;
            // 
            // tbSM
            // 
            this.tbSM.Location = new System.Drawing.Point(118, 111);
            this.tbSM.Name = "tbSM";
            this.tbSM.Size = new System.Drawing.Size(41, 22);
            this.tbSM.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Network ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "First usable address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Last usable address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Broadcast address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Network properties";
            // 
            // NetID_dec
            // 
            this.NetID_dec.AutoSize = true;
            this.NetID_dec.Location = new System.Drawing.Point(207, 341);
            this.NetID_dec.Name = "NetID_dec";
            this.NetID_dec.Size = new System.Drawing.Size(0, 17);
            this.NetID_dec.TabIndex = 11;
            // 
            // FirstUsable_dec
            // 
            this.FirstUsable_dec.AutoSize = true;
            this.FirstUsable_dec.Location = new System.Drawing.Point(207, 374);
            this.FirstUsable_dec.Name = "FirstUsable_dec";
            this.FirstUsable_dec.Size = new System.Drawing.Size(0, 17);
            this.FirstUsable_dec.TabIndex = 12;
            // 
            // LastUsable_dec
            // 
            this.LastUsable_dec.AutoSize = true;
            this.LastUsable_dec.Location = new System.Drawing.Point(207, 407);
            this.LastUsable_dec.Name = "LastUsable_dec";
            this.LastUsable_dec.Size = new System.Drawing.Size(0, 17);
            this.LastUsable_dec.TabIndex = 13;
            // 
            // Broadcast_dec
            // 
            this.Broadcast_dec.AutoSize = true;
            this.Broadcast_dec.Location = new System.Drawing.Point(207, 440);
            this.Broadcast_dec.Name = "Broadcast_dec";
            this.Broadcast_dec.Size = new System.Drawing.Size(0, 17);
            this.Broadcast_dec.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "IP Address:";
            // 
            // IPadd_dec
            // 
            this.IPadd_dec.AutoSize = true;
            this.IPadd_dec.Location = new System.Drawing.Point(207, 275);
            this.IPadd_dec.Name = "IPadd_dec";
            this.IPadd_dec.Size = new System.Drawing.Size(0, 17);
            this.IPadd_dec.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Subnet mask:";
            // 
            // SM_dec
            // 
            this.SM_dec.AutoSize = true;
            this.SM_dec.Location = new System.Drawing.Point(207, 308);
            this.SM_dec.Name = "SM_dec";
            this.SM_dec.Size = new System.Drawing.Size(0, 17);
            this.SM_dec.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 32);
            this.button2.TabIndex = 31;
            this.button2.Text = "Main menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IP_binTB
            // 
            this.IP_binTB.BackColor = System.Drawing.SystemColors.Control;
            this.IP_binTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IP_binTB.Location = new System.Drawing.Point(342, 275);
            this.IP_binTB.Name = "IP_binTB";
            this.IP_binTB.ReadOnly = true;
            this.IP_binTB.Size = new System.Drawing.Size(307, 17);
            this.IP_binTB.TabIndex = 32;
            this.IP_binTB.Text = "";
            // 
            // SM_binTB
            // 
            this.SM_binTB.BackColor = System.Drawing.SystemColors.Control;
            this.SM_binTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SM_binTB.Location = new System.Drawing.Point(342, 308);
            this.SM_binTB.Name = "SM_binTB";
            this.SM_binTB.ReadOnly = true;
            this.SM_binTB.Size = new System.Drawing.Size(307, 17);
            this.SM_binTB.TabIndex = 33;
            this.SM_binTB.Text = "";
            // 
            // NetID_binTB
            // 
            this.NetID_binTB.BackColor = System.Drawing.SystemColors.Control;
            this.NetID_binTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NetID_binTB.Location = new System.Drawing.Point(342, 341);
            this.NetID_binTB.Name = "NetID_binTB";
            this.NetID_binTB.ReadOnly = true;
            this.NetID_binTB.Size = new System.Drawing.Size(307, 17);
            this.NetID_binTB.TabIndex = 34;
            this.NetID_binTB.Text = "";
            // 
            // FirstUsable_binTB
            // 
            this.FirstUsable_binTB.BackColor = System.Drawing.SystemColors.Control;
            this.FirstUsable_binTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstUsable_binTB.Location = new System.Drawing.Point(342, 374);
            this.FirstUsable_binTB.Name = "FirstUsable_binTB";
            this.FirstUsable_binTB.ReadOnly = true;
            this.FirstUsable_binTB.Size = new System.Drawing.Size(307, 17);
            this.FirstUsable_binTB.TabIndex = 35;
            this.FirstUsable_binTB.Text = "";
            // 
            // LastUsable_binTB
            // 
            this.LastUsable_binTB.BackColor = System.Drawing.SystemColors.Control;
            this.LastUsable_binTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastUsable_binTB.Location = new System.Drawing.Point(342, 407);
            this.LastUsable_binTB.Name = "LastUsable_binTB";
            this.LastUsable_binTB.ReadOnly = true;
            this.LastUsable_binTB.Size = new System.Drawing.Size(307, 17);
            this.LastUsable_binTB.TabIndex = 36;
            this.LastUsable_binTB.Text = "";
            // 
            // Broadcast_binTB
            // 
            this.Broadcast_binTB.BackColor = System.Drawing.SystemColors.Control;
            this.Broadcast_binTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Broadcast_binTB.Location = new System.Drawing.Point(342, 440);
            this.Broadcast_binTB.Name = "Broadcast_binTB";
            this.Broadcast_binTB.ReadOnly = true;
            this.Broadcast_binTB.Size = new System.Drawing.Size(307, 17);
            this.Broadcast_binTB.TabIndex = 37;
            this.Broadcast_binTB.Text = "";
            // 
            // NetCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(626, 540);
            this.Controls.Add(this.Broadcast_binTB);
            this.Controls.Add(this.LastUsable_binTB);
            this.Controls.Add(this.FirstUsable_binTB);
            this.Controls.Add(this.NetID_binTB);
            this.Controls.Add(this.SM_binTB);
            this.Controls.Add(this.IP_binTB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SM_dec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.IPadd_dec);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Broadcast_dec);
            this.Controls.Add(this.LastUsable_dec);
            this.Controls.Add(this.FirstUsable_dec);
            this.Controls.Add(this.NetID_dec);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSM);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NetCalc";
            this.Text = "Sharpnet - Network Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbSM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label NetID_dec;
        private System.Windows.Forms.Label FirstUsable_dec;
        private System.Windows.Forms.Label LastUsable_dec;
        private System.Windows.Forms.Label Broadcast_dec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label IPadd_dec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label SM_dec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox IP_binTB;
        private System.Windows.Forms.RichTextBox SM_binTB;
        private System.Windows.Forms.RichTextBox NetID_binTB;
        private System.Windows.Forms.RichTextBox FirstUsable_binTB;
        private System.Windows.Forms.RichTextBox LastUsable_binTB;
        private System.Windows.Forms.RichTextBox Broadcast_binTB;
    }
}