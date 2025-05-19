public class CurrentAccount : Account
{
    public CurrentAccount(int accNo, string owner) : base(accNo, owner) { }

    public override void Withdraw(double amount)
    {
        Balance -= amount;
        transactions.Add(new Transaction($"Withdrawn {amount}"));
        Console.WriteLine($"Withdrawn {amount}. New Balance: {Balance}");
    }

    public override void Display()
    {
        Console.WriteLine($"[Current] {OwnerName} - Acc#: {AccountNumber} - Balance: {Balance}");
    }
}
