using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Typist : IEmployee
    {
        public int WordsPerMinute { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public Toy Toy{ get; set; }

        public IEmployee Clone()
        {
            
            return (IEmployee)MemberwiseClone();            
        }

        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}wpm", Name, Role, WordsPerMinute);
        }
    }
}
