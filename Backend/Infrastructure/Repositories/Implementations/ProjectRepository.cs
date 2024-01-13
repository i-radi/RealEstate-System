using Data.Entities.Projects;
using Infrastructure.Context;
using Infrastructure.Repositories.Abstracts;
using Infrastructure.Repositories.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Implementations;
public class ProjectRepository : GenericRepositoryAsync<Project>, IProjectRepository
{
    #region Fields
    private DbSet<Project> projects;
    #endregion

    #region Constructors
    public ProjectRepository(ApplicationDBContext dbContext) : base(dbContext)
    {
        projects = dbContext.Set<Project>();
    }
    #endregion

    #region Handle Functions

    #endregion
}