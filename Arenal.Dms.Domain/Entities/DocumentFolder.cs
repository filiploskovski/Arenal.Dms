using System;
using System.Collections.Generic;

namespace Arenal.Dms.Domain.Entities
{
    public partial class DocumentFolder
    {
        public DocumentFolder()
        {
            Document = new HashSet<Document>();
        }

        public int DocumentFolderId { get; set; }
        public string DocumentFolderName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<Document> Document { get; set; }
    }
}
