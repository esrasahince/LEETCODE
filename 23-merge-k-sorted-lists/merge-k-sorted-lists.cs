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
        PriorityQueue<int,int> que=new();
        foreach(var node in lists)
        {
            var item=node;
            while(item!=null)
            {
                que.Enqueue(item.val,item.val);
                item=item.next;
            }
        }
        ListNode head=null;
        if(que.Count>0)
        {
            head=new ListNode(que.Dequeue());
        }
        ListNode current=head;

        while(que.Count>0)
        {   int value=que.Dequeue();
            ListNode item=new ListNode(value);
            ListNode temp=current;
            temp.next=item;
            current=item;
        }
            
        return head;
        
    }
}