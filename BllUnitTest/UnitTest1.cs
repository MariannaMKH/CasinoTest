using System;
using CasinoBLL;
using CasinoEL.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BllUnitTest
{
    /// <summary>
    /// implement test on all bll methods
    /// Use Mock for thesting data
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        protected BLFactory blfactory;
        [TestMethod]
        public void Test_UpdateClient()
        {
            var tmpClient = new Client
            {
                ClientName = "aaa13399",
                PasswordHash = "a12345678S900",
            };

            blfactory = new BLFactory();
            using (var bl = blfactory.CreateClientBL())
            {
                var a = bl.UpdateClient(tmpClient);
                Assert.IsInstanceOfType(a, typeof(Int32));
            }
        }
    }
}
