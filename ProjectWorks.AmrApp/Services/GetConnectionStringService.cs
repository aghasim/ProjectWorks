using System.Collections.Generic;

namespace ProjectWorks.AmrApp
{
    public class GetConnectionStringService : IChangeConnectionString
    {
        public string GetDBContext(int filialId)
        {
            var connString = new Dictionary<int, string>()
            {
                {6,"NchelnyConnection" },
                {11,"SmrConnection" },
                {5,"SrtvConnection" }
            };
            return connString[filialId];
        }
    }
}
