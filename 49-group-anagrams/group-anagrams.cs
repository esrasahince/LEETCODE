public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dict=new();
        List<IList<string>> result=new();

        foreach(string s in strs)
        {
            int[] item=new int[26];
            for(int i=0;i<s.Length;i++)
            {
                int index=s[i]-'a';
                item[index]++;
            }
             string key = string.Join(",", item);
            if(!dict.ContainsKey(key))
            {
                dict[key]=new List<string>();
            }
            dict[key].Add(s);
        }
        

        foreach(KeyValuePair<string,List<string>> wordlist in dict)
        {
            result.Add(wordlist.Value);
        }
      return result;

    }
}