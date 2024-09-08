using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entites
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }
        public int? Age { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }
        [NotMapped]
        [Phone]
        public string PhoneNumber { get; set; }
        [NotMapped ]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
} 
