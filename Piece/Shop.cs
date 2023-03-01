using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piece
{
    class Shop:IDisposable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public Shop(string name, string description, string address)
        {
            Name = name;
            Description = description;
            Address = address;
        }
        public Shop() {
            Name = "N/A";
            Description = "N/A";
            Address = "N/A";
        }
        public void Print() => Console.WriteLine("Name - " + Name + "\nDescription - " + Description + "\nAddress - " + Address);
        public override string ToString()
        {
            return "Name - " + Name + "\nDescription - " + Description + "\nAddress - " + Address;
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose!!!");
            Console.Beep();
        }
        ~Shop()
        {
            Console.WriteLine("Destructor Dispose!");
            Console.Beep();
        }
    }
}
