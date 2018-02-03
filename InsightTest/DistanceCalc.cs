using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightTest
{
    class DistanceCalc
    {
        public string Calcule(int x1, int y1,int x2, int y2)
        {
            double dist = 0;

            dist = Math.Round(Math.Sqrt((Math.Pow(( x2 - x1 ), 2 )) + (Math.Pow(( y2 - y1 ), 2 ))),2);

            string finalDist = System.Convert.ToString(dist);

            return finalDist;
        }
    }
}
