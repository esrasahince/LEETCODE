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
        PriorityQueue<ListNode,int> que=new();
        foreach(var item in lists)
        {
             ListNode listitem=item;
             while(listitem!=null)
             {
                que.Enqueue(listitem,listitem.val);
                listitem=listitem.next;
            }
        }
        if(que.Count==0)
        return null;
        ListNode current=que.Dequeue();
        ListNode dummy=current;
        while(que.Count>0)
        {
            ListNode item=que.Dequeue();
            current.next=item;
            current=item;
        }
        current.next=null;
        return dummy; 
    }
}