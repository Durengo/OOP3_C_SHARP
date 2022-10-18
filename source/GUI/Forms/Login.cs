﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            if(SessionManager.Instance.Login(usernameBox.Text, passwordBox.Text))
            {
                checkBox1.Checked = true;
                usernameBox.Text = "";
                passwordBox.Text = "";
                if(SessionManager.Instance.currentUser.Type == User.AccountType.ADMINISTRATOR)
                {
                    SessionManager.Instance.openForms[1].Hide();
                    SessionManager.Instance.openForms[0].Show();
                }
                else
                {
                    SessionManager.Instance.openForms[1].Hide();
                    SessionManager.Instance.openForms[3].Show();
                }
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[1].Hide();
            SessionManager.Instance.openForms[0].Show();
        }
        private void Login_Closing(object sender, EventArgs e)
        {
            for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
            {
                SessionManager.Instance.openForms[SessionManager.Instance.openForms.Count - 1 - i].Close();
            }
        }
    }
}