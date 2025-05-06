public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        // A valid tree with n nodes must have exactly n-1 edges
        if (edges.Length != n - 1) return false;
        
        // Create an adjacency list representation of the graph
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        for (int i = 0; i < n; i++) {
            graph[i] = new List<int>();
        }
        
        // Add edges to the graph (undirected, so add both directions)
        foreach (var edge in edges) {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
        
        // Use BFS to check if the graph is connected
        HashSet<int> visited = new HashSet<int>();
        Queue<int> queue = new Queue<int>();
        
        // Start BFS from node 0
        queue.Enqueue(0);
        visited.Add(0);
        
        while (queue.Count > 0) {
            int node = queue.Dequeue();
            
            foreach (int neighbor in graph[node]) {
                if (!visited.Contains(neighbor)) {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }
        
        // If all nodes are visited, the graph is connected
        return visited.Count == n;
    }}