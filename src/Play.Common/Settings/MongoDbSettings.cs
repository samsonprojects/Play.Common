using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Play.Common.Service.Settings
{
    public class MongoDbSettings
    {
        private string connectionString;
        public string Host { get; set; }
        public int Port { get; set; }

        public string ConnectionString
        {
            get
            {
                return string.IsNullOrWhiteSpace(connectionString)
                    ? $"mongodb://{Host}:{Port}" : connectionString;
            }
            init { connectionString = value; }
        }

    }
}