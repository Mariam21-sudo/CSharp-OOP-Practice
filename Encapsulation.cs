using System;

class BankAccount
{
    private decimal _balance;

    public decimal Balance
    {
        get { return _balance; }
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount.");
        }
        else if (amount > _balance)
        {
            Console.WriteLine("Insufficient balance.");
        }
        else
        {
            _balance -= amount;
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.Deposit(1000);
        account.Withdraw(200);
        account.Deposit(-50);
        account.Withdraw(2000);

        Console.WriteLine("Balance: " + account.Balance);
    }
}
