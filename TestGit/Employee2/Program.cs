using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> myList = new List<Employee>(){

            new Employee(){employeeName="Employee1",Department="HR",workedHours=150},
            new Employee(){employeeName="Employee2",Department="HR",workedHours=154},
            new Employee(){employeeName="Employee3",Department="HR",workedHours=156},
            new Employee(){employeeName="Employee4",Department="HR",workedHours=176},
            new Employee(){employeeName="Employee5",Department="HR",workedHours=189},
            new Employee(){employeeName="Employee6",Department="HR",workedHours=146},
            new Employee(){employeeName="Employee7",Department="Logistics",workedHours=170},
            new Employee(){employeeName="Employee8",Department="Logistics",workedHours=188},
            new Employee(){employeeName="Employee9",Department="Logistics",workedHours=123},
            new Employee(){employeeName="Employee10",Department="Logistics",workedHours=210},
            new Employee(){employeeName="Employee11",Department="Logistics",workedHours=220},
            new Employee(){employeeName="Employee12",Department="Logistics",workedHours=230},
            new Employee(){employeeName="Employee13",Department="Accounting",workedHours=155},
            new Employee(){employeeName="Employee14",Department="Accounting",workedHours=157},
            new Employee(){employeeName="Employee15",Department="Accounting",workedHours=230},
            new Employee(){employeeName="Employee16",Department="Accounting",workedHours=220},
            new Employee(){employeeName="Employee17",Department="Accounting",workedHours=256},
            new Employee(){employeeName="Employee18",Department="Marketing",workedHours=188},
            new Employee(){employeeName="Employee19",Department="Marketing",workedHours=190},
            new Employee(){employeeName="Employee20",Department="Marketing",workedHours=205},
            new Employee(){employeeName="Employee21",Department="Marketing",workedHours=212} };

            var totalHours = myList.Sum(p => p.workedHours);
            Console.WriteLine("Total number of hours worked = " + totalHours);

            var averageHours = myList.Average(p => p.workedHours);
            Console.WriteLine("Average hours worked in all Departments = " + averageHours);

            var averageHoursHR = myList.Where(p => p.Department == "HR").Average(p => p.workedHours);
            Console.WriteLine("Average hours worked in HR Department = " + averageHoursHR);

            var mostHours = myList.Max(p => p.workedHours);
            Console.WriteLine("The most hours worked by an employee = "+mostHours);

            //var employeeOfTheMonthHR = myList.OrderByDescending(p => p.workedHours).First(p => p);
            //Console.WriteLine("Employee of the Month in HR Department is "+employeeOfTheMonthHR);

        }
        


    }
}   class Employee
    {
    public string employeeName { get; set; }
    public string Department { get; set; }
    public int workedHours { get; set; }
}
