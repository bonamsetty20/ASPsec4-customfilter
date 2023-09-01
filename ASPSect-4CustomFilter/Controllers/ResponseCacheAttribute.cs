using System;

namespace ASPSect_4CustomFilter.Controllers
{
    internal class ResponseCacheAttribute : Attribute
    {
        public int Duration { get; set; }
        public object Location { get; set; }
    }
}