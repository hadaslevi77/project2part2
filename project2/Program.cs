using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class GuestRequest
    {
        public string EntryDate { get; set; }
        public string ReleaseDate { get; set; }
        public bool IsApproved { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            bool c;
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = true;
            GuestRequest guest = new GuestRequest();
            guest.EntryDate = a;
            guest.ReleaseDate = b;
            guest.IsApproved = c;
            Console.WriteLine(guest.ToString());
        }
    }
}
