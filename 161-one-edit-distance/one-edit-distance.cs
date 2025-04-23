public class Solution {
    public bool IsOneEditDistance(string s, string t) {
       int slen=s.Length;
       int tlen=t.Length;
       if(Math.Abs(slen-tlen)>=2)
       return false;
       bool deletion=false;
       bool replacement=false;
       if(slen-tlen==1)
       {
        deletion=true;
       }
       if(slen==tlen)
       {
        replacement=true;
       }
       bool founddifference=false;
       int sptr=0;
       int tptr=0;
        while(sptr<slen&&tptr<tlen)
        {
        if(t[tptr]==s[sptr])
        {
             sptr++;
             tptr++;

        }
        else
        { 
            if(founddifference)
                return false;
            founddifference=true;
            if(replacement)
                {
                sptr++;
                tptr++;
                }
            else if(deletion)
            {
                sptr++;}
            else
            {
                tptr++;
            }
        }


       }
       return founddifference || sptr < slen || tptr < tlen;
    
    }
}