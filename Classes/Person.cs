using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtorisation.Classes
{
    public class Person
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Post { get; set; }
        public override string ToString()
        {
            return $"FullName: {FullName} Post: {Post}";
        }
    }
}
