using System;

namespace ConsoleApplication
{
    public class PayPalPayment:Payment
    {
        public string Password {get;set;}
        //adding a new method in addition to what was inherited from Payment
        public string Email {get;set;}
        public override string MakePayment()
        {
            string message = string.Empty;
            if(this.Amount > 0 && this.Password != null){
                return message = $"Your payment of ${this.Amount} has been processed by PayPal";
            }
//hwen you're overriding a method, everthing has to be the same - the arguments, the name, everything
            return message; 
        }

    }
}

//with PayPalPayment:Payment, PayPalPayment will have access to everything Payment has - email, account etc