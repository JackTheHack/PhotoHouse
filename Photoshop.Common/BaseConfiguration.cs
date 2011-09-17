using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Photoshop.Common
{
    public class BaseConfiguration
    {
        protected static string ReadString(string propertyName)
        {
            return ConfigurationManager.AppSettings[propertyName];
        }

        protected static string ReadConnectionString(string propertyName)
        {
            return ConfigurationManager.ConnectionStrings[propertyName].ConnectionString;
        }
    }
}
