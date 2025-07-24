public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int left = 0;
        int result = 0;
        int max=0;
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
            max = Math.Max(max,dict[item]);
            if (windowsize - max > k)
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

   

    


}