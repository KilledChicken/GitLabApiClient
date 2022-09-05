using System;
using System.Collections.Generic;
using System.Text;
using GitLabApiClient.Models.Commits.Responses;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.MergeRequests.Responses
{
    public sealed class MergeChanges : MergeRequest
    {
        [JsonProperty("changes")]
        public List<Diff> Changes { get; } = new List<Diff>();

        [JsonProperty("changes_count")]
        public int ChangesCount { get; }
        
    }
}
