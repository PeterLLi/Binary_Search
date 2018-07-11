using System;
using System.Collections.ObjectModel;

namespace Binary_Search{
    public class Node{
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(){}
        public Node(int data){
            this.Data = data;
        }
    }

    //Binary tree
    public class BinaryTree{
        public Node _root;
        public bool answer = false;
        //First binary root
        public BinaryTree(){
            _root = null;
        }

        //Insert a number
        public void Insert(int data){
            //If the tree is empty, return a new, single node 
            if (_root == null){
                _root = new Node(data);
                return;
            }
            //Otherwise, recur down the tree 
            InsertRec(_root, new Node(data));
        }

        //Populate the binary tree via recursion
        private void InsertRec(Node root, Node newNode){
            //If the first root number is empty, set it to the number
            if (root == null)
                root = newNode;

            //If the number is lower than the root number
            if (newNode.Data < root.Data){
                if (root.Left == null){
                    root.Left = newNode;
                } else {
                    InsertRec(root.Left, newNode);
                }
            } else {
                //If the number is greater than the root number
                if (root.Right == null){
                    root.Right = newNode;
                } else {
                    InsertRec(root.Right, newNode);
                }
            }
        }

        //Search feature via recursion
        public void isPresent(Node root, int x){
            
            if (root != null){
                // check if current node has the element we are looking for
                if (root.Data == x){
                    answer = true;
                } else if (x < root.Data) {
                    answer = false;
                    isPresent(root.Left, x);
                } else if (x > root.Data){
                    answer = false;
                    isPresent(root.Right, x);
                }
            }
        }

        //Display the numbers
        private void DisplayTree(Node root){
            if (root == null){
                return;
            }

            DisplayTree(root.Left);
            System.Console.Write(root.Data + " ");
            DisplayTree(root.Right);

        }

        //Display
        public void DisplayTree(){
            DisplayTree(_root);
        }
    }
}

