public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {

    List<IList<int>> result=new();
    List<int> temp=new();
      
    DFS(candidates,0,0,target,result,temp);
    return result;
        
    }

    public void DFS(int[] nums,int index,int sum,int target,List<IList<int>> result,List<int> temp)
    {
        if(index>=nums.Length)
        return;
        if(sum==target)
        {
            result.Add(new List<int>(temp));
            return;
        }
        //EKLEME bir sonrakinden devam et
        DFS(nums,index+1,sum,target,result,temp);

        //EKLE
        if(sum+nums[index]<=target)
        {
        temp.Add(nums[index]);
        DFS(nums,index,sum+nums[index],target,result,temp);
        temp.RemoveAt(temp.Count-1);
        }
        
    }
}