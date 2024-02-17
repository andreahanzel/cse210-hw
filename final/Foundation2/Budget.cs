using System;
using System.Collections.Generic;

public class Budget
{
    private decimal totalBudget;
    private Dictionary<string, decimal> categories = new Dictionary<string, decimal>();

    public Budget(decimal totalBudget)
    {
        this.totalBudget = totalBudget;
    }

    public void AllocateBudget(string category, decimal amount)
    {
        if (categories.ContainsKey(category))
        {
            categories[category] += amount;
        }
        else
        {
            categories.Add(category, amount);
        }
    }

    public void DisplayBudget()
    {
        Console.WriteLine($"Total Budget: {totalBudget}");
        foreach (var category in categories)
        {
            Console.WriteLine($"{category.Key}: {category.Value}");
        }
    }
}
