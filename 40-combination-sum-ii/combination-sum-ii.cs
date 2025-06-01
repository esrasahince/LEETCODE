public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        List<int> temp=new();
        List<IList<int>> result=new();
        Backtracking(candidates,0,0,target,temp,result);
        

        return result;
        
    }
    public void Backtracking(int[] nums,int index,int sum,int target,List<int> temp,List<IList<int>> result)
    {
        if(sum==target)
        {
            result.Add(new List<int>(temp));
            return;
        }
        if(sum>target||index>=nums.Length)
        {
            
            return;
        }
        
       
         //EKLE
            temp.Add(nums[index]);
            Backtracking(nums,index+1,sum+nums[index],target,temp,result);
            temp.RemoveAt(temp.Count-1);

        //EKLEME
        
            
            while(index+1<nums.Length&&nums[index]==nums[index+1])
            {
            index++;
            }
            Backtracking(nums,index+1,sum,target,temp,result);   
        
    }
}