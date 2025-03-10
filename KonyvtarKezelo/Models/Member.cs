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

        public void konyvKolcsonzes(Book book)
        {
            Book.Add= book;
        }


    }
}
