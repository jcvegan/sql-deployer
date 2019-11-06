using System.IO;
using SqlDeployer.Services.Def.Config;

namespace SqlDeployer.Services.Impl.Config
{
    public class ConfigFileValidatorService : IConfigFileValidatorService
    {
        public bool ExistsFile()
        {
            return File.Exists(".dbdeployer");
        }
    }
}