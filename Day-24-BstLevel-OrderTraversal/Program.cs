using System;

class Node
{
    public Node left, right;
    public int data;
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}
class Solution
{
    static void Main(String[] args)
    {
        Node root = null;

        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }
        levelOrder(root);
    }

    static Node insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else
        {
            Node cur;
            if (data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }

    static void levelOrder(Node root)
    {
        //Write your code here
        int h = height(root);
        for (int i = 1; i <= h; i++)
            CurrentLevel(root, i);

        Console.ReadLine();
    }

    static int height(Node root)
    {
        if (root == null)
            return 0;
        else
        {
            int lheight = height(root.left);
            int rheight = height(root.right);
            if (lheight > rheight)
                return (lheight + 1);
            else return (rheight + 1);
        }
    }

    static void CurrentLevel(Node root, int level)
    {
        if (root == null)
            return;

        if (level == 1)
            Console.Write(root.data +  " ");
        else if (level > 1)
        {
            CurrentLevel(root.left, level - 1);
            CurrentLevel(root.right, level - 1);
        }
    }
}