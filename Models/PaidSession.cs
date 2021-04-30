using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ACMS.DAL.Models
{
    public partial class PaidSession : Entity, IAggregateRoot
    {
        public Guid PaidSessionId { get; set; }
        public Guid RegistredClassId { get; set; }
        public DateTime? DatePaid { get; set; }
        public string PictureLink { get; set; }
        public bool? PaymentAccepted { get; set; }
        public string? PaymentsMonth { get; set; }

        public virtual RegistredClass RegistredClass { get; set; }

    }
}
