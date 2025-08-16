using BIKE_STROE_POS.Model;
using BIKE_STROE_POS.Service;
using BIKE_STROE_POS.Share;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIKE_STROE_POS.UserInterface
{
    public partial class FORM_LOGIN: Form
    {
        public FORM_LOGIN()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove the border
            this.StartPosition = FormStartPosition.CenterScreen; // Center the form on the screen
           
        }

        private void FORM_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when cancel button is clicked

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtboxUsername.Text == "")
            {
                Msg.Warning("Require username");
            }
            if (txtPassword.Text.Trim() == "")
            {
                Msg.Warning("Require password");
                return;
            }
            User user = new User();
            user.username = txtboxUsername.Text.Trim();
            user.password = txtPassword.Text.Trim();
            if (UserService.Login(user))
            {
                Msg.Success("Login successful");
                this.Hide(); // Hide the login form
                FORM_MAIN mainForm = new FORM_MAIN(); // Create an instance of the main form
                mainForm.Show(); // Show the main form
            }
            else
            {
                Msg.Error("Invalid username or password");
            }
        }
    }
}
