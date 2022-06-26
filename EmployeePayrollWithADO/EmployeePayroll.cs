using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollWithADO
{
    class EmployeeModel

    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string department { get; set; }
        public char gender { get; set; }
        public int salary { get; set; }
        public int basicpay { get; set; }
        public int deduction { get; set; }
        public int taxablepay { get; set; }
        public int netpay { get; set; }
        public int incometax { get; set; }
        public string startdate { get; set; }

    }
}