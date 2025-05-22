
public class BankAccount
{
    private string accountNo;
    private string accountName;
    private double balance;

    public BankAccount(string accountNo, string accountName, double balance)
    {
        this.accountNo = accountNo;
        this.accountName = accountName;
        this.balance = balance;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void Deposit(double amount)
    {
        try
        {
            if (amount <= 0)
            {
                throw new Exception("Amount must be greater than zero!");
            }

            balance += amount;
            Console.WriteLine($"{amount} has been deposited to your account");
            Console.WriteLine($"Your current balance is: {balance}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error in deposit: " + e.Message);
        }
    }

    public void Withdraw(double amount)
    {
         try
        {
            if (amount <= 0)
            {
                throw new Exception("Amount must be greater than zero!");
            }

            if (amount > balance)
            {
                throw new Exception("Insufficient balance!");
            }

            balance -= amount;
            Console.WriteLine($"{amount} has been withdrawn from your account");
            Console.WriteLine($"Your current balance is: {balance}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error in withdrawal: " + e.Message);
        }
    }
}
