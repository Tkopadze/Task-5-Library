using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Linq;


class Book
{
    string title;
    string author;
    string isbn;
    int copiesAvailable;


    public Book(string title, string author, string isbn, int copiesAvailable)
    {
        this.title = title;
        this.author = author;
        this.isbn = isbn;
        this.copiesAvailable = copiesAvailable;

    }
    public string _title
    {
        get { return title; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                title = value;
            }
            else
            {
                Console.WriteLine("სახელის ველი არ უნდა იყოს ცარიელი");
            }
        }


    }
    public string _author
    {
        get { return author; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                author = value;
            }
            else
            {
                Console.WriteLine("ავტორის ველი არ უნდა იყოს ცარიელი");
            }
        }
    }
    public string _isbn
    {
        set
        {
            if (!string.IsNullOrEmpty(value) && value.Length <= 13)
            {
                isbn = value;
            }
            else
            {
                Console.WriteLine("არავალიდური ISBN მნიშვნელობა, სცადეთ თავიდან");
            }
        }
    }
    public int _copiesAvailable
    {
        get { return copiesAvailable; }
        set
        {
            if (copiesAvailable > 0)

            {
                copiesAvailable = value;
            }
            else
            {
                Console.WriteLine("წიგნი არ არის მარაგში");
            }
        }
    }


    void DisplayInfo()
    {
        Console.WriteLine($"წიგნის სახელი: {_title}");
        Console.WriteLine($"წიგნის ავტორი: {_author}");
        Console.WriteLine($"წიგნის ISBN:  {isbn}");
        Console.WriteLine($"წიგნის რაოდენობა მარაგში:  {_copiesAvailable}");
    }
    public void BorrowBook()
    {
        Console.WriteLine($"რომელი წიგნის აღება გსურთ? {_title}");
        var bookToBorrow = Console.ReadLine();
        if (copiesAvailable > 0)
        {
            Console.WriteLine("შეგიძლიათ აიღოთ წიგნი.");
            copiesAvailable--;

        }
        else
        {
            Console.WriteLine("წიგნი არ არის მარაგში.")
        }

    }

    public void ReturnBook()
    {
        Console.WriteLine("რომელი წიგნის დაბრუნება გსურთ?");
        var bookToReturn = Console.ReadLine();
        if (bookToReturn == title)
        {
            Console.WriteLine($"წიგნი წარმატებით დაბრუნდა, ამჟამად მარაგში არის: {copiesAvailable} {bookToReturn}");
            copiesAvailable++;
        }
        else
        {
            Console.WriteLine("წიგნი არ შეგიძლიათ დაბრუნება, რადგან მარაგში უკვე არის 10 ეგზემპლარი.");
        }
    }
}
class library
{
    private Book[] books= new Book[100];
    int bookCount = 0;
   

    void AddBooks(Book book)
    {
        Console.WriteLine("შეიყვანეთ წიგნის სახელი");
        var bookToAdd = Console.ReadLine();
        Console.WriteLine("შეიყვანეთ წიგნის ავტორი");
        var AuthorToAdd = Console.ReadLine();
        Console.WriteLine("შეიყვანეთ წიგნის ISBN");
        var ISBNToAdd = Console.ReadLine();
        Console.WriteLine("შეიყვანეთ წიგნის რაოდენობა");
        int copiesToAdd = int.Parse(Console.ReadLine());
    }
    void RemoveBooks()
    {
        Console.WriteLine("შეიყვანეთ წიგნის სახელი რომლის წაშლაც გსურთ: ");
        var bookToRemove = Console.ReadLine();
    }
    void DisplayAllBooks()
    {
        Console.WriteLine("ამ ეტაპზე ბიბილიოთეკაში არსებული წიგნების სია:");
    }
    void SearchForBooks()
    {
        Console.WriteLine("შეიყვანეთ წიგნის სახელი რომლის მოძებნა გსურთ:");
        var bookToSearchFor = Console.ReadLine();
    }
    static void Main()
    {
        Console.WriteLine("მოგესალმებით, აირჩიეთ სასურველი ქმედება: ");
        library library = new library();
       
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("1. წიგნის გატანა:");
            Console.WriteLine("2. წიგნის დაბრუნება: ");
            Console.WriteLine("3. წიგნის დამატება: ");
            Console.WriteLine("4. წიგნის წაშლა: ");
            Console.WriteLine("5. ყველა წიგნის ნახვა: ");
            Console.WriteLine("6. წიგნის მოძებნა: ");
            Console.WriteLine("7. გამოსვლა: ");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    book[i].BorrowBook();
                    break;
                case "2":
                    ReturnBook();
                    break;
                case "3":
                    library.Book.AddBooks();
                    break;
                case "4":
                    library.RemoveBooks();
                    break;
                case "5":
                    library.DisplayAllBooks();
                    break;
                case "6":
                    library.SearchForBooks();
                    break;
                case "7":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("არავალიდური არჩევანი, გთხოვთ ისევ სცადოთ.");
                    break;
            }
        }

        Console.WriteLine("პროგრამა დასრულდა.");
    }
}