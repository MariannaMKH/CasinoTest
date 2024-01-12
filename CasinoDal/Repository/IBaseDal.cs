using CasinoDal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDal.Repository
{
    public interface IBaseDal :IDisposable 
    {
        void SetValues(object entity, object dbEntity);

        IUserDal UserDal { get; set; }
        IClientDal ClientDal { get; set; }

        IBonusDal BanusDal { get; set; }
        IUserRoleDal UserRoleDal { get; set; }

        IPermissionDal PermissionDal { get; set; }
        ICasinoRoleDal RoleDal { get; set; }
    }
        
}
