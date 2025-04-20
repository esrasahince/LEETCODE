/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if(head==null||head.next==null)
        return false;

        ListNode slow=head;
        ListNode fast=head;

        while(slow!=null&&fast!=null)
        { 
            if(fast.next!=null)
            fast=fast.next.next;
            else
            return false;
            slow=slow.next;
            if(fast==slow)
            return true;
        }
        return false;
        
    }
}