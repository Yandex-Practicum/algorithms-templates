using System;

public class Solution
{
    public static int Solve(Node root)
    {
        if (root == null)
        {
            return -1;
        }

        var ans = root.Value;
        ans = Math.Max(Solve(root.Left), ans);

        return Math.Max(Solve(root.Right), ans);
    }
}
