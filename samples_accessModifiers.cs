using System;

class BankAccount
{
    // Public property
    public string AccountNumber { get; set; }

    // Private field
    private decimal balance;

    // Constructor
    public BankAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        balance = initialBalance;
    }

    // Public method to deposit money
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    // Protected method
    protected decimal CalculateInterest(decimal interestRate)
    {
        return balance * interestRate / 100;
    }

    // Public method to display balance
    public void DisplayBalance()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Balance: ₦{balance:N2}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("BA001", 100000);

        Console.WriteLine($"Account Number: {account.AccountNumber}");

        account.Deposit(50000);

        account.DisplayBalance();

        // The following is NOT allowed because balance is private:
        // Console.WriteLine(account.balance);

        // The following is NOT allowed because CalculateInterest()
        // is protected:
        // account.CalculateInterest(5);
    }
}


class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, decimal balance)
        : base(accountNumber, balance)
    {
    }

    public void ShowInterest()
    {
        decimal interest = CalculateInterest(5);
        Console.WriteLine($"Interest: ₦{interest:N2}");
    }
}