public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        List<IList<int>> result=new();
        Array.Sort(nums);
        List<int> temp=new();
        bool[] visited=new bool[nums.Length];
        Backtracking(nums,0,visited,temp,result);
        return result;
    }
     public void Backtracking(int[] nums,int start,bool[] visited, List<int> temp,List<IList<int>> result)
    {
        
            result.Add(new List<int>(temp));

        for(int i=start;i<nums.Length;i++)
        {
            if(start>=nums.Length)
        {
            return;
        }
            if(i>start&&nums[i]==nums[i-1])//aynı seviyede dublicate olanı çağırma. bunu çağırma
            {
                continue;

            }
            temp.Add(nums[i]);
            Backtracking(nums,i+1,visited,temp,result);
            temp.RemoveAt(temp.Count-1);

        }
        
    }
        
    
    }
