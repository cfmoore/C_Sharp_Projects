using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems
{
    public class SLLNode
    {
        public int val;
        public SLLNode next;

        public SLLNode(int val = 0, SLLNode next = null)
        {
            this.val = val;
            this.next = next;
        }



        public SLLNode RemoveDuplicates(SLLNode head)
        {
            if (head == null)//If nothing is passed
                return head;
            if (head.next == null)//
                return head;
            SLLNode cur = head.next;
            SLLNode prev = head;
            bool found = false;
            while (cur != null)
            {
                Console.WriteLine("prev.val: " + prev.val + "    temp.val:" + cur.val);
                found = false;
                if (prev.val == cur.val)
                {
                    found = true;
                    prev.next = cur.next;

                }
                if (!found)
                {
                    prev = prev.next;
                    cur = cur.next;
                }
                else
                    cur = cur.next;
            }
            return head;
        }

        public void Printer(SLLNode prev)
        {
            while (prev != null)
            {
                Console.Write(prev.val + " ");
                prev = prev.next;
            }
            Console.WriteLine();
            return;
        }

    }
}
