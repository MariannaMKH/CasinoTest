using CasinoDal.Interfaces;
using CasinoDal.Repository;
using CasinoEL;
using System;

namespace CasinoDal.Core
{
    public class BaseDal : IBaseDal
    {
        private CasinoDBContext _db;

        public BaseDal(CasinoDBContext db = null)
        {
            if (db is null)
            {
                db = new CasinoDBContext();
            }
            _db = db;
        }
        protected internal CasinoDBContext db
        {
            get { return _db; }
        }

        private IUserDal _iUserDal;
        public IUserDal UserDal {
            get => _iUserDal ?? (_iUserDal = new UserDal(this));
            set { _iUserDal = value; }
        }
        private IClientDal _iClientDal;
        public IClientDal ClientDal
        {
            get => _iClientDal ?? (_iClientDal = new ClientDal(this));
            set { _iClientDal = value; }
        }
        private IBonusDal _iBonusDal;
        public IBonusDal BanusDal
        {
            get => _iBonusDal ?? (_iBonusDal = new BonusDal(this));
            set { _iBonusDal = value; } 
        }
        private IUserRoleDal _iUserRoleDal;
        public IUserRoleDal UserRoleDal 
        { 
            get => _iUserRoleDal ?? (_iUserRoleDal = new UserRoleDal(this));
            set { _iUserRoleDal = value; }
        }

        private IPermissionDal _iPermissionDal;
        public IPermissionDal PermissionDal 
        { 
            get => _iPermissionDal ?? (_iPermissionDal = new PermissionDal(this));
            set
            {
                _iPermissionDal = value;
            }
        }
        private ICasinoRoleDal _iCasinoRoleDal;
        public ICasinoRoleDal RoleDal 
        {
            get => _iCasinoRoleDal ?? (_iCasinoRoleDal = new CasinoRoleDal(this));
            set
            {
                _iCasinoRoleDal = value;
            }
        }

        public void SetValues(object entity, object dbEntity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
