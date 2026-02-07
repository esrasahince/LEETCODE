public class Solution {
    public int LengthOfLIS(int[] nums) {

        
            int n = nums.Length;
            int[] dp = new int[n];
            for(int i=0;i<n;i++)
            {
                dp[i] = 1;
            }

            for(int i=1;i<n;i++)
            {
                for(int j=0;j<i;j++)
                {

                    {
                        if (nums[i] > nums[j])
                        {
                            dp[i] =Math.Max(dp[i], 1 + dp[j]);
                        }
                    }

                }
            }

            int result = int.MinValue;
            for(int i=0;i<n;i++)
            {
                result = Math.Max(result, dp[i]);
            }
            return result;
        
        
        
        }
        
    }
