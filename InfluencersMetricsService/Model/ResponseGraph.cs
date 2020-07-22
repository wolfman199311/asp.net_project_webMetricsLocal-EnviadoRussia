﻿namespace InfluencersMetricsService.Model
{
    public class ResponseGraph
    {
        
        public Error error { get; set; }
    }

    public class Error
    {
        public string message { get; set; }
        public string type { get; set; }
        public int code { get; set; }
        public string fbtrace_id { get; set; }
    }
}