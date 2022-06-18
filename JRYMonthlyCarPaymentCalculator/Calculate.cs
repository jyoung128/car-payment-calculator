using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRYMonthlyCarPaymentCalculator
{
    public class Calculate
    {

        private double loanAmount; //private = field //// public = property
        private int months; //field
        private double interestRate;

        public double PurchasePrice { get; set; }
        public double DownPayment { get; set; }

        public Calculate(double purchasePrice, double downPayment, int months, double interestRate)
        {
            this.loanAmount = purchasePrice - downPayment;
        }

        public double GetLoanAmount()
        {
            return loanAmount;
        }

        public double GetMonthlyPayment()
        {
            //calculation
            return MonthlyPayment;
        }
    }
}
