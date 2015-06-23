using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentInfoSystem.Logic;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.View
{
    public partial class MainForm : Form
    {
        public UserStatus userStatus { get; private set; }
        public MainForm()
        {

            InitializeComponent();
            userStatus = UserStatus.ANONYMOUS;
            DisableControl();
           
        }
        
        private string GenerateInfoText()
        {
            string text = "Уверение\n";
            text +=txtFirstName.Text + " " +" \t "+ txtSecondName.Text + " " +" \t "+
            txtLastName.Text;
            text += " е студент/ка във Факултет " + " \t "+txtFaculty.Text +
            ", специалност " +" \t "+ txtSpecialty.Text;
            text += "\n";
            return text;
        }
        private void ShowStudentInfo()
        {
            txtFirstName.Text="Симеон";
            txtSecondName.Text="Христов";
            txtLastName.Text="Присадов";
            txtFaculty.Text="ФКСУ";
            txtSpecialty.Text = "КСТ";
            txtFacNumber.Text = "121212104";
            txtPotok.Text = "1";
            txtGroup.Text = "53";
            comboOKS.SelectedIndex = 1;
            comboStudentStatus.SelectedIndex = 1;
            numCourse.Value = 3;
            numCourse.Maximum = 4;
            numCourse.Minimum = 1;
            
        }
        private void ShowStudentInfo(Data.Student s)
        {
            if (s == null)
            {
                MessageBox.Show("no data");
                return;
            }
            txtFirstName.Text = s.FirstName;
            txtSecondName.Text = s.SecondName;
            txtLastName.Text = s.LastName;
            txtFaculty.Text = s.Faculty;
            txtSpecialty.Text = s.Specialty;
            txtFacNumber.Text = s.FacNumber;
            txtPotok.Text = s.Potok;
            txtGroup.Text = s.Group.ToString();
            comboOKS.SelectedIndex = s.OKS;
            comboStudentStatus.SelectedIndex = s.StudentStatus;
            numCourse.Value = 3;
            numCourse.Maximum = 4;
            numCourse.Minimum = 1;

        }
        public Data.Student ReadStudentInfo()
        {
            Data.Student st = new Data.Student();
            st.FirstName = txtFirstName.Text;
            st.SecondName = txtSecondName.Text;
            st.LastName = txtLastName.Text;
            st.Faculty = txtFaculty.Text;
            st.Specialty = txtSpecialty.Text;
            st.FacNumber = txtFacNumber.Text;
            int myInt;
            if (int.TryParse(txtGroup.Text, out myInt) == true)
            {
                st.Group = myInt;
            }
            st.Potok = txtPotok.Text;
            st.OKS = (short)comboOKS.SelectedIndex;
            st.StudentStatus = (short)comboStudentStatus.SelectedIndex;
            numCourse.Maximum = 4;
            numCourse.Minimum = 1;
            st.Course = (short)numCourse.Value;
            
            return st;
         }
        

        private void ClearStudentInfo()
        {
            comboOKS.SelectedIndex = 0;
            comboStudentStatus.SelectedIndex = 0;
            numCourse.Value = 1;
            txtFirstName.Clear();
            txtSecondName.Clear();
            txtLastName.Clear();
            txtFaculty.Clear();
            txtSpecialty.Clear();
            txtFacNumber.Clear();
            txtPotok.Clear();
            txtGroup.Clear();
        }

        private void EnableControls()
        {
            gbPersonalData.Enabled = true;
            gbStudentInfo.Enabled = true;
            gbStudentPhoto.Enabled = true;
            openPictureToolStripMenuItem.Visible = true;
            uverenieToolStripMenuItem.Visible = true;
        }
        private void LoadStudentPicture()
        {
            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                pbStudentPhoto.ImageLocation = openPictureDialog.FileName;
                pbStudentPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void DisableControl()
        {
            gbPersonalData.Enabled = false;
            gbStudentInfo.Enabled = false;
            gbStudentPhoto.Enabled = false;
            openPictureToolStripMenuItem.Visible = false;
            uverenieToolStripMenuItem.Visible = false;
            btnAddStudent.Visible = false;
            infoGroupToolStripMenuItem.Visible = false;
            pbStudentPhoto.Image = null;
            registracionToolStripMenuItem.Visible = false;
            
        }
        private void LogIn()
        {
            LoginForm lf = new LoginForm();
            if (lf.ShowDialog() == DialogResult.OK)
            {
                
                Student student = StudentValidation.IsThereStudent(lf.user);
                if (lf.user.Role==3)
                {

                    ShowStudentInfo(student);
                    EnableControls();
                    userStatus = UserStatus.ADMIN;
                    MessageBox.Show("welcome admin!");

                    registracionToolStripMenuItem.Visible = true;
                    infoGroupToolStripMenuItem.Visible = true;
                    
                    btnAddStudent.Visible = true;
                    
                    miLoginOut.Text = "LogOut";
                }
                if (lf.user.Role == 1)
                {
                    ShowStudentInfo(student);
                    EnableControls();
                    userStatus = UserStatus.STUDENT;
                    miLoginOut.Text = "LogOut";
                }
            }
            
        }
        
        private void LogOut()
        {
            ClearStudentInfo();
            DisableControl();
            userStatus = UserStatus.ANONYMOUS;
            miLoginOut.Text = "LogIn";
        }

        private void miLoginOut_Click(object sender, EventArgs e)
        {
            switch (userStatus)
            {
                case UserStatus.ANONYMOUS:LogIn();
                    break;
                case UserStatus.STUDENT:LogOut();
                    break;
                case UserStatus.ADMIN: LogOut();
                    break;
                default:
                    break;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        private void openPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadStudentPicture();
        }


       

        private void uverenieToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string text = GenerateInfoText();
            InfoForm infoForm = new InfoForm(text);
            infoForm.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student s = ReadStudentInfo();

            if (StudentValidation.ValidateData(s.FirstName,s.SecondName,s.LastName,s.Faculty,s.Specialty,(short)s.OKS, (short)s.StudentStatus,s.FacNumber,(short)s.Course,s.Potok,s.Group.ToString())!=string.Empty)
            {
                MessageBox.Show(StudentValidation.ValidateData(s.FirstName, s.SecondName, s.LastName, s.Faculty, s.Specialty, (short)s.OKS, (short)s.StudentStatus, s.FacNumber, (short)s.Course, s.Potok, s.Group.ToString()));
                return;
            }
            if (StudentData._IfFacNumberExist(s.FacNumber) == true)
            {
                MessageBox.Show("Студент с такъв факултетен номер вече съществува!");
                return;
            }
            if (StudentValidation.InsertStudentIfValid(s))
            {
                MessageBox.Show("Студентът е успешно добавен!");
            }
            else
            {
                MessageBox.Show("Некоректна информация относно групата!");
            }
        }

       
        private void infoGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupsForm moni = new GroupsForm();
            moni.ShowDialog();
        }



        private void registracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
        }
       

       
       

    }
}
