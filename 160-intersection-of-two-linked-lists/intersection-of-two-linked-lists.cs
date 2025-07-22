/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        
        HashSet<ListNode> hash=new();
        ListNode current=headA;
        while(current!=null)
        {
            hash.Add(current);
            current=current.next;
        }
        ListNode temp=headB;
        while(temp!=null)
        {
            if(hash.Contains(temp))
            {
               return temp;
            }
            temp=temp.next;
        }
        return null;
    }
}