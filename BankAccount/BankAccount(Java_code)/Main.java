
public class Main {
    public static void main(String[] args) {
        BankAccount account1 = new BankAccount("1234567890", "John Doe", 1000);
        BankAccount account2 = new BankAccount("0987654321", "Jane Doe", 500);

        account1.Deposit(500);
        account1.Withdraw(200);
        account1.Transfer(account2, 300);
    }
}
