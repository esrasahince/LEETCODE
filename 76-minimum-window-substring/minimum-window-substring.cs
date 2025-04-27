public class Solution {
    public string MinWindow(string s, string t) {
        string resultstr = "";
        if(s.Length < t.Length)
            return resultstr;
            
        // Characters needed from string t
        Dictionary<char, int> need = new();
        foreach(char c in t) {
            if(!need.ContainsKey(c)) {
                need[c] = 1;
            } else {
                need[c]++;
            }
        }

        // Current window character count
        Dictionary<char, int> sdic = new();
        int itemcount = need.Count; // Number of unique characters we need to match
        int left = 0;
      
        for(int right = 0; right < s.Length; right++) {
            char currentChar = s[right];
            
            // If this is a character we need
            if(need.ContainsKey(currentChar)) {
                // Add to window
                if(!sdic.ContainsKey(currentChar)) {
                    sdic[currentChar] = 1;
                } else {
                    sdic[currentChar]++;
                }
                
                // Check if we've met the frequency requirement for this character
                if(sdic[currentChar] == need[currentChar]) {
                    itemcount--; // One less character to satisfy
                }
            }
           
            // If we have all needed characters
            while(itemcount == 0) { // We found all needed characters
                // Check if this window is smaller than our previous result
                if(resultstr == "" || resultstr.Length > right - left + 1) {
                    resultstr = s.Substring(left, right - left + 1);
                }
                
                // Try to shrink window from the left
                char leftChar = s[left];
                
                // If we're removing a needed character
                if(need.ContainsKey(leftChar)) {
                    sdic[leftChar]--;
                    
                    // If we now have less than needed
                    if(sdic[leftChar] < need[leftChar]) {
                        itemcount++; // Need to find this character again
                    }
                }
                
                left++; // Move left pointer forward
            }
        }
        
        return resultstr;
    }
}