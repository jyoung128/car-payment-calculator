/* Jonah Young
 * C# Programming 1
 * Assignment 4: Monthly Payment Calculator
 * 10/17/2020
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRYMonthlyCarPaymentCalculator
{
    public partial class MonthlyPaymentCalculator : Form
    {
        public MonthlyPaymentCalculator()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            bool validPurchasePrice = Double.TryParse(PurchasePriceTB.Text, out double purchasePrice);
            bool validDownPayment = Double.TryParse(DownPaymentTB.Text, out double downPayment);
            bool validAnnualInterest = Decimal.TryParse(AnnualInterestTB.Text, out decimal annualInterest);
            bool validLoanLength = Double.TryParse(LoanLengthTB.Text, out double loanLength);
            double amountToFinance;
            double monthlyPayment;

            if (PurchasePriceTB.Text == "")
            {
                MessageBox.Show("Please enter a purchase price", "Input Left Empty");

            } else if (validPurchasePrice != true)
            {
                MessageBox.Show("Please enter a valid purchase price", "Invalid Input");
            }

            if (DownPaymentTB.Text == "")
            {
                downPayment = 0;
                validDownPayment = true;
            }
            else if (validDownPayment != true || downPayment > purchasePrice)
            {
                MessageBox.Show("Please enter a valid down payment", "Invalid Input");
            }

            if (AnnualInterestTB.Text == "")
            {
                MessageBox.Show("Please enter an annual interest rate", "Input Left Empty");
            }
            else if (validAnnualInterest != true)
            {
                MessageBox.Show("Please enter a valid annual interest rate", "Invalid Input");
            }

            if (LoanLengthTB.Text == "")
            {
                MessageBox.Show("Please enter a loan length", "Input Left Empty");
            }
            else if (validLoanLength != true)
            {
                MessageBox.Show("Please enter a valid loan length", "Invalid Input");
            }

            if (validPurchasePrice && validDownPayment && validAnnualInterest && validLoanLength) {

                decimal monthlyInterest = (annualInterest / 100) / 12;

                if (downPayment > 0) {

                  amountToFinance = purchasePrice - downPayment;

                } 
                else
                {
                    amountToFinance = purchasePrice;
                }

                monthlyPayment = (double)monthlyInterest * amountToFinance * (Math.Pow((double)(1 + monthlyInterest), loanLength) / (Math.Pow((double)(1 + monthlyInterest), loanLength) - 1));

                AmountToFinanceTB.Text = "$" + String.Format("{0:n}", amountToFinance);
                MonthlyPaymentTB.Text = "$" + String.Format("{0:n}", monthlyPayment);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
