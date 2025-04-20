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
        if(head==null)
        return null;
        ListNode fast=head;
        ListNode slow=head;
       
        while(fast!=null&&fast.next!=null)
        {
            slow=slow.next;
            fast=fast.next.next;
            if(fast==slow) //ilk karşılaşma yaşandıktan sonra slow dongu basına
            //daha sonra da ikiside birer birer ilerlicek
            {
                slow=head;
                while(slow!=fast)
                {
                    slow=slow.next;
                    fast=fast.next; //ikinci kez karsılastıklarında yani eşit olunca
                    //buradaki döngü de biter
                }
                return slow;
            }

         
        }
        return null;
    
        
    }
}