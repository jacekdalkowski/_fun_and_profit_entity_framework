using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutEmployees
{
    public class Employee
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public int? BossId { get; set; }
        public Employee Boss { get; set; }
        public DateTimeOffset EmployedSince { get; set; }
        public decimal SalaryBasic { get; set; }
        public decimal SalaryAdditional { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
