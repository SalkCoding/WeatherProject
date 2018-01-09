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
    class LifeIndexSearch : AppKey
    {

        private Double Latitude;//위도
        private Double Longitude;//경도
        private JObject LastSearch;//마지막 검색

        public LifeIndexSearch(Double lat, Double lon)
        {
            Latitude = lat;
            Longitude = lon;
        }

        public Double GetLongitude => Longitude;

        public Double GetLatitude => Latitude;

        public JObject GetLastSearch => LastSearch;

        //코드 수정및 주석 달아야함
        public JObject GetCarWashIndex()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/windex/carwash?version=1&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["summary"][0];
            }
        }

        public JObject GetUVIndex()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/windex/uvindex?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["summary"][0];
            }
        }

        public JObject GetLaundryIndex()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/windex/laundry?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["summary"][0];
            }
        }

        public JObject GetFineDustIndex()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/dust?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["summary"][0];
            }
        }

        public JObject GetWindChillTemperatureIndex()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/windex/wctindex?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["summary"][0];
            }
        }

        public JObject GetHeatIndex()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/windex/heatindex?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["summary"][0];
            }
        }

        public JObject GetTemperatureHumidityIndex()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/windex/thindex?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["summary"][0];
            }
        }

        public JObject GetDermatopathyIndex()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/windex/sdindex?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["summary"][0];
            }
        }

        public JObject GetPollenIndex()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/windex/paindex?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["summary"][0];
            }
        }

    }
}
