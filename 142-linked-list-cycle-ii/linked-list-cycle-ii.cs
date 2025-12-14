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
    public ListNode DetectCycle(ListNode head) {
        //ilk karsılasmadan sonra slow'u head e getirip 1 er ilerlet

        if(head==null)
        return head;
        ListNode slow=head;
        ListNode fast=head;
        while(fast!=null&&fast.next!=null)
        {
            slow=slow.next;
            fast=fast.next.next;
            if(fast==slow) //meeting point
            {
                slow=head;
                while(slow!=fast)
                {
                    slow=slow.next;
                    fast=fast.next;
                }
                return slow;
            }
        }
        return null;

        
    }
}