using System;

namespace SqlDeployer.Config
{
    [Serializable]
    public class Environment
    {
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        public string Prefix { get; set; }
    }
}