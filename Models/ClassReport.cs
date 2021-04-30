using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ACMS.DAL.Models
{
    public partial class ClassReport : Entity, IAggregateRoot
    {
        //public ClassReport()
        //{
        //    RegistredClasses = new HashSet<RegistredClass>();
        //}

        public Guid ClassReportId { get; set; }
        public string Remarks { get; set; }

        public virtual RegistredClass RegistredClasses { get; set; }
    }
}
