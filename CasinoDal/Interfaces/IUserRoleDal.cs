using CasinoEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDal.Interfaces
{
    public interface IUserRoleDal
    {
        void AddOrUpdateUserRole(UserRole argUser);
        void DeleteUserRole(int id);
    }
}
