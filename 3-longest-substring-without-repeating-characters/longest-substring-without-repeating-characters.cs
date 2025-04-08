public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s==null||s.Length==0)
        return 0;
        Dictionary<char,int> unique=new();
        int left=0;
        int right=0;
        int max=0;
        for(int i=0;i<s.Length;i++)
        {
             
            if(!unique.ContainsKey(s[i]))
            {
                unique[s[i]]=i;    
            }
            else
            {
                if(unique[s[i]]+1<s.Length)
                {   max=Math.Max(max,right-left);
                    left=Math.Max(left,unique[s[i]]+1);
                    unique[s[i]]=i;
                    
                    
                }
                
            }
            right++;
           
        }
        return Math.Max(max,right-left);
        
    }
}