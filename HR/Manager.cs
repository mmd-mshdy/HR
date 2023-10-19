using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    internal class manager1
    {
        private List<EMPLOYEE> Employees;
        private List<MANAGER> Managers;
        public void Hiremanager(MANAGER manager)
        {
            Managers = new List<MANAGER>();
            Managers.Add(manager);
            Console.WriteLine("manager has been hired.");

        }
        public void Firemanager()
        {
            Console.WriteLine("Enter Manager Id to Fire: ");
            int Remove = Convert.ToInt32(Console.ReadLine());

            MANAGER manager = Managers.Find(x => x.ID == Remove);
            if (manager != null)
            {
                Managers.Remove(manager);
                Console.WriteLine("Manager has been fired.");


            }
        }
        public void RefreshManager(int ID)
        {
            MANAGER manager = Managers.Find(x => x.ID == ID);
            if (manager != null)
            {
                Console.WriteLine("Please enter your new name :");
                manager.NAME = Console.ReadLine();
                Console.WriteLine("Please enter your new lastname :");
                manager.LASTNAME = Console.ReadLine();
                Console.WriteLine("Please enter your new POST :");
                manager.POST = Console.ReadLine();
                Console.WriteLine("Please enter your new WAGE :");
                manager.WAGE = Convert.ToDouble(Console.ReadLine());


            }
            else
            {
                Console.WriteLine("Managers does not exist");
            }
        }
        public void Showmanager(int ID)
        {
            MANAGER manager = Managers.Find(x => x.ID == ID);
            if (manager != null)
            {
                Console.WriteLine("manager ID: " + manager.ID);
                Console.WriteLine("manager name: " + manager.NAME);
                Console.WriteLine("manager LASTNAME): " + manager.LASTNAME);
                Console.WriteLine("manager POST: " + manager.POST);
                Console.WriteLine("manager WAGE: " + "$" + manager.WAGE);

            }
            else
            {
                Console.WriteLine("manager does not exist");
            }
        }
        public void DemoteManger(int ID)
        {
            MANAGER manager = Managers.Find(x => x.ID == ID);
            Console.WriteLine("Please enter your new name :");
            manager.ID = Convert.ToInt32(Console.ReadLine());
            EMPLOYEE employees = new EMPLOYEE();
            if (manager != null)
            {
                Console.WriteLine("Please enter your new name :");
                employees.ID = Convert.ToInt32(Console.ReadLine());
                employees.NAME = manager.NAME;
                employees.LASTNAME = manager.LASTNAME;
                employees.POST = manager.POST;
                employees.WAGE = manager.WAGE;
                Employees.Add(employees);
                Managers.Remove(manager);
            }
            else
            {
                Console.WriteLine("Employee does not exist");
            }
        }

        internal void DemoteManger()
        {
            throw new NotImplementedException();
        }
    }
}
