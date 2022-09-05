using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Models.Repository.Responses;

namespace GitLabApiClient
{
    public interface IRepositoryClient
    {
        /// <summary>
        /// Get a commit from commit sha
        /// </summary>
        /// <param name="projectId">The ID, path or <see cref="Project"/> of the project.</param>
        /// <param name="from">The commit hash or name of a repository branch or tag</param>
        /// /// <param name="to">The commit hash or name of a repository branch or tag</param>
        /// <returns></returns>
        Task<Compare> Compare(ProjectId projectId, string from, string to);
    }
}
