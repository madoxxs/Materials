using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentInfoSystem.View
{
    public partial class GroupsForm : Form
    {
        public GroupsForm()
        {
            InitializeComponent();
        }
        private void GroupsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentInfoDatabaseDataSet1.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentInfoDatabaseDataSet.Students);
            List<int> groups = Data.StudentData.GetGroups();
               // comboBox1.Items.Add("Add"); // moje i bez nego
            foreach (var item in groups) {
                comboBox1.Items.Add(item);
            }
        }

 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 try
            {
                this.studentsTableAdapter.FillByGroup(this.studentInfoDatabaseDataSet.Students, ((int)(System.Convert.ChangeType(comboBox1.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }



  



   

        

        

    }
}


