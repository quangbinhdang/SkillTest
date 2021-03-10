using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTest
{
    public class Furniture : IComparable
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

        public int CompareTo(object obj)
        {
            return String.Compare(Name,((Furniture)obj).Name);
        }
    }
}
