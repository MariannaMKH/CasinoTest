using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasinoBLL;

namespace Interface
{
    class Program
    {
        /// <summary>
        /// In interface create models map to our modelf from Casino EL layer to give to user
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var _blfactory = new BLFactory();
           
            using (var bl = _blfactory.CreateClientBL())
            {
                var value = bl.LoginClient("Login", "Password");
                
            }
           
        }
    }
}
