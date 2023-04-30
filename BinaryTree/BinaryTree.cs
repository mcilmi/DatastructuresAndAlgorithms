using System;
using System.Collections.Generic;

namespace Trees;
internal class BinaryTree
{
    private Node root;
    
    public void Add(int value)
    {
        root = AddRecursively(root, value);
    }

    private Node AddRecursively(Node node, int value)
    {
        if(node == null) {
            return new Node(value);
        }

        if(value <= node.Value)
        {
            node.Left = AddRecursively(node.Left, value);
        } else if( value >= node.Value)
        {
            node.Right = AddRecursively(node.Right, value);
        }
        return node;
    }

    private void dfsTraversal(Node node)
    {
        if(node != null)
        {
            Console.Write(" " + node.Value);
            dfsTraversal(node.Left);
            dfsTraversal(node.Right);
        }
    }
    public void DfsTraversal()
    {
        dfsTraversal(root);
    }

    public void BfsTraversal()
    {
        if (root == null) return;

        Queue<Node> nodes = new();
        nodes.Enqueue(root);
        
        while(nodes.Count() > 0)
        {
            Node node = nodes.Dequeue();
            Console.Write(" " + node.Value);
            if(node.Left != null) nodes.Enqueue(node.Left);
            if(node.Right != null) nodes.Enqueue(node.Right);
        }
    }
}
