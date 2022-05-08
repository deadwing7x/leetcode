// Solution using BFS.

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
    public int MaxDepth(TreeNode root) {
        if (root is null) {
            return 0;
        }
        
        int maxDepth = 0;
        
        Queue<TreeNode> visited = new();
        visited.Enqueue(root);
        
        while (visited.Count != 0) {
            int count = visited.Count;
            maxDepth++;
            
            for (int i = 0; i < count; i++) {
                TreeNode node = visited.Peek();
                visited.Dequeue();
                
                if (node.left != null) {
                    visited.Enqueue(node.left);
                }
                
                if (node.right != null) {
                    visited.Enqueue(node.right);
                }
            }
        }
        
        return maxDepth;
    }
}


// Solution using DFS - Recursion.

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
    public int MaxDepth(TreeNode root) {
        if (root is null) {
            return 0;
        }

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right)); 
    }
}

// Solution using DFS - Stacks

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
    public int MaxDepth(TreeNode root) {
        Stack<TreeNode> elements = new();
        Stack<int> depth = new();
        
        if (root is null) {
            return 0;
        }
        
        int currentDepth = 0;
        int maxDepth = 0;
        
        elements.Push(root);
        depth.Push(1);
        
        while (elements.Count is not 0) {
            root = elements.Pop();
            currentDepth = depth.Pop();
            
            if (root is not null) {
                maxDepth = Math.Max(maxDepth, currentDepth);
                elements.Push(root.left);
                elements.Push(root.right);
                depth.Push(currentDepth + 1);
                depth.Push(currentDepth + 1);
            } else {
                return maxDepth;
            }
        }
        
        return maxDepth;
    }
}

// Example 1:

// Input: root = [3,9,20,null,null,15,7]
// Output: 3

// Example 2:

// Input: root = [1,null,2]
// Output: 2