using System;
using System.Collections.Generic;

namespace Arenal.Dms.Domain.Entities
{
    public partial class DocumentFile
    {
        public int DocumentFileId { get; set; }
        public int DocumentId { get; set; }
        public byte[] File { get; set; }

        public virtual Document Document { get; set; }
    }
}
