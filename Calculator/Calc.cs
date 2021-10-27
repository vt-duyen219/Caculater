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
    public partial class Calc : Form
    {
        int sign_Indicator = 0; 
        double variable1;
        double variable2;
        int add = 0;
        int sub = 0;
        int mul = 0;
        int div = 0;
        int mod = 0;
        Boolean fl = false;
        String s, x;
        string userName; 
        public Calc()
        {
            InitializeComponent();
        }
        
        public Calc(string str) : this()
        {
            userName = str;
            lbUser.Text = userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(1);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(1);
                sign_Indicator = 0;
            }
            fl = true;
        }
        //2
        private void button2_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(2);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(2);
                sign_Indicator = 0;
            }
            fl = true;
        }
        //3
        private void button3_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0) //
            {
                txtInput.Text = txtInput.Text + Convert.ToString(3);
            }
            else if (sign_Indicator == 1) //
            {
                txtInput.Text = Convert.ToString(3);
                sign_Indicator = 0;
            }
            fl = true;
        }
        //4
        private void button13_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(4);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(4);
                sign_Indicator = 0;
            }
            fl = true;
        }
        //5
        private void button12_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(5);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(5);
                sign_Indicator = 0;
            }
            fl = true;
        }
        //6
        private void button11_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(6);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(6);
                sign_Indicator = 0;
            }
            fl = true;
        }
        //7
        private void button9_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(7);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(7);
                sign_Indicator = 0;
            }
            fl = true;
        }
        ///8
        private void button8_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(8);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(8);
                sign_Indicator = 0;
            }
            fl = true;
        }
        //9
        private void button7_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(9);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(9);
                sign_Indicator = 0;
            }
            fl = true;
        }
        //0
        private void button5_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtInput.Text = txtInput.Text + Convert.ToString(0);
            }
            else if (sign_Indicator == 1)
            {
                txtInput.Text = Convert.ToString(0);
                sign_Indicator = 0;
            }
            fl = true;
        }


        private void reset_SignBits()
        {
            //nếu = 0
            //nếu = 1 
            add = 0;
            sub = 0;
            mul = 0;
            div = 0;
            mod = 0;
            fl = false; 
        }
        //cong
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                add = 1;
                sign_Indicator = 1;
            }
        }
        //CLear
        private void button20_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            sign_Indicator = 0;
            variable1 = 0;
            variable2 = 0;
            reset_SignBits();
        }
        //tru
        private void button10_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                variable2 = Convert.ToDouble(txtInput.Text);
                calculate();
                reset_SignBits();
                sub = 1;
                sign_Indicator = 1;
            }
        }
        //nhan
        private void button19_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                mul = 1;
                sign_Indicator = 1;
            }
        }
        //chia
        private void button6_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                div = 1;
                sign_Indicator = 1;
            }
        }
        //Bang
        private void button18_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
            }
            sign_Indicator = 1;
        }
        //dot
        private void button21_Click(object sender, EventArgs e)
        {
            int i = 0;
            char chr = '\0';
            int decimal_Indicator = 0;
            int l = txtInput.Text.Length - 1;
            if (sign_Indicator != 1)
            {
                for (i = 0; i <= l; i++)
                {
                    chr = txtInput.Text[i];
                    if (chr == '.')
                    {
                        decimal_Indicator = 1;
                    }
                }

                if (decimal_Indicator != 1)
                {
                    txtInput.Text = txtInput.Text + Convert.ToString(".");
                }
            }
        }
        //sqrt
        private void button15_Click(object sender, EventArgs e)
        {
            double s, l;
            l = Convert.ToDouble(txtInput.Text);
            s = Math.Sqrt(l);
            txtInput.Text = Convert.ToString(s);
        }
        //1/x
        private void button16_Click(object sender, EventArgs e)
        {
            txtInput.Text = (1 / Convert.ToDouble(txtInput.Text)).ToString();
        }
        //Log     
        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double l;
                    l = Math.Log(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //e^x
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double l;
                    l = Math.Exp(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //chạy chuoi
        private void Form6_Load(object sender, EventArgs e)
        {
            lbName.Text = " 1754050020 - Vũ Thùy Duyên";
        }
        //Sin
        //txtbox phải có gtri trc khi nhấn Sin.
        //gọi hàm Math.Sin truyền vào txtbox
        //gán cờ về 1 - đây là lần đầu tiên đc nhấn, ko bị nối chuỗ- sẽ thay thế
        private void btnSin_Click(object sender, EventArgs e)
        {
            //xulyngoaile
            try
            {
                if (txtInput.Text.Length != 0) 
                {
                    double l = Math.Sin(Convert.ToDouble(txtInput.Text)); //tinh toan
                    txtInput.Text = Convert.ToString(l); //show ra man hinh
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Cos
        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double l = Math.Cos(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Tan
        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text.Length != 0)
                {
                    double l = Math.Tan(Convert.ToDouble(txtInput.Text));
                    txtInput.Text = Convert.ToString(l);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calculate()
        {
            if (txtInput.Text != ".")
            {
                variable2 = Convert.ToDouble(txtInput.Text);
                if (fl == false)
                {
                    variable1 = variable2;
                }
                else if (add == 1)
                {
                    variable1 = variable1 + variable2;
                }
                else if (sub == 1)
                {
                    variable1 = variable1 - variable2;
                }
                else if (mul == 1)
                {
                    variable1 = variable1 * variable2;
                }
                else if (div == 1)
                {
                    variable1 = variable1 / variable2;
                }
                else if (mod == 1)
                {

                    variable2 = Convert.ToInt32(txtInput.Text);
                    variable1 = Convert.ToInt32(variable1 % variable2);
                }
                else
                {
                    variable1 = variable2;
                }
                txtInput.Text = Convert.ToString(variable1);

            }
        }
        //Mod
        private void button25_Click(object sender, EventArgs e)
        {
            //nếu txtbox có giá trị
            //caculator 
            if (txtInput.Text.Length != 0)
            {
                calculate(); //gọi hàm tính toán
                reset_SignBits();
                mod = 1;
                sign_Indicator = 1;
            }
        }
        //Pi
        private void button26_Click(object sender, EventArgs e)
        {
            txtInput.Text = Math.PI.ToString();
            sign_Indicator = 1;
        }
        //x!
        private void button17_Click_1(object sender, EventArgs e)
        {
            try
            {
                long fact = 1;
                for (int i = 1; i <= Convert.ToInt32(txtInput.Text); i++)
                {
                    fact = fact * i;
                }
                txtInput.Text = Convert.ToString(fact);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

     
        //Backspace
        private void button27_Click(object sender, EventArgs e)
        {
            s = txtInput.Text;
            int l = s.Length;
            for (int i = 0; i < l - 1; i++)
            {
                x += s[i];
            }
            txtInput.Text = x;
            x = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login lg = new Login();
            lg.Show();
        }

        private void ScCalc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Close form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbName.Text = lbName.Text.Substring(1) + lbName.Text.Substring(0, 1);
        }
        
        private void ColorChange_Click(object sender, EventArgs e)
        {
            if (MauColor.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = MauColor.Color;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            Time time = new Time(lbUser.Text);
            this.Dispose(); 
            time.ShowDialog();
            
        }       
    }
}