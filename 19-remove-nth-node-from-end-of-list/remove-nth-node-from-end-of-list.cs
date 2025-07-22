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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head==null)
        return head;
        ListNode dummy=new ListNode(0,head);
        ListNode slow=dummy;
        ListNode fast=dummy;
        int k=0;
        while(k<=n&&fast!=null)
        {
          fast=fast.next;
          k++;
        }
   

        while(fast!=null)
        {
            slow=slow.next;
            fast=fast.next;
        }
        //slow (prevnode), deleted node, nextnode
      
        if(slow!=null&&slow.next!=null)
        {
            ListNode next=slow.next.next;
            slow.next=next;
        }
        return dummy.next;
        
    }
}