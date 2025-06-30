public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        Array.Sort(nums);
        HashSet<(int,int,int)> hash=new();
        var result = new List<IList<int>>();
        
        for(int i=0;i<nums.Length-2;i++)
        {
	        int left=i+1;
	        int right = nums.Length - 1;
        
        while (left < right)
        {
            int sum = nums[left] + nums[right];
            int target=-nums[i]; //toplamı 0 olan
            if (sum == target)
            {
                if(!hash.Contains((nums[i],nums[left], nums[right])))
                {
                result.Add(new List<int> { nums[i],nums[left], nums[right] });
                hash.Add((nums[i],nums[left], nums[right]));
                }
                
                // Skip duplicates
                while (left < right && nums[left] == nums[left + 1]) left++;
                while (left < right && nums[right] == nums[right - 1]) right--;
                //kod bitmesin devam etsin baska eslesmeler için 
                left++;
                right--;
            }
            else if (sum < target)
                left++;
            else
                right--;
        }
        }
        
        return result;
    }
}