using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasinoDal;
using CasinoDal.Interfaces;
using CasinoDal.Repository;

namespace CasinoBLL
{
    public class CoreBL : ICoreBL
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_isChild)
                {
                    _parent = null;
                }
                else
                {
                    if (db != null)
                    {
                        db = null;
                    }

                }
            }
        }
        public CoreBL(CoreBL parent = null)
        {
            _parent = parent;
            if (parent == null)
                db = new CasinoDBContext();
            else
            {
                _parent = parent;
                _isChild = true;
            }
        }

        private CasinoDBContext _db;

        protected CasinoDBContext db
        {
            get { return _isChild ? _parent.db : _db; }
            private set
            {
                if (_isChild)
                    throw CreateException("Not Allowed");
                _db = value;
            }
        }
        protected IBaseDal Dal
        {
            get { return db.GetBaseDal(); }
        }

        protected Exception CreateException(string message)
        {
            return new Exception(message.ToString());
        }

        private CoreBL _parent;

        protected readonly bool _isChild;
    }
}
