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
        

        ListNode current=head;
        ListNode nextnode=null;
        ListNode prevnode=null;
        while(current!=null)
        {
            nextnode=current.next;
            current.next=prevnode;
            prevnode=current;
            current=nextnode;
           
            

        }
      
        return prevnode;

        
    }
}