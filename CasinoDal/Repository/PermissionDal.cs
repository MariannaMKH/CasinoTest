using CasinoDal.Core;
using CasinoDal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDal.Repository
{
    public class PermissionDal : CoreDal, IPermissionDal
    {
        public PermissionDal(BaseDal dal) : base(dal)
        {
        }
    }
}
