using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionOfPractice8
{
    public partial class MemberAddUI : Form
    {
        List<Member> memberList = new List<Member>();
        public MemberAddUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Member aMember = new Member();
            aMember.Name = nameTextBox.Text;
            aMember.ContactNo = contactNoTextBox.Text;

            if (paidFeeCheckBox.Checked)
            {
                aMember.HasPaidFee = true;
            }
            else
            {
                aMember.HasPaidFee = false;
            }

            if (monthlyTypeRadioButton.Checked)
            {
                aMember.MembershipType = "Monthly";
            }
            else if (yearlyTypeRadioButton.Checked)
            {
                aMember.MembershipType = "Yearly";
            }
            else 
            {
                aMember.MembershipType = "Lifetime";
            }

            memberList.Add(aMember);
            MessageBox.Show("Member info has been saved successfully.");
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string allInfo = "";
            foreach (Member aMember in memberList)
            {
                string aMemberInfo = aMember.Name + " " 
                    + aMember.ContactNo +  " " + aMember.MembershipType;

                if (aMember.HasPaidFee == true)
                {
                    aMemberInfo += " Paid" + "\n";
                }
                else
                {
                    aMemberInfo += " Not Paid" + "\n";
                }

                allInfo += aMemberInfo;
            }

            MessageBox.Show(allInfo);
        }
    }
}
