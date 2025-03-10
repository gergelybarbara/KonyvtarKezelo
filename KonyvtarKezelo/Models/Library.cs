using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarKezelo.Models
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();

        public List<Member> Members { get; set; } = new List<Member>();



    }
}
