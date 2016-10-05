using System;

namespace ConsoleApplication
{
    public class Payment
    //this is the base class
    {
        public decimal Amount{get;set;}

        public virtual string MakePayment()
        {
            return $"You paid ${this.Amount} in Cash";
            //a virtual class will be overwritten by the company processing the payment
            //TODO hit the payment processing API
        }
        public string SendConfirmation(string email)
        {
        return "You purchased several nice items";
        }
        public string SendConfirmation(string email, bool digitalDownload)
        {
            return "Check you email for the downloadable book";
        }
    }
}