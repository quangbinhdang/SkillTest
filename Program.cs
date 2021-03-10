using System;
using System.Collections;

namespace SkillTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Furniture chair = new Furniture("Chair");
            Furniture table = new Furniture("Table");
            Furniture laptop = new Furniture("Laptop");
            Furniture television = new Furniture("Television");
            Furniture toothbrush = new Furniture("Toothbrush");
            Furniture toothpick = new Furniture("Toothpick");

            ArrayList furnitureList = new ArrayList();
            furnitureList.Add(chair);
            furnitureList.Add(table);
            furnitureList.Add(laptop);
            furnitureList.Add(television);
            furnitureList.Add(toothbrush);
            furnitureList.Add(toothpick);

            furnitureList.Sort();

            foreach (Furniture f in furnitureList)
            {
                Console.WriteLine("Item : " + f.Name);
            }
            
        }
    }
}
