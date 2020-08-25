// [Скоморохов Максим]
// Переписать программу, реализующее двоичное дерево поиска.
// а) Добавить в него обход дерева различными способами;
// б) Реализовать поиск в двоичном дереве поиска;

using System;
using System.ComponentModel;

namespace _2_BinaryTree
{
    //---------------------------------------------------------------------
    
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем бинарное дерево
            BinaryTree tree = new BinaryTree();

            Node n1 = tree.AddNode(null, 8);
            tree.root = n1;
            Node n2 = tree.AddNode(n1, 9, NodePosition.left);
            Node n3 = tree.AddNode(n1, 15, NodePosition.right);
            Node n4 = tree.AddNode(n2, 12, NodePosition.left);
            Node n5 = tree.AddNode(n2, 6, NodePosition.right);
            Node n6 = tree.AddNode(n3, 6, NodePosition.left);
            Node n7 = tree.AddNode(n3, 12, NodePosition.right);
            Node n8 = tree.AddNode(n4, 16, NodePosition.left);
            Node n9 = tree.AddNode(n6, 5, NodePosition.left);
            
            Console.WriteLine("Обход дерева КЛП");
            tree.PreOrderTravers(tree.root);
            Console.WriteLine("\n");

            Console.WriteLine("Обход дерева ЛКП");
            tree.SymetricOrderTravers(tree.root);
            Console.WriteLine("\n");

            Console.WriteLine("Обход дерева ЛПК");
            tree.PostOrderTravers(tree.root);

            Console.ReadLine();
        }
    }
}
