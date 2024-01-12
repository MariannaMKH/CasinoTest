using CasinoEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDal.BLL
{
    public interface IClientBL : IDisposable
    {
        Client LoginClient(string login, string password);
        int UpdateClient(Client argClient);
        void DeleteClient(long id);
    }
}
