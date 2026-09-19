namespace C__ass4;

internal class Program
{
    class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string Title;
       
        public Genre Genre { get; set; }
        


    }

    enum Genre
    {
        Fiction,
        NonFiction,
        Science
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

        Book b3 = new Book();

        b3.Title = "Clean Code";

        Console.WriteLine(b3.Title);

        Console.WriteLine("---------------------------------");

        Book b4 = new Book();

        b4.Genre = Genre.Science;  

        Console.WriteLine(b4.Genre);

        Console.WriteLine("---------------------------------");
























    }
}
