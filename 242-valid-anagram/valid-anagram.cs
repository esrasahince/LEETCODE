public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)
        return false;
        
    int[] frequences=new int[26];
    for(int i=0;i<s.Length;i++)
    {
        frequences[s[i]-'a']++;
        frequences[t[i]-'a']--;
    }
    return frequences.All(x=>x==0);
}}