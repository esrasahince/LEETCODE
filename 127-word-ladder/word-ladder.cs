public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
      Dictionary<string,List<string>> graph=new();
      BuildGraph(wordList,graph);
      Queue<(string,int)> que=new();
      HashSet<string> visited=new();
      que.Enqueue((beginWord,1));
      while(que.Count>0)
      {
        (string current,int level)=que.Dequeue();
        if(current==endWord)
        return level;
        for(int i=0;i<current.Length;i++)
        {
            string pattern=current.Substring(0,i)+"*"+current.Substring(i+1);
            if(graph.ContainsKey(pattern))
            {
                foreach(var word in graph[pattern])
                {
                    if(!visited.Contains(word))
                    {
                        que.Enqueue((word,level+1));
                        visited.Add(word);
                    }
                }
            }
        }
      }
      return 0;      
      
      
    }
    public void BuildGraph(IList<string> worldList,Dictionary<string,List<string>> graph)
    {
        
      foreach(string s in worldList)
      {
        
        for(int i=0;i<s.Length;i++)
        {
            string pattern=s.Substring(0,i)+"*"+s.Substring(i+1);
            if(!graph.ContainsKey(pattern))
            {
                graph[pattern]=new List<string>();
            }
            graph[pattern].Add(s);
         
        }
    
      }  
    
    }
}