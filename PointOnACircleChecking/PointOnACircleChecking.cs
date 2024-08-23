using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnACircleChecking
{
    public class PointOnACircleChecking
    {
        public static bool IsPointInsideCircle(int x, int y)
        {  
            int DistanceFormula = x * x + y * y;
            int radiusSquared = 5 * 5;
            return DistanceFormula <= radiusSquared;
        }
    }
}
