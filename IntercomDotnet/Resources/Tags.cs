﻿using RestSharp;

namespace IntercomDotNet.Resources
{
    public class Tags : Resource
    {
        public Tags(Client client) : base(client, "tags")
        {
        }

        public dynamic List()
        {
            return Client.Execute(BaseUrl, Method.GET, request => { });
        }

        public dynamic Post(object hash)
        {
            return Client.Execute(BaseUrl, Method.POST, request =>
                {
                    request.RequestFormat = DataFormat.Json;
                    request.AddBody(hash);
                });
        }

        public dynamic Delete(int id)
        {
            return Client.Execute(BaseUrlWithId, Method.DELETE, request =>
                {
                    request.AddUrlSegment("id", id.ToString());
                });
        }
    }
}
