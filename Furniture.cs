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

        private int size;
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Furniture(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public int CompareTo(object obj)
        {
            //return String.Compare(Name,((Furniture)obj).Name);
            if (Size > ((Furniture)obj).Size)
            {
                return -1;
            } else if (Size < ((Furniture)obj).Size)
            {
                return 1;
            } else return 0;

        }
    }
}
