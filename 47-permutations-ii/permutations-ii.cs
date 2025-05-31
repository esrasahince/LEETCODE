public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        List<IList<int>> result=new();
        List<int> temp=new();
        Array.Sort(nums);
        bool[] visited=new bool[nums.Length];
        Backtracking(nums,visited,temp,result);
        return result;
    }
    public void Backtracking(int[] nums,bool[] visited,List<int> temp,List<IList<int>> result)
    {
        if(temp.Count==nums.Length)
        {
            result.Add(new List<int>(temp));
            return;
        }
        for(int i=0;i<nums.Length;i++)
        {
        if(!visited[i])
        {
            if(i>0&&nums[i]==nums[i-1]&&!visited[i-1])
            {
                continue;
            }
            visited[i]=true;
            temp.Add(nums[i]);
            Backtracking(nums,visited,temp,result);
            visited[i]=false;
            temp.RemoveAt(temp.Count-1);
                
            
        }
        }
    }


        
    
}