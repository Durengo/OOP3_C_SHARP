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
    using OOP3.source.Input;
    using OOP3.source.User;
    public partial class Register : Form
    {
        private string ImageFullPath = "";
        public Register()
        {
            InitializeComponent();
            nameErr1.Hide();
            surnameErr1.Hide();
            dateErr1.Hide();
            datePicker.MaxDate = DateTime.Today;
            datePicker.MinDate = DateTime.Today.AddYears(-100);
        }

        private void nameDisplay_TextChanged(object sender, EventArgs e) { }

        private void registerButton1_Click(object sender, EventArgs e)
        {
            //DEBUG
            //checkInstance.Checked = SessionManager.Instance.isInstance();
            //

            bool[] conditions = new bool[5];

            if (!InputValidation.NameValidation(nameBox.Text))
            {
                conditions[0] = true;
                nameErr1.Show();
            }
            if (!InputValidation.NameValidation(surnameBox.Text))
            {
                conditions[1] = true;
                surnameErr1.Show();
            }
            //DATE
            var year = int.Parse(datePicker.SelectionRange.Start.ToString("yyyy"));
            var month = int.Parse(datePicker.SelectionRange.Start.ToString("MM"));
            var day = int.Parse(datePicker.SelectionRange.Start.ToString("dd"));
            var selectedDate = new DateTime(year, month, day);
            var ageDay = DateTime.Now.Day - selectedDate.Day;
            var ageMonth = DateTime.Now.Month - selectedDate.Month;
            var ageYear = DateTime.Now.Year - selectedDate.Year;
            if (ageDay <= 0)
                ageMonth--;
            if (ageMonth <= 0)
                ageYear--;
            if (ageYear < 14)
                conditions[2] = true;
                dateErr1.Show();
            //DATE

            if (conditions[0] || conditions[1] || conditions[2])
            {
                nameDisplay.Text = "";
                surnameDisplay.Text = "";
                dateDisplay.Text = "";
                usernameDisplay.Text = "";
                passwordDisplay.Text = "";
            }
            else
            {
                if(ImageFullPath != "")
                {
                    if(!SessionManager.Instance.CreateUser(usernameBox.Text, passwordBox.Text, ImageFullPath, nameBox.Text, surnameBox.Text, new DateOnly(int.Parse(datePicker.SelectionRange.Start.ToString("yyyy")), int.Parse(datePicker.SelectionRange.Start.ToString("MM")), int.Parse(datePicker.SelectionRange.Start.ToString("dd")))))
                    {
                        usernameErr.Show();
                    }
                    else
                    {
                        nameErr1.Hide();
                        surnameErr1.Hide();
                        dateErr1.Hide();
                        usernameErr.Hide();
                        nameDisplay.Text = nameBox.Text;
                        surnameDisplay.Text = surnameBox.Text;
                        dateDisplay.Text = datePicker.SelectionRange.Start.ToString("yyyy-MM-dd");
                        usernameDisplay.Text = usernameBox.Text;
                        passwordDisplay.Text = passwordBox.Text;
                    }
                }
                else
                {
                    if(!SessionManager.Instance.CreateUser(usernameBox.Text, passwordBox.Text, nameBox.Text, surnameBox.Text, new DateOnly(int.Parse(datePicker.SelectionRange.Start.ToString("yyyy")), int.Parse(datePicker.SelectionRange.Start.ToString("MM")), int.Parse(datePicker.SelectionRange.Start.ToString("dd")))))
                    {
                        usernameErr.Show();
                    }
                    else
                    {
                        nameErr1.Hide();
                        surnameErr1.Hide();
                        dateErr1.Hide();
                        usernameErr.Hide();
                        nameDisplay.Text = nameBox.Text;
                        surnameDisplay.Text = surnameBox.Text;
                        dateDisplay.Text = datePicker.SelectionRange.Start.ToString("yyyy-MM-dd");
                        usernameDisplay.Text = usernameBox.Text;
                        passwordDisplay.Text = passwordBox.Text;
                    }
                }
                
                
            }
            userCount.Text = SessionManager.Instance.users.Count.ToString();

        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "image files |*.png;*.jpg;*.jpeg;*.bmp";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName;
                avatarBox.ImageLocation = selectedFile;
                imagePath.Text = selectedFile;
                ImageFullPath = selectedFile;
                //avatarBox.Image = Image.FromFile(selectedFile);
                //avatarBox.Image = System.Drawing.Image.FromFile(selectedFile);\
            }
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.openForms[2].Hide();
            reset_All();
            SessionManager.Instance.openForms[0].Show();
        }

        private void Register_Closing(object sender, EventArgs e)
        {
            for (int i = 0; i < SessionManager.Instance.openForms.Count; i++)
            {
                SessionManager.Instance.openForms[SessionManager.Instance.openForms.Count - 1 - i].Close();
            }
        }

        private void nameErr1_Click(object sender, EventArgs e)
        {
            PopUpError popup = new PopUpError("The name must start with a capital letter, only 1 capital letter, no spaces, no numbers");
            DialogResult dialogresult = popup.ShowDialog();
            // if (dialogresult == DialogResult.OK)
            // {
            //     Console.WriteLine("You clicked OK");
            // }
            // else if (dialogresult == DialogResult.Cancel)
            // {
            //     Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            // }
            popup.Dispose();
        }

        private void surnameErr1_Click(object sender, EventArgs e)
        {
            PopUpError popup = new PopUpError("The name must start with a capital letter, only 1 capital letter, no spaces, no numbers");
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }

        private void dateErr1_Click(object sender, EventArgs e)
        {
            PopUpError popup = new PopUpError("You cannot register if you are not at least 14 years old.");
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }

        private void reset_All()
        {
            avatarBox.ImageLocation = "";
            nameErr1.Hide();
            surnameErr1.Hide();
            dateErr1.Hide();
            usernameErr.Hide();
            nameDisplay.Text = "";
            surnameDisplay.Text = "";
            dateDisplay.Text = "";
            usernameDisplay.Text = "";
            passwordDisplay.Text = "";
            nameBox.Text = "";
            surnameBox.Text = "";
            usernameBox.Text = "";
            usernameBox.Text = "";
            passwordBox.Text = "";
            datePicker.SetDate(DateTime.Today);
        }
    }
}
