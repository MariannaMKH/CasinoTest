﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoEL.Models
{
    /// <summary>
    /// Table define specific permission that can be assigned to role
    /// </summary>
    public class Permission
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }
    }
}
