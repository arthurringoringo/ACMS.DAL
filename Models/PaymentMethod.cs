using System;
using System.Collections.Generic;

#nullable disable

namespace ACMS.DAL.Models
{
    public partial class PaymentMethod : Entity, IAggregateRoot
    {
        //public PaymentMethod()
        //{
        //    RegistredClasses = new HashSet<RegistredClass>();
        //}

        public Guid PaymentMethodId { get; set; }
        public string MethodName { get; set; }
        public int? Terms { get; set; }

        public virtual ICollection<RegistredClass> RegistredClasses { get; set; }
    }
}
