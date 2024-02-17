using System;

class Program
{
    static void Main(string[] args)
    {
        Account myAccount = new Account("John Doe", 1000);
        myAccount.Deposit(500);
        myAccount.Withdraw(200);
        myAccount.DisplayBalance();

        Transaction transaction1 = new Transaction(DateTime.Now, -100, "Groceries");
        transaction1.DisplayTransaction();

        Budget myBudget = new Budget(2000);
        myBudget.AllocateBudget("Groceries", 300);
        myBudget.AllocateBudget("Utilities", 250);
        myBudget.DisplayBudget();
    }
}
