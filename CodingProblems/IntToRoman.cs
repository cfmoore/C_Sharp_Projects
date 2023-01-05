using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    class IntToRoman
    {
        // 1<=num<=3999
        public string runner(int num)
        {
            if (num > 3999)
                return "Error: Biggger than 3999";
            else if (num < 1)
                return "Error: Smaller than 1";
            string roman = "";
            int tempnum = num;
            int thousands = 0;
            int hundreds = 0;
            int tens = 0;
            int ones = 0;
            int count = 0;
            //Get Thousands
            thousands = tempnum / 1000;
            tempnum %= 1000;
            count = 0;
            while (count < thousands)
            {
                roman += "M";//Create String for Thousands
                count++;
            }
            //Get Hundreds
            hundreds = tempnum / 100;
            tempnum %= 100;
            count = 0;
            while (count < hundreds)//Creat 100s area
            {
                //**NOTE** the check for 4 and 9 could be outside of the loop, but i found this easier to read and understand
                //The Loop 
                if (hundreds == 9)//If the hundreds place is a 9, there can be no other combination
                {
                    roman += "CM";
                    break;
                }
                else if (count == 0 && hundreds >= 5)//If the hundreds place is greater than 5, add 5 character and continue
                {
                    roman += "D";
                    count = 5;
                }
                else if (hundreds == 4)//If the hundreds place is 4, there can be no other combination
                {
                    roman += "CD";
                    break;
                }
                else//Else add  Cs until criteria is met.
                {
                    roman += "C";
                    count++;
                }
            }
            //Get Tens
            tens = tempnum / 10;
            tempnum %= 10;
            count = 0;
            while(count < tens)//Create  Tens Area
            {
                //See Hundreds Explanation for each part
                if (tens == 9)
                {
                    roman += "XC";
                    break;
                }
                else if (count == 0 && tens >= 5)
                {
                    roman += "L";
                    count = 5;
                }
                else if (tens == 4)
                {
                    roman += "XL";
                    break;
                }
                else
                {
                    roman += "X";
                    count++;
                }
            }
            ones = tempnum;//Get Ones
            count = 0;
            while(count < ones)//Create Ones Area
            {
                if (ones == 9)
                {
                    roman += "IX";
                    break;
                }
                else if (count == 0 && ones >= 5)
                {
                    roman += "V";
                    count = 5;
                }
                else if (ones == 4)
                {
                    roman += "IV";
                    break;
                }
                else
                {
                    roman += "I";
                    count++;
                }
            }
            return roman;
        }
    }
}
