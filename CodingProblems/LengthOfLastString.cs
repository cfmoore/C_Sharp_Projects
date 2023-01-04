using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    class LengthOfLastString
    {
        //Find the length of the last word in a string
        //Word being english letters with no spaces between
        //Range 1<=input.length<10^4
        //Input string will always have 1 word
        public int runner()
        {
            string input = "";
            int size = 0;//Int to return the size of the last word.
            int end = input.Length-1;//end of the string
            char cur = input[end];//last char
            bool space = true;//let us know when the cursor is in the word
            while(end >= 0)
            {
                //If the current character is a space
                if (cur == ' ')
                {
                    if (!space)//If we have already found a word, break
                        break;
                    end--;
                }
                else if (cur != ' ')//If current char is a character
                {
                    size++;
                    space = false;//set space to false since there cannot be a space in a word
                    end--;
                }
                else//Cover all for moving the cursor (avoid infinite loops by bad string)
                    end--;
                if (end < 0)//If we ever get below 0, break to avoid Out Of Bounds below
                    break;
                cur = input[end];
            }

            return size;
        }
    }
}
