public class Solution {
    public void Rotate(int[] nums, int k) {
           if (nums == null || nums.Length == 0 || k == 0)
            return;
        k = k % nums.Length;
        Array.Reverse(nums);
        int firstpart=k;
       
        //first part reverse
        Reverse(nums,0,firstpart-1);
        Reverse(nums,firstpart,nums.Length-1);
     
        
    }

public void Reverse(int[] nums,int begin, int end)
{
    while(begin<end)
    {
        int temp=nums[end];
        nums[end]=nums[begin];
        nums[begin]=temp;
        begin++;
        end--;
    }
}
}