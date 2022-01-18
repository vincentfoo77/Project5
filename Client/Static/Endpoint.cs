using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project5.Client.Static
{
    public static class Endpoint
    {
        private static readonly string prefix = "api";
        public static readonly string EventsEndpoints = $"{prefix}/Events";
        public static readonly string Event_detailEndpoints = $"{prefix}/Event_detail";
        public static readonly string CategoryEndpoints = $"{prefix}/Category";
        public static readonly string RegistrationEndpoints = $"{prefix}/Regisration";
    }
}
