using System;
using System.Collections.Generic;

namespace OctoNet.Models
{
    public class OctoNetResult
    {
        public readonly System.Net.HttpStatusCode StatusCode;
        
        public static implicit operator bool(OctoNetResult m)
        {
            // code to convert from Result to Boolean
            return (m.StatusCode == System.Net.HttpStatusCode.OK);
        }

        public static implicit operator System.Net.HttpStatusCode(OctoNetResult m)
        {
            // code to convert from Result to HttpStatusCode (for convenience and to keep dev code cleaner)
            return m.StatusCode;
        }

        public OctoNetResult(RestSharp.RestResponse m)
        {
            StatusCode = m.StatusCode;
        }
    }

}
