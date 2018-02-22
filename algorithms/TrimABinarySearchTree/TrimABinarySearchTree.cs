using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimABinarySearchTree
{
    public class Solution
    {
        public TreeNode TrimBST(TreeNode root, int L, int R)
        {
            //if (root == null)
            //    return root;

            //if (root.val < L || root.val > R)
            //{
            //    if(root.left == null)
            //    {
            //        if (root.right == null)
            //        {
            //            root = null;
            //            return null;
            //        } else
            //        {
            //            root = root.right;
            //        }
            //    }else
            //    {
            //        root = root.left;
            //    }
            //    TrimBST(root, L, R);
            //}

            //if(root.left.val < L)
            //{
            //    TrimBST(root.left, L, R);
            //}

            //if (root.right.val > R)
            //{
            //    TrimBST(root.right, L, R);
            //}

            //return root;


            if (root == null) return root;
            if (root.val > R) return TrimBST(root.left, L, R);
            if (root.val < L) return TrimBST(root.right, L, R);

            root.left = TrimBST(root.left, L, R);
            root.right = TrimBST(root.right, L, R);
            return root;
        }
    }
}
