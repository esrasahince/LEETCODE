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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists==null)
        return null;
        PriorityQueue<int,int> que=new();
        foreach(var item in lists)
        {
             ListNode current=item;
             while(current!=null)
             {
                que.Enqueue(current.val,current.val);
                current=current.next;
            }
        }
        if(que.Count==0)
        return null;
        ListNode node=new ListNode();
        ListNode dummy=new ListNode(0,node);
        node.val=que.Dequeue();
        while(que.Count>0)
        {
            ListNode current=new ListNode(que.Dequeue());
            node.next=current;
            node=current;
        }
        return dummy.next;


        
    }
}