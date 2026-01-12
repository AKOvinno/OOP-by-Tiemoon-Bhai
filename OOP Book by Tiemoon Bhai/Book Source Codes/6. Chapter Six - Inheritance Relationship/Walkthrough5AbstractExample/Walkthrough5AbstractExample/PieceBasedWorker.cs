using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough5AbstractExample
{
    class PieceBasedWorker: Worker
    {
        public int NoOfPiecesProduced { set; get; }
        public double AmountPerPiece { set; get; }

        public override double GetTotalWage()
        {
            if (NoOfPiecesProduced <= 500)
            {
                return NoOfPiecesProduced * AmountPerPiece;
            }
            else
            {
                return (NoOfPiecesProduced * AmountPerPiece) * 1.02;
            }
        }
    }
}
