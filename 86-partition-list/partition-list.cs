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
   
    public ListNode Partition(ListNode head, int x) {
        if (head == null) return null;

        ListNode beforeHead = new ListNode(0); // Dummy node for values < x
        ListNode beforeTail = beforeHead;
        ListNode afterHead = new ListNode(0);  // Dummy node for values >= x
        ListNode afterTail = afterHead;

        ListNode current = head;

        while (current != null) {
            if (current.val < x) {
                beforeTail.next = current;
                beforeTail = beforeTail.next;
            } else {
                afterTail.next = current;
                afterTail = afterTail.next;
            }
            current = current.next;
        }

        // Ensure the last node in the ">= x" list does not point to old references
        afterTail.next = null;
        
        // Merge the two lists
        beforeTail.next = afterHead.next;

        return beforeHead.next; // Skip dummy node
    }
    }
