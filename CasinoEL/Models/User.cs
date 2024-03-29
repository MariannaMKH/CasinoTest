﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoEL.Models
{
    /// <summary>
    /// Describes the users  of the system
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
