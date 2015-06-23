namespace StudentInfoSystem.View
{
    partial class RegisterForm
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
            this.gbRegistration = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdPrepodavatel = new System.Windows.Forms.RadioButton();
            this.rdStudent = new System.Windows.Forms.RadioButton();
            this.txtFacuNumber = new System.Windows.Forms.TextBox();
            this.lblFacuNumber = new System.Windows.Forms.Label();
            this.txtConfirmPassWord = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.gbRegistration.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistration
            // 
            this.gbRegistration.Controls.Add(this.btnClose);
            this.gbRegistration.Controls.Add(this.panel1);
            this.gbRegistration.Controls.Add(this.txtFacuNumber);
            this.gbRegistration.Controls.Add(this.lblFacuNumber);
            this.gbRegistration.Controls.Add(this.txtConfirmPassWord);
            this.gbRegistration.Controls.Add(this.labelPassword2);
            this.gbRegistration.Controls.Add(this.btnRegistration);
            this.gbRegistration.Controls.Add(this.txtPassWord);
            this.gbRegistration.Controls.Add(this.txtUserName);
            this.gbRegistration.Controls.Add(this.labelPassword);
            this.gbRegistration.Controls.Add(this.labelUsername);
            this.gbRegistration.Location = new System.Drawing.Point(12, 12);
            this.gbRegistration.Name = "gbRegistration";
            this.gbRegistration.Size = new System.Drawing.Size(337, 227);
            this.gbRegistration.TabIndex = 10;
            this.gbRegistration.TabStop = false;
            this.gbRegistration.Text = "Регистрационна форма";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(163, 186);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Изход";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdPrepodavatel);
            this.panel1.Controls.Add(this.rdStudent);
            this.panel1.Location = new System.Drawing.Point(180, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 98);
            this.panel1.TabIndex = 10;
            // 
            // rdPrepodavatel
            // 
            this.rdPrepodavatel.AutoSize = true;
            this.rdPrepodavatel.Location = new System.Drawing.Point(16, 56);
            this.rdPrepodavatel.Name = "rdPrepodavatel";
            this.rdPrepodavatel.Size = new System.Drawing.Size(98, 17);
            this.rdPrepodavatel.TabIndex = 1;
            this.rdPrepodavatel.TabStop = true;
            this.rdPrepodavatel.Text = "Преподавател";
            this.rdPrepodavatel.UseVisualStyleBackColor = true;
            // 
            // rdStudent
            // 
            this.rdStudent.AutoSize = true;
            this.rdStudent.Location = new System.Drawing.Point(16, 18);
            this.rdStudent.Name = "rdStudent";
            this.rdStudent.Size = new System.Drawing.Size(65, 17);
            this.rdStudent.TabIndex = 0;
            this.rdStudent.TabStop = true;
            this.rdStudent.Text = "Студент";
            this.rdStudent.UseVisualStyleBackColor = true;
            // 
            // txtFacuNumber
            // 
            this.txtFacuNumber.Location = new System.Drawing.Point(7, 154);
            this.txtFacuNumber.Name = "txtFacuNumber";
            this.txtFacuNumber.Size = new System.Drawing.Size(100, 20);
            this.txtFacuNumber.TabIndex = 8;
            // 
            // lblFacuNumber
            // 
            this.lblFacuNumber.AutoSize = true;
            this.lblFacuNumber.Location = new System.Drawing.Point(7, 137);
            this.lblFacuNumber.Name = "lblFacuNumber";
            this.lblFacuNumber.Size = new System.Drawing.Size(82, 13);
            this.lblFacuNumber.TabIndex = 7;
            this.lblFacuNumber.Text = "Faculty number:";
            // 
            // txtConfirmPassWord
            // 
            this.txtConfirmPassWord.Location = new System.Drawing.Point(10, 110);
            this.txtConfirmPassWord.Name = "txtConfirmPassWord";
            this.txtConfirmPassWord.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmPassWord.TabIndex = 6;
            this.txtConfirmPassWord.UseSystemPasswordChar = true;
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Location = new System.Drawing.Point(7, 94);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(85, 13);
            this.labelPassword2.TabIndex = 5;
            this.labelPassword2.Text = "Password again:";
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(35, 187);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(86, 23);
            this.btnRegistration.TabIndex = 4;
            this.btnRegistration.Text = "Регистрация";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(10, 71);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(100, 20);
            this.txtPassWord.TabIndex = 3;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(10, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(4, 55);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(7, 16);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.btnRegistration;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(550, 262);
            this.Controls.Add(this.gbRegistration);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.gbRegistration.ResumeLayout(false);
            this.gbRegistration.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistration;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox txtConfirmPassWord;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.TextBox txtFacuNumber;
        private System.Windows.Forms.Label lblFacuNumber;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdPrepodavatel;
        private System.Windows.Forms.RadioButton rdStudent;

    }
}