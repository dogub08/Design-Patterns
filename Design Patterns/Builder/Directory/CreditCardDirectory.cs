using Builder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directory
{
   public class CreditCardDirectory
    {
        public void CreditCardConstructor(CreditCardBuilder creditCardBuilder)
        {
            creditCardBuilder.BankName();
            creditCardBuilder.CardLimit();
            creditCardBuilder.CardType();
            creditCardBuilder.HirePurchase();
        }
    }
}
