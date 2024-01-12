using CasinoEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDal.Core
{
    public abstract class CoreDal
    {
        private readonly BaseDal _Dal;
        protected BaseDal Dal
        {
            get
            {
                return _Dal;
            }
        }

        protected CasinoDBContext db
        {
            get
            {
                return _Dal.db;
            }
        }

        protected CoreDal(BaseDal dal)
        {
            if (dal == null)
                throw new ArgumentNullException("dal");
            _Dal = dal;
        }

        protected Exception CreateException(string message)
        {
            return new Exception(message.ToString());
        }
    }
}
