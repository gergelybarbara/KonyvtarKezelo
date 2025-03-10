using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarKezelo.Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        bool isAvailable { get; set; }

        public Book(string iSBN, string title, string author, int year, bool isAvailable)
        {
            ISBN = iSBN;
            Title = title;
            Author = author;
            Year = year;
            this.isAvailable = true;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"A könyv azonosító száma: {ISBN}, címe: {Title}, szerzője: {Author}, kiadási éve {Year} " + (isAvailable? "kölcsönözhető" : "nem kölcsönözhető"));
        }

        public override string? ToString()
        {
            return $"A könyv azonosító száma: {ISBN}, címe: {Title}, szerzője: {Author}, kiadási éve {Year} " + (isAvailable ? "kölcsönözhető" : "nem kölcsönözhető");
        }
    }
}
