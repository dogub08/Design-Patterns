using Builder.Abstract;
using Builder.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Concrete
{
    public class Visa : CreditCardBuilder
    {
        public Visa() => _creditCard = new CreditCard();
        public override void BankName() => _creditCard.BankName = "İş Bankası";
        public override void CardLimit() => _creditCard.CardLimit = 10000;
        public override void CardType() => _creditCard.CardType = "Visa";
        public override void HirePurchase() => _creditCard.HirePurchase = false;
    }
}
