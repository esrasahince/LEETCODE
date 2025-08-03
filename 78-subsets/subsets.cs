public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {

        List<IList<int>> result=new();
        List<int> temp=new();
        DFS(nums,0,result,temp);
        return result;
        
    }

    public void DFS(int[] nums,int index, List<IList<int>> result,List<int> temp)
    {
        if(index>=nums.Length)
        {
            result.Add(new List<int>(temp));
            return;
        }


        //EKLE
        temp.Add(nums[index]);
        DFS(nums,index+1,result,temp);
        temp.RemoveAt(temp.Count-1);

        //EKLEME
        DFS(nums,index+1,result,temp);

      
    }
}