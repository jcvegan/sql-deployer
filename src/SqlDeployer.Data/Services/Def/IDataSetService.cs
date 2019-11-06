using LiteDB;
using SqlDeployer.Data.Entities;

namespace SqlDeployer.Data.Services.Def
{
    public interface IDataSetService
    {
        LiteCollection<Project> GetProjectDbSet();
    }
}