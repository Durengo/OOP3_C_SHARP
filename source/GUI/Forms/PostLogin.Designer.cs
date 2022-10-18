namespace OOP3.source.GUI.Forms
{
    partial class PostLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editButton1 = new System.Windows.Forms.Button();
            this.logoutButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editButton1
            // 
            this.editButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editButton1.Location = new System.Drawing.Point(400, 500);
            this.editButton1.Name = "editButton1";
            this.editButton1.Size = new System.Drawing.Size(384, 61);
            this.editButton1.TabIndex = 5;
            this.editButton1.Text = "Edit Profile";
            this.editButton1.UseVisualStyleBackColor = true;
            // 
            // logoutButton1
            // 
            this.logoutButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoutButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutButton1.Location = new System.Drawing.Point(0, 500);
            this.logoutButton1.Name = "logoutButton1";
            this.logoutButton1.Size = new System.Drawing.Size(400, 61);
            this.logoutButton1.TabIndex = 4;
            this.logoutButton1.Text = "Log Out";
            this.logoutButton1.UseVisualStyleBackColor = true;
            this.logoutButton1.Click += new System.EventHandler(this.logoutButton1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 500);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PostLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.editButton1);
            this.Controls.Add(this.logoutButton1);
            this.Controls.Add(this.label1);
            this.Name = "PostLogin";
            this.Text = "PostLogin";
            this.Disposed += new System.EventHandler(this.PostLogin_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button editButton1;
        private Button logoutButton1;
        private Label label1;
    }
}