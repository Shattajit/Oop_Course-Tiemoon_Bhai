

public class CreditCrad 
{
    private string accountNo;
    private string accountName;
    private double balance;

    private double dailyLimit;
    private double totalSpending;

    private DateTime prevDate;
    private static double maxLimit = 500000;

    public CreditCrad(string accountName, string accountNo){
        this.accountName = accountName;
        this.accountNo = accountNo;
        this.balance = 0;
        this.dailyLimit = 0;

        this.totalSpending = 0;
        this.prevDate = DateTime.Now.Date;
    }

    public string getBalance(){
        return "Your current balance is: " + balance;
    }

    public string deposit(double amount){

        if(amount < 0){
            throw new Exception("amount must be positive");
        }

        if(amount + balance > maxLimit){
            throw new Exception("Limit crossed of your account. Please give less amount");
        }

        balance += amount;

        return amount + " is deposited to your account";
    }

    public string withDrawals(double amount){
        if(amount < 0){
            throw new Exception("amount must be positive");
        }

        if(amount > balance){
            throw new Exception("Insufficient balance");
        }

        if(amount > 20000){
            throw new Exception("Per transaction limit has crossed!");
        }

        DateTime currentDate = DateTime.Now.Date;

        if(currentDate == prevDate){

            if(dailyLimit + amount > 100000){
                throw new Exception(" Limit crossed for daily withdrawal!");
            }
        }

        if(totalSpending + amount > 500000){
            throw new Exception("toatal spending limit for your account has crossed. please give less amount");
        }

        balance -= amount;
        dailyLimit += amount;
        totalSpending += amount;

        return amount + " is withdrawed from your account.";
    }

}