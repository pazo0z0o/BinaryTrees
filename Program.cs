using BinaryTrees;
//using Microsoft.Graph;
//using NetTopologySuite.Index.Bintree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//recursive amd iterrative solutions( stack and queue) for training and understanding some concepts
namespace BinaryTrees
{
    public  class AlgoMenu 
    {
        public string choice;

        public string AlgoSelect()
        {
            
            //visual menu representation
            Console.WriteLine(String.Concat("Select the Traversal method you would like to see for the above tree,\nby writing the number of the option ...\n", Environment.NewLine,
                                "1.Breadth First Traversal", Environment.NewLine,
                                "2.Depth First Traversal", Environment.NewLine,
                                "3.InOrder Search",Environment.NewLine,
                                "4.PreOrder Search", Environment.NewLine,
                                "5.PostOrder Search"));
           
            bool valid = false;
            int isNumber;
            while (valid == false)
            {//check if a number was the input
                
                choice = Convert.ToString(Console.ReadLine()[0]); //reads only the character in position 0 of the input and converts char ->string
                if (int.TryParse(choice, out isNumber))
                {
                    valid = true;
                    if (isNumber > 5 || isNumber == 0 || isNumber == (char)13) //check for above,below menu number input or return key press
                    {
                        Console.WriteLine("You have given an invalid choice, try again....");
                        valid = false;
                    }
                  
                }
                else Console.WriteLine("Not an integer number, try again");
            }
           

            return choice;
        }
    }

    
}


    public class Node //class node initialized to null in the constructor to create nodes with null values so that we add our own 
    {
        public string val;
        public Node left, right;

    public Node()
    {   }

    public Node(string v)
        {         
        this.val=v;
        this.left=null;
        this.right=null;
        }
    }

internal class Program
{

    static void Main(string[] args)
    {
        //static tree for example
        Node root = new Node("a");
        Node b = new Node("b");
        Node c = new Node("c");
        Node d = new Node("d");
        Node e = new Node("e");
        Node f = new Node("f");

//tree creation with left right pointers for an easy example
        root.left = b;
        root.right = c;

        b.left = d;
        b.right = e;

        c.left = f;

        Console.WriteLine(@"    
                                     a
                                    / \
                                   b   c 
                                  /\    \                
                                 d  e    f
           
            ");

        BinTreeTravs tree1 = new BinTreeTravs();
        

        AlgoMenu z = new AlgoMenu();
        string sel = z.AlgoSelect(); //the return value of string AlgoSelect function is used for the switch expression
        //Algo select basicly handled all the menu and input stuff-- Wanted to put the switch statement in there as well
        //but trying to call a function from BinTreeTrav with root in there was a hassle

        switch (sel)
        {
            case "1":
                Console.WriteLine("\nBreadth First Traversal of our given binary tree is as follows. . . ");
                tree1.BreadthFirstTraversal(root);
                break;
            case "2":
                Console.WriteLine("\nDepth First Traversal of our given binary tree is as follows. . . ");
                tree1.DFT(root);
                break;
            case "3":
                Console.WriteLine("\nIn Order Traversal of our given binary tree is as follows. . . ");
                tree1.InOrder(root);
                break;
            case "4":
                Console.WriteLine("\nPre Order Traversal of our given binary tree is as follows. . . ");
                tree1.PreOrder(root);
                break;
            default:
                Console.WriteLine("\nPost Order Traversal of our given binary tree is as follows. . . ");
                tree1.PostOrder(root);
                break;
        }
    }
}


