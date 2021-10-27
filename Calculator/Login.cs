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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            string user = "VuThuyDuyen";
            string pass = "1";
            if (user.Equals(txtUser.Text) && pass.Equals(txtPassWord.Text))
            {
               
                this.Hide();
                Calc cal = new Calc(txtUser.Text);
                cal.Show();
            }
            else if (String.IsNullOrEmpty(txtUser.Text.Trim()))
            {
                MessageBox.Show("Please enter Username!     ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();

            }
            else if (String.IsNullOrEmpty(txtPassWord.Text.Trim()))
            {
                MessageBox.Show("Please enter Password!     ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassWord.Focus();

            }
            else
            {
                MessageBox.Show("You entered the wrong password or username, please re-enter!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUser.Clear();
                txtPassWord.Clear();
                txtUser.Focus();
            }
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }    
}
