import java.time.LocalDate;

public class CreditCard {
    private String accountNumber;
    private String accountName;
    private double balance;
    private double perDayTransaction;
    private double perTransaction;
    private LocalDate lastWithdrawalDate;
    private double totalBillPaid; 


    public CreditCard(String accountNumber, String accountName){
        this.accountNumber = accountNumber;
        this.accountName = accountName;
        balance = 0;
        perDayTransaction = 0;
        perTransaction = 0;
        lastWithdrawalDate = LocalDate.now();
        totalBillPaid = 0;
    }

    public void isAmountDepositableOrWitdrawable(double amount) throws Exception {
        if(amount <= 0){
            throw new Exception("Amount must be greater than 0");
        }
        if(amount > 20000){
            throw new Exception("Per transaction limit has been crossed!");
        }
    }

    public void currentBalance(){
        System.out.println("Your current balance is: " + balance);
    }

    public void deposit(double amount){
        try {
            try {
                isAmountDepositableOrWitdrawable(amount);
            } catch (Exception e) {
                System.out.println("Error in isAmountDepositableOrWitdrawable: "+ e.getMessage());
                e.printStackTrace();
                return;
            }

            if(balance + amount > 500000){
                throw new Exception("Account limit has crosssed. So please give fewer amount!");
            }
            else{
                balance += amount;
                System.out.println(amount + " has been deposited successfully to your account");
                currentBalance();
            }
            
        } catch (Exception e) {
            System.out.println("Error in deposit: "+ e.getMessage());
        }
    }

    public void perDayTransaction(double amount){
        try {
            if(perDayTransaction + amount > 100000){
              throw new Exception("Perday transaction limit has crossed!");
            }
            else if(totalBillPaid + amount > 500000){
                throw new Exception("Total spending limit has crossed!");
            }
            else{
                perDayTransaction += amount;
                balance -= amount;
                totalBillPaid += amount;
                System.out.println("Withdrawal successful");
                currentBalance();
            }
        } catch (Exception e) {
            System.out.println("Error in perDayTransaction: " + e.getMessage());
        }
    }

    public void withDraw(double amount){
        try {
              try {
                isAmountDepositableOrWitdrawable(amount);
            } catch (Exception e) {
                System.out.println("Error in isAmountDepositableOrWitdrawable: "+ e.getMessage());
                e.printStackTrace();
                return;
            }

            if(amount > balance){
                throw new Exception("Insufficient balance");
            }
            else{
                LocalDate todayDate = LocalDate.now();

                if(todayDate == lastWithdrawalDate){
                    try {
                        perDayTransaction(amount);
                    } catch (Exception e) {
                        System.out.println("Error in perDayTransaction: "+ e.getMessage());
                        e.printStackTrace();
                        return;
                    }
                }
                else{

                    perDayTransaction = 0;
                     try {
                        perDayTransaction(amount);
                    } catch (Exception e) {
                        System.out.println("Error in perDayTransaction: "+ e.getMessage());
                        e.printStackTrace();
                        return;
                    }
                }
            }
        } catch (Exception e) {
            System.out.println("Error in withdraw: " + e.getMessage());
            e.printStackTrace();
        }
    }
}
