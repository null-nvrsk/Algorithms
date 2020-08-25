// [Скоморохов Максим]
// Переписать программу, реализующее двоичное дерево поиска.
// а) Добавить в него обход дерева различными способами;
// б) Реализовать поиск в двоичном дереве поиска;

using System;

namespace _2_BinaryTree
{
    class Node
    {
        public int value;

        public Node left;
        public Node right;
        public Node parent;
    }

    //---------------------------------------------------------------------
    enum NodePosition { none, left, right };


    //---------------------------------------------------------------------
    class BinaryTree
    {
        public Node root;

        //---------------------------------------------------------------------
        public Node AddNode(Node parentNode, int value, NodePosition pos = NodePosition.none)
        {
            Node node = new Node();
            node.parent = parentNode;
            node.value = value;

            if (pos == NodePosition.left)
            {
                node.parent.left = node;
            }
            else if(pos == NodePosition.right)
            {
                node.parent.right = node;
            }

            return node;
        }

        //---------------------------------------------------------------------
        public void PreOrderTravers(Node root)
        {
            if (root != null)
            {
                Console.Write($"{root.value}, ");
                PreOrderTravers(root.left);
                PreOrderTravers(root.right);
            }
        }

        //---------------------------------------------------------------------
        public void SymetricOrderTravers(Node root)
        {
            if (root != null)
            {
                PreOrderTravers(root.left);
                Console.Write($"{root.value}, ");
                PreOrderTravers(root.right);
            }
        }

        //---------------------------------------------------------------------
        public void PostOrderTravers(Node root)
        {
            if (root != null)
            {
                PreOrderTravers(root.left);
                PreOrderTravers(root.right);
                Console.Write($"{root.value}, ");
            }
        }
    }
}
