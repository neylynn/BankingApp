using System;

class Program
{
    static void Main()
    {
        Bank bank = new Bank();
        while (true)
        {
            Console.WriteLine("\n===== Banking System =====");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Show Account Balance");
            Console.WriteLine("5. Show All Accounts");
            Console.WriteLine("6. Show Transactions");
            Console.WriteLine("7. Apply Interest");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    Console.Write("Owner Name: ");
                    string owner = Console.ReadLine();
                    Console.Write("Account Type (Savings/Current): ");
                    string type = Console.ReadLine();
                    bank.CreateAccount(owner, type);
                    break;

                case "2":
                    DoTransaction(bank, "deposit");
                    break;

                case "3":
                    DoTransaction(bank, "withdraw");
                    break;

                case "4":
                    ShowBalance(bank);
                    break;

                case "5":
                    bank.ShowAllAccounts();
                    break;

                case "6":
                    ShowTransactions(bank);
                    break;

                case "7":
                    bank.ApplyInterestToAll();
                    Console.WriteLine("Interest applied to all savings accounts.");
                    break;

                case "0":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void DoTransaction(Bank bank, string action)
    {
        Console.Write("Account Number: ");
        int accNo = int.Parse(Console.ReadLine());
        Console.Write("Amount: ");
        double amount = double.Parse(Console.ReadLine());

        var acc = bank.GetAccount(accNo);
        if (acc == null)
        {
            Console.WriteLine("Account not found.");
            return;
        }

        if (action == "deposit")
            acc.Deposit(amount);
        else
            acc.Withdraw(amount);
    }

    static void ShowBalance(Bank bank)
    {
        Console.Write("Account Number: ");
        int accNo = int.Parse(Console.ReadLine());
        var acc = bank.GetAccount(accNo);
        if (acc != null)
            Console.WriteLine($"Balance: {acc.GetBalance()}");
        else
            Console.WriteLine("Account not found.");
    }

    static void ShowTransactions(Bank bank)
    {
        Console.Write("Account Number: ");
        int accNo = int.Parse(Console.ReadLine());
        var acc = bank.GetAccount(accNo);
        if (acc != null)
            acc.ShowTransactions();
        else
            Console.WriteLine("Account not found.");
    }
}
