public class Solution {
    public int MyAtoi(string s) {
        StringBuilder temp = new();
        bool signadded = false;

        foreach (char c in s) {
            if (c == ' ') {
                if (!signadded && temp.Length == 0)
                    continue;
                else
                    break;
            }

            if ((c == '+' || c == '-')) {
                if (temp.Length == 0) {
                    temp.Append(c);
                    signadded = true;
                } else {
                    break;
                }
            }
            else if (char.IsDigit(c)) {
                temp.Append(c);
            }
            else {
                break;
            }
        }

        if (temp.Length == 0 || (temp.Length == 1 && (temp[0] == '+' || temp[0] == '-')))
            return 0;

      if (long.TryParse(temp.ToString(), out long result)) {
            if (result > int.MaxValue) return int.MaxValue;
            if (result < int.MinValue) return int.MinValue;
            return (int)result;
        } else {
            // Eğer long sınırını da aştıysa:
            return temp[0] == '-' ? int.MinValue : int.MaxValue;
        }
    }
}
