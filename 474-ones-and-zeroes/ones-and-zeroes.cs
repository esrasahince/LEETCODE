public class Solution {
    public int FindMaxForm(string[] strs, int m, int n) {

// Sort strings by length
    Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));

    // Create a dictionary to store capacity information
    Dictionary<string, int> capacity = new Dictionary<string, int>();

    // Initialize the dictionary with all possible capacities
    for (int i = 0; i <= m; i++)
    {
        for (int j = 0; j <= n; j++)
        {
            capacity[$"{i},{j}"] = 0; // Initialize counts to 0
        }
    }

    // Initialize matrix for dynamic programming
    int[,] dp = new int[m + 1, n + 1];

    // Iterate through each string
    foreach (string str in strs)
    {
        // Count zeros and ones in the current string
        int zeros = str.Count(c => c == '0');
        int ones = str.Length - zeros;

        // Update the dynamic programming matrix
        for (int i = m; i >= zeros; i--)
        {
            for (int j = n; j >= ones; j--)
            {
                dp[i, j] = Math.Max(dp[i, j], dp[i - zeros, j - ones] + 1);
            }
        }
    }

    // Return the maximum subset size
    return dp[m, n];
}
}