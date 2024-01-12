using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoEL.Models
{
    public class Bonus
    {
        public int Id { get; set; }
        public string BonusName { get; set; }
        public string Description { get; set; }
        public decimal Amoount { get; set; }

        public int ClientId { get; set; }

        public byte Type { get; set; }
    }
}
