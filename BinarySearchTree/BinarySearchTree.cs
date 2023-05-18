namespace BST;
internal class BinarySearchTree
{
    Node? root;

    public BinarySearchTree()
    {
        root = null;
    }

    public void insert(int value)
    {
        root = insertRecursively(root, value);
    }

    private Node insertRecursively(Node? root, int value) 
    {
        if (root == null)
        {
            root = new Node(value);
            return root;
        }

        if(value < root.Value) root.Left = insertRecursively(root.Left, value);
        else if(value > root.Value) root.Right = insertRecursively(root.Right, value);

        return root;
    }
    // Initiate DFS traversal print of BST
    public void printDfs()
    {
        if(root == null) return;
        printDfsRec(root);
    }

    // Do DFS traversal of BST
    private void printDfsRec(Node root)
    {
        if(root != null)
        {
            printDfsRec(root.Left);
            Console.Write(root.Value + " ");
            printDfsRec(root.Right);
        }
    }
     




    
}
