using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace EmployeePayrollWithADO
{
    class EmployeeRepo
    {

        SqlConnection connection = new SqlConnection(@"Data Source=BridgeLabz; Initial Catalog =payroll_service; Integrated Security = True;");

        public void GetAllEmployee()
        {
            try
            {



                EmployeeModel employeeModel = new EmployeeModel();
                using (this.connection)
                {
                    string query = @"SELECT id,name,salary,startdate,gender,phone,address,department,basicpay,deduction,taxablepay,netpay FROM employee_payroll;";

                    //define the SqlCommand Object
                    SqlCommand cmd = new SqlCommand(query, this.connection);

                    this.connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    //check if there are records

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            employeeModel.id = dr.GetInt32(0);
                            employeeModel.name = dr.GetString(1);
                            employeeModel.salary = dr.GetInt32(2);
                            //employeeModel.startdate = dr.GetDateTime(3);
                            employeeModel.gender = Convert.ToChar(dr.GetString(4));
                            employeeModel.department = dr.GetString(5);
                            employeeModel.basicpay = dr.GetInt32(6);
                            employeeModel.netpay = dr.GetInt32(7);
                            //employeeModel.startdate = dr.GetDateTime(8);


                            //display retrieve record
                            Console.WriteLine("{0},{1},{2}", employeeModel.id, employeeModel.name, employeeModel.salary);
                            Console.WriteLine("\n");

                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    //close data reader
                    dr.Close();

                    this.connection.Close();
                }
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }

        }
    }
}