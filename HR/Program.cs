using HR;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        HR hR = new HR();
        manager1 Manager = new manager1();

        while (true)
        {
            try
            {
                Console.WriteLine("If you want to use employee press 1:");
                Console.WriteLine("If you want to use manager press 2:");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                {
                    Console.WriteLine("if you want to Hire Employee insert 1:");
                    Console.WriteLine("if you want to Remove Employee information insert 2:");
                    Console.WriteLine("if you want to Refresh Employee insert 3:");
                    Console.WriteLine("if you want to Show Employee information insert 4:");
                    Console.WriteLine("if you want to promote Employee  insert 5:");
                    Console.WriteLine("if you want to Exit insert 6:");
                    int insert = Convert.ToInt32(Console.ReadLine());
                    switch (insert)
                    {
                        case 1:
                            Console.WriteLine("Enter Employee ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Employee Name: ");
                            string? name = Console.ReadLine();

                            Console.WriteLine("Enter Employee lastName: ");
                            string? lastName = Console.ReadLine();

                            Console.WriteLine("Enter Employee post: ");
                            string? post = Console.ReadLine();

                            Console.WriteLine("Enter Employee wage: ");
                            double wage = Convert.ToDouble(Console.ReadLine());

                            EMPLOYEE employee = new EMPLOYEE
                            {
                                ID = id,
                                NAME = name,
                                LASTNAME = lastName,
                                POST = post,
                                WAGE = wage
                            };
                            hR.HireEmployee(employee);
                            break;

                        case 2:
                            hR.Firemanager();
                            break;

                        case 3:
                            Console.WriteLine("Enter Employee ID to Refresh information");
                            int Refresh = Convert.ToInt32(Console.ReadLine());
                            hR.RefreshManager(Refresh);
                            break;

                        case 4:
                            Console.WriteLine("Enter Employee ID to show details: ");
                            int Show = Convert.ToInt32(Console.ReadLine());
                            hR.ShowEmployee(Show);
                            break;
                        case 5:
                            hR.PromoteEmployee();
                            break;

                        case 6:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Please insert correct number.");
                            break;
                    }
                }
                else if (answer == 2)
                {
                    Console.WriteLine("if you want to Hire Manager insert 1:");
                    Console.WriteLine("if you want to Remove Manager information insert 2:");
                    Console.WriteLine("if you want to RefreshManager insert 3:");
                    Console.WriteLine("if you want to Show Manager information insert 4:");
                    Console.WriteLine("if you want to Demote Manager  insert 5:");
                    Console.WriteLine("if you want to Exit insert 6:");
                    int enter = Convert.ToInt32(Console.ReadLine());
                    switch (enter)
                    {
                        case 1:
                            Console.WriteLine("Enter Manager ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Manager Name: ");
                            string? name = Console.ReadLine();

                            Console.WriteLine("Enter Manager lastName: ");
                            string? lastName = Console.ReadLine();

                            Console.WriteLine("Enter Manager post: ");
                            string? post = Console.ReadLine();

                            Console.WriteLine("Enter Manager wage: ");
                            double wage = Convert.ToDouble(Console.ReadLine());

                            MANAGER managers = new MANAGER
                            {
                                ID = id,
                                NAME = name,
                                LASTNAME = lastName,
                                POST = post,
                                WAGE = wage
                            };
                            Manager.Hiremanager(managers);
                            break;

                        case 2:
                            Manager.Firemanager();
                            break;

                        case 3:
                            Console.WriteLine("Enter Manager ID to Refresh information");
                            int Refresh = Convert.ToInt32(Console.ReadLine());
                            Manager.RefreshManager(Refresh);
                            break;

                        case 4:
                            Console.WriteLine("Enter Manager ID to show details: ");
                            int Show = Convert.ToInt32(Console.ReadLine());
                            Manager.Showmanager(Show);
                            break;
                        case 5:
                            Manager.DemoteManger();
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Please insert correct number.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("incorrect enterance.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine();

            }

        }
    }
}