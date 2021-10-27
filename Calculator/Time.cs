using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Time : Form
    {
        
        public Time()
        {
            InitializeComponent();
        }
        
        string userName;
        public Time(string str) : this()
        {
            userName = str;
           
        } 
        private void Time_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            lbUsername.Text = userName;
            lbNameMSSV.Text = "     1754050020 - Vũ Thùy Duyên     ";

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login lg = new Login();
            lg.Show();
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                       
            Calc cal = new Calc(lbUsername.Text);
            this.Dispose();
            cal.ShowDialog();
        }
 

        string[] type = { "hour", "minute", "second" };
        bool flag = false;
        int test = 0;
        String s, x;

        private void bt(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            if (flag)
                lbInput.Text += bt.Text;
            else
            {
                lbInput.Text = bt.Text;
                flag = true;
            }

            lbOutput.Text = convert(float.Parse(lbInput.Text), type[comboBox1.SelectedIndex], type[comboBox2.SelectedIndex]).ToString();
        }

        private void btDot_Click(object sender, EventArgs e)
        {
            int i = 0;
            char chr = '\0';
            int decimal_Indicator = 0;
            int l = lbInput.Text.Length - 1;
            if (test != 1)
            {
                for (i = 0; i <= l; i++)
                {
                    chr = lbInput.Text[i];
                    if (chr == '.')
                    {
                        decimal_Indicator = 1;
                    }
                }

                if (decimal_Indicator != 1)
                {
                    lbInput.Text = lbInput.Text + Convert.ToString(".");
                }
            }
        }

        private float convert(float num, string type1, string type2)
        {
            float result = 0;
            switch (type1)
            {
                case "hour":
                    switch (type2)
                    {
                        case "hour":
                            result = num;
                            break;
                        case "minute":
                            result = num * 60;
                            break;
                        case "second":
                            result = num * 60 * 60;
                            break;
                    }
                    break;
                case "minute":
                    switch (type2)
                    {
                        case "hour":
                            result = num / 60;
                            break;
                        case "minute":
                            result = num;
                            break;
                        case "second":
                            result = num * 60;
                            break;
                    }
                    break;
                case "second":
                    switch (type2)
                    {
                        case "hour":
                            result = num / (60 * 60);
                            break;
                        case "minute":
                            result = num / 60;
                            break;
                        case "second":
                            result = num;
                            break;
                    }
                    break;
            }
            return result;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0) return;
            lbOutput.Text = convert(float.Parse(lbInput.Text), type[comboBox1.SelectedIndex], type[comboBox2.SelectedIndex]).ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0) return;
            lbOutput.Text = convert(float.Parse(lbInput.Text), type[comboBox1.SelectedIndex], type[comboBox2.SelectedIndex]).ToString();
        }

        private void btClr_Click(object sender, EventArgs e)
        {
            test = 0;

            lbInput.Text = lbOutput.Text = "";
            comboBox1.Text = comboBox2.Text = "";

        }

        private void btColorChange_Click(object sender, EventArgs e)
        {
            if (mauform.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = mauform.Color;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbNameMSSV.Text = lbNameMSSV.Text.Substring(1) + lbNameMSSV.Text.Substring(0, 1);
        }

        private void lbNameMSSV_Click(object sender, EventArgs e)
        {

        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            
            s = lbInput.Text;
            int l = s.Length;
            for (int i = 0; i < l - 1; i++)
            {
                x += s[i];
            }
            lbInput.Text = x;
            x = "";
        }
    }
}
