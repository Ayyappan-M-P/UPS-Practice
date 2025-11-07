// // // using System;
// // // public class Practice1
// // // {
// // //     public record Point(int X, int Y);
// // //     public static void Main()
// // //     {
// // //         String s="gamers";
// // //         Console.WriteLine ("Hello"+s);
// // //         s="coders";
// // //         Console.WriteLine($"Hello {s}");
// // //         Console.WriteLine(s.Length);
// // //         String st="    Hello World      ";
// // //         Console.WriteLine($"start{st}end");
// // //         String trimst=st.TrimStart();
// // //         Console.WriteLine($"start{trimst}end");
// // //         trimst=st.TrimEnd();
// // //         Console.WriteLine($"start{trimst}end");
// // //         trimst=st.Trim();
// // //         Console.WriteLine($"start{trimst}end");
// // //         s=s.Replace("coders","Hackers");
// // //         Console.WriteLine($"Hello {s}");
// // //         Console.WriteLine(s.ToLower());
// // //         Console.WriteLine(s.ToUpper());
// // //         String sb="Hello I am a Developer";
// // //         Console.WriteLine(sb.Contains("not"));
// // //         Console.WriteLine(sb.StartsWith("Hello"));
// // //         Console.WriteLine(sb.EndsWith("Developer"));
// // //         int max=int.MaxValue;
// // //         int min=int.MinValue;
// // //         Console.WriteLine($"min {min} max {max}");
// // //         double a = 19;
// // //         double b = 23;
// // //         double c = 8;
// // //         double d = (a + b) / c;
// // //         Console.WriteLine(d);
// // //         double maxi = double.MaxValue;
// // //         double mini = double.MinValue;
// // //         Console.WriteLine($"The range of double is {mini} to {maxi}");
// // //         decimal minimum = decimal.MinValue;
// // //         decimal maximum = decimal.MaxValue;
// // //         Console.WriteLine($"The range of the decimal type is {minimum} to {maximum}");
// // //         double aa = 1.0;
// // //         double bb = 3.0;
// // //         Console.WriteLine(aa / bb);

// // //         decimal cc = 1.0M;
// // //         decimal dd = 3.0M;
// // //         Console.WriteLine(cc / dd);

// // //         double radius=2.50;
// // //         double area=radius*radius*Math.PI;
// // //         Console.WriteLine($"Circle {area} and {Math.PI}");

// // //         Point p1=new Point(2,3);
// // //         Console.WriteLine(p1);
// // //         var p2=p1 with {Y=4};
// // //         Console.WriteLine(p2);

// // //         if(p1==p2)

// // //             Console.WriteLine("Equal");

// // //         else

// // //             Console.WriteLine("Not Equal");

// // //         int count = 0;
// // //         while (count < 10)
// // //         {
// // //             Console.WriteLine(count);
// // //             count++;
// // //         }

// // //         do
// // //         {
// // //             Console.WriteLine(count);
// // //             count++;
// // //         } while (count < 15);

// // //         for(int i = 0; i < 5; i++)
// // //         {
// // //             Console.WriteLine(i);
// // //         }

// // //     }
// // // }

// // using System;
// // public class Practice1
// // {
// //     public record Point(int X, int Y);
// //     public static void Main()
// //     {
// //         String s="gamers";
// //         Console.WriteLine ("Hello"+s);
// //         s="coders";
// //         Console.WriteLine($"Hello {s}");
// //         Console.WriteLine(s.Length);
// //         String st="    Hello World      ";
// //         Console.WriteLine($"start{st}end");
// //         String trimst=st.TrimStart();
// //         Console.WriteLine($"start{trimst}end");
// //         trimst=st.TrimEnd();
// //         Console.WriteLine($"start{trimst}end");
// //         trimst=st.Trim();
// //         Console.WriteLine($"start{trimst}end");
// //         s=s.Replace("coders","Hackers");
// //         Console.WriteLine($"Hello {s}");
// //         Console.WriteLine(s.ToLower());
// //         Console.WriteLine(s.ToUpper());
// //         String sb="Hello I am a Developer";
// //         Console.WriteLine(sb.Contains("not"));
// //         Console.WriteLine(sb.StartsWith("Hello"));
// //         Console.WriteLine(sb.EndsWith("Developer"));
// //         int max=int.MaxValue;
// //         int min=int.MinValue;
// //         Console.WriteLine($"min {min} max {max}");
// //         double a = 19;
// //         double b = 23;
// //         double c = 8;
// //         double d = (a + b) / c;
// //         Console.WriteLine(d);
// //         double maxi = double.MaxValue;
// //         double mini = double.MinValue;
// //         Console.WriteLine($"The range of double is {mini} to {maxi}");
// //         decimal minimum = decimal.MinValue;
// //         decimal maximum = decimal.MaxValue;
// //         Console.WriteLine($"The range of the decimal type is {minimum} to {maximum}");
// //         double aa = 1.0;
// //         double bb = 3.0;
// //         Console.WriteLine(aa / bb);

// //         decimal cc = 1.0M;
// //         decimal dd = 3.0M;
// //         Console.WriteLine(cc / dd);

// //         double radius=2.50;
// //         double area=radius*radius*Math.PI;
// //         Console.WriteLine($"Circle {area} and {Math.PI}");

// //         Point p1=new Point(2,3);
// //         Console.WriteLine(p1);
// //         var p2=p1 with {Y=4};
// //         Console.WriteLine(p2);

// //         String n= Console.ReadLine();
// //         Console.WriteLine(n);
// //         //changes

// //         int first=1;
// //         double second = 1.07;
// //         Console.WriteLine(first.GetType());
// //         Console.WriteLine(second.GetType());

// //         int input = Convert.ToInt32(Console.ReadLine());
// //         Console.WriteLine(input);
// //         /*
// //         Convert.ToInt32
// //         Convert.ToDouble
// //         Convert.ToString
// //         Convert.ToBoolean
// //         */

// //         //Math
// //         Console.WriteLine(Math.Abs(-40));
// //         Console.WriteLine(Math.Ceiling(4.2));
// //         Console.WriteLine(Math.Floor(4.9));
// //         Console.WriteLine(Math.Max(4, 9));
// //         Console.WriteLine(Math.Min(4, 9));
// //         Console.WriteLine(Math.Pow(3, 4));
// //         Console.WriteLine(Math.Round(4.6));
// //         Console.WriteLine(Math.Sqrt(64));
// //         Console.WriteLine(Math.PI);
// //         Console.WriteLine(Math.E);

// //         //Random
// //         Random random = new Random();
// //         Console.WriteLine(random.Next());
// //         Console.WriteLine(random.Next(1, 7));
// //         Console.WriteLine(random.NextDouble());


// //         //Hypothesis
// //         Console.WriteLine("Enter side A: ");
// //         double x = Convert.ToDouble(Console.ReadLine());

// //         Console.WriteLine("Enter side B: ");
// //         double y = Convert.ToDouble(Console.ReadLine());

// //         double z = Math.Sqrt((x * x) + (y * y));

// //         Console.WriteLine("The hypotenuse is: " + z);

// //         //string interpolation
// //         string name = "John";
// //         //string insert
// //         string newname = name.Insert(0, "Hello ");
// //         Console.WriteLine(newname);

// //         //substring
// //         string substr = newname.Substring(0, 5);
// //         Console.WriteLine(substr);
// //     }
// // }



// public class Book
// {
//     public string Title { get; set; }
//     public string Author { get; set; }
//     public string ISBN { get; set; }

//     public Book(string title, string author, string isbn)
//     {
//         Title = title;
//         Author = author;
//         ISBN = isbn;
//     }
// }

// public class Library
// {
//     private List<Book> books = new List<Book>();

//     public void AddBook(Book book)
//     {
//         books.Add(book);
//         Console.WriteLine(" Book added successfully");
//     }

//     public void RemoveBook(string isbn)
//     {
//         Book removeBook = books.FirstOrDefault(b => b.ISBN == isbn);
//         if (removeBook != null)
//         {
//             books.Remove(removeBook);
//             Console.WriteLine("Book removed successfully");
//         }
//         else
//         {
//             Console.WriteLine("Book not found.");
//         }
//     }

//     public void FindBook(string title) 
//     {
//         Book findBook = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
//         if (findBook != null)
//         {
//             Console.WriteLine($"Book found: {findBook.Title} by {findBook.Author}, ISBN: {findBook.ISBN}");
//         }
//         else
//         {
//             Console.WriteLine("Book not found.");
//         }
//     }

//     public void DisplayBooks() 
//     {
//         if (books.Count == 0)
//         {
//             Console.WriteLine("No books in the library.");
//         }
//         else
//         {
//             Console.WriteLine("\nBooks in the Library:");
//             foreach (Book book in books)
//             {
//                 Console.WriteLine($"Title:{book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
//             }
//         }
//     }
// }

// public class Practice1
// {
//     public static void Main()
//     {
//         Library library = new Library();

//         Book book1 = new Book("A", "Author A", "1234");
//         Book book2 = new Book("B", "Author B", "5678");

//         library.AddBook(book1);
//         library.AddBook(book2);

//         library.DisplayBooks();

//         library.FindBook("B");

//         library.RemoveBook("5678");

//         library.DisplayBooks();
//     }
// }

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }
}

public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Books add successfully");
    }

    public void Removebook(string isbn)
    {
        Book removebook = books.FirstOrDefault(b => b.ISBN == isbn);
        if (removebook != null)
        {
            books.Remove(removebook);
            Console.WriteLine("Book removed successfully");
        }
        else
        {
            Console.WriteLine("Book not found");
        }
    }

    public void Findbook(string title)
    {
        Book findbook = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (findbook != null)
        {
            Console.WriteLine($"Book found: {findbook.Title} by {findbook.Author}, ISBN: {findbook.ISBN}");
        }
        else
        {
            Console.WriteLine("Book not found");
        }
    }

    public void Displaybooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books in the library.");
        }
        else
        {
            Console.WriteLine("Books in the library:");
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author}, ISBN: {book.ISBN}");
            }
        }
    }

}

public class Practice1
{
    public static void Main()
    {
        Library library = new Library();

        Book book1 = new Book("A","Author A","1234");
        Book book2 = new Book("B","Author B","5678");
        

        library.AddBook(book1);
        library.AddBook(book2);
        

        library.Displaybooks();

        library.Findbook("B");

        library.Removebook("5678");

        library.Displaybooks();
    }
}