using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoEL.Models
{
    /// <summary>
    /// table describes roles that will be given to user
    /// </summary>
    public class CasinoRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }

        public int PermissionId { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
