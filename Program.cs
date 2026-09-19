namespace C__ass4;

internal class Program
{
    class Book
    {
        private string password = "secret";
    }

    static void Main(string[] args)
    {
        Book b = new Book();
        // error brcause -> private allowe use it in class Book only
        Console.WriteLine(b.password);



















    }
}
