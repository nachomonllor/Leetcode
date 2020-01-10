https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/submissions/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int GetDecimalValue(ListNode head) {
        int potencia = 0;
                for (ListNode h = head; h != null; h = h.next)
                {
                    potencia++;
                }
                potencia--;
                int sum = 0;
                for (ListNode h = head; h != null; h = h.next)
                {
                    // prod = prod * 10 + head.val;
                    sum += h.val * (int)Math.Pow(2, potencia--);
                }
                return sum;
    }
}