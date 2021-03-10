using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTest
{
    public class FurnitureComparer : IComparer<Furniture>
    {
        public int Compare(Furniture x, Furniture y)
        {
            // TODO: Handle x or y being null, or them not having names
            return x.Name.CompareTo(y.Name);
        }
    }
}
