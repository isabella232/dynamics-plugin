﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using createsend_dotnet;

namespace Campmon.Dynamics.Plugins.Operations
{
    public class GetClientList : IOperation
    {
        ConfigurationService _cmService { get; set; }
        public GetClientList(ConfigurationService cmService)
        {
            _cmService = cmService;
        }

        public string Execute(string clientId)
        {
            var auth = new ApiKeyAuthenticationDetails(_cmService.GetAccessToken());
            var client = new Client(auth, clientId);
            return JsonConvert.SerializeObject(client.Lists());
        }
    }
}
