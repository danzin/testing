using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_SoftServe
{
    public static class TreeExample
    {

        static void Main()
        {
            //Creating the employees
            Employee CEO = new Employee("THe big CEO");
            Employee DD = new Employee("The Delivery Director ");
            Employee ProMan = new Employee("Project Manager");
            Employee TeamLead = new Employee("The team leder");
            // Hardcoded info about the employees
            CEO.Money = "322381556";
            CEO.Phone = "123123123123";
            CEO.Email = "imtheCEO@gmail.com";
            CEO.Address = "8 CEO str.";

            DD.Email = "dd.@gmail.com";
            DD.Address = "5 directors str.";
            DD.Money = "451451";
            DD.Phone = "7654";
            ProMan.Email = "manager@gmail.com";
            ProMan.Money = "156165";
            ProMan.Address = "7 manager's str.";
            ProMan.Phone = "343254";
            TeamLead.Email = "leader@gmail.com";
            TeamLead.Money = "2895";
            TeamLead.Address = "6 leader's str.";
            TeamLead.Phone = "23423423";
            // Create the tree from the sample
            Tree<string> tree =
                  new Tree<string>(CEO.Name+ " - " + CEO.Email,
                        new Tree<string>(DD.Name,
                            new Tree<string>(ProMan.Name,
                                new Tree<string>(TeamLead.Name))));
            //Prints the tree 
            tree.PrintDFS();
            // Perfrom tree manipulations
            Console.WriteLine("To add delivery director press D: \n"+ "To add project manager  press P: \n"+ "To add team leader press T: \n");
            string opts = Console.ReadLine().ToUpper();
            if (opts == "D")
            {
                Console.WriteLine("name: ");
                string name = Console.ReadLine();
                //Gets the root and adds a child to it
                tree.Root.AddChild(new TreeNode<string>(name));
                tree.PrintDFS();
            }
            if (opts == "P")
            {
                Console.WriteLine("name: ");
                string name = Console.ReadLine();
                //Gets the root's first child and adds a child to it
                tree.Root.GetChild(0).AddChild(new TreeNode<string>(name));
                tree.PrintDFS();
            }
            if (opts == "T")
            {
                Console.WriteLine("name: ");
                string name = Console.ReadLine();
                //Gets the first child of the root's first child, and adds achild to it.
                tree.Root.GetChild(0).GetChild(0).AddChild(new TreeNode<string>(name));
                tree.PrintDFS();
            }



            Console.ReadKey();




             
        }
        
    }
}
