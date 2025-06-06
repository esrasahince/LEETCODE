/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // Constructor initializes an empty nested list.
 *     public NestedInteger();
 *
 *     // Constructor initializes a single integer.
 *     public NestedInteger(int value);
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // The result is undefined if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // Set this NestedInteger to hold a single integer.
 *     public void SetInteger(int value);
 *
 *     // Set this NestedInteger to hold a nested list and adds a nested integer to it.
 *     public void Add(NestedInteger ni);
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // The result is undefined if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class Solution {
    public int DepthSum(IList<NestedInteger> nestedList) {
        int sum=0;
        int level=1;
        Recursive(nestedList,ref sum,level);
        return sum;
   
        
    }
    public void Recursive(IList<NestedInteger> nestedList,ref int sum,int level)
    {
          
            foreach(var item in nestedList)
            {
                if(item.IsInteger())
                {
                    sum+=item.GetInteger()*level;

                }
                else
                {
                   Recursive(item.GetList(),ref sum,level+1);
                }

            }
            
        
    }
}