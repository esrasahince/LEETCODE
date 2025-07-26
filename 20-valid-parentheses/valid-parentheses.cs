public class Solution {
    public bool IsValid(string s) {
        if(s==null||s.Length<=1)
        return false;
        Dictionary<char,char> dict=new();
        dict['(']=')';
        dict['{']='}';
        dict['[']=']';
        Stack<char> stack=new();
        foreach (char c in s)
        {
            if(stack.Count==0)
            {
                if(!dict.ContainsKey(c))
                    return false;
                else
                {
                    stack.Push(c);
                }
            }
            else
            {
                if(dict.ContainsKey(c))
                    stack.Push(c);
                else if(dict[stack.Peek()]==c)
                stack.Pop();
                else return false;
            }
            
        }
        return stack.Count>0?false: true;
        
    }
}