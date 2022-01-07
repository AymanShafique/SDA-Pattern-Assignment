using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Models
{
    public static class Singleton
    {
        public static Factory Instance { get; } = new Factory();
        public static Factory getInstance()
        {
            return Instance;
        }

    }
}
