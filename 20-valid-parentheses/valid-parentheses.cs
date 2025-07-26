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
                if(dict.ContainsKey(c))
                    stack.Push(c);
                else if(stack.Count==0||dict[stack.Peek()]!=c)
                return false;
                else stack.Pop();
            
            
        }
        return stack.Count>0?false: true;
        
    }
}