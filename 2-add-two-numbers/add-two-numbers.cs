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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        if(l1==null)
        return l2;
        if(l2==null)
        return l1;
        ListNode result=new ListNode(0);
        ListNode resulttail=result;
        int remain=0;
        int sum=0;

        while(l1!=null||l2!=null)
        {
            if(l1!=null&&l2!=null)
            {
                sum=l1.val+l2.val+remain;
                remain=sum/10;
                ListNode add=new ListNode(sum%10);
                resulttail.next=add;
                resulttail=add;
                l1=l1.next;
                l2=l2.next;

            }
            else
            { 
                if(l1!=null)
                {
                sum=l1.val+remain;
                remain=sum/10;
                ListNode add=new ListNode(sum%10);
                resulttail.next=add;
                resulttail=add;
                l1=l1.next;
                }
                else
                {
                sum=l2.val+remain;
                remain=sum/10;
                ListNode add=new ListNode(sum%10);
                resulttail.next=add;
                resulttail=add;
                l2=l2.next;
                }
                
            }

        }

        if(remain!=0)
        {
            ListNode add=new ListNode(remain);
            resulttail.next=add;
               
        }
        return result.next;
        
    }
}