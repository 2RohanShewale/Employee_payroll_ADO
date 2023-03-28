using System;
using System.Data;
using System.Data.SqlClient;

namespace EmoloyeePayrollSevice
{
    public class EmoployeesPayroll
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Payroll_Service_DB";
        public void AddData(EmployeeModel employee)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("SpStoreData", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Name",employee.Name);
                    sqlCommand.Parameters.AddWithValue("@BasicPay",employee.BasicPay);
                    sqlCommand.Parameters.AddWithValue("@Startdate", employee.Startdate);
                    sqlCommand.Parameters.AddWithValue("@Gender", employee.Gender);
                    sqlCommand.Parameters.AddWithValue("@Address", employee.Address);
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                    sqlCommand.Parameters.AddWithValue("@Department", employee.Department);
                    sqlCommand.Parameters.AddWithValue("@Deduction", employee.Deduction);
                    sqlCommand.Parameters.AddWithValue("@TaxablePay", employee.TaxablePay);
                    sqlCommand.Parameters.AddWithValue("@IncomeTax", employee.IncomeTax);
                    sqlCommand.Parameters.AddWithValue("@NetPay", employee.NetPay);

                    int result = sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    if (result >= 1)
                    {
                        Console.WriteLine("New employee add successfully");
                    }
                    else
                        Console.WriteLine("Error while adding");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
