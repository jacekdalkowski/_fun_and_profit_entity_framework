using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutEmployees
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SalaryMin { get; set; }
        public decimal SalaryMax { get; set; }
    }
}
