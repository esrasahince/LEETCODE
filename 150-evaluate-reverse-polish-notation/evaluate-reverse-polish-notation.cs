public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack=new();
        HashSet<string> set=new();
        set.Add("+");
        set.Add("*");
        set.Add("-");
        set.Add("/");
        foreach(string c in tokens)
        {

            if(!set.Contains(c))
            {
                stack.Push(Convert.ToInt32(c));
            }
            else
            {
                if(stack.Count>0)
                {
                    int second=stack.Pop();
                    int first=stack.Pop();
                    int result=Calculate(first,second,c);
                    stack.Push(result);
                }
            }
        }
        return stack.Peek();
    
        
    }
    public int Calculate(int a,int b, string operand)
    {
        if(operand=="+")
        return a+b;
        if(operand=="-")
        return a-b;
        if(operand=="*")
        return a*b;
        if(operand=="/")
        return a/b;
        return -1;
    }
}