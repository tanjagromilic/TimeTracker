using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTrackerPMF.Client
{
    public class Config
    {
        public const string ApiRootUrl = "https://localhost:44394/";
        public const string ApiResourceUrl = ApiRootUrl + "api/";
        public const string TokenUrl = ApiRootUrl + "get-token";
    }
}
