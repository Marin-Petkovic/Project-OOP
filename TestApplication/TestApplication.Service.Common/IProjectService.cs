﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Common.GETProject;
using TestApplication.Model.Common;

namespace TestApplication.Service.Common
{
    public interface IProjectService
    {
        Task<List<IProject>> RetrieveProjectsAsync(IProjectSorting sorting, IProjectPaging paging, IProjectFiltering filtering);

        Task<IProject> InsertProjectAsync(IProject project);

        Task<IProject> UpdateProjectNameByIdAsync(int id, string projectName);

        
        Task<IProject> DeleteProjectByIdAsync(int id);
        
    }
}
