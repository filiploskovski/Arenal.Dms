using System;
using System.Collections.Generic;

namespace Arenal.Dms.Domain.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            DocumentFolder = new HashSet<DocumentFolder>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime DateCreated { get; set; }
        public int RoleId { get; set; }
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Role Role { get; set; }
        public virtual EmployeePicture EmployeePicture { get; set; }
        public virtual ICollection<DocumentFolder> DocumentFolder { get; set; }
    }
}
