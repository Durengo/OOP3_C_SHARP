namespace OOP3.source.GUI.Forms
{
    using OOP3.source.CLI;
    using OOP3.source.Core;
    using OOP3.source.Log;
    using OOP3.source.Input;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            datePicker.MinDate = DateTime.Now.AddYears(-110);
            datePicker.MaxDate = DateTime.Now;
            //datePicker.TodayDate = DateTime.Now.AddYears(-14);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DEBUG
            checkInstance.Checked = SessionManager.Instance.isInstance();
            //

            bool[] conditions = new bool[5];

            if (!InputValidation.NameValidation(nameBox.Text)) conditions[0] = true;
            if (!InputValidation.NameValidation(surnameBox.Text)) conditions[1] = true;
            //DATE
            var year = int.Parse(datePicker.SelectionRange.Start.ToString("yyyy"));
            var month = int.Parse(datePicker.SelectionRange.Start.ToString("MM"));
            var day = int.Parse(datePicker.SelectionRange.Start.ToString("dd"));
            var selectedDate = new DateTime(year, month, day);
            var ageDay = DateTime.Now.Day - selectedDate.Day;
            var ageMonth = DateTime.Now.Month - selectedDate.Month;
            var ageYear = DateTime.Now.Year - selectedDate.Year;
            if (ageDay <= 0) ageMonth--;
            if (ageMonth <= 0) ageYear--;
            if(ageYear < 14) conditions[2] = true;
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
                nameDisplay.Text = nameBox.Text;
                surnameDisplay.Text = surnameBox.Text;
                dateDisplay.Text = datePicker.SelectionRange.Start.ToString("yyyy-MM-dd");
                usernameDisplay.Text = usernameBox.Text;
                passwordDisplay.Text = passwordBox.Text;
            }

        }

        private void nameDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName;
            }
        }
    }
}
