using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Photoshop.Common
{
    public class MainConfiguration : BaseConfiguration
    {
        public static string DatabaseConnection {get; private set;}

        static MainConfiguration()
        {
            DatabaseConnection = ReadConnectionString("Mongo");
        }
    }
}
