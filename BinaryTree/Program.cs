using System;
using Trees;

BinaryTree binaryTree = new BinaryTree();
binaryTree.Add(1);
binaryTree.Add(2);
binaryTree.Add(3);
binaryTree.Add(2);
binaryTree.Add(2);
binaryTree.Add(9);
binaryTree.Add(7);
binaryTree.DfsTraversal();
Console.WriteLine();