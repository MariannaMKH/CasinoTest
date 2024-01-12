using CasinoEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDal.BLL
{
    public interface IBonusBl
    {
        int UpdateBonus(Bonus argClient);
        void DeleteBonus(long id);

        void AssignBonusToClient(int clientId, int bonusId);

        decimal CalculateBonus(int clientId, int bonusId);
    }
}
