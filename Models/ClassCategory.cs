using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ACMS.DAL.Models
{
    public partial class ClassCategory : Entity, IAggregateRoot
    {
        //public ClassCategory()
        //{
        //    RegistredClasses = new HashSet<RegistredClass>();
        //}

        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal? IncomeInstructor { get; set; }
        public decimal? IncomeAiu { get; set; }
        public decimal? TotalTutionFee { get; set; }
        public decimal? DiscountedFee { get; set; }

        public virtual ICollection<RegistredClass> RegistredClasses { get; set; }
    }
}
