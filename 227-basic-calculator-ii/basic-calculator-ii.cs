public class Solution {
    public int Calculate(string s) {
        Stack<int> stack=new();
        char operand='+';
        int number=0;
        int result=0;

        foreach(char c in s)
        {
            if(char.IsDigit(c))
            {
                number=number*10+(c-'0');
            }
            else
            { 
                if(c==' ')
                continue;
             

                switch(operand)
                {
                case '+': 
                    stack.Push(number);
                    break;
                case '-':
                    stack.Push(-number);
                    break;
                case '*':
                    stack.Push(stack.Pop()*number);
                    break;
                case '/':
                    stack.Push(stack.Pop()/number);
                    break;
                
                }
                number=0;
                operand=c;

            }
        }

            //process the last number

                switch(operand)
                {
                case '+': 
                    stack.Push(number);
                    break;
                case '-':
                    stack.Push(-number);
                    break;
                case '*':
                    stack.Push(stack.Pop()*number);
                    break;
                case '/':
                    stack.Push(stack.Pop()/number);
                    break;
                
                }
                
         
            
        
           while(stack.Count>0)
            {
                result+=stack.Pop();
            }
        return result;
        
    }

}