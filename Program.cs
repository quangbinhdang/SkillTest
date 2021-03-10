using System;
using System.Collections;

namespace SkillTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Furniture chair = new Furniture("Chair");
            Furniture table1 = new Furniture("Table");
            Furniture table2 = new Furniture("Table");
            Furniture table3 = new Furniture("Table");
            Furniture laptop = new Furniture("Laptop");
            Furniture television1 = new Furniture("Television");
            Furniture television2 = new Furniture("Television");
            Furniture television3 = new Furniture("Television");
            Furniture toothbrush1 = new Furniture("Toothbrush");
            Furniture toothbrush2 = new Furniture("Toothbrush");
            Furniture toothbrush3 = new Furniture("Toothbrush");
            Furniture toothbrush4 = new Furniture("Toothbrush");
            Furniture toothpick = new Furniture("Toothpick");
            Furniture glass1 = new Furniture("Glass");
            Furniture glass2 = new Furniture("Glass");

            ArrayList furnitureList = new ArrayList();
            furnitureList.Add(chair);
            furnitureList.Add(table1);
            furnitureList.Add(table2);
            furnitureList.Add(table3);
            furnitureList.Add(laptop);
            furnitureList.Add(television1);
            furnitureList.Add(television2);
            furnitureList.Add(television3);
            furnitureList.Add(toothbrush1);
            furnitureList.Add(toothbrush2);
            furnitureList.Add(toothbrush3);
            furnitureList.Add(toothbrush4);
            furnitureList.Add(toothpick);
            furnitureList.Add(glass1);
            furnitureList.Add(glass2);

            furnitureList.Sort();

            foreach (Furniture f in furnitureList)
            {
                Console.WriteLine("Item : " + f.Name);
            }
            
        }
    }
}
