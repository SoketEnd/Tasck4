using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Class;

public static class Calculator
{
    public static void CalculateInterest(Account account)
    {
        if (account.AccountType != null)
        {
            account.Interest = account.AccountType.CalculateInterest();
        }
    }
}