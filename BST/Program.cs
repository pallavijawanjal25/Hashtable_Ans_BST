using BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");

            UC1_AddDataIntoBST BST = new UC1_AddDataIntoBST();
            BST.add();

            UC2_BinaryTree BST2 = new UC2_BinaryTree();
            BST2.binaryTree();

            UC3_SearchNode BST3 = new UC3_SearchNode();
            BST3.search(63);
        }
    }
}
