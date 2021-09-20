using ClientManager;
using ClientManager.DataAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClientManagerDalTests
{
    [TestClass]
    public class CreateDaoTests
    {
        [TestMethod]
        public void CreateCustomerDao()
        {
            ICustomerDao dao = DaoFactory.Create<ICustomerDao>();

            Assert.IsInstanceOfType(dao, typeof(ICustomerDao));
        }
    }
}
