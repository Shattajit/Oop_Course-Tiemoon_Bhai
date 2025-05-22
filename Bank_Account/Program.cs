

BankAccount account1 = new BankAccount("1231", "abcd", 200);
BankAccount account2 = new BankAccount("1234", "abce", 300);
BankAccount account3 = new BankAccount("1235", "abcf", 400);
BankAccount account4 = new BankAccount("1236", "abcg", 500);

Bank bank = new Bank();

bank.AddAccount(account1); 
bank.AddAccount(account2); 
bank.AddAccount(account3);
bank.AddAccount(account4);

Console.WriteLine(bank.GetTotalBalance());

account4.Withdraw(500);

Console.WriteLine(bank.GetTotalBalance());

