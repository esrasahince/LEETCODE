public class Solution {
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null)
            return;

        // 1. Orta noktayı bul
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        // 2. İkinci yarıyı ters çevir
        ListNode second = slow.next;
        slow.next = null;
        ListNode prev = null;
        while (second != null) {
            ListNode temp = second.next;
            second.next = prev;
            prev = second;
            second = temp;
        }

        // 3. İki listeyi birleştir (head + reversed second half)
        ListNode first = head;
        second = prev; // ters çevrilmiş ikinci yarı
        while (second != null) {
            ListNode temp1 = first.next;
            ListNode temp2 = second.next;

            first.next = second;
            second.next = temp1;

            first = temp1;
            second = temp2;
        }
    }
}
