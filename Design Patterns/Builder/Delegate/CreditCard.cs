using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Delegate
{
    public class CreditCard
    {
        public string BankName { get; set; }
        public int CardLimit { get; set; }
        public string CardType { get; set; }
        public bool HirePurchase { get; set; }
    }
}
