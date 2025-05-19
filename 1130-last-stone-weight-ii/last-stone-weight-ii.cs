public class Solution {
    public int LastStoneWeightII(int[] stones) {
        Dictionary<(int,int),int> memo=new();
        int totalsum=0;
        for(int i=0;i<stones.Length;i++)
        {
            totalsum+=stones[i];

        }
        return TopDown(stones,stones.Length-1,0,totalsum,memo);
    }
    public int TopDown(int[] numbers,int index,int sum,int totalsum,Dictionary<(int,int),int> memo)
    {
        if(index<0)
        return Math.Abs(2*sum-totalsum);
        if(memo.ContainsKey((index,sum)))
        return memo[(index,sum)];

       int first=TopDown(numbers,index-1,sum+numbers[index],totalsum,memo);
       int second=TopDown(numbers,index-1,sum,totalsum,memo);
       memo[(index,sum)]=Math.Min(first,second);
       return  memo[(index,sum)];

    }
   


    }
