using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyword_void
{
    internal class Program
    {

        public static void GiveGreetings(string Username)
        {
            Console.WriteLine("Olá, {0}", Username);
        }

        static void Main(string[] args)
        {
            GiveGreetings("Joao");

            Console.ReadKey();
        }
    }
}
