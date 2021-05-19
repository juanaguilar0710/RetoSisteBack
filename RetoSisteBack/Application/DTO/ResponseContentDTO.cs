using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetoSisteBack.Application.DTO
{
    public class ResponseContentDTO
    {
        public ResponseContentDTO()
        {
            this.Errors = new Dictionary<string, string[]>();
        }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("traceId")]
        public string TraceId { get; set; }

        [JsonProperty("errors")]
        public Dictionary<string, string[]> Errors { get; set; }
    }
}
