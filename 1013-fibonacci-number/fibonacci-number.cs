public class Solution {
    public int Fib(int n)
    {
            Dictionary<int,int> dict=new();
            dict[0]=0;
            dict[1]=1;
            return Bottomup(dict,n);   
    }
    public int Bottomup(Dictionary<int,int> dict,int n)
    {
        if(n<2)
        return dict[n];
        int result=0;
       
        for(int i=2;i<=n;i++)
        {
           if(dict.Keys.Contains(i))
           result=dict[i];
            else
            {result=Bottomup(dict,i-1)+Bottomup(dict,i-2);
            dict[i]=result;
            }
            
              
        }
        return result;
    }
}