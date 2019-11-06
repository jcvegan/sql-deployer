using LiteDB;
using SqlDeployer.Data.Entities;
using SqlDeployer.Data.Services.Def;

namespace SqlDeployer.Data.Services.Impl
{
    public class DataSetService : IDataSetService
    {
        private readonly string _dbPath;

        public DataSetService(string dbPath)
        {
            _dbPath = dbPath;
        }
        public LiteCollection<Project> GetProjectDbSet()
        {
            using (var db = new LiteDatabase(_dbPath))
            {
                return db.GetCollection<Project>("projects");
            }
        }
    }
}