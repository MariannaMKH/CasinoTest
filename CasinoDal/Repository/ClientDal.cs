using CasinoDal.Core;
using CasinoDal.Interfaces;
using CasinoEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDal.Repository
{
    /// <summary>
    /// Implement all CRUD operations and basic data manupulation for Client here
    /// </summary>
    public class ClientDal : CoreDal, IClientDal
    {
        public ClientDal(BaseDal dal) : base(dal)
        {
        }
        /// <summary>
        /// Add New Client or updates if exists
        /// </summary>
        /// <param name="argClient"></param>
        public void AddClient(Client argClient)
        {
            var dbClient = db.Client.FirstOrDefault(x => x.Id == argClient.Id);
            if (dbClient != null)
            {
                db.Update(argClient);
            }
            db.Client.Add(argClient);
            db.SaveChanges();
        }
        /// <summary>
        /// Remove Client
        /// </summary>
        /// <param name="id"></param>
        public void DeleteClient(int id)
        {
            var dbClient = db.Client.FirstOrDefault(x => x.Id == id);
            if (dbClient == null)
                throw CreateException($"Client with id {id} doesn't exists");

            db.Client.Remove(dbClient);
            db.SaveChanges();
        }

        public void DeleteClient(long id)
        {
            throw new NotImplementedException();
        }

        public Client GetClientById(long id)
        {
            throw new NotImplementedException();
        }

        public Client GetClientByLogin(string login)
        {
            throw new NotImplementedException();
        }

        public void UpdateClient(Client argClient)
        {
            throw new NotImplementedException();
        }
    }
}
