using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.SKTPlanetAPI
{
    public class AppKey
    {

        private static readonly String Weatherkey = "";
        private static readonly String MapKey = "";

        public static String GetWeatherAppkey => Weatherkey;

        public static String GetMapAppkey => MapKey;

    }
}
