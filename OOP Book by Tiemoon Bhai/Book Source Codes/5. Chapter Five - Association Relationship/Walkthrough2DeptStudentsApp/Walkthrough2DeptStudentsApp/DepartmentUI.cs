using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walkthrough2DeptStudentsApp
{
    public partial class DepartmentUI : Form
    {
        Department aDept = new Department();
        public DepartmentUI()
        {
            InitializeComponent();
        }

        private void saveDeptButton_Click(object sender, EventArgs e)
        {
            aDept.Name = deptNameEntryTextBox.Text;
            aDept.Code = deptCodeEntryTextBox.Text;
            MessageBox.Show("Dept has been saved.");
        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Name = studentNameTextBox.Text;
            aStudent.Email = studentEmailTextBox.Text;
            aStudent.RegNo = studentRegNoTextBox.Text;
            aDept.StudentList.Add(aStudent);
            MessageBox.Show("Student has been saved.");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            deptNameShowTextBox.Text = aDept.Name;
            deptCodeShowTextBox.Text = aDept.Code;
            noOfStudentsShowShowTextBox.Text = aDept.StudentList.Count.ToString();
            studentsListBox.Items.Clear();

            foreach (Student student in aDept.StudentList)
            {
                studentsListBox.Items.Add(student.RegNo + " " + student.Name);
            }
        }
    }
}
