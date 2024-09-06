using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyword_abstract.Models
{
    public class Worker : Person
    { 
        public Worker(string name, string cpf) 
        {
            base.Name = name;
            base.CPF = cpf;
        }

        public override void ShowData() 
        {
            Console.WriteLine(base.Name);
            Console.WriteLine(base.CPF);
        }

    }
}
