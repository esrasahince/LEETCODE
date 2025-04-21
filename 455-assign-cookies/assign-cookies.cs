public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        if(s.Length==0||g.Length==0)
        return 0;
       Array.Sort(g);
       Array.Sort(s);
       int result=0;
       int sind=0;
       for(int i=0;i<g.Length;i++)
       {
        while(sind<s.Length)
        {
            if(g[i]<=s[sind])
            {
                result++;
                 sind++;
                break;

            }
             sind++;
          
            
        }
         
       }
       return result;
        
    }
}