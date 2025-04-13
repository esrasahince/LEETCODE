public class Solution {
    public int JobScheduling(int[] startTime, int[] endTime, int[] profit) {
        int n = startTime.Length;
        var jobs = new List<(int start, int end, int profit)>();

        for (int i = 0; i < n; i++) {
            jobs.Add((startTime[i], endTime[i], profit[i]));
        }

        // Sıralama: end'e göre değil, start'a göre sıralayacağız binary search için
        jobs.Sort((a, b) => a.start.CompareTo(b.start));

        var starts = jobs.Select(j => j.start).ToList();
        var memo = new Dictionary<int, int>();

        return Dp(0, jobs, starts, memo);
    }

    private int Dp(int index, List<(int start, int end, int profit)> jobs, List<int> starts, Dictionary<int, int> memo) {
        if (index >= jobs.Count) return 0;
        if (memo.ContainsKey(index)) return memo[index];

        // Bir sonraki job'u bul: şu anki işin end zamanından sonra başlayan ilk işi bul
        int next = LowerBound(starts, jobs[index].end);

        int take = jobs[index].profit + Dp(next, jobs, starts, memo);
        int skip = Dp(index + 1, jobs, starts, memo);

        return memo[index] = Math.Max(take, skip);
    }

    // C#'ta binary search karşılığı lower bound
    private int LowerBound(List<int> arr, int target) {
        int left = 0, right = arr.Count;
        while (left < right) {
            int mid = (left + right) / 2;
            if (arr[mid] < target) left = mid + 1;
            else right = mid;
        }
        return left;
    }
}
