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
            repo.GetAllEmployee();

        }
    }
}