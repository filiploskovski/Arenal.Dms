using System;
using System.Collections.Generic;

namespace Arenal.Dms.Domain.Entities
{
    public partial class EmployeePicture
    {
        public int EmployeeId { get; set; }
        public byte[] Picture { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
