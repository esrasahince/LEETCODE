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
    public ListNode ReverseList(ListNode head) {
        ListNode prev=null;
        ListNode current=head;
       
        return Recursive(prev,current);
        
    }
    public ListNode Recursive(ListNode prev, ListNode current)
    {
        if(current==null)
        return prev;
        ListNode next=current.next;
        current.next=prev;
        prev=current;
        current=next;
        return Recursive(prev,current);
       

    }
}