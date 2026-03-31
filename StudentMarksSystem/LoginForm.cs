using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMarksSystem
{
 
        public partial class LoginForm : Form
        {
            public User AuthenticatedUser { get; private set; }

            public LoginForm()
            {
                InitializeComponent();
            }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UserRepository userRepo = new UserRepository();
                User user = userRepo.Authenticate(username, password);

                if (user != null)
                {
                    AuthenticatedUser = user;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
   }

