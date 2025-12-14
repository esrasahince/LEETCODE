public class Solution {
  public int LengthOfLongestSubstring(string s) {
    if(String.IsNullOrEmpty(s))
    return 0;
    if(String.IsNullOrWhiteSpace(s))
    return 1;

        HashSet<char> check=new();
        int result=1;
        int leftptr=0;
        //"abcabcbb"
        //left: 0 i:0  check=a
        //left: 0 i:1  check=a-b
        //left: 0 i:2  check=a-b-c
        //left: 0 i:3  check=a-b-c  result Math.MAx(0, 3-0)=3
           // s[leftptr]=a==a  leftptr=1  check b-c
        //left: 1 i:4  check=b-c  result Math.MAx(3, 4-1)=3
        

          


        for(int i=0;i<s.Length;i++)
        {
            char item=s[i];
            if(check.Contains(item))
            {
                result=Math.Max(result,i-leftptr);
                while(s[leftptr]!=item)
                {
                    check.Remove(s[leftptr]);
                    leftptr++;
                }
                check.Remove(s[leftptr]);
                leftptr++;



            }
            check.Add(item);

        }

        return Math.Max(result,check.Count);
        
    }

}