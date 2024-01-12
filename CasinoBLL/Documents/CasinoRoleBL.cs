using CasinoDal.BLL;
using CasinoDal.Interfaces;
using CasinoEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoBLL.Documents
{
    /// <summary>
    /// implement role assigmnement and other logic here
    /// </summary>
    class CasinoRoleBL : CoreBL, ICasinoRoleBl
    {
        #region Constructor
        public CasinoRoleBL(CoreBL parent = null)
            : base(parent)
        {
        }
        #region Properties
        protected ICasinoRoleDal RoleDal
        {
            get { return Dal.RoleDal; }
        }
        #endregion
        /// <summary>
        /// Delets role from database
        /// </summary>
        /// <param name="id"></param>
        public void DeleteRole(int id)
        {
            RoleDal.DeleteRole(id);
        }
        /// <summary>
        /// Asign role to the user
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="clientId"></param>
        public void GiveRoleToUser(int roleId, int userId)
        {
            try
            {
                var role = RoleDal.GetRoleById(roleId);
                var user = Dal.UserDal.GetUserById(userId);

                Dal.UserRoleDal.AddOrUpdateUserRole(new UserRole
                {
                    CasinoRoleId = role.Id,
                    UserId = user.Id
                });
                    
            }
            catch(Exception e)
            {
                throw CreateException(e.Message);
            }
        }
        /// <summary>
        /// adds the role to database
        /// </summary>
        /// <param name="argClient"></param>
        /// <returns></returns>
        public int UpdateRole(CasinoRole argClient)
        {
           return  RoleDal.UpdateRole(argClient);
        }
        #endregion

    }
}
