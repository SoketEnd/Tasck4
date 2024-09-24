using ConsoleApp20.Class;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegularAccount regularAccount = new RegularAccount { Balance = 800 };
            Account account1 = new Account { AccountType = regularAccount };
            account1.ComputeInterest();
            Console.WriteLine($"Обычный аккаунт - Процент: {account1.Interest}");

            // Создание зарплатного аккаунта
            SalaryAccount salaryAccount = new SalaryAccount { Balance = 1500 };
            Account account2 = new Account { AccountType = salaryAccount };
            account2.ComputeInterest();
            Console.WriteLine($"Зарплатный аккаунт - Процент: {account2.Interest}");

            // Проверка с неизвестным типом
            Account unknownAccount = new Account { AccountType = null };
            unknownAccount.ComputeInterest(); // Выводит сообщение об ошибке
        }
    }
}
