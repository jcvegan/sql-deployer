using System.IO;
using NUnit.Framework;
using SqlDeployer.Services.Def.Config;

namespace SqlDeployer.Services.Tests
{
    public class ConfigFileCreatorServiceTest
    {
        private IConfigCreatorService _creatorService;
        
        [SetUp]
        public void Setup()
        {
            _creatorService = new ConfigCreatorService();
        }
        
        [Test]
        public void TestConfigCreator()
        {
            var existsFileBefore = File.Exists(".dbdeployer");
            _creatorService.Create();
            var existsFileAfter = File.Exists(".dbdeployer");
            Assert.AreNotEqual(existsFileBefore, existsFileAfter);
        }
    }
}