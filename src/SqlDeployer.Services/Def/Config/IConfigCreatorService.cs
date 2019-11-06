using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using SqlDeployer.Config;
namespace SqlDeployer.Services.Def.Config
{
    public interface IConfigCreatorService
    {
        void Create();
    }

    public class ConfigCreatorService : IConfigCreatorService
    {
        public void Create()
        {
            var projects = new List<Project>();
            using (FileStream stream = new FileStream(".dbdeployer",FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, projects);
            }
        }
    }
}