// Solution using In-Order traversal:

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
    public int KthSmallest(TreeNode root, int k) {
        if (root is null) {
            return -1;
        }
        
        List<int> values = traverseNodesInOrder(root);
        
        return values[k - 1];
    }
    
    List<int> traverseNodesInOrder(TreeNode root) {
        List<int> nodes = new();
        
        if (root is not null) {
            nodes.AddRange(traverseNodesInOrder(root.left));

            nodes.Add(root.val);
        
            nodes.AddRange(traverseNodesInOrder(root.right));
        }
        
        return nodes;
    }
}

// Solution using Stack

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
    public int KthSmallest(TreeNode root, int k) {
        Stack<TreeNode> stack = new();
        
        while (stack.Count > 0 || root is not null) {
            if (root is not null) {
                stack.Push(root);
                root = root.left;
            } else {
                root = stack.Pop();
                
                k--;
                
                if (k is 0) {
                    return root.val;
                }
                
                root = root.right;
            }
        }
        
        return -1;
    }
}

// Example 1:

// Input: root = [3,1,4,null,2], k = 1
// Output: 1

// Example 2:

// Input: root = [5,3,6,2,4,null,null,1], k = 3
// Output: 3