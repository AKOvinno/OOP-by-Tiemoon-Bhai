using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryShopManagement
{
    class Damage : OperationOnProduct
    {
        public string CauseOfDamage { set; get; }
        public override string GetBasicInfo()
        {
            return base.GetBasicInfo() + " || " + CauseOfDamage;
        }
    }
}
