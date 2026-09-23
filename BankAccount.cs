using System;

class BankAccount
{
    private string accountNumber;
    private string holderName;
    private double balance;

    public BankAccount(string accountNumber, string holderName, double balance)
    {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Amount Deposited: " + amount);
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Amount Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Holder Name: " + holderName);
        Console.WriteLine("Balance: " + balance);
    }

    static void Main()
    {
        BankAccount account = new BankAccount("ACC101", "Jitendra", 10000);

        account.DisplayDetails();
        account.Deposit(5000);
        account.Withdraw(2000);
        account.DisplayDetails();
    }
}
