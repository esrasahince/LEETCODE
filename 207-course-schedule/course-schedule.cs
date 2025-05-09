public class Solution {
    public bool CanFinish(int n, int[][] prerequisites) {

        Dictionary<int, List<int>> graph = new();
        Dictionary<int, int> visited = new();

        // initialize
        for (int i = 0; i < n; i++) {
            graph[i] = new List<int>();
            visited[i] = 0;
        }

        // build graph
        foreach (var pre in prerequisites) {
            int to = pre[0];
            int from = pre[1];
            graph[from].Add(to);
        }

        // dfs check for cycle
        for (int i = 0; i < n; i++) {
            if (HasCycle(graph, visited, i))
                return false;
        }

        return true;
    }

    private bool HasCycle(Dictionary<int, List<int>> graph, Dictionary<int, int> visited, int current) {
        if (visited[current] == 1)
            return true; // cycle detected
        if (visited[current] == 2)
            return false; // already visited

        visited[current] = 1; // mark as visiting

        foreach (var neighbor in graph[current]) {
            if (HasCycle(graph, visited, neighbor))
                return true;
        }

        visited[current] = 2; // mark as visited
        return false;
    }
}
