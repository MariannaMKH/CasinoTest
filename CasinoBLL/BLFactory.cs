using CasinoBLL.Documents;
using CasinoDal.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoBLL
{
    /// <summary>
    /// Implements factory to work with DAL
    /// </summary>
    public class BLFactory 
    {
        public IClientBL clientBl { get; set; }
        public IClientBL CreateClientBL(CoreBL parentBL = null)
        {
            return clientBl ?? new ClientBL(parentBL);
        }

        public IUserBl userBl { get; set; }
        public IUserBl CreateUserBL(CoreBL parentBL = null)
        {
            return userBl ?? new UserBL(parentBL);
        }


        public ICasinoRoleBl casinoRoleBl { get; set; }
        public ICasinoRoleBl CreateCasinoRoleBL(CoreBL parentBL = null)
        {
            return casinoRoleBl ?? new CasinoRoleBL(parentBL);
        }

        public IBonusBl bonusBl { get; set; }
        public IBonusBl CreateBonusBL(CoreBL parentBL = null)
        {
            return bonusBl ?? new BonusBl(parentBL);
        }
    }
}
