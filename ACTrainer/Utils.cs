using System;
using System.Collections.Generic;
using System.Text;

namespace ACTrainer
{
    public static class Utils
    {
        public static int GetClosestPlayer(List<playerCord> playersCord, playerCord myCords)
        {
            int index = 0; 
            double minDist = int.MaxValue;
            double d;
            for(int i = 0; i < playersCord.Count; ++i) 
            {
                d = Dist3D(myCords, playersCord[i]);
                if (d < minDist) 
                {
                    index = i;
                    minDist = d;
                }
            }
            return index;
        }

        public static double Dist3D(playerCord p1, playerCord p2) 
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2) + Math.Pow(p1.z - p2.z, 2));
        }

        public static double Dist2D(playerCord p1, playerCord p2) 
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }

        public static double Dist1D(playerCord p1, playerCord p2)
        {
            return Math.Abs(p1.x - p2.x);
        }
    }
}
