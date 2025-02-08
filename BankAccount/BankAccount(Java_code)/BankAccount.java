
public class BankAccount {
    
    private String AccountNumber;
    private String AccountName;
    private double Balance;

    public BankAccount(String AccountNumber, String AccountName, double Balance){
        this.AccountNumber = AccountNumber;
        this.AccountName = AccountName;
        this.Balance = Balance;
    }

    public void Deposit(double amount){
        try {
            if(amount <= 0){
                throw new Exception("Amount must be greater than 0");
            }
            Balance += amount;
            System.out.println(amount + " has been deposited to your account");
            System.out.println("Your current balance is: " + Balance);

        } catch (Exception e) {
            System.out.println("Error in deposit: " + e.getMessage());
        }
    }

    public void Withdraw(double amount){
       try {
            if(amount <= 0){
                throw new Exception("Amount must be greater than 0");
            }
            else if(amount > Balance){
                throw new Exception("Amount must be less or equal to your balance");
            }
            else{
                Balance -= amount;
                System.out.println(amount + " has been withdrawn from your account");
                System.out.println("Your current balance is: " + Balance);
            }
       } catch (Exception e) {
            System.out.println("Error in withdraw: " + e.getMessage());
       }
    }

    public void Transfer(BankAccount AccountNumber, double amount){
        try {
            if(amount <= 0){
                throw new Exception("Amount must be greater than 0");
            }
            else if(amount > Balance){
                throw new Exception("Amount must be less or equal to your balance");
            }
            else{
                Balance -= amount;
                AccountNumber.Balance += amount;
                System.out.println(amount + " has been transferred to " + AccountNumber.AccountName);
                System.out.println("Your current balance is: " + Balance);
            }
        } catch (Exception e) {
            System.out.println("Error in transfer: " + e.getMessage());
        }
    }
}
