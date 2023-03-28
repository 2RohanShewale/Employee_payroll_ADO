using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoloyeePayrollSevice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeModel employee = new EmployeeModel() 
            {
                Name = "Abhijeet",
                BasicPay = 1450000,
                Startdate = DateTime.Now,
                Gender = 'M',
                Address = "Mumbai",
                PhoneNumber = 125454543,
                Department = "Developer",
                Deduction = 0,
                TaxablePay = 0,
                IncomeTax = 0,
                NetPay = 0
            };
            EmployeeModel updateEmployee = new EmployeeModel()
            {
                Name = "Abhijeet",
                Address = "Pune",
                
            };
            EmoployeesPayroll emoployeesPayroll = new EmoployeesPayroll();
            
            while (true)
            {
                Console.Write("1.Add Date\n2.get all data\n3.Delete contact\n4.Update Contact\nEnter a choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        emoployeesPayroll.AddData(employee);
                        break;
                    case 2:
                        emoployeesPayroll.GetAllData();
                        break;
                    case 3:
                        emoployeesPayroll.DeleteData("Abhijeet");
                        break;
                    case 4:
                        emoployeesPayroll.UpdateDate(updateEmployee);
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
