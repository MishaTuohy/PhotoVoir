using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace IdentityManagement.Utilities
{
    public class Utils
    {
        private static readonly IConfiguration configuration;
        public static String ConnectionString()
        {
            return configuration.GetConnectionString("Default");
        }
    }
}
