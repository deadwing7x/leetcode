public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        IList<int> result = new List<int>();
        
        if (matrix is null || matrix.Length is 0) {
            return result;
        }
        
        int left = 0;
        int right = matrix[0].Length - 1;
        int top = 0;
        int bottom = matrix.Length - 1;

        int size = matrix.Length * matrix[0].Length;
        
        while (result.Count < size) {
            for (int i = left; i <= right && result.Count < size; i++) {
                result.Add(matrix[top][i]);
            }
            
            top++;
            
            for (int i = top; i <= bottom && result.Count < size; i++) {
                result.Add(matrix[i][right]);
            }
            
            right--;
            
            for (int i = right; i >= left && result.Count < size; i--) {
                result.Add(matrix[bottom][i]);
            }
            
            bottom--;
            
            for(int i = bottom; i >= top && result.Count < size; i--) {
                result.Add(matrix[i][left]);
            }
            
            left++;
        }
        
        return result;
    }
}

// Example 1:

// Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
// Output: [1,2,3,6,9,8,7,4,5]

// Example 2:

// Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
// Output: [1,2,3,4,8,12,11,10,9,5,6,7]