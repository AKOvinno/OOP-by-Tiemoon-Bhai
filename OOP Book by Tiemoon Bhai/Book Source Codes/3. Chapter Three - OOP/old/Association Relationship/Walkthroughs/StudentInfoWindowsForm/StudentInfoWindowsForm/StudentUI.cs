using System.Windows.Forms;

namespace StudentInfoWindowsForm
{
    public partial class StudentUI : Form
    {
        private Student aStudent;
        public StudentUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            ContactInfo contactInfo = new ContactInfo();
            contactInfo.Email = emailTextBox.Text;
            contactInfo.MobileNo = mobileTextBox.Text;
            contactInfo.PostalAddress = addressTextBox.Text;

            aStudent = new Student();
            aStudent.FirstName = firstNameTextBox.Text;
            aStudent.LastName = lastNameTextBox.Text;
            aStudent.ContactInfo = contactInfo;
            MessageBox.Show("Student Info has been saved in temp. memory");
        }

        private void viewAllButton_Click(object sender, System.EventArgs e)
        {
            if (aStudent != null)
            {
                string info = aStudent.FirstName + "\n" +
                              aStudent.LastName + "\n" +
                              aStudent.RegNo + "\n" +
                              aStudent.ContactInfo.MobileNo + "\n" +
                              aStudent.ContactInfo.Email + "\n" +
                              aStudent.ContactInfo.PostalAddress;
                MessageBox.Show(info);
            }
            else
            {
                MessageBox.Show("No Student info to show");
            }
        }
    }
}
