/* Jonah Young
 * C# Programming 1
 * Assignment 4: Monthly Payment Calculator
 * 10/17/2020
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRYMonthlyCarPaymentCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MonthlyPaymentCalculator());
        }
    }
}
