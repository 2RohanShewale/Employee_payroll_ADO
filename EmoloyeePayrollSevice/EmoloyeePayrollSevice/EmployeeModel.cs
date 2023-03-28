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
        public float BasicPay { get; set; }
        public DateTime Startdate { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public string Department { get; set; }
        public float Deduction { get; set; }
        public float TaxablePay { get; set; }
        public float IncomeTax { get; set; }
        public float NetPay { get; set; }
    }
}
