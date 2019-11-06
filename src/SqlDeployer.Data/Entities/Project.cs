using System.Collections.Generic;

namespace SqlDeployer.Data.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TargetPath { get; set; }
        
        public List<Environment> Envrionments { get; set; }
    }
}