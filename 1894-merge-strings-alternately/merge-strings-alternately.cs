public class Solution {
    public string MergeAlternately(string word1, string word2) {

        int first=0;
        int second=0;
        StringBuilder result=new();
        while(first<word1.Length&&second<word2.Length)
        {
            result.Append(word1[first]);
            result.Append(word2[second]);
            first++;
            second++;

        }
        while(first<word1.Length)
        {
            result.Append(word1[first]);
            first++;
        }
           while(second<word2.Length)
        {
            result.Append(word2[second]);
            second++;
        }
        return result.ToString();
        
    }
}