using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using System.Linq;

namespace LINQ
{
    class Linq
    {
        public IEnumerable<int> Display()
        {
            int[] scores = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };
            IEnumerable<int> scoreQuery = from score in scores where score > 55 select score;

            return scoreQuery;
        }
    }
}
