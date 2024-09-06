using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyword_abstract.Models
{
    public abstract class Person
    {
        public string Name;
        public string CPF;

        public abstract void ShowData(); 
    }
}
