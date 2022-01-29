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
                if (d < minDist && playersCord[i].health > 0) 
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

        public static double Dist2DXY(playerCord p1, playerCord p2) 
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }

        public static double Dist1D(playerCord p1, playerCord p2)
        {
            return Math.Abs(p1.x - p2.x);
        }

        public static float ConvertRadiansToFloatDegrees(double angleInRadian)
        {
            return (float)(angleInRadian * 180 / Math.PI);
        }

        public static float AdjustMosueXToCorrectRangeAndLocation(playerCord myCord, playerCord enemyCord, float mouseXoriginal) 
        {
            if (enemyCord.x >= myCord.x && enemyCord.y <= myCord.y) 
            {
                return mouseXoriginal;
            }
            if (enemyCord.x >= myCord.x && enemyCord.y > myCord.y)
            {
                return 180-mouseXoriginal;
            }
            if (enemyCord.x < myCord.x && enemyCord.y > myCord.y)
            {
                return mouseXoriginal + 180;
            }
            if (enemyCord.x < myCord.x && enemyCord.y <= myCord.y)
            {
                return 360-mouseXoriginal;
            }
            throw new ArgumentException($"the players are location are impossible. MyCord: x={myCord.x}, y={myCord.y}, z={myCord.z}\nEnemyCord: x={enemyCord.x}, y={enemyCord.y}, z={enemyCord.z}\nMouseOriginalXPosition: {mouseXoriginal}");
        }

        public static float AdjustMosueYToCorrectRangeAndLocation(playerCord myCord, playerCord enemyCord, float mouseYoriginal) 
        {
            if (enemyCord.z < myCord.z) 
            {
                return -mouseYoriginal;
            }
            return mouseYoriginal;
        }
    }
}
