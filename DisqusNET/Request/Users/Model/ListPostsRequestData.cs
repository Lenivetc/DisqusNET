﻿using System.Runtime.Serialization;

namespace DisqusNET.Request.Users.Model
{
    [DataContract]
    public class ListPostsRequestData : ApiKeyRequestExtension
    {
        [DataMember(Name = "access_token")]
        public string AccessToken { get; set; }

        [DataMember(Name = "limit")]
        public int Limit { get; set; }

        public ListPostsRequestData()
        {
            Limit = 25;
        }
    }
}