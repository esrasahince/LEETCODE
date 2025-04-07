public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> result = new();
     
        if (numRows == 0)
            return result;

        result.Add(new List<int> { 1 });

        for (int i = 1; i < numRows; i++) {
            List<int> row = new();
            IList<int> prev = result[i - 1];

            row.Add(1);
            for (int j = 1; j < prev.Count; j++) {
                row.Add(prev[j - 1] + prev[j]);
            }
            row.Add(1);

            result.Add(row);
        }

        return result;
    }
}
