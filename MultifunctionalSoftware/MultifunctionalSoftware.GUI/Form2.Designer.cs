
namespace MultifunctionalSoftware.GUI
{
    partial class Form2
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
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.tbx_firstname = new System.Windows.Forms.TextBox();
            this.tbx_userName = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.lbl_dateOfBirth = new System.Windows.Forms.Label();
            this.tbx_dateofBirth = new System.Windows.Forms.TextBox();
            this.tbx_lastname = new System.Windows.Forms.TextBox();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.lbl_dateofbirthHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Location = new System.Drawing.Point(304, 131);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(52, 13);
            this.lbl_firstname.TabIndex = 15;
            this.lbl_firstname.Text = "Firstname";
            // 
            // tbx_firstname
            // 
            this.tbx_firstname.Location = new System.Drawing.Point(378, 128);
            this.tbx_firstname.Name = "tbx_firstname";
            this.tbx_firstname.Size = new System.Drawing.Size(103, 20);
            this.tbx_firstname.TabIndex = 14;
            // 
            // tbx_userName
            // 
            this.tbx_userName.Location = new System.Drawing.Point(378, 94);
            this.tbx_userName.Name = "tbx_userName";
            this.tbx_userName.Size = new System.Drawing.Size(103, 20);
            this.tbx_userName.TabIndex = 13;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(304, 97);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 12;
            this.lbl_username.Text = "Username";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.ForeColor = System.Drawing.Color.Black;
            this.btn_SignUp.Location = new System.Drawing.Point(365, 284);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(75, 23);
            this.btn_SignUp.TabIndex = 11;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // lbl_dateOfBirth
            // 
            this.lbl_dateOfBirth.AutoSize = true;
            this.lbl_dateOfBirth.Location = new System.Drawing.Point(304, 199);
            this.lbl_dateOfBirth.Name = "lbl_dateOfBirth";
            this.lbl_dateOfBirth.Size = new System.Drawing.Size(65, 13);
            this.lbl_dateOfBirth.TabIndex = 19;
            this.lbl_dateOfBirth.Text = "Date of birth";
            // 
            // tbx_dateofBirth
            // 
            this.tbx_dateofBirth.Location = new System.Drawing.Point(378, 196);
            this.tbx_dateofBirth.Name = "tbx_dateofBirth";
            this.tbx_dateofBirth.Size = new System.Drawing.Size(103, 20);
            this.tbx_dateofBirth.TabIndex = 18;
            this.tbx_dateofBirth.Click += new System.EventHandler(this.tbx_dateofBirth_Click);
            // 
            // tbx_lastname
            // 
            this.tbx_lastname.Location = new System.Drawing.Point(378, 162);
            this.tbx_lastname.Name = "tbx_lastname";
            this.tbx_lastname.Size = new System.Drawing.Size(103, 20);
            this.tbx_lastname.TabIndex = 17;
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(304, 165);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(53, 13);
            this.lbl_lastname.TabIndex = 16;
            this.lbl_lastname.Text = "Lastname";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(304, 233);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 21;
            this.lbl_password.Text = "Password";
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(378, 230);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(103, 20);
            this.tbx_password.TabIndex = 20;
            // 
            // lbl_dateofbirthHint
            // 
            this.lbl_dateofbirthHint.AutoSize = true;
            this.lbl_dateofbirthHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateofbirthHint.Location = new System.Drawing.Point(487, 199);
            this.lbl_dateofbirthHint.Name = "lbl_dateofbirthHint";
            this.lbl_dateofbirthHint.Size = new System.Drawing.Size(115, 13);
            this.lbl_dateofbirthHint.TabIndex = 22;
            this.lbl_dateofbirthHint.Text = "format like: 03.05.1989";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_dateofbirthHint);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.lbl_dateOfBirth);
            this.Controls.Add(this.tbx_dateofBirth);
            this.Controls.Add(this.tbx_lastname);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.tbx_firstname);
            this.Controls.Add(this.tbx_userName);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_SignUp);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.TextBox tbx_firstname;
        private System.Windows.Forms.TextBox tbx_userName;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Label lbl_dateOfBirth;
        private System.Windows.Forms.TextBox tbx_dateofBirth;
        private System.Windows.Forms.TextBox tbx_lastname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label lbl_dateofbirthHint;
    }
}