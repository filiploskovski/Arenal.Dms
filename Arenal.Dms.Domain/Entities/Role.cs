using System;
using System.Collections.Generic;

namespace Arenal.Dms.Domain.Entities
{
    public partial class Role
    {
        public Role()
        {
            Employee = new HashSet<Employee>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
