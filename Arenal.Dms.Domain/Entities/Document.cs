using System;
using System.Collections.Generic;

namespace Arenal.Dms.Domain.Entities
{
    public partial class Document
    {
        public Document()
        {
            DocumentFile = new HashSet<DocumentFile>();
        }

        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPrefix { get; set; }
        public int DocumentFolderId { get; set; }

        public virtual DocumentFolder DocumentFolder { get; set; }
        public virtual ICollection<DocumentFile> DocumentFile { get; set; }
    }
}
