public class Solution {
    public int[] OccurrencesOfElement(int[] nums, int[] queries, int x) {
        List<int> index=new();
        
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==x)
            index.Add(i);
        }
        
        for(int i=0;i<queries.Length;i++)
        {
            if(queries[i] < 1 ||queries[i]>index.Count)
            queries[i]=-1;
            else 
            {
             queries[i]=index[queries[i]-1];

            }
        }
        return queries;
        
    }
}