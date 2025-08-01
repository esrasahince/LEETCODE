public class Solution {
    public int ExpressiveWords(string s, string[] words) {

        List<(char,int)> sresult=Analyse(s);
        int result=0;
        foreach(string word in words)
        {
            List<(char,int)> wresult=Analyse(word);
          
            if(Check(sresult,wresult))
             result++;      
        }
           
            

        
        return result;  
    }
    public bool Check(List<(char,int)> sresult, List<(char,int)> wresult)
    {
          if(sresult.Count!=wresult.Count)
                return false;;
        
            for(int i=0;i<sresult.Count;i++)
            {
                int wcount=wresult[i].Item2;
                char wc=wresult[i].Item1;
                 int scount=sresult[i].Item2;
                char sc=sresult[i].Item1;
                // Characters must match
            if (sc != wc)
                return false;
            
            // If counts are equal, it's valid
            if (scount == wcount)
                continue;
            
            // If s has fewer characters than word, impossible to stretch
            if (scount < wcount)
                return false;
            
            // If s has more characters, it must be stretchable (at least 3)
            if (scount > wcount && scount < 3)
                return false;
            }
            return true;
        
    }
    public List<(char,int)> Analyse(string s)

    {   List<(char,int)> result=new();
        char c=s[0];
        int count=0;
        int index=0;
        while(index<s.Length)
        {
            if(s[index]==c)
              count++;
            else
            {
                result.Add((c,count));
                count=1;
                c=s[index];
            }
            index++;
        }
        result.Add((c, count));
        return result;
        
    }
}