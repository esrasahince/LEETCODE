public class Solution {
    public IList<string> LetterCasePermutation(string s) {
        List<string> result=new();
        char[] tempresult=s.ToCharArray();
        Backtracking(tempresult,s.Length-1,result);
        return result;
    }

    
    public void Backtracking(char[] s,int index,  List<string> result)
        {
            if(index<0)
            {
                result.Add(new String(s));
                return;
            }
            if(char.IsLetter(s[index]))
            {
                s[index]=char.ToLower(s[index]);

                Backtracking(s,index-1,result); //first version is same
                s[index]=char.ToUpper(s[index]);

                Backtracking(s,index-1,result); //first version is same

            }
            else
            {
                Backtracking(s,index-1,result); //first version is same
            }

        }

    
    
}