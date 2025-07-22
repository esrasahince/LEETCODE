/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {

        ListNode slow=head;
        ListNode fast=head;
        while(fast!=null&&fast.next!=null)
        {
            slow=slow.next;
            fast=fast.next.next;
        }
     
        ListNode second=Reverse(slow);
         
        ListNode first=head;
        while(first!=null&&second!=null)
        {
            if(first.val!=second.val)
            return false;
            first=first.next;
            second=second.next;
        }
        return true;


        
    }
    public ListNode Reverse(ListNode head)
    {
        ListNode current=head;
        ListNode prev=null;
        while(current!=null)
        {
            ListNode next=current.next;
            current.next=prev;
            prev=current;
            current=next;
            
        }
        return prev;
    }
}