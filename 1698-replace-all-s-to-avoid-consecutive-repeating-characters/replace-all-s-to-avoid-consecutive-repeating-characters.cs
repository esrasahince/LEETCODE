public class Solution {
    public string ModifyString(string s) {
        char prev;
        char next;
        char[] text=s.ToCharArray();

        for(int i=0;i<s.Length;i++)
        {
            if(s[i]=='?')
            {
            prev=i>0?text[i-1]:' ';
            
            next=i+1<s.Length?text[i+1]:' ';

            for(char k='a';k<='z';k++)
            {
                if(k!=prev&&k!=next)
                {
                    text[i]=k;
                    break;
                }
            }
            }
        }
        return new String(text);
    }
}