public class Solution {
    public IList<IList<int>> Permute(int[] nums) {

        List<IList<int>> resultlist=new();
        List<int> result=new();
        bool[] visited=new bool[nums.Length];
        BackTracking(nums,visited,result,resultlist);
        return resultlist;

        
    }
    public void BackTracking(int[] nums,bool[] visited,List<int> result,List<IList<int>> resultlist)
    {
        if(result.Count==nums.Length)
        {
            var temp=new List<int>(result);
            resultlist.Add(temp);
            return;
        }
        
        for(int i=0;i<nums.Length;i++)
        {
            if(!visited[i])
            {
              visited[i]=true;
              result.Add(nums[i]);
              BackTracking(nums,visited,result,resultlist);
              result.RemoveAt(result.Count-1);
              visited[i]=false;
            }   
        }
    }
}