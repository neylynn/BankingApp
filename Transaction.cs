public class Transaction
{
    public DateTime Time { get; }
    public string Description { get; }

    public Transaction(string desc)
    {
        Time = DateTime.Now;
        Description = desc;
    }

    public override string ToString()
    {
        return $"{Time:G} - {Description}";
    }
}
