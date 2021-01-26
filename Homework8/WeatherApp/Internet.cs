using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Internet
    {
        public WebClient webClient { get; }
        private Internet()
        {
            webClient = new WebClient() { Encoding = Encoding.UTF8 };
        }
        public static Internet cl = new Internet();
    }
}
