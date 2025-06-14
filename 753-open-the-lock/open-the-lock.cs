public class Solution {
    public int OpenLock(string[] deadends, string target) {
       Dictionary<char,char> nextslot=new();
       nextslot['0']='1';
       nextslot['1']='2';
       nextslot['2']='3';
       nextslot['3']='4';
       nextslot['4']='5';
       nextslot['5']='6';
       nextslot['6']='7';
       nextslot['7']='8';
       nextslot['8']='9';
       nextslot['9']='0';
        Dictionary<char,char> prevslot=new();
       prevslot['0']='9';
       prevslot['1']='0';
       prevslot['2']='1';
       prevslot['3']='2';
       prevslot['4']='3';
       prevslot['5']='4';
       prevslot['6']='5';
       prevslot['7']='6';
       prevslot['8']='7';
       prevslot['9']='8';
       //deadendleri zaten ziyaret etmiş gibi davranıcaz
       HashSet<string> visited=new();
       foreach(string s in deadends)
       visited.Add(s);

        if (visited.Contains("0000")) {
            return -1;
        }
       return BFS(nextslot,prevslot,visited,target);

        
    }
    public int BFS(Dictionary<char,char> nextslot,Dictionary<char,char> prevslot,HashSet<string> visited,string target)
    {
        Queue<(string,int)> que=new();
        que.Enqueue(("0000",0));
        visited.Add("0000");
        while(que.Count>0)
        {
            var (current,distance)=que.Dequeue();
          
            if(current==target)
            return distance;
            for(int i=0;i<4;i++)
            {
                char[] next=current.ToCharArray();
                next[i]=nextslot[current[i]];
                string nextstr=new String(next);

                char[] prev=current.ToCharArray();
                prev[i]=prevslot[current[i]];
                string prevstr=new string(prev);
                if(!visited.Contains(nextstr))
                {
                que.Enqueue((nextstr,distance+1));
                visited.Add(nextstr);
                }
                if(!visited.Contains(prevstr))
                {
                que.Enqueue((prevstr,distance+1));
                visited.Add(prevstr);
                }


            }

        }
        return -1;
    }
}