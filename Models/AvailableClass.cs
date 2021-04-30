using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ACMS.DAL.Models
{
    public partial class AvailableClass :Entity, IAggregateRoot
    {
        //public AvailableClass()
        //{
        //    PaidSessions = new HashSet<PaidSession>();
        //    RegistredClasses = new HashSet<RegistredClass>();
        //    SessionSchedules = new HashSet<SessionSchedule>();
        //}
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ClassId { get; set; }
        public string ClassName { get; set; }
        public Guid TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<RegistredClass> RegistredClasses { get; set; }
        public virtual ICollection<SessionSchedule> SessionSchedules { get; set; }
    }
}
