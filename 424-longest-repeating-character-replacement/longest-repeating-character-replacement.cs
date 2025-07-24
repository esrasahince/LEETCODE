public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int left = 0;
        int result = 0;
        Dictionary<char,int> dict=new();
        for (int right = 0; right < s.Length; right++)
        {
            char item = s[right];
            if (dict.ContainsKey(item))
            {
                dict[item]++;
            }
            else
            {
                dict[item] = 1;
            }
            int windowsize = right - left + 1;
            var max = CheckDict(dict);
            if (windowsize - max.Value > k)
            {
                char slideitem = s[left];
                dict[slideitem]--;
                if (dict[slideitem] <= 0)
                    dict.Remove(slideitem);
                left++;
            }
            result = Math.Max(result, right - left + 1);


        }
        return result;

    }

    public KeyValuePair<char, int> CheckDict(Dictionary<char, int> dict)
    {
        Comparer<int> comp = Comparer<int>.Create((a, b) => b.CompareTo(a));
        PriorityQueue<KeyValuePair<char,int>, int> que = new PriorityQueue<KeyValuePair<char,int>, int>(comp);
        foreach (var item in dict)
        {
            que.Enqueue(item, item.Value);
        }
        return que.Peek();
    }

    


}