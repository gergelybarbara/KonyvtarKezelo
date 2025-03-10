using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarKezelo.Models
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();

        public List<Member> Members { get; set; } = new List<Member>();


        public void AddBook(Book book) { 
            Books.Add(book);
        }    
        
        public void AddMember(Member member) { 
            Members.Add(member);
        }

        public Book FindBook(string isbn) {

            return Books.FirstOrDefault(b => b.ISBN == isbn);
        
        }

        public void RemoveBook(string isbn) {

            Books.Remove(FindBook(isbn));
        
        }

        public void ListAvaiable() {
            var avaiableBooks = Books.Where(b => b.isAvailable);
            if (avaiableBooks.Any()) {
                foreach (Book item in avaiableBooks)
                {
                    Console.WriteLine(item);
                }
            }
            else {
                Console.WriteLine("Nincs elérhető könyv!");
            }
            
        }
    }
}
