using CasinoDal.Core;
using CasinoDal.Interfaces;
using CasinoEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDal.Repository
{/// <summary>
/// implement all CRUD for casino role here
/// </summary>
    public class CasinoRoleDal : CoreDal, ICasinoRoleDal
    {
        public CasinoRoleDal(BaseDal dal) : base(dal)
        {
        }
        /// <summary>
        /// Deletes Role from the database
        /// </summary>
        /// <param name="id"></param>
        public void DeleteRole(int id)
        {
            var dbRole = db.CasinoRole.FirstOrDefault(x => x.Id == id);
            if (dbRole == null)
                throw CreateException("Role doesn't exists"); 

            db.CasinoRole.Remove(dbRole);
            db.SaveChanges();
        }

        public CasinoRole GetRoleById(int id)
        {
            try
            {
                var dbRole = db.CasinoRole.FirstOrDefault(x => x.Id == id);
                if (dbRole == null)
                    throw CreateException("Role doesn't exists");

                return dbRole;
            }
            catch(Exception e)
            {
                throw CreateException(e.Message);
            }
        }
        
        /// <summary>
        /// add a role to the database
        /// </summary>
        /// <param name="argRole"></param>
        /// <returns></returns>
        public int UpdateRole(CasinoRole argRole)
        {
            try
            {
                var dbRole = db.CasinoRole.FirstOrDefault(x => x.Id == argRole.Id);
                if (dbRole != null)
                {
                    db.Update(argRole);
                }
                db.CasinoRole.Add(argRole);
                db.SaveChanges();

                return dbRole.Id;
            }
            catch (Exception e)
            {
                throw CreateException(e.Message);
            }
           
        }
    }
}
