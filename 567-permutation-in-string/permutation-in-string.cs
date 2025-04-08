public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length)
            return false;
        int[] freq1=new int[26];
        int[] freq2=new int[26];
         
         //calculate s1 frequence
         foreach(char item in s1)
         {
            freq1[item-'a']++;
         }

         //first window
         int windowsize=s1.Length;
         for(int i=0;i<windowsize;i++)
         {
            if(i<s2.Length)
            freq2[s2[i]-'a']++;
         }
         if(CheckArray(freq1,freq2))
         return true;

         //slide window
        
         for(int i=windowsize;i<s2.Length;i++)
         {
            freq2[s2[i]-'a']++;
            freq2[s2[i-windowsize]-'a']--;
            
            if(CheckArray(freq1,freq2))
            return true;

         }
         return false;

        
    }
    public bool CheckArray(int[] arr1,int[] arr2)
    {
        for(int i=0;i<arr1.Length;i++)
        {
            if(arr1[i]!=arr2[i])
            return false;
        }
        return true;
    }
}