using CasinoDal.Core;
using CasinoDal.Repository;
using CasinoEL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDal
{
    public partial class CasinoDBContext : DbContext
    {
        public CasinoDBContext()
        {
        }
        private IBaseDal _baseDal;
        public IBaseDal GetBaseDal()
        {
            return _baseDal ?? (_baseDal = new BaseDal(this));
        }
        public void Remove( object entity)
        {
            //Implement Entity removal from DB
        }

        public object Update(object entity)
        {
            //implement update operation on context
            return null;
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Bonus> Bonus { get; set; }
        public virtual DbSet<CasinoRole> CasinoRole { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
    }
}
