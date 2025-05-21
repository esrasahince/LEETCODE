public class Solution {
    public int MaxCoins(int[] piles) {
	
	Array.Sort(piles);
	int left=0;
	int right=piles.Length-1;
	if(piles.Length==3)
	return piles[1];
	if(piles.Length<3)
	return 0;
	
	int result=0;
	while(left<right)
	{
	right--;
	if(right>0)
	{
	result+=piles[right];
	

	}
	right--;
	left++;
	
	
	}
	return result;
        
        
    }
}