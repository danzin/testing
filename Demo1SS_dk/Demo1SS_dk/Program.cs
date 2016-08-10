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
            Tree<Employee> tree =
               new Tree<Employee>(CEO);
            Employee DD = new Employee("The Delivery Director ");
            Employee ProMan = new Employee("Project Manager");
            Employee TeamLead = new Employee("The team leder");
            Employee Intermediate = new Employee("Intermediate");
            Employee Senior = new Employee("Senior");
            Employee Junior = new Employee("Junior");
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

            //Prints the tree 
            tree.PrintDFS();
            // Perfrom tree manipulations
            Console.WriteLine("To add delivery director press 1 \n" + "To add project manager  press 2 \n" + "To add team leader press 3 \n" + "To add senior press 4 \n"
                    + "To add intermediat press 5 \n" + "To add junior press 6 \n");
            int opts = int.Parse(Console.ReadLine());
            switch (opts)
            {
                case 1:
                    Console.WriteLine("name of the delivery director: ");
                    string name = Console.ReadLine();
                    //Gets the root and adds a child to it
                    tree.Root.AddChild(new TreeNode<Employee>(new Employee(name)));
                    tree.PrintDFS();
                    break;
                case 2:
                    if (tree.Root.ChildrenCount == 0)
                    {
                        Console.WriteLine("The Project manager needs a Delivery director, you need to add one: ");
                        Console.WriteLine("name: ");
                        name = Console.ReadLine();
                        //Gets the root and adds a child to it
                        tree.Root.AddChild(new TreeNode<Employee>(new Employee(name)));
                        tree.PrintDFS();
                        Console.WriteLine("There is a DD now, we can proceed...");

                    }
                    Console.WriteLine("name of project manager: ");
                    string tname = Console.ReadLine();
                    //Gets the root's first child and adds a child to it
                    tree.Root.GetChild(0).AddChild(new TreeNode<Employee>(new Employee(tname)));
                    tree.PrintDFS();
                    break;
                case 3:
                    //checks for CEO>DD>Project manager
                     if (tree.Root.ChildrenCount == 0)
                        {
                            Console.WriteLine("You cant add a team leader without the rest of the structure ");
                            Console.WriteLine("name: ");
                            name = Console.ReadLine();
                            //Gets the root and adds a child to it
                            tree.Root.AddChild(new TreeNode<Employee>(new Employee(name)));
                            tree.PrintDFS();
                            Console.WriteLine("There is a DD now, we can proceed to  a project manager ");
                            name = Console.ReadLine();
                            tree.Root.GetChild(0).AddChild(new TreeNode<Employee>(new Employee(name)));
                            Console.WriteLine("We have a project manager. Now we add the team leader: \n Name: ");
                            name = Console.
                        }
                        Console.WriteLine("The Team leaders need project managers, we need to add some before adding team leader...");
                        Console.WriteLine("name of project manager: ");
                        string pname = Console.ReadLine();
                        //Gets the root's first child and adds a child to it
                        tree.Root.GetChild(0).AddChild(new TreeNode<Employee>(new Employee(pname)));
                
                    break;
                case 4:
                default:
                    break;
            }
            Console.ReadKey();


        }
    }
}