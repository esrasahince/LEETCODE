
public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {

        //I need to create a dictionary like.  vertex number and its neighbours
        //I need a visited list
        //for exp
        //0: 4,9
        //1: 4,7
        //2: 4
        //3: 4
        //4: 3,1,8,6,2,7,0,5
        //5: 4
        //6: 4,
        //7:1,4
        //8:4,
        //9:0
        // for loop 
        //ınvestigate all child whether having dest or not
        if(edges.Length==0||edges==null||source==destination)
        return true;
        
        Dictionary<int,HashSet<int>> edge=new();
        for(int i=0;i<n;i++)
        {
                edge[i]=new HashSet<int>();
        }
        
        for(int i=0;i<edges.Length;i++)
        {
            edge[edges[i][0]].Add(edges[i][1]);
            edge[edges[i][1]].Add(edges[i][0]);
        }
        HashSet<int> visited=new();
        return Check(edge,source,destination,visited);
        
        
    }
    public bool Check(Dictionary<int,HashSet<int>> edge, int source,int dest, HashSet<int> visited )
   {
    if(edge[source].Contains(dest))
    return true;
    visited.Add(source);
    foreach(int value in edge[source])
    {
        
                if(!visited.Contains(value))
                {
                
                     if (Check(edge, value, dest, visited))
                    return true;
                }       
            
    }
    return false;

   } 
}