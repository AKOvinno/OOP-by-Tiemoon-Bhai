using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NamespaceExample
{
    public partial class InstituteUI : Form
    {
        Department anInstitute;
        
        public InstituteUI()
        {
            InitializeComponent();
            studentEnrollComboBox.DisplayMember = "Name";
            studentResultComboBox.DisplayMember = "Name";

            courseEntollComboBox.DisplayMember = "Title";
            courseResultComboBox.DisplayMember = "Title";
            
            anInstitute = new Department();
        }

        private void saveInstituteButton_Click(object sender, EventArgs e)
        {
            anInstitute.Name = instituteNameTextBox.Text;
            anInstitute.Tagline = instituteTaglineTextBox.Text;
            //anInstitute.Logo
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            Course aCourse = new Course();
            aCourse.Title = courseTitleTextBox.Text;
            if (level1RadioButton.Checked)
            {
                aCourse.Level = level1RadioButton.Text;
            }
            
            if (level2RadioButton.Checked)
            {
                aCourse.Level = level2RadioButton.Text;
            }

            if (level3RadioButton.Checked)
            {
                aCourse.Level = level3RadioButton.Text;
            }
            aCourse.DurationInHour = Convert.ToInt16(courseDurationTextBox.Text);
            anInstitute.Courses.Add(aCourse);
            courseEntollComboBox.Items.Add(aCourse);
            MessageBox.Show("Course info has been added.");
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Name = studentNameTextBox.Text;
            aStudent.ContactNo = studentContactNoTextBox.Text;
            aStudent.Email = studentEmailTextBox.Text;
            aStudent.RegNo = studentRegNoTextBox.Text;
            anInstitute.Students.Add(aStudent);
            studentEnrollComboBox.Items.Add(aStudent);
            MessageBox.Show("Student info has been saved.");
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            Enrollment anEnrollment = new Enrollment();
            anEnrollment.Student = (Student)studentEnrollComboBox.SelectedItem;
            anEnrollment.Course = (Course)courseEntollComboBox.SelectedItem;
            anEnrollment.EnrollmentDate = enrollmentDateDateTimePicker.Value;
            anInstitute.Enrollments.Add(anEnrollment);
            MessageBox.Show("Enrollment info has been saved.");
        }
    }
}

