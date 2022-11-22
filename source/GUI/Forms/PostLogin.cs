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
    using source.Core;

    public partial class PostLogin : Form
    {
        public PostLogin()
        {
            InitializeComponent();
        }

        public void UpdateUserText()
        {
            nameDisplay.Text = SessionManager.Instance.currentUser.Name;
            surnameDisplay.Text = SessionManager.Instance.currentUser.Surname;
            birthdayDisplay.Text = SessionManager.Instance.currentUser.BirthDate.ToString();
            usernameDisplay.Text = SessionManager.Instance.currentUser.Username;
            passwordDisplay.Text = SessionManager.Instance.currentUser.Password;
            avatarBox.Image = SessionManager.Instance.currentUser.Avatar;
        }

        private void logoutButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[3].Hide();
            SessionManager.Instance.Logout();
            nameDisplay.Text = "";
            surnameDisplay.Text = "";
            birthdayDisplay.Text = "";
            usernameDisplay.Text = "";
            passwordDisplay.Text = "";
            avatarBox.Image = null;
            passwordShow.Checked = false;
            passwordDisplay.UseSystemPasswordChar = true;
            SessionManager.Instance.openForms[0].Show();
        }

        private void PostLogin_Closing(object sender, EventArgs e)
        {
            for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
            {
                SessionManager.Instance.openForms[
                    SessionManager.Instance.openForms.Count - 1 - i
                ].Close();
            }
        }

        private void passwordShow_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordShow.CheckState == CheckState.Unchecked)
            {
                passwordDisplay.UseSystemPasswordChar = true;
            }
            else
            {
                passwordDisplay.UseSystemPasswordChar = false;
            }
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            ChangePassword popup = new ChangePassword();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "image files |*.png;*.jpg;*.jpeg;*.bmp";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName;
                SessionManager.Instance.currentUser.Avatar = new Bitmap(selectedFile);
                UpdateUserText();
            }
        }
    }
}
