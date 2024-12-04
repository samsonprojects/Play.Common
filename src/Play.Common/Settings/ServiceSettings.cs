using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Play.Common.Service.Settings
{
    public class ServiceSettings
    {
        public string ServiceName { get; init; }
        public string Authority { get; init; }
        public string MessageBroker { get; set; }
    }
}