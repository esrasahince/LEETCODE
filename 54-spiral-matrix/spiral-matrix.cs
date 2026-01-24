public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {

        int left = 0;
        int right = matrix[0].Length;
        int top = 0;
        int bottom = matrix.Length;

        List<int> result = new();

        while (left < right && top < bottom) {

            // 1️⃣ top row: left → right
            for (int col = left; col < right; col++) {
                result.Add(matrix[top][col]);
            }
            top++;

            // 2️⃣ right column: top → bottom
            for (int row = top; row < bottom; row++) {
                result.Add(matrix[row][right - 1]);
            }
            right--;

            if (left >= right || top >= bottom)
                break;

            // 3️⃣ bottom row: right → left
            for (int col = right - 1; col >= left; col--) {
                result.Add(matrix[bottom - 1][col]);
            }
            bottom--;

            // 4️⃣ left column: bottom → top
            for (int row = bottom - 1; row >= top; row--) {
                result.Add(matrix[row][left]);
            }
            left++;
        }

        return result;
    }
}
