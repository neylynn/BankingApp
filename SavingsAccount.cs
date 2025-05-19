public class SavingsAccount : Account
{
    private const double InterestRate = 0.03; // 3%

    public SavingsAccount(int accNo, string owner) : base(accNo, owner) { }

    public override void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            transactions.Add(new Transaction($"Withdrawn {amount}"));
            Console.WriteLine($"Withdrawn {amount}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public override void ApplyInterest()
    {
        double interest = Balance * InterestRate;
        Balance += interest;
        transactions.Add(new Transaction($"Interest applied: {interest}"));
    }

    public override void Display()
    {
        Console.WriteLine($"[Savings] {OwnerName} - Acc#: {AccountNumber} - Balance: {Balance}");
    }
}
