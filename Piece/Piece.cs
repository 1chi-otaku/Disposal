using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piece
{
    class Piece: IDisposable
    {
        public string pieceName { get; set; }
        public string authorName { get; set; }
        public string genre { get; set; }
        public string year { get; set; }

        public Piece() {
            pieceName = "N/A";
            authorName = "N/A";
            genre = "N/A";
            year = "N/A";
        }
        public Piece(string pieceName, string authorName, string genre, string year)
        {
            this.pieceName = pieceName;
            this.authorName = authorName;
            this.genre = genre;
            this.year = year;
        }
        public void Print() => Console.WriteLine("Piece - " + pieceName + "\nAuthor - " + authorName +"\nGenre - " + genre + "\nYear - " + year);
        public override string ToString()
        {
            return "Piece - " + pieceName + "\nAuthor - " + authorName +"\nGenre - " + genre + "\nYear - " + year + "\n";
        }

        public void Dispose()
        {
            Console.WriteLine("Disposal!");
            Console.Beep();
        }
        ~Piece()
        {
            Console.Write("'Destructor' Disposal!");
        }
    }
}
