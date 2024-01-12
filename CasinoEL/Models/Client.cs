using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoEL.Models
{
    /// <summary>
    /// Client table describes Casino players
    /// </summary>
    public partial class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public decimal Balance { get; set; }

        public long PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
    }
}
