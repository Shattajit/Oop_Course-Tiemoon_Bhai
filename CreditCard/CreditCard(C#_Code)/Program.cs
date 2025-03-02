
public class Program{
    public static void Main(string[] args){

        CreditCrad creditCard = new CreditCrad("Shattajit", "12345");


        Console.WriteLine(creditCard.deposit(200000));
        Console.WriteLine(creditCard.withDrawals(20000));
        Console.WriteLine(creditCard.withDrawals(20000));
        Console.WriteLine(creditCard.withDrawals(20000));
        Console.WriteLine(creditCard.withDrawals(20000));
        Console.WriteLine(creditCard.withDrawals(20000));
        Console.WriteLine(creditCard.withDrawals(20000));
        Console.WriteLine(creditCard.getBalance());
    }
}