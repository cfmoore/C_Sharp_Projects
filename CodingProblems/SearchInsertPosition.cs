using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    class SearchInsertPosition
    {
        public int Runner()
        {
            //Making a binary search
            int[] nums = {1,3,5,6};//Starting Array
            int target = 7;//Searching Target
            int left = 0;
            int right = nums.Length - 1;
            if (left == right)//If Array Length == 1
            {
                if (nums[left] < target)
                    return left + 1;
                else
                    return left;
            }
            int mid = (left + right) / 2;
            //Binary Search Algorithm
            while (left <= right)
            {
                //Debug print
                Console.WriteLine("Left: " + left + "   Right: " + right);
                mid = (left + right) / 2;
                //If we are too low, increase left side
                if (nums[mid] < target)
                    left = mid + 1;
                //If we are too high, decrease right side
                else if (nums[mid] > target)
                    right = mid - 1;
                //If we found the number, return it.
                else
                    return mid;
            }
            //Debug Print
            Console.WriteLine("OUT OF LOOP left: " + left + "   right: " + right);
            //IF left is over the array bounds
            if(left >=nums.Length)
            {
                //If target is greater than last element, return length(thats where it should go)
                if (nums[nums.Length - 1] <= target)
                    return nums.Length;
                else//It must be smaller than the last element, but bigger than the second to last, place element at current end of array
                    return nums.Length - 1;
            }
            else if (nums[left] >= target)//IF the left target is greater than the target, return the position
                return left;
            else if (nums[right] <= target)//if the right target is less than return the position
                return right;
            else//Saftey Case, Should never be reached.
                return 0;
        }
    }
}
