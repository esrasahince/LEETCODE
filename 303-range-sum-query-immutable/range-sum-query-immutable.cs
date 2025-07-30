public class NumArray {

    int[] prefixsum = null;
    public NumArray(int[] nums)
    {
        this.prefixsum = new int[nums.Length];
        if (nums.Length >= 1)
        {
            prefixsum[0] = nums[0]; }
        for (int i = 1; i < nums.Length; i++)
        {
            prefixsum[i] = nums[i] + prefixsum[i - 1];
        }

    }

    public int SumRange(int left, int right)
    {
        if (prefixsum == null)
            return 0;
        if(left==0)
        return prefixsum[right];

        return prefixsum[right] - prefixsum[left - 1];
        
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */