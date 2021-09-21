using ClientManager;
using ClientManager.DataAccessLayer;
using ClientManager.Model;
using DatabaseVersioning;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClientManagerDalTests
{
    [TestClass]
    public class CustomerTests
    {
        private static string connectionString = $"Server=(local)\\SqlExpress; Database=ClientManager_{Guid.NewGuid()}; Trusted_connection=true";

        [TestInitialize]
        public void Setup()
        {
            DatabaseVersion.Upgrade(connectionString);
        }

        [TestCleanup]
        public void TearDown()
        {
            DatabaseVersion.Destroy(connectionString);
        }

        [TestMethod]
        public void GetAllTest()
        {
            // TODO: Implement database integration test
            ICustomerDao dao = DaoFactory.Create<ICustomerDao>(connectionString);

            Assert.Fail();
        }

        [TestMethod]
        public void GetByIdTest()
        {
            // TODO: Implement database integration test
            
            Assert.Fail();
        }

        [TestMethod]
        public void CreateCustomerTest()
        {
            ICustomerDao dao = DaoFactory.Create<ICustomerDao>(connectionString);

            Customer customer = new()
            {
                Firstname = "Donald",
                Lastname = "Duck",
                Address = "1313 Webfoot Street",
                City = "Duckburg",
                Zip = "LZ6548",
                Email = "daisylover01@barksuniverse.com",
                Phone = "877-764-2539"
            };

            int result = dao.Insert(customer);

            Assert.IsTrue(result == 5);
        }

        [TestMethod]
        public void UpdateCustomerTest()
        {
            // TODO: Implement database integration test
            
            Assert.Fail();
        }

        [TestMethod]
        public void DeleteCustomerTest()
        {
            // TODO: Implement database integration test

            Assert.Fail();
        }
    }
}
