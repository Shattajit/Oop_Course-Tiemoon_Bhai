#include <iostream>
#include <string>
#include <stdexcept>

using namespace std;

class BankAccount {
private:
    string AccountNumber;
    string AccountName;
    double Balance;

public:
    // Constructor
    BankAccount(string AccountNumber, string AccountName, double Balance) {
        this->AccountNumber = AccountNumber;
        this->AccountName = AccountName;
        this->Balance = Balance;
    }

    // Deposit Method
    void Deposit(double amount) {
        try {
            if (amount <= 0) {
                throw invalid_argument("Amount must be greater than 0");
            }
            Balance += amount;
            cout << amount << " has been deposited to your account" << endl;
            cout << "Your current balance is: " << Balance << endl;
        }
        catch (const exception& e) {
            cout << "Error in deposit: " << e.what() << endl;
        }
    }

    // Withdraw Method
    void Withdraw(double amount) {
        try {
            if (amount <= 0) {
                throw invalid_argument("Amount must be greater than 0");
            }
            else if (amount > Balance) {
                throw invalid_argument("Amount must be less or equal to your balance");
            }
            else {
                Balance -= amount;
                cout << amount << " has been withdrawn from your account" << endl;
                cout << "Your current balance is: " << Balance << endl;
            }
        }
        catch (const exception& e) {
            cout << "Error in withdraw: " << e.what() << endl;
        }
    }

    // Transfer Method
    void Transfer(BankAccount& AccountNumber, double amount) {
        try {
            if (amount <= 0) {
                throw invalid_argument("Amount must be greater than 0");
            }
            else if (amount > Balance) {
                throw invalid_argument("Amount must be less or equal to your balance");
            }
            else {
                Balance -= amount;
                AccountNumber.Balance += amount;
                cout << amount << " has been transferred to " << AccountNumber.AccountName << endl;
                cout << "Your current balance is: " << Balance << endl;
            }
        }
        catch (const exception& e) {
            cout << "Error in transfer: " << e.what() << endl;
        }
    }
};

int main() {
    // Create bank account objects
    BankAccount account1("1234567890", "John Doe", 1000.0);
    BankAccount account2("0987654321", "Jane Doe", 500.0);

    // Test the methods
    account1.Deposit(200);
    account1.Withdraw(100);
    account1.Transfer(account2, 150);

    return 0;
}
