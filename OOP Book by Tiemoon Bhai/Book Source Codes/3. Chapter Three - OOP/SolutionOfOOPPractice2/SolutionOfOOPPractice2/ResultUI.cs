using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionOfOOPPractice2
{
    public partial class ResultUI : Form
    {
        public ResultUI()
        {
            InitializeComponent();
        }

        private void showResultTextBox_Click(object sender, EventArgs e)
        {
            double mathScore = Convert.ToDouble(mathScoreTextBox.Text);
            double physicsScore = Convert.ToDouble(physicsScoreTextBox.Text);
            double chemistryScore = Convert.ToDouble(chemistryScoreTextBox.Text);

            ResultSheet aResultSheet = new ResultSheet();
            aResultSheet.mathScore = mathScore;
            aResultSheet.physicsScore = physicsScore;
            aResultSheet.chemistryScore = chemistryScore;

            mathGradeTextBox.Text = aResultSheet.GetMathGrade();
            physicsGradeTextBox.Text = aResultSheet.GetPhysicsGrade();
            chemistryGradeTextBox.Text = aResultSheet.GetChemistryGrade();

            averageScoreTextBox.Text = aResultSheet.GetAverageScore().ToString();
            overAllGradeTextBox.Text = aResultSheet.GetOverAllGradeLetter();



        }
    }
}
