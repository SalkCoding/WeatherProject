using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather.SKTPlanetAPI
{
    class GlobalWeatherSearch : AppKey
    {

        private Double Latitude;//위도
        private Double Longitude;//경도
        private JObject LastSearch;//마지막 검색

        public GlobalWeatherSearch(Double lat, Double lon)
        {
            Latitude = lat;
            Longitude = lon;
        }

        public Double GetLongitude => Longitude;

        public Double GetLatitude => Latitude;

        public JObject GetLastSearch => LastSearch;

        /// <summary>
        /// 현재날씨(분별)
        /// </summary>
        /// 기상청 자동기상관측장비(AWS: Automatic Weather Station)로부터 수집한
        /// 기상관측 정보를 분석.가공하여 1분 단위로 현재날씨 정보를 제공한다
        public JObject GetCurrentWeather()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/gweather/current?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["gweather"]["current"][0];
            }
        }

        public JObject GetShortWeather()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/gweather/short?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["gweather"]["forecastDays"][0];
            }
        }

        public JObject GetMiddleWeather()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/gweather/mid?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["gweather"]["forecastDays"][0];
            }
        }

    }
}
