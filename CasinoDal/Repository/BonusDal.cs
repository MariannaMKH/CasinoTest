using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasinoDal.Core;
using CasinoDal.Interfaces;
using CasinoEL.Models;

namespace CasinoDal.Repository
{
    /// <summary>
    /// Implement all CRUD operations and basic data manipulation for Bonus class here
    /// </summary>
    public class BonusDal : CoreDal, IBonusDal
    {
        public BonusDal(BaseDal dal) : base(dal)
        {
        }
        #region methods
        /// <summary>
        /// Add New Bonus or updates if exists
        /// </summary>
        /// <param name="argClient"></param>
        public void AddBonus(Bonus argBonus)
        {
            var dbClient = db.Client.FirstOrDefault(x => x.Id == argBonus.Id);
            if (dbClient != null)
            {
                db.Update(argBonus);
            }
            db.Bonus.Add(argBonus);
            db.SaveChanges();
        }
        /// <summary>
        /// Remove Bonus
        /// </summary>
        /// <param name="id"></param>
        public void DeleteClient(int id)
        {
            var dbBonus = db.Bonus.FirstOrDefault(x => x.Id == id);
            if (dbBonus == null) return;

            db.Bonus.Remove(dbBonus);
            db.SaveChanges();
        }
        #endregion

    }

}

