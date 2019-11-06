namespace SqlDeployer.Data.Entities
{
    public class Environment
    {
        public int EnvironmentId { get; set; }
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        public string Prefix { get; set; }
        public bool IsDefault { get; set; }
    }
}