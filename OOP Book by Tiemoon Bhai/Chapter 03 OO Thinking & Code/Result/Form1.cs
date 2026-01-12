using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result
{
    public partial class ResultUI : Form
    {
        Result aResult;
        public ResultUI()
        {
            InitializeComponent();
        }

        private void ShowResultButton_Click(object sender, EventArgs e)
        {
            aResult = new Result();
            aResult.MathScore = Convert.ToDouble(MathScoreTextBox.Text);
            aResult.PhysicsScore = Convert.ToDouble(PhysicsScoreTextBox.Text);
            aResult.ChemistryScore = Convert.ToDouble(ChemistryScoreTextBox.Text);
            MathGradeTextBox.Text = aResult.Grade(aResult.MathScore);
            PhysicsGradeTextBox.Text = aResult.Grade(aResult.PhysicsScore);
            ChemistryGradeTextBox.Text = aResult.Grade(aResult.ChemistryScore);
            OverallGradeTextBox.Text = aResult.OverallGrade();
            AverageGradeTextBox.Text = aResult.AverageScore().ToString();
        }
    }
}
