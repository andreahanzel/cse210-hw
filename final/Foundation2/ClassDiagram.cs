/*
+---------------------------+
|          Account          |
+---------------------------+
| - balance: decimal (private) |
| - accountName: string (private)|
+---------------------------+
| + Deposit(decimal): void  |
| + Withdraw(decimal): void |
| + DisplayBalance(): void  |
+---------------------------+
                |
+---------------------------+
|         Transaction       |
+---------------------------+
| - date: DateTime (private)|
| - amount: decimal (private)|
| - description: string (private)|
+---------------------------+
| + DisplayTransaction(): void |
+---------------------------+
                |
+---------------------------+
|           Budget          |
+---------------------------+
| - totalBudget: decimal (private)|
| - categories: Dictionary<string, decimal> (private)|
+---------------------------+
| + AllocateBudget(string, decimal): void |
| + DisplayBudget(): void   |
+---------------------------+
*/
