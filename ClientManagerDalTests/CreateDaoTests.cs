using ClientManager;
using ClientManager.DataAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClientManagerDalTests
{
    [TestClass]
    public class CreateDaoTests
    {
        private static string connectionString = $"Server=(localdb)\\MSSqlLocalDb; Database=ClientManager_{Guid.NewGuid()}; Trusted_connection=true";

        [TestMethod]
        public void CreateCustomerDao()
        {
            ICustomerDao dao = DaoFactory.Create<ICustomerDao>(connectionString);

            Assert.IsInstanceOfType(dao, typeof(ICustomerDao));
        }
    }
}
