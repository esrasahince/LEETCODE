public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left=0;
        int right=0;
        HashSet<char> set=new();
        int result=0;
        while(right<s.Length)
        {
            if(!set.Contains(s[right]))
            {
                set.Add(s[right]);
                right++;

            }
            else
            {
                result=Math.Max(result,right-left);
                while(s[left]!=s[right]&&left<=right)
                {
                    set.Remove(s[left]);
                    left++;
                }
                 set.Remove(s[left]);
                left++;
            }
        }
        result=Math.Max(result,right-left);

        return result;
        
    }
}