using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp20.Class
{
    internal class SalaryAccount : IAccount
    {
        public double Balance { get; set; }
        public double CalculateInterest()
        {
            return Balance *= 0.5;
        }
    }
}