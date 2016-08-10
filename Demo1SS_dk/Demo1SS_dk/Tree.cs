using System;
using System.Collections.Generic;


namespace Demo1_SoftServe
{
    public class TreeNode<T>
    {
        // Contains the value of the node
        private T value;

        // Shows whether the current node has parent
        private bool hasParent;

        // Contains the children of the node
        private List<TreeNode<T>> children;

        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(
                      "Cannot insert null value!");
            }
            this.value = value;
            this.children = new List<TreeNode<T>>();
        }



        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }


        public int ChildrenCount
        {
            get
            {
                return this.children.Count;
            }
        }


        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException(
                      "Cannot insert null value!");
            }

            if (child.hasParent)
            {
                throw new ArgumentException(
                      "The node already has a parent!");
            }

            child.hasParent = true;
            this.children.Add(child);
        }


        public TreeNode<T> GetChild(int index)
        {

            return this.children[index];
        }
    }


    public class Tree<T>
    {
        // The root of the tree
        private TreeNode<T> root;



        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(
                      "Cannot insert null value!");
            }

            this.root = new TreeNode<T>(value);
        }


        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        public TreeNode<T> Root
        {
            get
            {
                return this.root;
            }
        }


        private void PrintDFS(TreeNode<T> root, string spaces)
        {
            if (this.root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.Value);

            TreeNode<T> child = null;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                PrintDFS(child, spaces + "   ");
            }
        }


        public void PrintDFS()
        {
            this.PrintDFS(this.root, string.Empty);
        }
    }
}

