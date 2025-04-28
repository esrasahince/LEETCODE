public class Solution {
    public string MinWindow(string s, string t) {
        string result = "";

        if (t.Length > s.Length)
            return result;

        // Frequency of t
        Dictionary<char, int> tdic = new();
        foreach (char item in t) {
            if (tdic.ContainsKey(item))
                tdic[item]++;
            else
                tdic[item] = 1;
        }

        int start = 0;
        Dictionary<char, int> sdic = new();
        int count = 0;

        for (int i = 0; i < s.Length; i++) {
            char item = s[i];
            
            if (tdic.ContainsKey(item)) {
                if (sdic.ContainsKey(item))
                    sdic[item]++;
                else
                    sdic[item] = 1;

                // Sadece eşitlendiği anda count artırıyoruz. 
				//yani tdic count ile burdaki count esit oldugunda
				//bu demektirki hem itemlar hem de onların frekansları eşit
				//artık pencereyi sonlandırabiliiz.
                if (sdic[item] == tdic[item])
                    count++;
            }

            // windowu küçültmeye çalış
            while (count == tdic.Count) {
                // window daha küçükse sonucu güncelle
				char remove = s[start];
				
				
				
                if (result == "" || (i - start + 1) < result.Length)
                    result = s.Substring(start, i - start + 1);
				
                
                  if (tdic.ContainsKey(remove)) {
                    sdic[remove]--;
                    if (sdic[remove] < tdic[remove]) {
                        count--;
                    }
                }
                    
					start++;
                
               
            }
        }

        return result;
    }
}
