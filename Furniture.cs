using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTest
{
    public enum FurnitureType
    {
        Toothpick,
        Toothbrush,
        Glass,
        Laptop,
        Television,
        Chair,
        Table
    }

    public class Singleton {
        private static Singleton instance = null;
        private static readonly object padlock = new object();
        public ArrayList sizeList = new ArrayList();

        Singleton()
        {
            //Console.WriteLine("Create Singleton");
            sizeList.Add("Toothpick");
            sizeList.Add("Toothbrush");
            sizeList.Add("Glass");
            sizeList.Add("Laptop");
            sizeList.Add("Television");
            sizeList.Add("Chair");
            sizeList.Add("Table");
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }

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

        //private FurnitureType type;
        //public FurnitureType FurnitureType
        //{
        //    get { return type; }
        //    set { type = value; }
        //}

        public Furniture(string name)
        {
            Name = name;
        }

        public int CompareTo(object obj)
        {
            //Console.WriteLine("Name : " + Singleton.sizeList.IndexOf(Name));
            //foreach (string i in Singleton.Instance.sizeList) {
            //    Console.WriteLine("Name : " + i);
            //}
            //return String.Compare(Name, ((Furniture)obj).Name);
            if (Singleton.Instance.sizeList.IndexOf(Name) > Singleton.Instance.sizeList.IndexOf(((Furniture)obj).Name))
            {
                //Console.WriteLine("-1 : Name 1 = " + Name + " | name 2 : " + ((Furniture)obj).Name);
                return -1;
            }
            else if (Singleton.Instance.sizeList.IndexOf(Name) < Singleton.Instance.sizeList.IndexOf(((Furniture)obj).Name))
            {
                //Console.WriteLine("+1 : Name 1 = " + Name + " | name 2 : " + ((Furniture)obj).Name);
                return 1;
            }
            else {
                //Console.WriteLine("0 : Name 1 = " + Name + " | name 2 : " + ((Furniture)obj).Name);
                return 0;
            }
            //return 0;
        }
    }
}
