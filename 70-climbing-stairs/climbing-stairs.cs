public class Solution {
    public int ClimbStairs(int n)
            {
                Dictionary<int,int> dict=new();
            return Recursive(n, n,dict);
            }

            public int Recursive(int n,int current, Dictionary<int,int> dict)
        {
            if (current < 0)
                return 0;
            if (current<=1)
               return 1;
            if(dict.ContainsKey(current))
            return dict[current];
            
            int onestep = Recursive(n, current - 1,dict);
            int twostep= Recursive(n, current - 2,dict);

         int result=onestep + twostep;
         dict[current]=result;
         return result;

        }}
