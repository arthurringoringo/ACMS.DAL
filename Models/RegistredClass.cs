using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ACMS.DAL.Models
{
    public partial class RegistredClass : Entity, IAggregateRoot
    {
        public RegistredClass()
        {
            ClassReport = new ClassReport();
            ClassReportId = ClassReport.ClassReportId;
        }

        public Guid RegistredClassId { get; set; }
        public Guid StudentId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid ClassId { get; set; }
        public Guid ClassReportId { get; set; }
        public bool ConfirmedByTeacher { get; set; }
        public DateTime DateRegistered { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public Guid PaymentMethodId { get; set; }
        public bool? FullyPaid { get; set; }
        //TODO ClassREPort if needed

        [ForeignKey("CategoryId")]
        public virtual ClassCategory Category { get; set; }
        [ForeignKey("ClassId")]
        public virtual AvailableClass Class { get; set; }
        [ForeignKey("ClassReportId")]
        public virtual ClassReport ClassReport { get; set; }
        [ForeignKey("PaymentMethodId")]
        public virtual PaymentMethod PaymentMethod { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
        
        public virtual ICollection<PaidSession> PaidSession { get; set; }
    }
}
