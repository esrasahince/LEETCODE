public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<IList<int>> result=new();

        HashSet<(int,int,int)> set=new();
        for(int i=0;i<nums.Length-2;i++)
        {
            int sum=-nums[i];
            int left=i+1;
            int right=nums.Length-1;
            while(left<right)
            {
                int tempsum=nums[left]+nums[right];
                if(tempsum==sum)
                {  List<int> temp=new();
                  temp.Add(nums[i]);
                  temp.Add(nums[left]);
                  temp.Add(nums[right]);
                  if(!set.Contains((nums[i],nums[left],nums[right])))
                  {
                    result.Add(temp);
                    set.Add((nums[i],nums[left],nums[right]));
                  }
                
                  right--;
                  left++;
                

                }
               else if(tempsum>sum)
                right--;
                else
                left++;
                
            }

        }
        return result;

        
    }
}