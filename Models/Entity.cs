using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ACMS.DAL.Models
{
    public class Entity
    {
        public DateTime CreatedOn{ get; set; }
        
        [DefaultValue("false")]
        public bool Deleted { get; set; }
        [DefaultValue(null)]
        public DateTime? DeletedOn { get; set; }
    }
}
