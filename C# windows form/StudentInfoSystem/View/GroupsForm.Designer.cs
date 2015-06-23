namespace StudentInfoSystem.View
{
    partial class GroupsForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoDatabaseDataSet = new StudentInfoSystem.StudentInfoDatabaseDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.studentsTableAdapter = new StudentInfoSystem.StudentInfoDatabaseDataSetTableAdapters.StudentsTableAdapter();
            this.fillByGroupToolStrip = new System.Windows.Forms.ToolStrip();
            this.groupToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.groupToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByGroupToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDatabaseDataSet)).BeginInit();
            this.fillByGroupToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.facultyDataGridViewTextBoxColumn,
            this.specialtyDataGridViewTextBoxColumn,
            this.oKSDataGridViewTextBoxColumn,
            this.studentStatusDataGridViewTextBoxColumn,
            this.facNumberDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.potokDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1255, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // facultyDataGridViewTextBoxColumn
            // 
            this.facultyDataGridViewTextBoxColumn.DataPropertyName = "Faculty";
            this.facultyDataGridViewTextBoxColumn.HeaderText = "Faculty";
            this.facultyDataGridViewTextBoxColumn.Name = "facultyDataGridViewTextBoxColumn";
            // 
            // specialtyDataGridViewTextBoxColumn
            // 
            this.specialtyDataGridViewTextBoxColumn.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.HeaderText = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.Name = "specialtyDataGridViewTextBoxColumn";
            // 
            // oKSDataGridViewTextBoxColumn
            // 
            this.oKSDataGridViewTextBoxColumn.DataPropertyName = "OKS";
            this.oKSDataGridViewTextBoxColumn.HeaderText = "OKS";
            this.oKSDataGridViewTextBoxColumn.Name = "oKSDataGridViewTextBoxColumn";
            // 
            // studentStatusDataGridViewTextBoxColumn
            // 
            this.studentStatusDataGridViewTextBoxColumn.DataPropertyName = "StudentStatus";
            this.studentStatusDataGridViewTextBoxColumn.HeaderText = "StudentStatus";
            this.studentStatusDataGridViewTextBoxColumn.Name = "studentStatusDataGridViewTextBoxColumn";
            // 
            // facNumberDataGridViewTextBoxColumn
            // 
            this.facNumberDataGridViewTextBoxColumn.DataPropertyName = "FacNumber";
            this.facNumberDataGridViewTextBoxColumn.HeaderText = "FacNumber";
            this.facNumberDataGridViewTextBoxColumn.Name = "facNumberDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // potokDataGridViewTextBoxColumn
            // 
            this.potokDataGridViewTextBoxColumn.DataPropertyName = "Potok";
            this.potokDataGridViewTextBoxColumn.HeaderText = "Potok";
            this.potokDataGridViewTextBoxColumn.Name = "potokDataGridViewTextBoxColumn";
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentInfoDatabaseDataSet;
            // 
            // studentInfoDatabaseDataSet
            // 
            this.studentInfoDatabaseDataSet.DataSetName = "StudentInfoDatabaseDataSet";
            this.studentInfoDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // fillByGroupToolStrip
            // 
            this.fillByGroupToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripLabel,
            this.groupToolStripTextBox,
            this.fillByGroupToolStripButton});
            this.fillByGroupToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByGroupToolStrip.Name = "fillByGroupToolStrip";
            this.fillByGroupToolStrip.Size = new System.Drawing.Size(1303, 25);
            this.fillByGroupToolStrip.TabIndex = 2;
            this.fillByGroupToolStrip.Text = "fillByGroupToolStrip";
            this.fillByGroupToolStrip.Visible = false;
            // 
            // groupToolStripLabel
            // 
            this.groupToolStripLabel.Name = "groupToolStripLabel";
            this.groupToolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.groupToolStripLabel.Text = "group:";
            // 
            // groupToolStripTextBox
            // 
            this.groupToolStripTextBox.Name = "groupToolStripTextBox";
            this.groupToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByGroupToolStripButton
            // 
            this.fillByGroupToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByGroupToolStripButton.Name = "fillByGroupToolStripButton";
            this.fillByGroupToolStripButton.Size = new System.Drawing.Size(72, 22);
            this.fillByGroupToolStripButton.Text = "FillByGroup";
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 262);
            this.Controls.Add(this.fillByGroupToolStrip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GroupsForm";
            this.Text = "GroupsForm";
            this.Load += new System.EventHandler(this.GroupsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDatabaseDataSet)).EndInit();
            this.fillByGroupToolStrip.ResumeLayout(false);
            this.fillByGroupToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private StudentInfoDatabaseDataSet studentInfoDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private StudentInfoDatabaseDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByGroupToolStrip;
        private System.Windows.Forms.ToolStripLabel groupToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox groupToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByGroupToolStripButton;


    }
}