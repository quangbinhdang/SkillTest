using System;
using System.Collections;

namespace SkillTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Furniture chair = new Furniture("Chair", 6);
            Furniture table1 = new Furniture("Table 1", 7);
            Furniture table2 = new Furniture("Table 2", 7);
            Furniture table3 = new Furniture("Table 3", 7);
            Furniture laptop = new Furniture("Laptop", 4);
            Furniture television1 = new Furniture("Television 1", 5);
            Furniture television2 = new Furniture("Television 2", 5);
            Furniture television3 = new Furniture("Television 3", 5);
            Furniture toothbrush1 = new Furniture("Toothbrush 1", 2);
            Furniture toothbrush2 = new Furniture("Toothbrush 2", 2);
            Furniture toothbrush3 = new Furniture("Toothbrush 3", 2);
            Furniture toothbrush4 = new Furniture("Toothbrush 4",2 );
            Furniture toothpick = new Furniture("Toothpick",1 );
            Furniture glass1 = new Furniture("Glass1", 3);
            Furniture glass2 = new Furniture("Glass2", 3);

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
