namespace Models
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    public class Employee : Person
    {
       
        public string Contract { get; set; }
    }

    public class Clients
    {

    }

    public struct Currency
    {
        public string Name { get; set; }
        public int Value { get; set; }

    }

}