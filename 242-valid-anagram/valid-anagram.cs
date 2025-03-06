public class Solution {
    public bool IsAnagram(string s, string t) {
        int slen=s.Length;
        int tlen=t.Length;
        if(slen!=tlen)
        return false;
        List<int> s1=new();
        List<int> t1=new();

       


        for(int i=0;i<slen;i++)
        {
            s1.Add((int)s[i]);
            t1.Add((int)t[i]);

        }
        s1.Sort();
        t1.Sort();
        if(s1.SequenceEqual(t1))
        return true;
        return false;


        
    }
}