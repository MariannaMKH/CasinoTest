using CasinoDal.BLL;
using CasinoDal.Interfaces;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoBLL.Documents
{
    /// <summary>
    /// implement all business logic for client account management activities here
    /// </summary>
    public class ClientBL : CoreBL, IClientBL
    {
        #region Constructor
        public ClientBL(CoreBL parent = null)
            : base(parent)
        {
        }
        #endregion

        #region Properties
        protected IClientDal ClientDal
        {
            get { return Dal.ClientDal; }
        }
        #endregion
        public void DeleteClient(long id)
        {
            ClientDal.DeleteClient(id);
        }

        public global::CasinoEL.Models.Client LoginClient(string login, string password)
        {
            var client = ClientDal.GetClientByLogin(login);
            if (client == null)
                return null;

            var pwd = Helper.ComputeHash(password, client.PasswordSalt);
            if (!pwd.Equals(client.PasswordHash))
                return null;

            return client;
        }

        public int UpdateClient(global::CasinoEL.Models.Client argClient)
        {
            throw new NotImplementedException();
        }
    }
}
