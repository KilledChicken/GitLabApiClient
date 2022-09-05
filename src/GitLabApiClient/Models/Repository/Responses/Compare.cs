using System;
using System.Collections.Generic;
using System.Text;
using GitLabApiClient.Models.Commits.Responses;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Repository.Responses
{
    public sealed class Compare
    {
        [JsonProperty("commit")]
        public Commit Commit { get; }
        [JsonProperty("commits")]
        public List<Commit> Commits { get; } = new List<Commit>();
        [JsonProperty("diffs")]
        public List<Diff> Diffs { get; } = new List<Diff>();
        [JsonProperty("compare_timeput")]
        public bool Compare_timeout { get;}
        [JsonProperty("compare_same_ref")]
        public bool Compare_same_ref { get;}

    }
}
