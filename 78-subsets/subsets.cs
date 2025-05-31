public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        
        List<IList<int>> result=new();
    
        List<int> temp=new();
        Backtracking(nums,0,temp,result);
        return result;
    }
    public void Backtracking(int[] nums,int index, List<int> temp,List<IList<int>> result)
    {
        if(index==nums.Length)
        {
        result.Add(new List<int>(temp));
        return;
        }
      
        Backtracking(nums,index+1,temp,result);
        temp.Add(nums[index]);
        Backtracking(nums,index+1,temp,result);
        temp.RemoveAt(temp.Count-1);


        
    }

}