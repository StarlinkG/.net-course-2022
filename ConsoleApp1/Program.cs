using Models;

public class Program
{
    static void Main(string[] args)
    {

        var currency = new Currency { WalletName = "Dollars", WalletValue = 687 };
        ChangeWallet(ref currency, "Euro", 666);
        Console.WriteLine($"{currency.WalletValue}{currency.WalletName}");


        var employee1 = new Employee { FirstName = "Elon", LastName = "Musk" };

        employee1.Contract = UpdateContract(employee1.FirstName, employee1.LastName, employee1.Contract);
        Console.WriteLine(employee1.Contract);

    }
    static string UpdateContract(string FirstName, string LastName, string Contract)

    {

        return Contract = ($"{FirstName} {LastName} was invited for 2 years");

    }

    public static void ChangeWallet(ref Currency currency, string NewName, int NewValue)
    {
        currency.WalletName = NewName;
        currency.WalletValue = NewValue;
        NewName = "Euro";
        NewValue = 666;



    }
}