public class Solution {
    public int LastStoneWeightII(int[] stones) {
        Dictionary<(int,int,int),int> memo=new();
        return TopDown(stones,stones.Length-1,0,0,memo);



        
    }
    public int TopDown(int[] numbers,int index,int sum1,int sum2,Dictionary<(int,int,int),int> memo)
    {
        if(index<0)
        return Math.Abs(sum1-sum2);
        if(memo.ContainsKey((index,sum1,sum2)))
        return memo[(index,sum1,sum2)];

       int first=TopDown(numbers,index-1,sum1+numbers[index],sum2,memo);
       int second=TopDown(numbers,index-1,sum1,sum2+numbers[index],memo);
       memo[(index,sum1,sum2)]=Math.Min(first,second);
       return  memo[(index,sum1,sum2)];

    }
}