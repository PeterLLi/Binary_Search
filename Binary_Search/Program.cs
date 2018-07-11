using System;

namespace Binary_Search
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int userNumber;
            BinaryTree tree = new BinaryTree();


            //Console.WriteLine("What number would you like to search?");
            //userNumber = Int32.Parse(Console.ReadLine());

            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(5);
            tree.Insert(1);
            tree.Insert(3);
            tree.DisplayTree();

            tree.isPresent(tree._root, 1);

            if(tree.answer == true){
                Console.WriteLine("Found");
            } else {
                Console.WriteLine("Not found");
            }
        }
    }
}
