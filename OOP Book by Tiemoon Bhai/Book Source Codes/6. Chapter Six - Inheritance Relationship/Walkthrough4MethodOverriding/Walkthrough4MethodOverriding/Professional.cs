using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough4MethodOverriding
{
    class Professional : Participant
    {
        public string CompanyName { set; get; }
        public string CompanyContact { set; get; }
        public double DiscountPercent { set; get; }

        public override double GetTotalPayable()
        {
            double grossTotal = base.GetTotalPayable();
            double totalPayable = grossTotal - GetDiscountAmount();
            return totalPayable;
        }
        public double GetDiscountAmount()
        {
            double totalAmount = 0;
            foreach (Course aCourse in EnrolledCourses)
            {
                totalAmount += aCourse.Fee;
            }
            double discountAmount = (totalAmount * DiscountPercent) / 100.0;
            return discountAmount;
        }
    }
}
