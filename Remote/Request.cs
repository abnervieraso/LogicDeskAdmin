using LogicDeskAdmin.Forms.Utils;
using LogicDeskAdmin.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.Remote
{
    public class Request
    {
        static async Task<DataWrapper<T>?> Send<T>(RestRequest request)
        {
            FormUtils.MainForm!.Validate();
            //request.AddHeader("Authorization", Storage.Token!);
            return (await Connection.Execute<T>(request)!)?.RData;

        }

        public static async Task<DataWrapper<T>?> Get<T>(string resource, Dictionary<string, object>? _params = null)
        {
            var request = new RestRequest(resource);

            if (_params != null)
                foreach (KeyValuePair<string, object> parameter in _params)
                    request.AddParameter(parameter.Key, (string)parameter.Value);
            return await Send<T>(request);
        }

        public static async Task<DataWrapper<T>?> Delete<T>(string resource, object? ids = null)
        {
            var request = new RestRequest(resource) { Method = Method.Delete };
            if (ids is not null)
                request.AddJsonBody(new { Ids = ids });
            return await Send<T>(request);
        }

        public static async Task<DataWrapper<T>?> PostOrPut<T>(string resource, object data, bool put = false) 
        {
            var request = new RestRequest(resource) { Method = put ? Method.Put : Method.Post };
            request.AddJsonBody(data);
            return await Send<T>(request);
        }


    }
}
