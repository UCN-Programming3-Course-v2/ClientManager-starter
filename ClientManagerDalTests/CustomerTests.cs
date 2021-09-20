using ClientManager;
using ClientManager.DataAccessLayer;
using ClientManager.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagerDalTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CreateCustomerTest()
        {
            ICustomerDao dao = DaoFactory.Create<ICustomerDao>();

            Customer customer = new()
            {
                Firstname = "Donald",
                Lastname = "Duck",
                Address = "1313 Webfoot Street",
                City = "Duckburg",
                Zip = "DB009Z",
                Email = "daisylover01@barksuniverse.com",
                Phone = "877-764-2539"
            };

            int result = dao.Insert(customer);

            Assert.IsTrue(result > 0);
        }
    }
}
