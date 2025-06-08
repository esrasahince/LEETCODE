/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node parent;
}
*/

public class Solution {
    public Node LowestCommonAncestor(Node p, Node q) {

        int deptp=FindDept(p);
        int deptq=FindDept(q);
       
        while(deptp<deptq) //q daha asagıda 
        {
            q=q.parent;
            deptq--;
            if(p==q)
            return p;
        }
        while(deptq<deptp) //p daha asagıda 
        {
            p=p.parent;
            deptp--;
            if(p==q)
            return p;
        }
         while(deptp==deptq)
        {
            p=p.parent;
            q=q.parent;
            if(p==q)
            return p;
        }

        
        return null;
    }
    public int FindDept(Node node)
    {
        if(node==null)
        return 0;
        return FindDept(node.parent)+1;
    }
}