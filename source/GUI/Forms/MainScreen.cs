using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4.source.GUI.Forms
{
    using OOP4.source.Core;

    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            SessionManager.Instance.openForms.Add(this);
            SessionManager.Instance.openForms.Add(new Login());
            SessionManager.Instance.openForms.Add(new Register());
            SessionManager.Instance.openForms.Add(new PostLogin());
            SessionManager.Instance.openForms.Add(new AdminPostLogin());
            SessionManager.Instance.openForms.Add(new RemoveUsers());
        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[0].Hide();
            SessionManager.Instance.openForms[1].Show();
        }

        private void registerButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[0].Hide();
            SessionManager.Instance.openForms[2].Show();
        }
    }
}
