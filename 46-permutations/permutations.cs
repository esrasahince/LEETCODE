public class Solution {
    public IList<IList<int>> Permute(int[] nums) {

        List<IList<int>> resultlist=new();
        List<int> result=new();
        BackTracking(nums,result,resultlist);
        return resultlist;

        
    }
    public void BackTracking(int[] nums,List<int> result,List<IList<int>> resultlist)
    {
        if(result.Count==nums.Length)
        {
            var temp=new List<int>(result);
            resultlist.Add(temp);
            return;
        }
        
        for(int i=0;i<nums.Length;i++)
        {
            if(!result.Contains(nums[i]))
            {
              result.Add(nums[i]);
              BackTracking(nums,result,resultlist);
              result.RemoveAt(result.Count-1);
            }   
        }
    }
}