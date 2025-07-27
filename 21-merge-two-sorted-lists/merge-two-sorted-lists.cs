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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1==null)
        return list2;
        if(list2==null)
        return list1;
        if(list1==null&&list2==null)
        return null;

        ListNode ptr1=list1;
        ListNode ptr2=list2;
       
       
        ListNode current=new ListNode(0);
        ListNode result=current;

        while(ptr1!=null&&ptr2!=null)
        {
          

            if(ptr1.val<=ptr2.val)
            {
               ListNode ptr1next=ptr1.next;
               current.next=ptr1;
               
               current=ptr1;
               ptr1=ptr1.next;
            }
            else
            {
               ListNode ptr2next=ptr2.next;
               current.next=ptr2;
            
               current=ptr2;
               ptr2=ptr2.next;
            }

            
        }
        if(ptr1!=null)
        current.next=ptr1;
        else 
        current.next=ptr2;
       

        

       return result.next;

      
        
        
    }
}