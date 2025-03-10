using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarKezelo.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();


        public void BorrowBook(Book book)
        {
            if (book.isAvailable)
            {

                book.isAvailable = false;
                BorrowedBooks.Add(book);
            }
        }
        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                book.isAvailable = true;
                BorrowedBooks.Remove(book);
                Console.WriteLine($"{book.Title} sikeresen visszaadva!");
            }
            else {
                Console.WriteLine($"{book.Title} nem volt kikölcsönözve!");
            }
        }

    }
}
