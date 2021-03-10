using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTest
{
    class Furniture
    {
        private string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public Furniture(string name)
        {
            Name = name;
        }
    }
}
