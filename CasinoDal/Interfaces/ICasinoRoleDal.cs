using CasinoEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDal.Interfaces
{
    public interface ICasinoRoleDal
    {
        int UpdateRole(CasinoRole argClient);
        void DeleteRole(int id);

        CasinoRole GetRoleById(int Id);
    }
}
