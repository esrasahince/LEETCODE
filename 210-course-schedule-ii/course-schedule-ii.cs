public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
         List<int> result=new();
           // Eğer herhangi bir ders yoksa, boş bir liste döndür
   
        Dictionary<int,HashSet<int>> courses=new();
        int[] visited=new int[numCourses];
         for(int i=0;i<numCourses;i++)
        {
            courses[i]=new HashSet<int>();
        }
       
        for(int i=0;i<prerequisites.Length;i++)
        {
            
            courses[prerequisites[i][1]].Add(prerequisites[i][0]);

        }
        for(int i=0;i<numCourses;i++)
        {
            if(HasCycle(courses,i,result,visited))
            return new int[0];
        }
        result.Reverse();
        return result.Count==numCourses?result.ToArray():new int[0];
        
    }
    public bool HasCycle(Dictionary<int,HashSet<int>> courses,int index,List<int> result,   int[] visited)
    {
        if(visited[index]==1)
        return true;
        if(visited[index]==2)
        return false;
        visited[index]=1;
        foreach(var item in courses[index])
        {
            if(HasCycle(courses,item,result,visited))
            return true;

        }
        visited[index]=2;
        result.Add(index);
        return false;
    }
}