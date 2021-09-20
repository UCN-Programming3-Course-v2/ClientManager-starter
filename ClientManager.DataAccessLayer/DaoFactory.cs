using System;

namespace ClientManager
{
    public static class DaoFactory
    {
        public static TEntity Create<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
