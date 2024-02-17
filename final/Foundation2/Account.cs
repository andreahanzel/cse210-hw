public class Account
{
    private decimal balance;
    private string accountName;

    public Account(string name, decimal initialBalance)
    {
        accountName = name;
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            System.Console.WriteLine("Insufficient funds.");
        }
    }

    public void DisplayBalance()
    {
        System.Console.WriteLine($"{accountName} Balance: {balance}");
    }
}
