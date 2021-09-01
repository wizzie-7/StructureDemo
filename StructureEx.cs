using System;

namespace StructureDemo
{
    struct Employee
    {
        public int EmpId;
        public string EmpName;
        public string post;
        public int salary;
    }
    class StructureEx
    {
        static void Main(string[] args)
        {
            Employee EMP1;
            Employee EMP2;

            EMP1.EmpId = 1001;
            EMP1.EmpName = "VIVEK JADHAV";
            EMP1.post = "Jr. Software Engineer";
            EMP1.salary = 30000;

            EMP2.EmpId = 10002;
            EMP2.EmpName = "Krnual Pandya";
            EMP2.post = "Manger";
            EMP2.salary = 50000;
            Console.WriteLine("*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
            Console.WriteLine("Employee ID   : " + EMP1.EmpId);
            Console.WriteLine("Employee name : " + EMP1.EmpName);
            Console.WriteLine("Designation   : " + EMP1.post);
            Console.WriteLine("Salary        : " + EMP1.salary);
            Console.WriteLine("*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
            Console.WriteLine("Employee ID   : " + EMP2.EmpId);
            Console.WriteLine("Employee name : " + EMP2.EmpName);
            Console.WriteLine("Designation   : " + EMP2.post);
            Console.WriteLine("Salary        : " + EMP2.salary);
            Console.WriteLine("*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
        }
    }
}
