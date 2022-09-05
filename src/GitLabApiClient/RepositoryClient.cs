using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Http;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Internal.Queries;
using GitLabApiClient.Models.Repository.Responses;

namespace GitLabApiClient
{
    public sealed class RepositoryClient : IRepositoryClient
    {
        private readonly GitLabHttpFacade _httpFacade;


        internal RepositoryClient(GitLabHttpFacade httpFacade)
        {
            _httpFacade = httpFacade;
        }

        public async Task<Compare> Compare(ProjectId projectId, string from, string to) =>
            await _httpFacade.Get<Compare>($"projects/{projectId}/repository/compare?from={from}&to={to}");

    }
}
