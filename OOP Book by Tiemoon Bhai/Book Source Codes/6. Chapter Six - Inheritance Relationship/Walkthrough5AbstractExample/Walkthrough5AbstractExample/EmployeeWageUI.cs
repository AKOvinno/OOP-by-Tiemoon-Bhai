using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walkthrough5AbstractExample
{
    public partial class EmployeeWageUI : Form
    {
        double totalWage = 0;
        public EmployeeWageUI()
        {
            InitializeComponent();
        }

        private void showTimeWorkerInfoButton_Click(object sender, EventArgs e)
        {
            int TotalTimeWorked = Convert.ToInt16(timeWorkerWorkedHrTextBox.Text);
            double amount = Convert.ToDouble(timeWorkerAmountPerHrTextBox.Text);
            TimeBasedWorker tWorker = new TimeBasedWorker();
            tWorker.Name = timeWorkerNameTextBox.Text;
            tWorker.ContactNo = timeWorkerContactTextBox.Text;
            tWorker.TotalHoursWorked = TotalTimeWorked;
            tWorker.AmountPerHour = amount;
            totalWage = tWorker.GetTotalWage();
            MessageBox.Show(tWorker.Name + "\nTotal Wage: " + totalWage );
        }

        private void pieceWorkerInfoButton_Click(object sender, EventArgs e)
        {
            int TotalPiece = Convert.ToInt16(NoOfPiecesTextBox.Text);
            double amount = Convert.ToDouble(pieceWorkerAmountPerPCTextBox.Text);
            PieceBasedWorker pWorker = new PieceBasedWorker();
            pWorker.Name = pieceWorkerNameTextBox.Text;
            pWorker.ContactNo = pieceWorkerContactTextBox.Text;
            pWorker.NoOfPiecesProduced = TotalPiece;
            pWorker.AmountPerPiece = amount;
            totalWage = pWorker.GetTotalWage();
            MessageBox.Show(pWorker.Name + "\nTotal Wage: " + totalWage);
        }
    }
}
