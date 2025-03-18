public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        int index=0;
        int[] stack=new int[n];
        int nindex=1;
        IList<string> result=new List<string>();
        for(int i=0;i<target.Length;i++)
        {
          
            while(nindex<=target[i])
            {
                result.Add("Push");
                Push(stack,ref index,nindex );
                nindex++;
                if(Peek(stack,ref index)!=target[i])
                {
                result.Add("Pop");
                Pop(stack,ref index);
                }
                else
                break;
               
            }
           


        }
        return result;

        
    }
    public void Push(int[] stack, ref int lastindex,int item)
    {
        stack[lastindex]=item;
        lastindex++;
    }
       public void Pop(int[] stack, ref int lastindex)
    {
        stack[lastindex-1]=0;
        lastindex--;
    }
        public int Peek(int[] stack, ref int lastindex)
    {
        return stack[lastindex-1];
        
    }
}