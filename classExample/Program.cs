public class Sample
{
    static void Main()
    {
        //reference variables
        Customer c1, c2;

        //objects
        c1 = new Customer();
        c1.CustomerID = "1";
        c1.CustomerName = "holi";
        Console.WriteLine($"{c1.CustomerID} {c1.CustomerName}");
        c2 = new Customer();
    }
}