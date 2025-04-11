public class Solution {
      public int[] TwoSum(int[] numbers, int target) {
	int left=0;
	int right=numbers.Length-1;
	int sum=0;
	bool check=false;
	
	
	while(left<right)
	{
	if(right<0||left<0||right>=numbers.Length||left>=numbers.Length)
	break;
	
	sum=numbers[left]+numbers[right];
	if(sum==target)
	{
	check=true;
	break;
	}
	if(sum>target)
	right--;
	else 
	left++;
	}
	if(check)
	return new int[2]{left+1,right+1};
	else
	return new int[1];
        
    }
}