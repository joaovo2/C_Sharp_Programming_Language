using Keyword_abstract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyword_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("Joao", "12345678900");

            worker.ShowData();

            Console.ReadKey();
        }
    }
}
