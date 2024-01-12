using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoEL.Models
{
    /// <summary>
    /// defines many to many connection to user and their roles
    /// </summary>
    public class UserRole
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int CasinoRoleId { get; set; }

    }
}
