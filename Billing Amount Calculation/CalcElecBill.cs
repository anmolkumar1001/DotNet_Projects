using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcElecBill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            cal.GetUnits();
            cal.DisplayBill();

            Console.ReadLine();
        }
    }

    public class Calculate
    {
        private int units;

        public void GetUnits()
        {
            Console.Write("Enter the number of units consumed: ");
            units = Convert.ToInt32(Console.ReadLine());
        }

        public double CalculateAmount()
        {
            double amount = 0;

            if (units <= 100)
            {
                amount = units * 60;
            }
            else if (units <= 200)
            {
                amount = 100 * 60 + (units - 100) * 60;
            }
            else if (units <= 300)
            {
                amount = 100 * 60 + 100 * 80 + (units - 200) * 90;
            }
            else
            {
                amount = 5000;
            }

            return amount;
        }

        public void DisplayBill()
        {
            Console.WriteLine("Number of units Consumed: " + units);
            Console.WriteLine("Total Amount: Rs. " + CalculateAmount());
        }
    }
}
