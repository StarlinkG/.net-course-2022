using Models;

public class Program
{
    static void Main(string[] args)
    {

        var currency = new Currency { Name = "USD", Value = 687 };
        RenameWallet(ref currency, "EUR", 666);
        Console.WriteLine($"{currency.Value}{currency.Name}");


        var employee = new Employee { FirstName = "Elon", LastName = "Musk" };

        employee.Contract = CreateContract(employee.FirstName, employee.LastName);
        Console.WriteLine(employee.Contract);

    }
    static string CreateContract(string firstname, string lastname)

    {
       
       return ($"{firstname} {lastname} was invited for 2 years");

    }

    public static void RenameWallet(ref Currency currency, string NewName, int NewValue)
    {
        currency.Name = NewName;
        currency.Value = NewValue;
        



    }
}