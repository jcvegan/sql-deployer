using System.Collections.Generic;
using SqlDeployer.Data.Entities;
using SqlDeployer.Data.Services.Def;

namespace SqlDeployer.Data.Services.Impl
{
    public class ProjectDataService : IProjectDataService
    {
        private readonly IDataSetService _dataSetService;

        public ProjectDataService(IDataSetService dataSetService)
        {
            _dataSetService = dataSetService;
        }
        
        public IEnumerable<Project> GetProjects()
        {
            var projectDataSet = _dataSetService.GetProjectDbSet();
            return projectDataSet.Query().ToList();
        }

        public void AddProject(Project projectToCreate)
        {
            var projectDataSet = _dataSetService.GetProjectDbSet();
            projectDataSet.Insert(projectToCreate);
        }

        public void UpdateProject(Project projectToUpdate)
        {
            var projectDataSet = _dataSetService.GetProjectDbSet();
            projectDataSet.Update(projectToUpdate);
        }

        public void DeleteProject(Project projectToDelete)
        {
            var projectDataSet = _dataSetService.GetProjectDbSet();
            projectDataSet.Delete(projectToDelete.ProjectId);
        }
    }
}