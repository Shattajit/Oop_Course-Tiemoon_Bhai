public class Bank
{
    private List<BankAccount> accounts = new List<BankAccount>();

    public void AddAccount(BankAccount account)
    {
        accounts.Add(account);
    }

    public double GetTotalBalance()
    {
        double tot = 0;

        foreach(BankAccount account in accounts)
        {
            tot += account.GetBalance();
        }

        return tot;
    }
}