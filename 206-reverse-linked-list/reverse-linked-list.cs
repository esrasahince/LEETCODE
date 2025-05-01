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
        if(head==null)
        return null;
    
    ListNode prev=null;
    ListNode next=null;
    ListNode current=head;
    while(current!=null&&current.next!=null)
    { 
		    next=current.next;
		    current.next=prev; //okun yönünü cevirdik. gelecek nodu belirledik.
		    
		    prev=current;
		    current=next;
    
    }
    
    //döngüden çıktığımızda son elemanı çevirememiş oluyoruz.
    current.next=prev;
    return current;
        
    }
}