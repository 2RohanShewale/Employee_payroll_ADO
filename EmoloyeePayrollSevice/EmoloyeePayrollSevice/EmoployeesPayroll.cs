using System;
using System.Collections.Generic;
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
        public void GetAllData()
        {
            SqlConnection connection = new SqlConnection(connectionString);
           
                List<EmployeeModel> employees = new List<EmployeeModel>();
            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("SpGetAllData", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            EmployeeModel employee = new EmployeeModel();
                            employee.Name = reader.GetString(0);
                            employee.BasicPay = (float)reader.GetDouble(1);
                            employee.Startdate = reader.GetDateTime(2);
                            employee.Gender = reader.GetString(3)[0];
                            employee.Address = reader.GetString(4);
                            employee.PhoneNumber = reader.GetInt64(5);
                            employee.Department = reader.GetString(6);
                            employee.Deduction = (float)reader.GetDouble(7);
                            employee.TaxablePay = (float)reader.GetDouble(8);
                            employee.IncomeTax = (float)reader.GetDouble(9);
                            employee.NetPay = (float)reader.GetDouble(10);
                            employees.Add(employee);
                        }
                        foreach (var employee in employees)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"{employee.Name} salary: {employee.BasicPay} Startdate: {employee.Startdate}");
                        }

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("NO Data in table");
                    }

                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
        public void DeleteData(string name)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("SpDeleteEmployee", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Name",name);

                    int result = sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    if (result >= 1)
                    {
                        Console.WriteLine("employee data deleted");
                    }
                    else
                        Console.WriteLine("Error");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
