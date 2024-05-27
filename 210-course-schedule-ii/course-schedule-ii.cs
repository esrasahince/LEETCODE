public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {

        Dictionary<int, List<int>> graph=new();
        List<int> result=new();;
        Dictionary<int,int>visited=new(); //0: not visited, 1: visited -1 : visiting

        //Initialize graph
        for(int i=0;i<numCourses;i++)
        {
            graph[i]=new List<int>();
            visited[i]=0;
        }
        //Build adjacency list
        foreach(var item in prerequisites)
        {
            graph[item[1]].Add(item[0]);
        }
      
       
          for(int i=0;i<numCourses;i++)
        {
            if(visited[i]==0)
            {  
            if (!DFS(i, graph, visited, result)) {
                    return new int[0]; // If a cycle is detected, return an empty array
                }
              
               
              
            }
        }
        result.Reverse();
        return result.ToArray();

    }
    public bool DFS(int i, Dictionary<int,List<int>> graph, Dictionary<int,int> visited, List<int> result)
    {
        if(visited[i]==-1)
        {
            
            return false; //cycle detected
        }
        
        if(visited[i]==1)
        return true;
   
        visited[i]=-1;
        foreach(int j in graph[i])
        {
            if(!DFS(j,graph,visited,result))
            return false;
        }
        visited[i]=1;
        result.Add(i);
        return true;
      }

    }
