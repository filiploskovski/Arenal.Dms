using System;
using System.Collections.Generic;

namespace Arenal.Dms.Domain.Entities
{
    public partial class Company
    {
        public Company()
        {
            Employee = new HashSet<Employee>();
            Role = new HashSet<Role>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime Password { get; set; }
        public DateTime PasswordSalt { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Role> Role { get; set; }
    }
}
