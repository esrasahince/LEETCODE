public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> result=new();
        int len=nums.Length;
        if(len<3)
        return result;
        Array.Sort(nums);
        int left=0;
        int right=len-1;
        int target=0;

        for(int i=0;i<nums.Length-2;i++) //current value and 2 pointer 
        {
            //for make unique the result for i pointer;
            if(i>0&&nums[i]==nums[i-1])
            continue;
            target=-nums[i];
            left=i+1;
            right=len-1;
             
            while(left<right)
            { //now 2 pointer

                int tempsum=nums[left]+nums[right];
                if(tempsum==target)
                {
                result.Add(new List<int>{nums[i],nums[left],nums[right]});
                while(left+1<right)
                {
                    if(nums[left]==nums[left+1])
                    {
                        left++;
                    }
                    else break;
                }
                while(right-1>left)
                {
                    if(nums[right]==nums[right-1])
                    {
                        right--;
                    }
                    else break;
                }
                left++;
                right--;

                }
                else if(tempsum>target)
                right--;
                else 
                left++;
            }
            

        }
        return result;
        
    }
}