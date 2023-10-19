using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class EMPLOYEE
    {
        public string? NAME { get; set; }
        public string? LASTNAME { get; set; }
        public int ID { get; set; }
        public string? POST { get; set; }
        public double? WAGE { get; set; }

        internal void Add(EMPLOYEE employee)
        {
            throw new NotImplementedException();
        }

        internal EMPLOYEE Find(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        internal void Remove(object employee)
        {
            throw new NotImplementedException();
        }
    }
    public class MANAGER
    {
        public string? NAME { get; set; }
        public string? LASTNAME { get; set; }
        public int ID { get; set; }
        public string? POST { get; set; }
        public double? WAGE { get; set; }
    }
    public class HR
    {
        private List<EMPLOYEE> Employees;
        private List<MANAGER> Managers;

        public HR()
        {
            Employees = new List<EMPLOYEE>();
        }
        public void HireEmployee(EMPLOYEE employees)
        {
            Employees.Add(employees);
            Console.WriteLine("Employee has been hired.");

        }
        public void Firemanager()
        {
            Console.WriteLine("Enter Employee Id to Fire: ");
            int Remove = Convert.ToInt32(Console.ReadLine());

            EMPLOYEE employees = Employees.Find(x => x.ID == Remove);
            if (employees != null)
            {
                Employees.Remove(employees);
                Console.WriteLine("Employee has been fired.");


            }
        }
        public void RefreshManager(int ID)
        {
            EMPLOYEE employees = Employees.Find(x => x.ID == ID);
            if (employees != null)
            {
                Console.WriteLine("Please enter your new name :");
                employees.NAME = Console.ReadLine();
                Console.WriteLine("Please enter your new lastname :");
                employees.LASTNAME = Console.ReadLine();
                Console.WriteLine("Please enter your new POST :");
                employees.POST = Console.ReadLine();
                Console.WriteLine("Please enter your new WAGE :");
                employees.WAGE = Convert.ToDouble(Console.ReadLine());


            }
            else
            {
                Console.WriteLine("Employee does not exist");
            }
        }
        public void ShowEmployee(int ID)
        {
            EMPLOYEE employees = Employees.Find(x => x.ID == ID);
            if (employees != null)
            {
                Console.WriteLine("Employee ID: " + employees.ID);
                Console.WriteLine("Employee name: " + employees.NAME);
                Console.WriteLine("Employee LASTNAME): " + employees.LASTNAME);
                Console.WriteLine("Employee POST: " + employees.POST);
                Console.WriteLine("Employee WAGE: " + "$" + employees.WAGE);

            }
            else
            {
                Console.WriteLine("Employee does not exist");
            }
        }
        public void PromoteEmployee(int ID)
        {
            EMPLOYEE employees = Employees.Find(x => x.ID == ID);
            Console.WriteLine("Please enter your new name :");
            employees.ID = Convert.ToInt32(Console.ReadLine());
            MANAGER manager = new MANAGER();
            if (employees != null)
            {

                manager.NAME = employees.NAME;
                manager.LASTNAME = employees.LASTNAME;
                manager.POST = employees.POST;
                manager.WAGE = employees.WAGE;
                Managers.Add(manager);
                Employees.Remove(employees);
            }
            else
            {
                Console.WriteLine("Employee does not exist");
            }
        }

        internal void Hiremanager(MANAGER managers)
        {
            throw new NotImplementedException();
        }

        internal void Showmanager(int show)
        {
            throw new NotImplementedException();
        }

        internal void PromoteEmployee()
        {
            throw new NotImplementedException();
        }

        internal void DemoteManger()
        {
            throw new NotImplementedException();
        }
    }
}
