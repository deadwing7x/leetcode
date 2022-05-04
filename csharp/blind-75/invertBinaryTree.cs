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
    public TreeNode InvertTree(TreeNode root) {
        if (root is null) {
            return null;
        }
        
        return invertChildNodes(root);
    }
    
    TreeNode invertChildNodes(TreeNode node) {
        if (node is null) {
            return null;
        }
        
        TreeNode tempNode = node.left;
        node.left = node.right;
        node.right = tempNode;
        
        invertChildNodes(node.left);
        
        invertChildNodes(node.right);
        
        return node;
    }
}

// Example 1:

// Input: root = [4,2,7,1,3,6,9]
// Output: [4,7,2,9,6,3,1]

// Example 2:

// Input: root = [2,1,3]
// Output: [2,3,1]

// Example 3:

// Input: root = []
// Output: []

// Example 4:

// Input: root = [10,5,15,3,7,12,18,1,2,6,8,11,13,16,19]

// Output: [10,15,5,18,12,7,3,19,16,13,11,8,6,2,1]

