public class Solution {
    public bool IsPalindrome(string s) {
        
        if(String.IsNullOrEmpty(s))
        return true;
        
        s=s.ToLower();
        s=new String(s.Where(x=>char.IsLetterOrDigit(x)).ToArray());
     
       
        int beginptr=0;
        int endptr=s.Length-1;
        while(beginptr!=endptr&&beginptr<s.Length-1&&endptr>=0)
        {
            if(s[beginptr]!=s[endptr])
            return false;
            beginptr++;
            endptr--;

        }
        return true;
        
    }
}