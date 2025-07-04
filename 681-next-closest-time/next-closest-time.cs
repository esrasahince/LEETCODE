public class Solution {
    public string NextClosestTime(string time) {
        // Extract digits from time string and find minimum 
        int[] digits = new int[4];
        int count = 0;
        int minDigit = 9;
        
        foreach(char c in time) {
            if(char.IsDigit(c)) {
                digits[count] = c - '0';
                minDigit = Math.Min(digits[count], minDigit);
                count++;
            }
        }
        
        // Get sorted unique digits for next digit lookup
         var uniqueDigits = digits.Distinct().ToArray();
         Array.Sort(uniqueDigits);

        
        // Create lookup dictionary for next larger digit
        Dictionary<int, int> nextDigit = new Dictionary<int, int>();
        for(int i = 0; i < uniqueDigits.Length - 1; i++) {
            nextDigit[uniqueDigits[i]] = uniqueDigits[i + 1];
        }
        nextDigit[uniqueDigits[uniqueDigits.Length - 1]] = -1; // No next digit for largest
        
        // Try to increment from rightmost position
        for(int pos = 3; pos >= 0; pos--) {
            if(nextDigit[digits[pos]] != -1) { //yani kendinden büyük eleman varsa
                int originalDigit = digits[pos]; //değiştir valid mi diye bak
                digits[pos] = nextDigit[digits[pos]];
                
                if(IsValidTime(digits)) {
                    // valid ise kendinden sonrakileri min ile doldur. 
                    for(int i = pos + 1; i < 4; i++) {
                        digits[i] = minDigit;
                    }
                    return ConvertToString(digits);
                }
                
                // Revert if invalid
                digits[pos] = originalDigit;
            }
        }
        
        // If no valid next time found, wrap around to next day
        Array.Fill(digits, minDigit);
        return ConvertToString(digits);
    }
    
    private string ConvertToString(int[] digits) {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < 4; i++) {
            sb.Append((char)(digits[i] + '0'));
            if(i == 1) {
                sb.Append(':');
            }
        }
        return sb.ToString();
    }
    
    private bool IsValidTime(int[] digits) {
        int hours = digits[0] * 10 + digits[1];
        int minutes = digits[2] * 10 + digits[3];
        return hours < 24 && minutes < 60;
    }
}