using Newtonsoft.Json.Serialization;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LogicDeskAdmin.Models;

namespace LogicDeskAdmin.Remote
{
    public class Remote : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        static readonly RestClient _client;
        static readonly Uri _serverHost;
        static bool _isBusy;

        public bool IsBusy 
        {
            get => _isBusy;
            private set
            {
                if (value != _isBusy)
                {
                    _isBusy = value;
                    OnPropertyChanged();
                }
            }
        }

        public static Remote Instance { get; }

        static Remote()
        {
            Instance = new();
            _serverHost = new Uri("http://127.0.0.1:80");
            _client = new RestClient(_serverHost);
            _client.UseNewtonsoftJson(new Newtonsoft.Json.JsonSerializerSettings()
            {
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Local,
                ContractResolver = new DefaultContractResolver() { NamingStrategy = new SnakeCaseNamingStrategy() }

            });
        }


        public static async Task<ResponseWrapper<T?>?>? Execute<T>(RestRequest request)
        {
            if (_isBusy)
                return default;
            Instance.IsBusy = true;
            var response = await _client.ExecuteAsync<ResponseWrapper<T?>?>(request);
            Instance.IsBusy = false;

            return response.Data;
        }
    }
}
