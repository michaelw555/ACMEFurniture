using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalFinanceWebsite.Shared
{
    public class Pinfo
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public decimal Deposit { get; set; }
        public int Months { get; set; }
        public string Status { get; set; } = "Pending";
    }
}
