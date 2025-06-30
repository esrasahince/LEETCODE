public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s==null)
            return 0;
        if(s.Length==1)
            return 1;
     
    int left=0;
    Dictionary<char,int> dict=new();
    int result=int.MinValue;
    for(int right=0;right<s.Length;right++)
    {
        if(!dict.ContainsKey(s[right]))
        {
            dict[s[right]]=right;
            
        }
        else
        {
            int until=dict[s[right]];
            result=Math.Max(result,right-left);
            while(left<=until)
            {
                dict.Remove(s[left]);
                left++;
            }
            dict[s[right]]=right;
        }
        
    }

    result=Math.Max(result,s.Length-left);
    return result;
}
}