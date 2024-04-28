public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
               List<IList<int>>[] total = new List<IList<int>>[target + 1];
        for(int k=0;k<target+1;k++)
        {
            total[k] = new List<IList<int>>();
        }
      total[0].Add(new List<int>());
        
        foreach(int item in candidates)
        {
            for(int i=item;i<target+1;i++)
            {
                
                foreach(var subset in total[i-item])
                {
                    var temp = new List<int>(subset);
                    temp.Add(item);
                    total[i].Add(temp);
                }
               
            }
        }

        return total[target];
}
}