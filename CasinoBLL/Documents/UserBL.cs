using CasinoDal.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoBLL.Documents
{
    public class UserBL : CoreBL, IUserBl
    {
        #region Constructor
        public UserBL(CoreBL parent = null)
            : base(parent)
        {
        }
        #endregion
    }
}
