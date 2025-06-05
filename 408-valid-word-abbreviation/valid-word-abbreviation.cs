public class Solution {
    public bool ValidWordAbbreviation(string word, string abbr) {

        int i=0; //word pointer
        int j=0; // abbr pointer

        while(i<word.Length&&j<abbr.Length)
        {
            
            if(char.IsDigit(abbr[j]))// digit starts
            { 
                if(abbr[j]=='0')
                return false;
                int start=j;
                while(j<abbr.Length&&char.IsDigit(abbr[j]))
                {
                    j++;
                }
                i+=Convert.ToInt32(abbr.Substring(start,j-start));
            }
            else
            {
                if(word[i]!=abbr[j])
                return false;
                i++;
                j++;
            }
        }
        if(i!=word.Length||j!=abbr.Length)
        return false;
        return true;
        
    }
}