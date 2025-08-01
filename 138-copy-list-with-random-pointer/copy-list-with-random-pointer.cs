/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if(head==null)
        return null;

        Dictionary<Node,Node> dict=new();
        Node current=head;
        while(current!=null)
        {
            dict[current]=new Node(current.val);
            current=current.next;
        }
        
        Node copy=dict[head];
        Node temp=head;
        while(temp!=null)
        {
            Node random=temp.random;
            Node next=temp.next;

            dict[temp].random=random==null?null: dict[random];
            dict[temp].next=next==null?null:dict[next];

            temp=temp.next;

        }
        return copy;
        

        
    }
}