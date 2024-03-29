﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMS.DAL.Models
{
    public class User : IdentityUser<int>
    {
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
