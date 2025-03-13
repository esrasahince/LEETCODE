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

        if(head.next==null||head==null)
        return null;
        int count=0;
        ListNode temp1=head;
        while(temp1!=null)
        {
            count++;
            temp1=temp1.next;
        }
        int stoppoint=count-n;
  
        ListNode temp=head;
        if(stoppoint==0)
        return head.next;
        while(stoppoint>1)
        {
             temp=temp.next;
            stoppoint--;

        }
        if(temp.next.next!=null){
        ListNode next=temp.next.next;
        temp.next=next;
        }else
        {
            temp.next=null;
        }
        return head;
    }

}