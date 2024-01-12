using CasinoEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDal.Interfaces
{
    public interface IUserDal
    {
        void AddOrUpdateUser(User argUser);
        void DeleteUser(int id);

        User GetUserById(int Id);
    }
}
