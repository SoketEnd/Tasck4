using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp20.Class
{
    public class RegularAccount : IAccount
    {
        public double Balance { get; set; }
        public double CalculateInterest()
        {
            double interest = Balance * 0.4;
            if (Balance < 1000)
                interest -= Balance * 0.2;
            else if (Balance < 2000)
                interest -= Balance * 0.4;

            return interest;
        }
    }
}