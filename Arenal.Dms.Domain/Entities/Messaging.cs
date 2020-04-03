using System;
using System.Collections.Generic;

namespace Arenal.Dms.Domain.Entities
{
    public partial class Messaging
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public DateTime Date { get; set; }
    }
}
