using System;
using System.Collections.Generic;

#nullable disable

namespace ACMS.DAL.Models
{
    public partial class SessionSchedule : Entity, IAggregateRoot
    {
        public Guid ScheduleId { get; set; }
        public Guid TeacherId { get; set; }
        public Guid ClassId { get; set; }
        public Guid StudentId { get; set; }
        public DateTime? Time { get; set; }
        public string Day { get; set; }
        public string Remarks { get; set; }

        public virtual AvailableClass Class { get; set; }
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
