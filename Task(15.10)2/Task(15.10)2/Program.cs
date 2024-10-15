namespace Task_15._10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Math", 10);
            Book book2 = new Book("Phsyics", 10);


            Library library1 = new Library("Library1");
            library1.AddBook(book1);
            library1.AddBook(book2);

            library1.SearchBook("Phsyics");
            library1.SearchBook("Math");

            library1.ShowAllBooks();
        }
    }

    class Book
    {
        public string Name;
        public double Price;

        public Book(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    class Library
    {
        public string Name;
        public Book[] Books;

        public Library(string name)
        {
            Name = name;
            Books = new Book[0];
        }


        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public void SearchBook(string name)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (name == Books[i].Name)
                {
                    Console.WriteLine($"Axtardiginiz kitab tapildi: {Books[i].Name}");
                }
            }
        }

        public void ShowAllBooks()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Console.WriteLine(Books[i].Name);
            }
        }

    }

}
