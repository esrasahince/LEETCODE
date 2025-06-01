public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        List<int> temp=new();
        List<IList<int>> result=new();
        Backtracking(candidates,0,0,target,temp,result);
        

        return result;
        
    }
    public void Backtracking(int[] nums,int start,int sum,int target,List<int> temp,List<IList<int>> result)
    {
        if(sum==target)
        {
            result.Add(new List<int>(temp));
            return;
        }
        if(sum>target)
        {
            
            return;
        }
        for(int i=start;i<nums.Length;i++)
        { //1,1,2,2
          
            if(i>start&&nums[i]==nums[i-1])
            continue;
       

            temp.Add(nums[i]);
      
            Backtracking(nums,i+1,sum+nums[i],target,temp,result);
            temp.RemoveAt(temp.Count-1);
           
        }
    }
}