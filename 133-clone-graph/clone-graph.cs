/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node==null)
        return node;
        Dictionary<Node,Node> dict=new();
        Queue<Node> que=new();
        HashSet<Node> visited=new();
        que.Enqueue(node);
        visited.Add(node);
        dict[node]=new Node(node.val,new List<Node>());
        while(que.Count>0)
        {
            Node current=que.Dequeue();
            
          
            foreach(var item in current.neighbors)
            {
                if(!visited.Contains(item))
                {
                que.Enqueue(item);
                visited.Add(item);
                }
                if(!dict.ContainsKey(item))
                {
                    dict[item]=new Node(item.val,new List<Node>());
                }
                dict[current].neighbors.Add(dict[item]);
                

            }
        }
        return dict[node];
        
    }
}