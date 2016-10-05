using System;

namespace ConsoleApplication
{
    public class CreditCardPayment:Payment
    {
        public string CreditCardNumber {get;set;}
        //adding a new method in addition to what was inherited from Payment
        public override string MakePayment()
        {
            string message = string.Empty;
            if(this.Amount > 0 && this.CreditCardNumber != null){
                return message = $"Your payment of ${this.Amount} has been processed by Visa";
            }
//hwen you're overriding a method, everthing has to be the same - the arguments, the name, everything
            return message; 
        }

    }
}