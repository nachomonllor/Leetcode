//https://leetcode.com/problems/palindrome-linked-list/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        private static ListNode reverse(ListNode node)
        {
            ListNode prev = node;
            ListNode curr = node.next;
            ListNode next = null;
            node.next = null;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }

        public static ListNode Duplicate(ListNode n)
        {
            // handle the degenerate case of an empty list
            if (n == null)
            {
                return null;
            }

            // create the head node, keeping it for later return
            ListNode first = new ListNode(0);
            first.val = n.val;

            // the 'temp' pointer points to the current "last" node in the new list
            ListNode temp = first;

            n = n.next;
            while (n != null)
            {
                ListNode n2 = new ListNode(0);
                n2.val = n.val;
                // modify the Next pointer of the last node to point to the new last node
                temp.next = n2;
                temp = n2;
                n = n.next;
            }

            return first;

        }

        public static bool IsPalindrome(ListNode head)
        {
            if (head == null) return true;
            ListNode rev = Duplicate(head);
            rev = reverse(rev);



            for (ListNode l = head, r = rev; l != null && r != null; l = l.next, r = r.next)
            {
                if (l.val != r.val) return false;
            }

            return true;
        }


        static void Main(string[] args)
        {

            //ListNode lista = new ListNode(1);
            //lista.next = new ListNode(1);
            //lista.next.next = new ListNode(2);
            //lista.next.next.next = new ListNode(1);
            //lista.next.next.next.next = new ListNode(5);
            ListNode lista = new ListNode(1);
            lista.next = new ListNode(1);
            lista.next.next = new ListNode(2);
            lista.next.next.next = new ListNode(1);
            


            Console.WriteLine(IsPalindrome(lista));

            Console.ReadLine();
        }
    }
}
