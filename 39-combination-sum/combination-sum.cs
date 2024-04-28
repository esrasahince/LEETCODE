public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
            List<List<List<int>>> sum = new List<List<List<int>>>();
        
        // Initialize the sum list with empty lists
        for (int i = 0; i <= target; i++) {
            sum.Add(new List<List<int>>());
        }
        
        // Base case: There's one way to get a sum of 0
        sum[0].Add(new List<int>());

        // Iterate through each candidate and fill the sum list
        foreach (int item in candidates) {
            for (int i = item; i <= target; i++) {
                foreach (var subset in sum[i - item]) {
                    var temp = new List<int>(subset); // Make a copy of the subset
                    temp.Add(item);
                    sum[i].Add(temp);
                }
            }
        }
        
    IList<IList<int>> result = new List<IList<int>>();
        foreach (var list in sum[target]) {
            result.Add(list);
        }
        
        return result;
        
    }
}