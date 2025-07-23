public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(String.IsNullOrEmpty(s))
        return 0;
        if(s.Length==1)
        return 1;
        HashSet<char> hash=new();
        int left=0;
        int result=0;
        for(int right=0;right<s.Length;right++)
        {
            char item=s[right];
            if(hash.Contains(item))
            {
               while(hash.Contains(item))
               {
                  hash.Remove(s[left]);
                  left++;
               }
               hash.Add(item);
            }
            else
            {
                hash.Add(item);
            }
            result=Math.Max(result,right-left+1);
        }
        return result;
        
    }
}