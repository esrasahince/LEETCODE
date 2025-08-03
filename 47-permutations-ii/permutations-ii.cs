public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
    Array.Sort(nums);
    List<IList<int>> result=new();
    List<int> temp=new();
         HashSet<int> check=new();
        DFS(nums,0,result,temp,check);
        return result;
        
    }

    public void DFS(int[] nums,int index, List<IList<int>> result,List<int> temp,HashSet<int> check)
    {
        if(temp.Count==nums.Length)
        {
            result.Add(new List<int>(temp));
            return;
        }
         for(int i=0;i<nums.Length;i++)
        { 
          if(check.Contains(i))
          continue;
          if(i!=0&&nums[i]==nums[i-1]&&check.Contains(i-1))
          continue;
            temp.Add(nums[i]);
            check.Add(i);
            DFS(nums,i,result,temp,check);
            temp.RemoveAt(temp.Count-1);
            check.Remove(i);
        }
        
    }
}