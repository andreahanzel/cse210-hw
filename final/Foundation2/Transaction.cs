using System;

public class Transaction
{
    private DateTime date;
    private decimal amount;
    private string description;

    public Transaction(DateTime date, decimal amount, string description)
    {
        this.date = date;
        this.amount = amount;
        this.description = description;
    }

    public void DisplayTransaction()
    {
        Console.WriteLine($"{date.ToShortDateString()} - {description}: {amount}");
    }
}
