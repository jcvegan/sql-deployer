using System.Collections.Generic;

namespace SqlDeployer.Config
{
    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Profile { get; set; }
        public string TargetPath { get; set; }

        public List<Environment> Environments { get; set; }
        public List<Source> Sources { get; set; }
    }
}