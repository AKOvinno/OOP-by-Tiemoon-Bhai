using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dept_Student
{
    public partial class DepartmentUI : Form
    {
        Department aDept = new Department();
        public DepartmentUI()
        {
            InitializeComponent();
        }

        private void SaveDeptButton_Click(object sender, EventArgs e)
        {
            aDept.Name = DeptNameEntryTextBox.Text;
            aDept.Code = DeptCodeEntryTextBox.Text;
            MessageBox.Show("Dept has been saved.");
        }

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Name = StudentNameEntryTextBox.Text;
            aStudent.Email = StudentEmailEntryTextBox.Text;
            aStudent.RegNo = StudentRegNoEntryTextBox.Text;
            aDept.StudentList.Add(aStudent);
            MessageBox.Show("Student has been saved.");
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            DeptNameShowTextBox.Text = aDept.Name;
            DeptCodeShowTextBox.Text = aDept.Code;
            DeptNoOfStudentShowTextBox.Text = aDept.StudentList.Count.ToString();
            string studentListBox = "";
            foreach(Student student in aDept.StudentList)
            {
                studentListBox += (student.RegNo + " " + student.Name + "\n");
            }
            DeptStudentListShowTextBox.Text = studentListBox;
        }
    }
}
