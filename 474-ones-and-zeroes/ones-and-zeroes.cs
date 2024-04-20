public class Solution {
    public int FindMaxForm(string[] strs, int m, int n) {

        int[,] matris = new int[m + 1, n + 1];
        foreach (var item in strs)
        {
            var zeros=item.Count(x=>x=='0');
            var ones = item.Length - zeros;

            for (int i = m; i >=zeros; i--)
            {
                for (int j = n; j >=ones; j--)
                {
                    matris[i, j] = Math.Max(matris[i, j], matris[i - zeros, j - ones] + 1);
                }
            }


        }

        return matris[m, n];
}
}