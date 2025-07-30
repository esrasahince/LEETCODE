public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int,int> dict=new();
        dict[0]=1;
        int currentsum=0;
        int result=0;
        for(int i=0;i<nums.Length;i++)
        {
            currentsum+=nums[i];
            int temp=currentsum-k;
            if(dict.ContainsKey(temp)) //k yı bulduk demektir. resultı güncelle
            {
                result+=dict[temp];
            }
            //her durumda currentsumı dicte ekliycez
            if(dict.ContainsKey(currentsum))
            {
                dict[currentsum]++;
            }
            else
            {
                 dict[currentsum]=1;
                
            }

        }
        return result;
        
    }
}