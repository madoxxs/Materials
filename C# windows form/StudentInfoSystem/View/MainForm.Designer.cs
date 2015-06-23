namespace StudentInfoSystem.View
{
    partial class MainForm
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miLoginOut = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uverenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlStudenInfo = new System.Windows.Forms.TabControl();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.gbStudentPhoto = new System.Windows.Forms.GroupBox();
            this.pbStudentPhoto = new System.Windows.Forms.PictureBox();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.numCourse = new System.Windows.Forms.NumericUpDown();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtPotok = new System.Windows.Forms.TextBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.comboStudentStatus = new System.Windows.Forms.ComboBox();
            this.comboOKS = new System.Windows.Forms.ComboBox();
            this.txtFacNumber = new System.Windows.Forms.TextBox();
            this.lblFacNumber = new System.Windows.Forms.Label();
            this.lblStudentStatus = new System.Windows.Forms.Label();
            this.lblOKS = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblPotok = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.gbPersonalData = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tabMarks = new System.Windows.Forms.TabPage();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuMain.SuspendLayout();
            this.tabControlStudenInfo.SuspendLayout();
            this.tabStudents.SuspendLayout();
            this.gbStudentPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).BeginInit();
            this.gbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).BeginInit();
            this.gbPersonalData.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miLoginOut,
            this.helpToolStripMenuItem,
            this.openPictureToolStripMenuItem,
            this.uverenieToolStripMenuItem,
            this.infoGroupToolStripMenuItem,
            this.registracionToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(485, 24);
            this.menuMain.TabIndex = 0;
            // 
            // miFile
            // 
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miLoginOut
            // 
            this.miLoginOut.Name = "miLoginOut";
            this.miLoginOut.Size = new System.Drawing.Size(49, 20);
            this.miLoginOut.Text = "Login";
            this.miLoginOut.Click += new System.EventHandler(this.miLoginOut_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // openPictureToolStripMenuItem
            // 
            this.openPictureToolStripMenuItem.Name = "openPictureToolStripMenuItem";
            this.openPictureToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.openPictureToolStripMenuItem.Text = "Open Picture";
            this.openPictureToolStripMenuItem.Click += new System.EventHandler(this.openPictureToolStripMenuItem_Click);
            // 
            // uverenieToolStripMenuItem
            // 
            this.uverenieToolStripMenuItem.Name = "uverenieToolStripMenuItem";
            this.uverenieToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.uverenieToolStripMenuItem.Text = "Uverenie";
            this.uverenieToolStripMenuItem.Click += new System.EventHandler(this.uverenieToolStripMenuItem_Click_1);
            // 
            // infoGroupToolStripMenuItem
            // 
            this.infoGroupToolStripMenuItem.Name = "infoGroupToolStripMenuItem";
            this.infoGroupToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.infoGroupToolStripMenuItem.Text = "Info group";
            this.infoGroupToolStripMenuItem.Click += new System.EventHandler(this.infoGroupToolStripMenuItem_Click);
            // 
            // registracionToolStripMenuItem
            // 
            this.registracionToolStripMenuItem.Name = "registracionToolStripMenuItem";
            this.registracionToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.registracionToolStripMenuItem.Text = "Registracion";
            this.registracionToolStripMenuItem.Click += new System.EventHandler(this.registracionToolStripMenuItem_Click);
            // 
            // tabControlStudenInfo
            // 
            this.tabControlStudenInfo.Controls.Add(this.tabStudents);
            this.tabControlStudenInfo.Controls.Add(this.tabMarks);
            this.tabControlStudenInfo.Location = new System.Drawing.Point(0, 28);
            this.tabControlStudenInfo.Name = "tabControlStudenInfo";
            this.tabControlStudenInfo.SelectedIndex = 0;
            this.tabControlStudenInfo.Size = new System.Drawing.Size(442, 244);
            this.tabControlStudenInfo.TabIndex = 1;
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.btnAddStudent);
            this.tabStudents.Controls.Add(this.gbStudentPhoto);
            this.tabStudents.Controls.Add(this.gbStudentInfo);
            this.tabStudents.Controls.Add(this.gbPersonalData);
            this.tabStudents.Location = new System.Drawing.Point(4, 22);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(434, 218);
            this.tabStudents.TabIndex = 0;
            this.tabStudents.Text = "Студент";
            this.tabStudents.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(323, 34);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 5;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // gbStudentPhoto
            // 
            this.gbStudentPhoto.Controls.Add(this.pbStudentPhoto);
            this.gbStudentPhoto.Location = new System.Drawing.Point(4, 7);
            this.gbStudentPhoto.Name = "gbStudentPhoto";
            this.gbStudentPhoto.Size = new System.Drawing.Size(89, 76);
            this.gbStudentPhoto.TabIndex = 4;
            this.gbStudentPhoto.TabStop = false;
            this.gbStudentPhoto.Text = "Снимка";
            // 
            // pbStudentPhoto
            // 
            this.pbStudentPhoto.Location = new System.Drawing.Point(6, 19);
            this.pbStudentPhoto.Name = "pbStudentPhoto";
            this.pbStudentPhoto.Size = new System.Drawing.Size(65, 39);
            this.pbStudentPhoto.TabIndex = 0;
            this.pbStudentPhoto.TabStop = false;
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.numCourse);
            this.gbStudentInfo.Controls.Add(this.txtGroup);
            this.gbStudentInfo.Controls.Add(this.txtPotok);
            this.gbStudentInfo.Controls.Add(this.lblSpecialty);
            this.gbStudentInfo.Controls.Add(this.comboStudentStatus);
            this.gbStudentInfo.Controls.Add(this.comboOKS);
            this.gbStudentInfo.Controls.Add(this.txtFacNumber);
            this.gbStudentInfo.Controls.Add(this.lblFacNumber);
            this.gbStudentInfo.Controls.Add(this.lblStudentStatus);
            this.gbStudentInfo.Controls.Add(this.lblOKS);
            this.gbStudentInfo.Controls.Add(this.lblGroup);
            this.gbStudentInfo.Controls.Add(this.lblPotok);
            this.gbStudentInfo.Controls.Add(this.lblCourse);
            this.gbStudentInfo.Controls.Add(this.txtSpecialty);
            this.gbStudentInfo.Controls.Add(this.txtFaculty);
            this.gbStudentInfo.Controls.Add(this.lblFaculty);
            this.gbStudentInfo.Location = new System.Drawing.Point(89, 83);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(273, 139);
            this.gbStudentInfo.TabIndex = 3;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Студентска информация";
            // 
            // numCourse
            // 
            this.numCourse.Location = new System.Drawing.Point(209, 20);
            this.numCourse.Name = "numCourse";
            this.numCourse.Size = new System.Drawing.Size(50, 20);
            this.numCourse.TabIndex = 14;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(209, 62);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(48, 20);
            this.txtGroup.TabIndex = 13;
            // 
            // txtPotok
            // 
            this.txtPotok.Location = new System.Drawing.Point(209, 41);
            this.txtPotok.Name = "txtPotok";
            this.txtPotok.Size = new System.Drawing.Size(48, 20);
            this.txtPotok.TabIndex = 12;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(0, 44);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(76, 13);
            this.lblSpecialty.TabIndex = 0;
            this.lblSpecialty.Text = "Специалност:";
            // 
            // comboStudentStatus
            // 
            this.comboStudentStatus.FormattingEnabled = true;
            this.comboStudentStatus.Items.AddRange(new object[] {
            "Избери...",
            "Активен",
            "Прекъснал"});
            this.comboStudentStatus.Location = new System.Drawing.Point(84, 81);
            this.comboStudentStatus.Name = "comboStudentStatus";
            this.comboStudentStatus.Size = new System.Drawing.Size(64, 21);
            this.comboStudentStatus.TabIndex = 10;
            // 
            // comboOKS
            // 
            this.comboOKS.FormattingEnabled = true;
            this.comboOKS.Items.AddRange(new object[] {
            "Избери..",
            "Бакалавър",
            "Магистър",
            "Професионален бакалавър"});
            this.comboOKS.Location = new System.Drawing.Point(84, 60);
            this.comboOKS.Name = "comboOKS";
            this.comboOKS.Size = new System.Drawing.Size(64, 21);
            this.comboOKS.TabIndex = 9;
            // 
            // txtFacNumber
            // 
            this.txtFacNumber.Location = new System.Drawing.Point(84, 102);
            this.txtFacNumber.Name = "txtFacNumber";
            this.txtFacNumber.Size = new System.Drawing.Size(63, 20);
            this.txtFacNumber.TabIndex = 8;
            // 
            // lblFacNumber
            // 
            this.lblFacNumber.AutoSize = true;
            this.lblFacNumber.Location = new System.Drawing.Point(0, 107);
            this.lblFacNumber.Name = "lblFacNumber";
            this.lblFacNumber.Size = new System.Drawing.Size(70, 13);
            this.lblFacNumber.TabIndex = 7;
            this.lblFacNumber.Text = "Фак.Номер:";
            // 
            // lblStudentStatus
            // 
            this.lblStudentStatus.AutoSize = true;
            this.lblStudentStatus.Location = new System.Drawing.Point(26, 86);
            this.lblStudentStatus.Name = "lblStudentStatus";
            this.lblStudentStatus.Size = new System.Drawing.Size(44, 13);
            this.lblStudentStatus.TabIndex = 6;
            this.lblStudentStatus.Text = "Статус:";
            // 
            // lblOKS
            // 
            this.lblOKS.AutoSize = true;
            this.lblOKS.Location = new System.Drawing.Point(38, 65);
            this.lblOKS.Name = "lblOKS";
            this.lblOKS.Size = new System.Drawing.Size(32, 13);
            this.lblOKS.TabIndex = 5;
            this.lblOKS.Text = "ОКС:";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(156, 64);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(39, 13);
            this.lblGroup.TabIndex = 4;
            this.lblGroup.Text = "Група:";
            // 
            // lblPotok
            // 
            this.lblPotok.AutoSize = true;
            this.lblPotok.Location = new System.Drawing.Point(154, 45);
            this.lblPotok.Name = "lblPotok";
            this.lblPotok.Size = new System.Drawing.Size(41, 13);
            this.lblPotok.TabIndex = 3;
            this.lblPotok.Text = "Поток:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(164, 26);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(31, 13);
            this.lblCourse.TabIndex = 2;
            this.lblCourse.Text = "Курс";
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Location = new System.Drawing.Point(85, 40);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(63, 20);
            this.txtSpecialty.TabIndex = 1;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(85, 20);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(63, 20);
            this.txtFaculty.TabIndex = 1;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(10, 23);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(60, 13);
            this.lblFaculty.TabIndex = 0;
            this.lblFaculty.Text = "Факултет:";
            // 
            // gbPersonalData
            // 
            this.gbPersonalData.Controls.Add(this.txtLastName);
            this.gbPersonalData.Controls.Add(this.lblLastName);
            this.gbPersonalData.Controls.Add(this.txtSecondName);
            this.gbPersonalData.Controls.Add(this.lblSecondName);
            this.gbPersonalData.Controls.Add(this.txtFirstName);
            this.gbPersonalData.Controls.Add(this.lblFirstName);
            this.gbPersonalData.Location = new System.Drawing.Point(99, 6);
            this.gbPersonalData.Name = "gbPersonalData";
            this.gbPersonalData.Size = new System.Drawing.Size(169, 77);
            this.gbPersonalData.TabIndex = 2;
            this.gbPersonalData.TabStop = false;
            this.gbPersonalData.Text = "Лични данни";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(49, 53);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 56);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Фамилия:";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(48, 33);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(100, 20);
            this.txtSecondName.TabIndex = 1;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Location = new System.Drawing.Point(10, 38);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(56, 13);
            this.lblSecondName.TabIndex = 0;
            this.lblSecondName.Text = "Презиме:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(49, 13);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(10, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(32, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Име:";
            // 
            // tabMarks
            // 
            this.tabMarks.Location = new System.Drawing.Point(4, 22);
            this.tabMarks.Name = "tabMarks";
            this.tabMarks.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarks.Size = new System.Drawing.Size(434, 218);
            this.tabMarks.TabIndex = 1;
            this.tabMarks.Text = "Оценки";
            this.tabMarks.UseVisualStyleBackColor = true;
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openFileDialog1";
            this.openPictureDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 285);
            this.Controls.Add(this.tabControlStudenInfo);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.tabControlStudenInfo.ResumeLayout(false);
            this.tabStudents.ResumeLayout(false);
            this.gbStudentPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).EndInit();
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).EndInit();
            this.gbPersonalData.ResumeLayout(false);
            this.gbPersonalData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miLoginOut;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlStudenInfo;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.GroupBox gbStudentPhoto;
        private System.Windows.Forms.PictureBox pbStudentPhoto;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.NumericUpDown numCourse;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtPotok;
        private System.Windows.Forms.ComboBox comboStudentStatus;
        private System.Windows.Forms.ComboBox comboOKS;
        private System.Windows.Forms.TextBox txtFacNumber;
        private System.Windows.Forms.Label lblFacNumber;
        private System.Windows.Forms.Label lblStudentStatus;
        private System.Windows.Forms.Label lblOKS;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblPotok;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.GroupBox gbPersonalData;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TabPage tabMarks;
        private System.Windows.Forms.ToolStripMenuItem openPictureToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.ToolStripMenuItem uverenieToolStripMenuItem;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ToolStripMenuItem infoGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registracionToolStripMenuItem;
    }
}