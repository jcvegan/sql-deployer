using System.Collections.Generic;
using SqlDeployer.Data.Entities;

namespace SqlDeployer.Data.Services.Def
{
    public interface IProjectDataService
    {
        IEnumerable<Project> GetProjects();
        void AddProject(Project projectToCreate);
        void UpdateProject(Project projectToUpdate);
        void DeleteProject(Project projectToDelete);
    }
}