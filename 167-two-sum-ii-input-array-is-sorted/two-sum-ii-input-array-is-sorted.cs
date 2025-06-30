public class Solution {
      public int[] TwoSum(int[] numbers, int target) {
    
	int left=0;
	int right=numbers.Length-1;
	int sum=0;
	
	while(left<right)
	{

	sum=numbers[left]+numbers[right];
	if(sum==target)
	{
	return new int[2]{left+1,right+1};
	}
	if(sum>target)
	right--;
	else 
	left++;
	}
	
        return new int[1];
    }
}