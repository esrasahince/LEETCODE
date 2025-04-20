public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        List<int> result=new();
        if(p.Length>s.Length)
        return result;

        int[] pf=new int[26];
        int[] sf=new int[26];
        //fill p frequence
        for(int i=0;i<p.Length;i++)
        {
            pf[p[i]-'a']++;
        }

        int windowsize=p.Length;
        for(int i=0;i<windowsize;i++)
        {
            sf[s[i]-'a']++;
        }
        if(CompareArray(pf,sf))
        result.Add(0);
        for(int i=windowsize;i<s.Length;i++)
        {   char firstchar=s[i-windowsize];
            sf[firstchar-'a']--;
            sf[s[i]-'a']++;
            if(CompareArray(sf,pf))
            result.Add(i-windowsize+1);
        }

        return result;
    }
    public bool CompareArray(int[] arr1, int[] arr2)
    {
        for(int i=0;i<arr1.Length;i++)
        {
            if(arr1[i]!=arr2[i])
            return false;
        }
        return true;
    }
}