public class Solution {
    public bool CanPermutePalindrome(string s) {
        //palindrome abcdcba
        //permutation yer değiştirmiş hali
        HashSet<char> check=new();
        foreach(char i in s)
        {
            if(check.Contains(i))
            {
                check.Remove(i);
            }
            else
            check.Add(i);
        }
        return check.Count>1?false:true;
     
    
        
    }
}