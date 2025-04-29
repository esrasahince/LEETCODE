public class Solution {
    public bool IsPalindrome(string s) {
        if(s==null)
        return false;
        StringBuilder result=new();
        foreach(char item in s)
        {
            if(char.IsLetterOrDigit(item))
            {
                result.Append(char.ToLower(item));
            }
        }
        int left=0;
        int right=result.Length-1;
        while(left<right)
        {
            if(result[left]!=result[right])
            return false;
            left++;
            right--;
        }
        return true;
        
    }
}