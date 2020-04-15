﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btree
{
    class Program
    {
        
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node(int x)
            {
                val = x;
            }
        }
        public class Btree
        {
            public Node root;
            public Btree() { }

            public void Insert(int x)
            {
                if (root == null)
                    root = new Node(x);
                else
                    insert(root, x);
            }
            private void insert(Node p, int x)
            {
                if (x < p.val)
                    if (p.left != null)
                        insert(p.left, x);
                    else
                        p.left = new Node(x);
                else
                    if (p.right != null)
                    insert(p.right, x);
                else
                    p.right = new Node(x);
            }
            public void Print()
            {
                print(root, 0);
            }
            private void print(Node p, int shift)
            {
                if (p.left != null)
                    print(p.left, shift + 1);
                for (int i = 0; i != shift; i++)
                    Console.Write("  ");
                Console.WriteLine(p.val);
                if (p.right != null)
                    print(p.right, shift + 1);
            }
            public void store(Node p, List<Node> nodes)
            {
                if (p == null)
                    return;
                store(p.left, nodes);
                nodes.Add(p);
                store(p.right, nodes);
            }
            public Node buildtree(Node p)
            {
                var nodes = new List<Node>();
                store(p, nodes);
                return buildit(nodes, 0, nodes.Count - 1);
            }
            public Node buildit(List<Node> nodes, int start, int end)
            {
                if (start > end)
                    return null;
                int mid = (start + end) / 2;
                Node p = nodes[mid];
                p.left = buildit(nodes, start, mid - 1);
                p.right = buildit(nodes, mid + 1, end);
                return p;
            }
        
        }

        class pr
        {
            static void Main()
            {
                var obj = new Btree();

                var rnd = new System.Random(1);
                var init = Enumerable.Range(0, 15).OrderBy(x => rnd.Next()).ToArray();
                foreach (var i in init)
                    obj.Insert(i);



                //obj.Print();

                obj.root = obj.buildtree(obj.root);

                obj.Print();

                // var lst = new LinkedList<int>();
                // lst.FindIndex(); // FindIndex List

                // k7k
                // kk6
                // 5kk
                // kk3
                // k2k
                // kk1

                //     10
                //  5     15
                //2  8   12

            }
        }
    }
}


/* public class Node
        {
            public int val;//{get;set}
            public Node left;
            public Node right;
            public Node(int x)
            {
                val = x;
            }
        }
        public class Btree
        {
            public Node root;
            public Btree() { }

            public Insert(int x)
            {
                if (root = null)
                    root = new Node(x)
        
        else
                    insert(root, x);
            }
            private void insert(Node p, int x)
            {
                if (x < p.val)
                    if (p.left != null)
                        insert(p.left, x);
                    else
                        p.left = new Node(x);
                else
                 if (p.right != null)
                    insert(p.right, x);
                else
                    p.right = new Node(x);
            }

            public void Print()
            {
                print(root, 0);
            }

            public void print(Node p, int shift)
            {
                if (p.right != null)
                    print(p.right, shift + 1);

                for (int i = 0; i != shift; i++)
                    Console.Write(" ");
                Console.WriteLine(p.val);

                if (p.left != null)
                    print(p.left, shift + 1);
            }

            public void store(Node p, System.Collections.Generic.List<Node>() )
            {
                if (p == null)
                    return;
                store(p.left, nodes);
                nodes.Add(p);
                store(p.right, nodes)
        
            }
            public Node buildtree(Node p)
            {

                System.Collections.Generic.List<Node>();
                nodes(p, nodes);

                //int n = nodes.Count;

                return buildit(nodes, 0, nodes.Count - 1)
        
            }

            public Node buildit(System.Collections.Generic.List<Node> nodes int start, int end)
            {

            }

            class pr
            {
                static void Main()
                {
                    var obj = new Btree();

                    var rnd = new System.Random(1);
                    var init = Enumerable.Range(0, 5).OrderBy(x => rnd.Next()).ToArray();
                    foreach (var i in init)
                        obj.Insert(i);

                    obj.Insert(10);
                    obj.Insert(5);
                    obj.Insert(15);
                    obj.Insert(8);

                    Console.WriteLine(obj.root.left.right)

        //var lst = new LinkedList<int>();
                }


     }
 }*/


