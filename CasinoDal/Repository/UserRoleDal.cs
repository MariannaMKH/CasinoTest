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
    public class UserRoleDal : CoreDal, IUserRoleDal
    {
        public UserRoleDal(BaseDal dal) : base(dal)
        {
        }

        public void AddOrUpdateUserRole(UserRole argUserRole)
        {
            try
            {
                var dbURole = db.UserRole.FirstOrDefault(x => x.Id == argUserRole.Id);
                if (dbURole != null)
                {
                    db.Update(argUserRole);
                }
                db.UserRole.Add(argUserRole);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw CreateException(e.Message);
            }
        }

        public void DeleteUserRole(int id)
        {
            try
            {
                var dbURole = db.UserRole.FirstOrDefault(x => x.Id == id);
                if (dbURole == null)
                {
                    throw CreateException($"user role with id = {id} doesn't exists");
                }
                db.UserRole.Remove(dbURole);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw CreateException(e.Message);
            }
        }
    }
}
