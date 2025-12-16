public class Solution {
    public int ClimbStairs(int n) {
        Dictionary<int,int> memory=new();

        return DP(n,0,memory);
        
    }

    public int DP(int n,int current,Dictionary<int,int> memory)
    {
        if(current>n)
        return 0;
        if(current==n)
        return 1;
        if(memory.ContainsKey(current))
        return memory[current];
        memory[current]=DP(n,current+1,memory)+DP(n,current+2,memory);
        return memory[current];

    }
}