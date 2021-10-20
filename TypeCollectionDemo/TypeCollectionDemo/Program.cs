using System; 

namespace TypeCollectionDemo
{
    struct Employee
    {
        public int EmpNo;
        public string EmpName;
        public double Salary;

        public double AnnualSalary()
        {
            return Salary * 12;
        }

        public Employee(int empno,string empname,double salary)
        {
            this.EmpNo = empno;
            this.EmpName = empname;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return string.Format($"EmpNo: {EmpNo} EmpName: {EmpName} Salary: {Salary}");
        }
        
    }
    enum Month
    {
        jan = 1, feb, mar, apr, may, jun, jul, aug, sep, oct, nov, dec
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "darshan", 1000);
            Console.WriteLine("" + employee.AnnualSalary());
            Console.WriteLine(employee);

            Console.WriteLine(DayOfWeek.Wednesday + ":" + (int)DayOfWeek.Wednesday);
            Console.WriteLine(Month.oct + ":" + (int) Month.oct);
        }
    }
}
