public class Solution {
    public string LongestPalindrome(string s) {

        //Input: s = "babad"
       // Output: "bab"
  if (string.IsNullOrEmpty(s) || s.Length < 1)
            return "";
  
   string result = s[0].ToString();
        string temp = null;
    for(int i=0;i<s.Length-1;i++)
    {
        
        
           temp=Check(i,i,s);
           if(temp!=null&&temp.Length>result.Length)
        result=temp;

      
            temp=Check(i,i+1,s);
            if(temp!=null&&temp.Length>result.Length)
        result=temp;

        
     
        

    
    }
    return result;
               
        
    }
    public string Check(int left, int right,string s)
    {
        while(left>=0&&right<=s.Length-1&&s[left]==s[right])
        {
        
            left--;
            right++;
        }
        left++;
        right--;
        return s.Substring(left,right-left+1);
    }
}