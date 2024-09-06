using Keyword_equals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyword_equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Animal a = new Animal();

            Console.WriteLine(p.Equals(p));
            Console.WriteLine(a.Equals(p));

            Console.ReadKey();
        }
    }
}
