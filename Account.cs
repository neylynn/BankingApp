using System;
using System.Collections.Generic;

public abstract class Account
{
    public int AccountNumber { get; }
    public string OwnerName { get; }
    protected double Balance;
    protected List<Transaction> transactions = new List<Transaction>();

    public Account(int accNo, string owner)
    {
        AccountNumber = accNo;
        OwnerName = owner;
        Balance = 0;
        transactions.Add(new Transaction("Account created"));
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        transactions.Add(new Transaction($"Deposited {amount}"));
        Console.WriteLine($"Deposited {amount}. New Balance: {Balance}");
    }

    public abstract void Withdraw(double amount);
    public abstract void Display();

    public void ShowTransactions()
    {
        Console.WriteLine($"Transaction history for account {AccountNumber}:");
        foreach (var t in transactions)
        {
            Console.WriteLine(t);
        }
    }

    public double GetBalance() => Balance;

    public virtual void ApplyInterest() { }
}
