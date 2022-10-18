using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3.source.GUI.Forms
{
    using source.Core;

    public partial class PostLogin : Form
    {
        public PostLogin()
        {
            InitializeComponent();
        }

        private void logoutButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[3].Hide();
            SessionManager.Instance.Logout();
            SessionManager.Instance.openForms[0].Show();
        }

        private void PostLogin_Closing(object sender, EventArgs e)
        {
            for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
            {
                SessionManager.Instance.openForms[SessionManager.Instance.openForms.Count - 1 - i].Close();
            }
        }
    }
}
