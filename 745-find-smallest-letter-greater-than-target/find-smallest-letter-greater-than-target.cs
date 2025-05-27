public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {

        //x-x-y-y target z, return x

        int left=0;
        int right=letters.Length-1;
        while(left<=right)
        {
            int middle=left+(right-left)/2;

            if(target==letters[middle])
            {
                left=middle+1;
            }

            else if(target>letters[middle])
            {
                left=middle+1;

            }
            else
            {
                right=middle-1;
            }
        }
       return letters[left % letters.Length];
    }
}