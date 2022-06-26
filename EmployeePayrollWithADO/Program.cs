// See https://aka.ms/new-console-template for more information
using System;

namespace EmployeePayrollWithADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll!");

            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();
            //repo.GetAllEmployee();

            employee.name = "Priyanka";
            employee.salary = 35000;
            employee.startdate = "02-07-2022";
            employee.gender = 'F';
            employee.phone = "8588698767";
            employee.address = "Munekolala";
            employee.department = "Engineer";
            employee.basicpay = 32000;
            employee.deduction = 1500;
            employee.taxablepay = 200;
            employee.incometax = 5000;
            employee.netpay = 25000;

            repo.AddEmployee(employee);

        }
    }
}