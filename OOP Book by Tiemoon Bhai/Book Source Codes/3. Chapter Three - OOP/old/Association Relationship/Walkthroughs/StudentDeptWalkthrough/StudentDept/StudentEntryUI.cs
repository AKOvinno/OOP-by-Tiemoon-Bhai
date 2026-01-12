using System;
using System.Windows.Forms;

namespace StudentDept
{
    public partial class StudentEntryUI : Form
    {
        public StudentEntryUI()
        {
            InitializeComponent();
        }

        private Department deptObj = null;

        private void deptSaveButton_Click(object sender, EventArgs e)
        {
            deptObj = new Department(deptCodeTextBox.Text, deptNameTextBox.Text);
            MessageBox.Show("Department information has been saved.");
        }

        private void studentSaveButton_Click(object sender, EventArgs e)
        {
            Student studentObj = new Student(studentRegNoTextBox.Text,
                studentNameTextBox.Text, studentEmailTextBox.Text);
            string message = "";
            if (deptObj != null)
            {
                deptObj.Students.Add(studentObj);
                message = "Student has been saved";
            }
            else
            {
                message = "Department is not created. Please create the department first";
            }
            MessageBox.Show(message);
        }

        private void showDetailsInfo_Click(object sender, EventArgs e)
        {
            string detailsMsg = "";
            if (deptObj != null)
            {
                string deptMessage = "Dept Id: " + deptObj.Code + " Name: " + deptObj.Name + "\n";
                detailsMsg += deptMessage;
                string studentInfoHeader = "Student Reg.No\tName\tEmail\n";
                detailsMsg += studentInfoHeader;
                foreach (Student studentObj in deptObj.Students)
                {
                    string studentMsg = studentObj.RegNo + "\t" + studentObj.Name +
                        "\t" + studentObj.Email + "\n";
                    detailsMsg += studentMsg;
                }
            }
            else
            {
                detailsMsg = "No Information about dept";
            }
            MessageBox.Show(detailsMsg);
        }
    }
}
