using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem
{
    public partial class Login : Form
    {
        public SignUp sign { set; get; }
        public UserData user { get; set; }
        public Login(SignUp sgn,UserData _user)
        {
            sign = sgn;
            user = _user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
           sign.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text==user.Name && txtPassword.Text==user.Password)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("false");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
