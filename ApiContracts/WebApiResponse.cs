using System.Net;
using Newtonsoft.Json;

namespace CustomFramework.BaseWebApi.Contracts.ApiContracts
{
    public class WebApiResponse
    {
        public HttpStatusCode StatusCode { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        public object Result { get; set; }

        public int TotalCount { get; set; }

        public ErrorResponse ErrorResponse { get; set; }
    }    
}
