using CasinoDal.BLL;
using CasinoEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoBLL.Documents
{
    /// <summary>
    /// Implement all business logic connecting to Bonus like calculation, assignment etc. here
    /// </summary>
    class BonusBl : CoreBL, IBonusBl
    {
        #region Constructor
        public BonusBl(CoreBL parent = null)
            : base(parent)
        {
        }
        #endregion
       /// <summary>
       /// Give Bonus to client, set clinetId on bonus entity
       /// </summary>
       /// <param name="clientId"></param>
       /// <param name="bonusId"></param>
        public void AssignBonusToClient(int clientId, int bonusId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Calculates Bonus based on the client by getting clientByid 
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="bonusId"></param>
        public decimal CalculateBonus(int clientId, int bonusId)
        {
            throw new NotImplementedException();
        }

        public void DeleteBonus(long id)
        {
            throw new NotImplementedException();
        }

        public int UpdateBonus(Bonus argClient)
        {
            throw new NotImplementedException();
        }
    }
}
