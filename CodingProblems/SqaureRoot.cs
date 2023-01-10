using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    class SqaureRoot
    {
        /**
         * Given a non-negative integer x, return the square root of x rounded down to the nearest integer. 
         * The returned integer should be non-negative as well.
         * You must not use any built-in exponent function or operator.
         * 
         * 0 <= num <= 2^31 - 1
         * @num: the number to find the sqaure root of
         */
        public int sqroot(int num)
        {
            if (num == 0 || num == 1)//Default Case
                return num;
            // implementing Binary Search to dinf the square root
            //Start = the smaller bound the sqaure could be
            //End = the upper bound the square could be
            // sqrt = is best guess if the algorithm cannot find the exact square.
            uint start = 1, end = (uint)num / 2, sqrt = 0;
            uint mid = (start + end) / 2;//Find the mid point between the two extremes to see if that works as a square root
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (mid > 46340)//Catch Int Overflow. As this is the upper bounds, no answer can be greater than this.
                    mid = 46340;
                uint sqr = mid * mid;// Find the square of the two numbers
                //Console.WriteLine("Start: " + start + " || End: " + end + " || Mid: " + mid + " || Sqrt:" + sqrt+" || Sqaured: "+sqr);
                if (sqr == num)//if the square is perfect it will return here
                    return (int)mid;
                if(sqr < (uint)num)//If the squared numbers are less than the passed number, move the starting point to the mid number
                {
                    if (mid == 46340)//Catch Int Overflow. Without This, infinite loop.
                        end = mid - 1;
                    start = mid + 1;
                    sqrt = mid;
                }
                else//If it is bigger, move the end point to the mid number
                {
                    end = mid - 1;
                }
            }
            return (int)sqrt;
        }

        public int bruteforce(int num)
        {
            int count = 1;
            int sq = 0;
            while(count <= num)
            {
                num = num - count;
                sq++;
                count += 2;
            }
            return sq;
        }
    }
}
