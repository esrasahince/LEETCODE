public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {

        for(int i=0;i<nums1.Length;i++)
        {
            nums1[i]=Array.IndexOf(nums2,nums1[i]);
        }

        Stack<int> stack=new();
        for(int i=nums2.Length-1;i>=0;i--)
        {
            if(stack.Count>0)
            { 
                while(stack.Count>0&&stack.Peek()<=nums2[i])
                {
                    stack.Pop();
                }
            }
            int result=nums2[i];
            if(stack.Count==0)
            {
                nums2[i]=-1;
            }
            else
            { 
                nums2[i]=stack.Peek();
            }
            stack.Push(result);

        }

        List<int> resultlist=new();
        foreach(int item in nums1)
        {
            resultlist.Add(nums2[item]);
        }
        return resultlist.ToArray();
        
    }
}