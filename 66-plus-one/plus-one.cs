public class Solution {
    public int[] PlusOne(int[] digits) {
        int sum=digits[digits.Length-1]+1;
        if(sum<10)
        {
            digits[digits.Length-1]=sum;
            return digits;
        }
       
        LinkedList<int> list=new();
        list.AddFirst(sum%10);
        int carry=sum/10;
        for(int i=digits.Length-2;i>=0;i--)
        {
            int newsum=carry+digits[i];
            list.AddFirst(newsum%10);
            carry=newsum/10;

        }
        if(carry!=0)
        list.AddFirst(carry);
        return list.ToArray();
        
    }
}