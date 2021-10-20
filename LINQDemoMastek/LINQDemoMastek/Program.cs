using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemoMastek
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            int[] numbers = { 44, 33, 492, 23, 13, 13, 1, 3213, 113, 123, 444, 11, 3 };

            //declarative
            //print even numbers
            int[] evendata = (from n in numbers
                              where n % 2 == 0
                              select n).ToArray();

            //method
            evendata = numbers.Where(n => n % 2 == 0).ToArray();

            //evendata = numbers.Where(IsEvenNumber).ToArray();
            for (int i = 0; i < evendata.Length; i++)
            {
                Console.WriteLine(evendata[i]);
            }

            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { EmpNo = 101, EmpName = "bhavana", Address = "mumbai", Dept = "hr", Salary = 15000 });
            empList.Add(new Employee() { EmpNo = 102, EmpName = "amit", Address = "mumbai", Dept = "sales", Salary = 25000 });
            empList.Add(new Employee() { EmpNo = 103, EmpName = "vishal", Address = "pune", Dept = "sales", Salary = 20000 });
            empList.Add(new Employee() { EmpNo = 104, EmpName = "priya", Address = "mumbai", Dept = "hr", Salary = 30000 });
            empList.Add(new Employee() { EmpNo = 105, EmpName = "asha", Address = "mumbai", Dept = "sales", Salary = 30000 });
            empList.Add(new Employee() { EmpNo = 106, EmpName = "pankaj", Address = "pune", Dept = "hr", Salary = 35000 });
            empList.Add(new Employee() { EmpNo = 107, EmpName = "anil", Address = "mumbai", Dept = "sales", Salary = 18000 });
            empList.Add(new Employee() { EmpNo = 108, EmpName = "preeti", Address = "pune", Dept = "hr", Salary = 25000 });

            //foreach (Employee item in empList)
            //{
            //    Console.WriteLine(item);
            //}

            //simple query
            IEnumerable<Employee> query1 = from e in empList where e.Dept =="sales" select e;

            query1.Where(e => e.Dept == "sales");

            foreach (Employee item in query1)
            {
                Console.WriteLine(item);
            }

            IEnumerable<Employee> query2 = from e in empList where e.Dept == "sales" select e;

            query2.Where(e => e.Dept == "sales");

            foreach (Employee item in query2)
            {
                Console.WriteLine(item);
            }
            IEnumerable<Employee> query3 = from e in empList where e.Salary > 25000 select e;
            query3.Where(e => e.Salary > 25000);

            foreach (Employee item in query3)
            {
                Console.WriteLine(item);
            }
            IEnumerable<Employee> query4 = from e in empList where e.Dept == "hr" && e.Address == "mumbai" select e;
            query4.Where(e => e.Dept == "hr");

            foreach (Employee item in query4)
            {
                Console.WriteLine(item);
            }
            IEnumerable<Employee> query5 = from e in empList where e.EmpName.StartsWith('p') select e;
            //query5.Where(e => e.EmpName.StartsWith('p'));

            //foreach (Employee item in query5)
            //{
            //    Console.WriteLine(item);
            //}

            //defered execution
            query5 = empList.Where(e => e.EmpName.StartsWith("p"));

            //immediate execution
            query5 = empList.Where(e => e.EmpName.StartsWith("p")).ToList();

            empList.Add(new Employee() { EmpNo = 201, EmpName = "peter", Address = "pune", Dept = "hr", Salary = 25000 });
            Console.WriteLine("--------Linq query output-----------");
            foreach (Employee item in query5)
            {
                Console.WriteLine(item);
            }

            empList.Add(new Employee() { EmpNo = 301, EmpName = "pete1", Address = "pune", Dept = "hr", Salary = 25000 });
            Console.WriteLine("-------Linq query output------------");
            //defered execution
            foreach (Employee item in query5)
            {
                Console.WriteLine(item);
            }

            //list employees whose empno is 102
            //Employee e = (from e in empList where e.EmpNo==102 select e).SingleOrDefault();
            Employee emp = (from e in empList where e.Address == "mumbai" select e).FirstOrDefault();

            emp = empList.Where(e => e.EmpNo == 102).FirstOrDefault();

            emp = empList.FirstOrDefault(e => e.EmpNo == 102);

            Console.WriteLine("Employee: " + emp);

            //specific column selection
            //list empname,dept,,salary
            //list empname and salary
            //list empno and salary

            IEnumerable<Employee> query7 = from e in empList select e;
            //known type
            //Employee emp = new Em ployee();

            //anonymous type - {}
            //var --- implicitly typed local variable
            //var emp1 = new {emp.EmpName,emp.Dept,emp.Salary};

            //anonymous type and var - implicitly typed local variable
            //var query8 = from e in empList select new { e.EmpName,e.Dept,e.Salary};

            var query8 = empList.Select(e => new { e.EmpName, e.Dept, e.Salary });

            foreach (var item in query8)
            {
                Console.WriteLine(item.EmpName + " " + item.Dept + " " + item.Salary);
            }

            //list all emp name and salary who are earning between 25000 and 30000
            var query9 = from e in empList
                         where e.Salary >= 20000 && e.Salary <= 30000
                         select new
                         {
                             e.EmpName,
                             e.Salary
                         };
            query9 = empList.Where(e => e.Salary >= 20000 && e.Salary <= 30000).Select(e => new
            {
                e.EmpName,
                e.Salary
            });

            foreach (var item in query9)
            {
                Console.WriteLine(item.GetType().Name);
            }

            #endregion
        }
    }
}
