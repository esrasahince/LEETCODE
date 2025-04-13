public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> result=new();

        //sort the array to build logic
        Array.Sort(nums);

        //for each item in nums, use the 2 pointer technique
        //we want unique items in rresult. so if first pointer, or right or left pointer is same with previous pointer
        //move the pointer

        //last 2 item for left and right pointer. so nums.Length-2
        int goal=0;
        int left=0;
        int right=0;
        for(int i=0;i<nums.Length-2;i++)
        {
            if(i>0&&nums[i]==nums[i-1])
            continue; // for i, check dublicate value
            goal=-nums[i];
            //start 2 pointer technique
            left=i+1;
            right=nums.Length-1;
            
            while(left<right)
            {
                
             
                int sum=nums[left]+nums[right];
                if(sum==goal)
                {
                    result.Add(new List<int>(){nums[i],nums[left],nums[right]});
                        while(left<right&&nums[left]==nums[left+1]){left++;}
                        while(left<right&&nums[right]==nums[right-1]){right--;}
                    left++;
                    right--;
                }
                else if(sum<goal)
                {
                    left++;
                }
                else
                {right--;}
            
            
            }

        }
        return result;
    }  
    
}