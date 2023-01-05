using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    class AddLastNumber
    {
        public int[] runner(int[] digits)
        {
            int pos = digits.Length - 1;
            if (digits[pos] != 9)
                digits[pos]++;
            else
            {
                while(pos != -1 && digits[pos]== 9)
                {
                    digits[pos] = 0;
                    pos--;
                }
                if(pos != -1)
                    digits[pos]++;
                else
                {
                    digits[0] = 1;
                    for (int j = 0; j < digits.Length; j++)
                        Console.Write(digits[j] + ",");
                    Console.Write('\n');
                    Console.WriteLine("Array OOB");
                    int[] temp = new int[digits.Length+1];
                    temp[0] = 1;
                    for (int i = 1; i < temp.Length; i++)
                        temp[i] = 0;
                    return temp;
                }
            }
            return digits;
        }
    }
}
