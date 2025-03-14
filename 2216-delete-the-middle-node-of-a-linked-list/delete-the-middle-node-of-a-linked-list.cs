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
    public ListNode DeleteMiddle(ListNode head) {

     if (head == null||head.next == null) {
            return null;
        }
           
        
        ListNode fast=head;
        ListNode slow=head;
        ListNode last=null;


        while(fast!=null&&fast.next!=null)
        {
            last=slow;
            slow=slow.next;
            fast=fast.next.next;
        }
    
            last.next=slow.next;
        
        return head;
   
    }
}