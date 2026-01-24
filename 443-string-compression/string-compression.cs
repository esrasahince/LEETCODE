public class Solution {
    public int Compress(char[] chars) {
        int writeIndex = 0;  // Where we write compressed data
        int readIndex = 0;   // Where we read from
        
        while(readIndex < chars.Length)
        {
            char currentChar = chars[readIndex];
            int count = 0;
            
            // Count consecutive occurrences of current character
            while(readIndex < chars.Length && chars[readIndex] == currentChar)
            {
                readIndex++;
                count++;
            }
            
            // Write the character
            chars[writeIndex++] = currentChar;
            
            // Write the count if greater than 1
            if(count > 1)
            {
                string countStr = count.ToString();
                foreach(char c in countStr)
                {
                    chars[writeIndex++] = c;
                }
            }
        }
        
        return writeIndex;
    }
}