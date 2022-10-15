using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    public class BinTreeTravs 
    {
        public void BreadthFirstTraversal(Node root)
        {   

            Node y = new Node();
            Queue<Node> qt = new Queue<Node>();

            qt.Enqueue(root);

            while (qt.Count > 0)
            {
                y = qt.Dequeue(); //first itteration takes the root , and it goes from there
                if (y.left != null)
                { qt.Enqueue(y.left); }
                if (y.right != null)
                { qt.Enqueue(y.right); }


                Console.WriteLine(y.val);
            }

        }

        public void DFT(Node root)
        {

            Stack<Node> s = new Stack<Node>();
            Node x = new Node();

            s.Push(root);

            while (s.Count > 0)
            {

                x = s.Pop();
                //first we go for the right rootchiled cause stack is LiFO
                if (x.right != null) { s.Push(x.right); }
                if (x.left != null) { s.Push(x.left); }

                Console.WriteLine(x.val);

            }

        }

        public void InOrder(Node root)
        {
            //procceed with recursion: First we call for the left subtree and after that, the right subtree
            if (root != null)
            {
                InOrder(root.left);
                Console.WriteLine(root.val);
                InOrder(root.right);
            }

            

        }

        public void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.val);
                PreOrder(root.left);
                PreOrder(root.right);
            }

        }

        public void PostOrder(Node root)
        {
            if (root != null)
            {
                PostOrder(root.left);
                //we leave root for last in post order( first we deal with the left, then with the right subtree
                PostOrder(root.right);
                Console.WriteLine(root.val);
            }


        }

    }
}
