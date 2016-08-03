using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_1_hpsys
{
    public static class TreeExample
    {
        static void Main()
        {
            // Create the tree from the sample
            Tree<string> tree =
                  new Tree<string>("CEO" ,
                        new Tree<string>("Snoop Dogg - DD",
                              new Tree<string>("Jhon" ,
                                    new Tree<string>("Leader1"),
                                    new Tree<string>("Leader2", new Tree<string>("Stoner", new Tree<string>("Spensnqta")),
                                    new Tree<string>("Leader3", new Tree<string>("Stoner"))))),
                             
                   new Tree<string>("Tom Smith DD ",
                              new Tree<string>("Project Manager" ,
                                    new Tree<string>("Team Leader"),
                                    new Tree<string>("Team Leader", new Tree<string>("Senior", new Tree<string>("Intermediate")),
                                    new Tree<string>("Team Leader", new Tree<string>("Senior")))))
                  );

            tree.PrintDFS();
            
            int team = Int32.Parse(Console.ReadLine());
            for (; ; )
            {
                Console.WriteLine("type 1 to see the emplyees ");
                Console.WriteLine("type 2 to choose a team");
                Console.WriteLine("type 3 to see the emplyees ");
                Console.WriteLine("type 1 to see the emplyees ");
                Console.WriteLine("type 1 to see the emplyees ");
            }


























            switch (team)
            {
                case 1:
                    Console.WriteLine("on" + tree.Root.GetChild(0).Value + "'s Team - Delivery Director");
                    Console.WriteLine("Choose an option:");
                    break;
                case 2: 
                    Console.Write(tree.Root.GetChild(1));
                    break;

                default: Console.WriteLine("No such team exists");
                    break;
            }
            Console.WriteLine("1 See Delivery Directors");
            Console.WriteLine("2 See Project Managers");
            Console.WriteLine("3 See Team Leaders");
            Console.WriteLine("4 Add Delivery Director");
            Console.WriteLine("5 Add Team Leader");



            int input = Int32.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine(tree.Root.GetChild(0).Value);
                    Console.WriteLine(tree.Root.GetChild(1).Value);
                    break;
                case 2:
                    Console.WriteLine(tree.Root.GetChild(0).GetChild(0).Value);
                    Console.WriteLine(tree.Root.GetChild(1).GetChild(0).Value);
                    break;
                case 3:
                    Console.WriteLine(tree.Root.GetChild(1).GetChild(0).GetChild(0).Value);
                    break;
                case 4:
                    tree.Root.
                        AddChild(new TreeNode<string>(Console.ReadLine()));
                    tree.PrintDFS();
                    break;
                case 5:
                    tree.Root.GetChild(0).GetChild(0).
                        AddChild(new TreeNode<string>(Console.ReadLine()));
                    tree.PrintDFS();
                    break;
                default:
                    Console.WriteLine("Unknown choice");
                    break;
            }


            Console.ReadKey();

        }
    }
}
