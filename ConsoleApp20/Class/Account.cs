using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Class;

public class Account
{
    public IAccount AccountType { get; set; }

    public double Interest { get; set; } // Измените доступ к set на private

    public void ComputeInterest()
    {
        if (AccountType != null)
        {
            Interest = AccountType.CalculateInterest();
        }
    }
}
