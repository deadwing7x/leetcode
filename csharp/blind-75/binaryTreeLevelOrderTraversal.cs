/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        
        if (root is null) {
            return result;
        }
        
        Queue<TreeNode> visited = new();
        visited.Enqueue(root);
        
        while (visited.Count != 0) {
            List<int> currentLevel = new();
            
            int currentLevelCount = visited.Count;
            
            for (int i = 0; i < currentLevelCount; i++) {
                TreeNode currentNode = visited.Peek();
                visited.Dequeue();
                
                currentLevel.Add(currentNode.val);
                
                if (currentNode.left is not null) {
                    visited.Enqueue(currentNode.left);
                }
                
                if (currentNode.right is not null) {
                    visited.Enqueue(currentNode.right);
                }
            }
            
            result.Add(currentLevel);
        }
        
        return result;
    }
}

// Example 1:

// Input: root = [3,9,20,null,null,15,7]
// Output: [[3],[9,20],[15,7]]

// Example 2:

// Input: root = [1]
// Output: [[1]]

// Example 3:

// Input: root = []
// Output: []