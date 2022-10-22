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
    using OOP3.source.Core;

    public partial class RemoveUsers : Form
    {
        private int whichUser = -1;

        public RemoveUsers()
        {
            InitializeComponent();
            removeButton1.BackColor = Color.DarkGray;
        }

        public void UpdateUserList()
        {
            userList.Items.Clear();
            for (int i = 0; i < SessionManager.Instance.users.Count; i++)
            {
                // var item = SessionManager.Instance.users[i];
                // var count = i + 1;
                // string text = count + ". " + item.Username + " " + item.Name + " " + item.Surname + " " + item.BirthDate;
                // userList.Items.Add(text);
                userList.Items.Add((i + 1) + " " + SessionManager.Instance.users[i]);
            }
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            whichUser = userList.SelectedIndex;
            removeButton1.BackColor = Color.Red;
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[5].Hide();
            SessionManager.Instance.openForms[4].Show();
        }

        private void removeButton1_Click(object sender, EventArgs e)
        {
            if (whichUser == -1)
            {
                return;
            }
            else
            {
                var user = SessionManager.Instance.users[whichUser];
                if (user.UserAccountType == User.AccountType.ADMINISTRATOR)
                {
                    PopUpError popup = new PopUpError("Cannot remove any administrator users.");
                    DialogResult dialogresult = popup.ShowDialog();
                    popup.Dispose();
                    return;
                }
                else
                {
                    SessionManager.Instance.users.RemoveAt(whichUser);
                    removeButton1.BackColor = Color.DarkGray;
                    whichUser = -1;
                    UpdateUserList();
                }
            }
        }
    }
}
