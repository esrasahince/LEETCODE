/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution {
    public Node Flatten(Node head) {
        if(head==null)
        return null;
        List<Node> result=new();
        Recursive(head,result);
 
        Node dummy=new();
        Node final=dummy;
       for(int i=0;i<result.Count;i++)
       {
        Node next=result[i];
        dummy.next=next;
        dummy.child=null;
        next.prev=dummy;
        dummy=next;
    
       }
       final=final.next;
       final.prev=null;
        return final;

        
    }
    public void Recursive(Node current, List<Node> result)
    {
       if(current==null)
       return;
     
    
       result.Add(current);
       Recursive(current.child,result);


       Recursive(current.next,result);
    }
}