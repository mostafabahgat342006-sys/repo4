namespace C__ass4;

internal class Program
{
    class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
    }

    static void Main(string[] args)
    {
        Book b1 = new Book();
        // error brcause -> private allowe use it in class Book only
        //Console.WriteLine(b.password);

        Console.WriteLine("---------------------------------");

        Book b2 = new Book();
        // will compile if within the saame project
        Console.WriteLine(b2.copiesInStock);

        Console.WriteLine("---------------------------------");





















    }
}
