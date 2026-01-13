using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubMemberInformation
{
    public partial class ClubMemberInfoUI : Form
    {
        List<ClubMember> clubmemberList = new List<ClubMember>();
        public ClubMemberInfoUI()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string membershipType = "";
            if (MonthlyRadioButton.Checked)
            {
                membershipType = MonthlyRadioButton.Text;
                MonthlyRadioButton.Checked = false;
            }
            else if (YearlyRadioButton.Checked)
            {
                membershipType = YearlyRadioButton.Text;
                YearlyRadioButton.Checked = false;
            }
            else if (LifetimeRadioButton.Checked)
            {
                membershipType = LifetimeRadioButton.Text;
                LifetimeRadioButton.Checked = false;
            }

            string hasPaidMembershipFee = string.Empty;
            if (PaidMembershipFeeCheckBox.Checked)
            {
                hasPaidMembershipFee = "Paid";
            }
            else
            {
                hasPaidMembershipFee = "Not Paid";
            }
            PaidMembershipFeeCheckBox.Checked = false;

            ClubMember aClubmember = new ClubMember(NameTextBox.Text, ContactNoTextBox.Text, hasPaidMembershipFee, membershipType);
            clubmemberList.Add(aClubmember);
            NameTextBox.Text = "";
            ContactNoTextBox.Text = "";

            MessageBox.Show("Employee Info. has been saved.");
        }

        private void MonthlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PaidMembershipFeeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            string allInfo = "";
            foreach(ClubMember aClubMember in clubmemberList)
            {
                string info = aClubMember.Name + " " + aClubMember.ContactNo + " " + aClubMember.MembershipType + " " + aClubMember.HasPaidMembershipFee + "\n";
                allInfo += info;
            }
            MessageBox.Show(allInfo);
        }
    }
}
