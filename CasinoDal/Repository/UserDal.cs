using CasinoDal.Core;
using CasinoDal.Interfaces;
using CasinoEL.Models;
using System;
using System.Linq;

namespace CasinoDal.Repository
{
    public class UserDal : CoreDal, IUserDal
    {
        public UserDal(BaseDal dal) : base(dal)
        {
        }

        public void AddOrUpdateUser(User argUser)
        {
            try
            {
                var dbUser = db.User.FirstOrDefault(x => x.Id == argUser.Id);
                if (dbUser != null)
                {
                    db.Update(argUser);
                }
                db.User.Add(argUser);
                db.SaveChanges();
            }
            catch(System.Exception e)
            {
                throw CreateException(e.Message);
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                var dbUser = db.User.FirstOrDefault(x => x.Id == id);
                if (dbUser == null)
                    throw CreateException("User doesn't exists");

                db.User.Remove(dbUser);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw CreateException(e.Message);
            }
        }

        public User GetUserById(int id)
        {
            try
            {
                var dbUser = db.User.FirstOrDefault(x => x.Id == id);
                if (dbUser == null)
                    throw CreateException("User doesn't exists");

                return dbUser;
            }
            catch(Exception e)
            {
                throw CreateException(e.Message);
            }
        }
    }
}
