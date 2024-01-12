using CasinoEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDal.Interfaces
{
    public interface IClientDal
    {
        void AddClient(Client argClient);
        void DeleteClient(long id);
        void UpdateClient(Client argClient);
        Client GetClientById(long id);

        Client GetClientByLogin(string login);
    }
}
