using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Datasource
{
    static class ObjectHelper
    {
        public static void Dump(this object data)
        {
            Trace.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));
        }
    }
}
