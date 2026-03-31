using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMarksSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool loggedIn = false;
            User user = null;

            // Show login form until successful login or exit
            while (!loggedIn)
            {
                using (LoginForm loginForm = new LoginForm())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        user = loginForm.AuthenticatedUser;
                        loggedIn = true;
                    }
                    else
                    {
                        return; // Exit application
                    }
                }

                if (loggedIn)
                {
                    using (MainForm mainForm = new MainForm(user))
                    {
                        if (mainForm.ShowDialog() == DialogResult.Retry)
                        {
                            // User clicked logout - show login again
                            loggedIn = false;
                        }
                        else
                        {
                            // Exit application
                            return;
                        }
                    }
                }
            }
        }
    }
}
