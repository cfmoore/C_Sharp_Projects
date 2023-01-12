using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    class Stairs
    {
        //1 <= num <= 45
        public int ClimbStairs(int num)
        {
            /*
             * Climb satirs where you can go either 1 or 2 at a time
             * How many combinations are there for each amount of sqaures.
             * 
             * Sequence will follow fibonachi sequence
             * 0  1  2  3  4  5  6    7   8
             * 1  1  2  3  5  8  13  21  34  ......
             */
            int ways = 1;
            int old = 1;
            int temp = 0;
            //0 & 1 will not run through loop, it will kick it out.
            //fibonachi sequence
            for (int i = 1; i < num; i++)
            { 
                temp = old;
                old = ways;
                ways = old + temp;
            }
            return ways;
        }
    }
}
