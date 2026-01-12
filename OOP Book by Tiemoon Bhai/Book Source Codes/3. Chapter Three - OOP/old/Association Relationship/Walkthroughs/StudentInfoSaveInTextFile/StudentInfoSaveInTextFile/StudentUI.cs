using System.IO;
using System.Windows.Forms;

namespace StudentInfoSaveInTextFile
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

            string info = aStudent.FirstName + " " +
              aStudent.LastName + " " +
              aStudent.RegNo + " " +
              aStudent.ContactInfo.MobileNo + " " +
              aStudent.ContactInfo.Email + " " +
              aStudent.ContactInfo.PostalAddress;

            StreamWriter file = new StreamWriter(@"StudentInfo.txt", true);
            file.WriteLine(info);
            file.Close();
            
            MessageBox.Show(@"Student Info has been saved in StudentInfo.txt file");
        }

        private void viewAllButton_Click(object sender, System.EventArgs e)
        {
            string aLine;
            string info ="";
            StreamReader file = new StreamReader(@"StudentInfo.txt");
            while ((aLine = file.ReadLine()) != null)
            {
                info += aLine + "\n";
            }
            file.Close();
            MessageBox.Show(info);
        }
    }
}
