using CasinoEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDal.BLL
{
    public interface ICasinoRoleBl
    {
        int UpdateRole(CasinoRole argClient);
        void DeleteRole(int id);
        void GiveRoleToUser(int roleId, int userId);
    }
}
