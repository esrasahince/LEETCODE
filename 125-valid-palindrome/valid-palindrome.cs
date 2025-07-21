public class Solution {
    public bool IsPalindrome(string s) {
        int left=0;
        int right=s.Length-1;
     
        while(left<right)
        {
            char l=s[left];
            char r=s[right];
            if(char.IsLetterOrDigit(l)&&char.IsLetterOrDigit(r))
            {
                if(char.ToLower(l)==char.ToLower(r))
                {
                    left++;
                    right--;
                 
                    continue;
                }
                else
                return false;
            }
            else
            {
                if(!char.IsLetterOrDigit(l))
                left++;
                if(!char.IsLetterOrDigit(r))
                right--;
            }
        
        }
        return true;
        
    }
}