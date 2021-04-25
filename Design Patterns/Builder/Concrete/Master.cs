using Builder.Abstract;
using Builder.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Concrete
{
    public class Master : CreditCardBuilder
    {
        public Master() => _creditCard = new CreditCard();
        public override void BankName() => _creditCard.BankName = "Garanti Bankası";
        public override void CardLimit() => _creditCard.CardLimit = 10000;
        public override void CardType() => _creditCard.CardType = "Master";
        public override void HirePurchase() => _creditCard.HirePurchase = true;
    }
}
