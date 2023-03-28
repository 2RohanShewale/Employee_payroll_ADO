using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoloyeePayrollSevice
{
    public class EmployeeModel
    {
        public string Name { get; set; }
        public double BasicPay { get; set; }
        public DateTime Startdate { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public string Department { get; set; }
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }
    }
}
