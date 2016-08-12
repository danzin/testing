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
            Employee Intermediate = new Employee("Intermediate");
            Employee Senior = new Employee("Senior");

            Employee Junior = new Employee("Junior");
            Tree<Employee> tree =
               new Tree<Employee>(CEO,
                   new Tree<Employee>(DD,
                       new Tree<Employee>(ProMan,
                           new Tree<Employee>(TeamLead,
                               new Tree<Employee>(Senior,
                                   new Tree<Employee>(Intermediate,
                                       new Tree<Employee>(Junior)))))));

            // Hardcoded info about the employees


            //Prints the tree 
            tree.PrintDFS();
            // Perfrom tree manipulations
            int opts;
            do
            {

                    Console.WriteLine("To add delivery director press 1 \n" + "To add project manager  press 2 \n" + "To add team leader press 3 \n" + "To add senior press 4 \n"
                            + "To add intermediate press 5 \n" + "To add junior press 6 \n" + "To view information about the employees , press 7" );
                     opts = int.Parse(Console.ReadLine());
                    switch (opts)
                    {
                        //delivery director
                        case 1:
                            string name = AddDD(tree);
                            string af = AddDDInfo(tree);

                            break;
                        case 2: //project manager
                            if (tree.Root.ChildrenCount == 0)
                            {
                                name = AddDD(tree);
                                af = AddDDInfo(tree);
                                tree.PrintDFS();

                                Console.WriteLine("There is a DD now, we can proceed...");
                                AddPM(tree);
                            }

                             else{
                                 AddPM(tree);

                            }
                            break;
                        case 3: //team leader 
                                //checka for a DD
                            if (tree.Root.ChildrenCount == 0)
                            {
                                name = AddDD(tree);
                                af = AddDDInfo(tree);
                                Console.WriteLine("There is a DD now, we can proceed...");
                                AddPM(tree);
                                name = AddTL(tree, name);
                                AddTLInfo(tree);

                        }else
                        {
                            tree.PrintDFS();
                            Console.WriteLine("We are adding a team leader now: ");
                            name = Console.ReadLine();
                            tree.Root.GetChild(0).GetChild(0).AddChild(new TreeNode<Employee>(new Employee(name)));
                            Console.WriteLine("would you like to add additional information about the team lead? \n y/n");
                            string arf = Console.ReadLine().ToUpper();
                            if (arf == "Y")
                            {
                                Console.WriteLine("Address: ");
                                tree.Root.GetChild(0).GetChild(0).GetChild(0).Value.Address = Console.ReadLine();
                                Console.WriteLine("Phone: ");
                                tree.Root.GetChild(0).GetChild(0).GetChild(0).Value.Phone = Console.ReadLine();
                                Console.WriteLine("Salary: ");
                                tree.Root.GetChild(0).GetChild(0).GetChild(0).Value.Money = Console.ReadLine();
                                Console.WriteLine("Project: ");
                                tree.Root.GetChild(0).GetChild(0).GetChild(0).Value.Project = Console.ReadLine();
                            }
                            tree.PrintDFS();
                        }
                       
                            break;
                        //senior
                    case 4: 
                        if(tree.Root.ChildrenCount == 0)
                        {
                            goto case 1;
                        }
                        if (tree.Root.GetChild(0).ChildrenCount == 0)
                        {
                            goto case 2;
                        }
                        if(tree.Root.GetChild(0).GetChild(0).ChildrenCount == 0)
                        {
                            goto case 3;
                        }else
                        {
                            Console.WriteLine("Name of the senior: ");
                            name = Console.ReadLine();
                            tree.Root.GetChild(0).GetChild(0).GetChild(0).AddChild(new TreeNode<Employee>(new Employee(name)));
                            tree.PrintDFS();
                        }
                        break;
                    case 7:
                        Console.WriteLine(tree.Root.Value.Address + tree.Root.Value.Phone + tree.Root.Value.Money);



                        break;
                    








                        default: tree.PrintDFS();
                            break;
                    }


            }
            while (opts != 0);
        }

        private static void AddTLInfo(Tree<Employee> tree)
        {
            Console.WriteLine("would you like to add additional information about the team lead? \n y/n");
            string arf = Console.ReadLine().ToUpper();
            if (arf == "Y")
            {
                Console.WriteLine("Address: ");
                tree.Root.GetChild(0).GetChild(0).GetChild(0).Value.Address = Console.ReadLine();
                Console.WriteLine("Phone: ");
                tree.Root.GetChild(0).GetChild(0).GetChild(0).Value.Phone = Console.ReadLine();
                Console.WriteLine("Salary: ");
                tree.Root.GetChild(0).GetChild(0).GetChild(0).Value.Money = Console.ReadLine();
                Console.WriteLine("Project: ");
                tree.Root.GetChild(0).GetChild(0).GetChild(0).Value.Project = Console.ReadLine();
            }
            tree.PrintDFS();
        }

        private static string AddTL(Tree<Employee> tree, string name)
        {
            Console.WriteLine("We are adding a team leader now: ");
            name = Console.ReadLine();
            tree.Root.GetChild(0).GetChild(0).AddChild(new TreeNode<Employee>(new Employee(name)));
            return name;
        }

        private static void AddPM(Tree<Employee> tree)
        {
            Console.WriteLine("Name of project manager: ");
            string tname = Console.ReadLine();
            //Gets the root's first child and adds a child to it
            tree.Root.GetChild(0).AddChild(new TreeNode<Employee>(new Employee(tname)));
            tree.PrintDFS();
        }

        private static string AddDDInfo(Tree<Employee> tree)
        {
            string af = Console.ReadLine().ToUpper(); ;
            if (af == "Y")
            {
                Console.WriteLine("Address: ");
                tree.Root.GetChild(0).Value.Address = Console.ReadLine();
                Console.WriteLine("Phone: ");
                tree.Root.GetChild(0).Value.Phone = Console.ReadLine();
                Console.WriteLine("Salary: ");
                tree.Root.GetChild(0).Value.Money = Console.ReadLine();
            }
            tree.PrintDFS();
            return af;
        }

        private static string AddDD(Tree<Employee> tree)
        {
            Console.WriteLine("name of the delivery director: ");
            string name = Console.ReadLine();
            //Gets the root and adds a child to it
            var newChild = new TreeNode<Employee>(new Employee(name));
            tree.Root.AddChild(newChild);
            Console.WriteLine("Would u like to add additional information about him? \n y/n");
            return name;
        }
    }
}