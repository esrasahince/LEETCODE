public class Solution {
    public string ReverseVowels(string s) {

        HashSet<char> vowels=new();
        vowels.Add('a');
        vowels.Add('e');
        vowels.Add('i');
        vowels.Add('o');
        vowels.Add('u');
        vowels.Add('A');
        vowels.Add('E');
        vowels.Add('I');
        vowels.Add('O');
        vowels.Add('U');
        int left=0;
        int right=s.Length-1;
        char[] chars = s.ToCharArray();
        while(left<right)
        {   
            char first=s[left];
            char last=s[right];
            if(vowels.Contains(first))
            {
                if(vowels.Contains(last))
                {
                    
                    chars[left]=last;
                    chars[right]=first;
                    left++;
                   

                }
               
                    right--;

            }
            else
            {

                left++;
            }
        }
        return new String(chars);

        
    }
}