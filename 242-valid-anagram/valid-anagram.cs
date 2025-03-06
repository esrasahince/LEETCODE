public class Solution {
    public bool IsAnagram(string s, string t) {

        Char[] s1=s.ToCharArray();
        Char[] t1=t.ToCharArray();
        Array.Sort(s1);
        Array.Sort(t1);

        
       String snew= new String(s1);
       String tnew= new String(t1);

        if(snew==tnew)
        return true;
        return false;
        
    }
}