using System;

namespace SqlDeployer.Config
{
    [Serializable]
    public class Source
    {
        public string Path { get; set; }
        public int Order { get; set; }
    }
}