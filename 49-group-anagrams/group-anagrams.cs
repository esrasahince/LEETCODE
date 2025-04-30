public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        //Input: strs = ["eat","tea","tan","ate","nat","bat"]

       //Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

       Dictionary<string,List<string>> result=new();

       foreach(string s in strs)
       {
       char[] temp=s.ToCharArray();
        Array.Sort(temp);
        string temp2=new string(temp);
        
        if(!result.ContainsKey(temp2))
        {
            result[temp2]=new List<string>();
        }
        result[temp2].Add(s);

       }

       List<IList<string>> resultlist=new();
       foreach(List<string> resultitem in result.Values)
       {
        resultlist.Add(resultitem);

       }
       return resultlist;
        
    }
}