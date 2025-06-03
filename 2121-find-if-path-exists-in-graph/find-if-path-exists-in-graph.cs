public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        if(edges==null||edges.Length==0||source==destination)
        return true;

        Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();
        
        foreach (var edge in edges)
        {
            if (!result.ContainsKey(edge[0]))
                result[edge[0]] = new List<int>();
            if (!result.ContainsKey(edge[1]))
                result[edge[1]] = new List<int>();

            result[edge[0]].Add(edge[1]);
            result[edge[1]].Add(edge[0]);

        }

        Stack<int> stack=new();
        HashSet<int> visited=new();
        stack.Push(source);
        visited.Add(source);
        while(stack.Count > 0)
        {
            int item=stack.Pop();
            foreach(var child in result[item])
            {
                if(child==destination)
                return true;
                if (!visited.Contains(child))
                {
                    stack.Push(child);
                    visited.Add(child);
                }
            }
        }
        return false;


    }
  
}