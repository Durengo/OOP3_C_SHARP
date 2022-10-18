namespace OOP3.source.GUI.Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.MonthCalendar();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.Crate = new System.Windows.Forms.Button();
            this.surnameDisplay = new System.Windows.Forms.TextBox();
            this.nameDisplay = new System.Windows.Forms.TextBox();
            this.checkInstance = new System.Windows.Forms.CheckBox();
            this.dateDisplay = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordDisplay = new System.Windows.Forms.TextBox();
            this.usernameDisplay = new System.Windows.Forms.TextBox();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.imageButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameBox
            // 
            this.surnameBox.AccessibleName = "";
            this.surnameBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameBox.Location = new System.Drawing.Point(152, 58);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(134, 35);
            this.surnameBox.TabIndex = 3;
            this.surnameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // datePicker
            // 
            this.datePicker.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.datePicker.Location = new System.Drawing.Point(298, 17);
            this.datePicker.MaxSelectionCount = 1;
            this.datePicker.Name = "datePicker";
            this.datePicker.TabIndex = 0;
            this.datePicker.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // nameBox
            // 
            this.nameBox.AccessibleName = "";
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(152, 17);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(134, 35);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(12, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(134, 32);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "First Name:";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameLabel.Location = new System.Drawing.Point(15, 59);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(131, 32);
            this.surnameLabel.TabIndex = 4;
            this.surnameLabel.Text = "Last Name:";
            this.surnameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Crate
            // 
            this.Crate.Location = new System.Drawing.Point(182, 358);
            this.Crate.Name = "Crate";
            this.Crate.Size = new System.Drawing.Size(75, 23);
            this.Crate.TabIndex = 5;
            this.Crate.Text = "Create";
            this.Crate.UseVisualStyleBackColor = true;
            this.Crate.Click += new System.EventHandler(this.button1_Click);
            // 
            // surnameDisplay
            // 
            this.surnameDisplay.AccessibleName = "";
            this.surnameDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameDisplay.Location = new System.Drawing.Point(152, 428);
            this.surnameDisplay.Name = "surnameDisplay";
            this.surnameDisplay.ReadOnly = true;
            this.surnameDisplay.Size = new System.Drawing.Size(134, 35);
            this.surnameDisplay.TabIndex = 7;
            // 
            // nameDisplay
            // 
            this.nameDisplay.AccessibleName = "";
            this.nameDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameDisplay.Location = new System.Drawing.Point(152, 387);
            this.nameDisplay.Name = "nameDisplay";
            this.nameDisplay.ReadOnly = true;
            this.nameDisplay.Size = new System.Drawing.Size(134, 35);
            this.nameDisplay.TabIndex = 6;
            this.nameDisplay.TextChanged += new System.EventHandler(this.nameDisplay_TextChanged);
            // 
            // checkInstance
            // 
            this.checkInstance.AutoSize = true;
            this.checkInstance.Location = new System.Drawing.Point(315, 202);
            this.checkInstance.Name = "checkInstance";
            this.checkInstance.Size = new System.Drawing.Size(70, 19);
            this.checkInstance.TabIndex = 8;
            this.checkInstance.Text = "instnace";
            this.checkInstance.UseVisualStyleBackColor = true;
            // 
            // dateDisplay
            // 
            this.dateDisplay.AccessibleName = "";
            this.dateDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateDisplay.Location = new System.Drawing.Point(12, 387);
            this.dateDisplay.Name = "dateDisplay";
            this.dateDisplay.ReadOnly = true;
            this.dateDisplay.Size = new System.Drawing.Size(134, 35);
            this.dateDisplay.TabIndex = 9;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(30, 141);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(116, 32);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // passwordBox
            // 
            this.passwordBox.AccessibleName = "";
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordBox.Location = new System.Drawing.Point(152, 140);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(134, 35);
            this.passwordBox.TabIndex = 12;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(20, 100);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(126, 32);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // usernameBox
            // 
            this.usernameBox.AccessibleName = "";
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameBox.Location = new System.Drawing.Point(152, 99);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(134, 35);
            this.usernameBox.TabIndex = 10;
            this.usernameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // passwordDisplay
            // 
            this.passwordDisplay.AccessibleName = "";
            this.passwordDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordDisplay.Location = new System.Drawing.Point(292, 428);
            this.passwordDisplay.Name = "passwordDisplay";
            this.passwordDisplay.ReadOnly = true;
            this.passwordDisplay.Size = new System.Drawing.Size(134, 35);
            this.passwordDisplay.TabIndex = 15;
            this.passwordDisplay.UseSystemPasswordChar = true;
            // 
            // usernameDisplay
            // 
            this.usernameDisplay.AccessibleName = "";
            this.usernameDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameDisplay.Location = new System.Drawing.Point(292, 387);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.ReadOnly = true;
            this.usernameDisplay.Size = new System.Drawing.Size(134, 35);
            this.usernameDisplay.TabIndex = 14;
            // 
            // avatarBox
            // 
            this.avatarBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.avatarBox.Location = new System.Drawing.Point(152, 181);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(128, 128);
            this.avatarBox.TabIndex = 16;
            this.avatarBox.TabStop = false;
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(182, 315);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(75, 23);
            this.imageButton.TabIndex = 17;
            this.imageButton.Text = "Upload";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.avatarBox);
            this.Controls.Add(this.passwordDisplay);
            this.Controls.Add(this.usernameDisplay);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.dateDisplay);
            this.Controls.Add(this.checkInstance);
            this.Controls.Add(this.surnameDisplay);
            this.Controls.Add(this.nameDisplay);
            this.Controls.Add(this.Crate);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.datePicker);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar datePicker;
        private TextBox nameBox;
        private Label nameLabel;
        private Label surnameLabel;
        private TextBox surnameBox;
        private Button Crate;
        private TextBox surnameDisplay;
        private TextBox nameDisplay;
        private CheckBox checkInstance;
        private TextBox dateDisplay;
        private Label passwordLabel;
        private TextBox passwordBox;
        private Label usernameLabel;
        private TextBox usernameBox;
        private TextBox passwordDisplay;
        private TextBox usernameDisplay;
        private PictureBox avatarBox;
        private Button imageButton;
        private OpenFileDialog openFileDialog1;
    }
}