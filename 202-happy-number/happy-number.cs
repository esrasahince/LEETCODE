public class Solution {
    public bool IsHappy(int n) {
        int slow=n;
        int fast=n;
    while(true)
    {
    slow=Calculate(slow);
    if(slow==1)
    return true;
    fast=Calculate(Calculate(fast));
    if(fast==slow)
    return false;
    }
    return true;
        
    }
    public int Calculate(int n)
    {
        int sum=0;

        int first=0;
        int second=n;
        while(second!=0)
        {
            first=second%10;
            second=second/10;
            sum+=first*first;
        } 
        sum+=second*second;
        return sum;
         
         

    }
}