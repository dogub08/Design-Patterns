using Builder.Abstract;
using Builder.Concrete;
using Builder.Directory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCardBuilder americanExpress = new AmericanExpress();
            CreditCardBuilder master = new Master();
            CreditCardBuilder visa = new Visa();

            CreditCardDirectory creditCardDirectory = new CreditCardDirectory();
            creditCardDirectory.CreditCardConstructor(americanExpress);

            CreditCardDirectory creditCardDirectory_1 = new CreditCardDirectory();
            creditCardDirectory_1.CreditCardConstructor(master);

            CreditCardDirectory creditCardDirectory_2 = new CreditCardDirectory();
            creditCardDirectory_2.CreditCardConstructor(visa);

            Console.WriteLine("================American Express=================");
            Console.WriteLine($"Bank Name: {americanExpress.CreditCard.BankName}");
            Console.WriteLine($"Card Type:{americanExpress.CreditCard.CardType}");
            Console.WriteLine($"Card Limit:  {americanExpress.CreditCard.CardLimit}");
            Console.WriteLine($"Installment Option: {americanExpress.CreditCard.HirePurchase}");

            Console.WriteLine("================Master Card=================");
            Console.WriteLine($"Bank Name:  {master.CreditCard.BankName}");
            Console.WriteLine($"Card Type: {master.CreditCard.CardType}");
            Console.WriteLine($"Card Limit:  {master.CreditCard.CardLimit}");
            Console.WriteLine($"Installment Option: {master.CreditCard.HirePurchase}");
            
            Console.ReadKey();
        }
    }
}
