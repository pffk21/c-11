using System.Collections;
//задание 1
// namespace bookLibarary
// {
//     class Book : IComparable, ICloneable
//     {
//         string name;
//         string author;
//         public Book(string name, string author)
//         {
//             this.name = name;
//             this.author = author;
//         }
//         public Book() : this("Властелин колец", "Джон Р. Р. Толкин") { }
//         public void Show()
//         {
//             Console.WriteLine("\n{0}   {1}", name, author);
//         }
//         public object Clone()
//         {
//             return new Book(this.name,this.author); 
//         }
//         public int CompareTo(object obj)
//         {
//             if (obj is Book)
//                 return name.CompareTo((obj as Book).name);
//
//             throw new NotImplementedException();
//         }
//         public class SortByName : IComparer
//         {
//             int IComparer.Compare(object obj1, object obj2)
//             {
//                 if (obj1 is Book && obj2 is Book)
//                     return (obj1 as Book).name.CompareTo((obj2 as Book).name);
//
//                 throw new NotImplementedException();
//             }
//         }
//         public class SortByAuthor : IComparer
//         {
//             int IComparer.Compare(object obj1, object obj2)
//             {
//                 if (obj1 is Book && obj2 is Book)
//                     return (obj1 as Book).author.CompareTo((obj2 as Book).author);
//
//                 throw new NotImplementedException();
//             }
//         }
//     }
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Book[] c = new Book[4];
//             Console.WriteLine("Неупорядоченный массив:");
//             c[0] = new Book("Гордость и предубеждение", "Джейн Остин");
//             c[1] = new Book("Тёмные начала", "Филип Пулман");
//             c[2] = new Book("Винни Пух", "Алан Александр Милн");
//             c[3] = new Book("Война и мир", "Лев Толстой");
//   
//             foreach (Book temp in c)
//                 temp.Show();
//             Array.Sort(c);
//             Console.WriteLine("\nУпорядоченный массив:");
//             foreach (Book temp in c)
//                 temp.Show();
//             foreach (Book temp in c)
//                 temp.Show();
//             Array.Sort(c, new Book.SortByName());
//             Console.WriteLine("\nпо названию книги:");
//             foreach (Book temp in c)
//                 temp.Show();
//             Array.Sort(c, new Book.SortByAuthor());
//             Console.WriteLine("\nпо автору:");
//             foreach (Book temp in c)
//                 temp.Show();
//             
//             Book originalBook = new Book("Гарри Поттер и философский камень", "Джоан Роулинг");
//             Console.WriteLine("\nОригинал:");
//             originalBook.Show();
//             Book clonedBook = (Book)originalBook.Clone();
//             Console.WriteLine("\nICloneable:");
//             clonedBook.Show();
//         }
//     }
// }





//задание 2
// namespace bookLibrary
// {
//     class Book
//     {
//         public string Name { get; set; }
//         public string Author { get; set; }
//
//         public Book(string name, string author)
//         {
//             this.Name = name;
//             this.Author = author;
//         }
//         public void Show()
//         {
//             Console.WriteLine("{0} - {1}", Name, Author);
//         }
//     }
//     class Library : IEnumerable<Book>
//     {
//         private Book[] books;
//
//         public Library(Book[] booksArray)
//         {
//             this.books = booksArray;
//         }
//         public IEnumerator<Book> GetEnumerator()
//         {
//             foreach (Book book in books)
//             {
//                 yield return book;
//             }
//         }
//         IEnumerator IEnumerable.GetEnumerator()
//         {
//             return GetEnumerator();
//         }
//     }
//
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Book[] books = new Book[]
//             {
//                 new Book("Гордость и предубеждение", "Джейн Остин"),
//                 new Book("Тёмные начала", "Филип Пулман"),
//                 new Book("Винни Пух", "Алан Александр Милн"),
//                 new Book("Война и мир", "Лев Толстой")
//             };
//             Library library = new Library(books);
//             Console.WriteLine("Книги в библиотеке:");
//             foreach (Book book in library)
//             {
//                 book.Show();
//             }
//         }
//     }
// }