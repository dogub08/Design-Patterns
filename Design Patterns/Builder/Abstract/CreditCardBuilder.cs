using Builder.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Abstract
{
   public abstract class CreditCardBuilder
    {
        protected CreditCard _creditCard;
        public CreditCard CreditCard { get => _creditCard; }

        public abstract void BankName();
        public abstract void CardLimit();
        public abstract void CardType();
        public abstract void HirePurchase();
    }
}
