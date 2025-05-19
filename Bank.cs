using System;
using System.Collections.Generic;

public class Bank
{
    private List<Account> accounts = new List<Account>();
    private int nextAccNo = 100;

    public Account CreateAccount(string owner, string type)
    {
        Account acc = type.ToLower() switch
        {
            "savings" => new SavingsAccount(++nextAccNo, owner),
            "current" => new CurrentAccount(++nextAccNo, owner),
            _ => throw new ArgumentException("Invalid account type")
        };

        accounts.Add(acc);
        Console.WriteLine($"Account created. Account Number: {acc.AccountNumber}");
        return acc;
    }

    public Account GetAccount(int accNo)
    {
        return accounts.Find(a => a.AccountNumber == accNo);
    }

    public void ApplyInterestToAll()
    {
        foreach (var acc in accounts)
        {
            acc.ApplyInterest();
        }
    }

    public void ShowAllAccounts()
    {
        foreach (var acc in accounts)
        {
            acc.Display();
        }
    }
}
