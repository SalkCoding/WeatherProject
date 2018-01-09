using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Windows.Forms;

namespace Weather.SKTPlanetAPI
{
    class WeatherSearch : AppKey
    {

        private Double Latitude;//위도
        private Double Longitude;//경도
        private JObject LastSearch;//마지막 검색

        public WeatherSearch(Double lat,Double lon)
        {
            Latitude = lat;
            Longitude = lon;
        }

        public Double GetLongitude => Longitude;

        public Double GetLatitude => Latitude;

        public JObject GetLastSearch => LastSearch;

        /// <summary>
        /// 간편 날씨
        /// </summary>
        /// 어제날씨와 더불어 오늘/내일/모레날씨 정보를 간략하게 제공한다.
        /// 어제날씨는 하늘상태/최고,최저기온/일누적 강수량 정보를 제공하고 
        /// 오늘/내일/모레날씨는 하늘상태/최고,최저기온 정보를 제공한다.
        public JObject GetSummaryWeather()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/summary?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["summary"][0];
            }
        }

        /// <summary>
        /// 현재날씨(분별)
        /// </summary>
        /// 기상청 자동기상관측장비(AWS: Automatic Weather Station)로부터 수집한
        /// 기상관측 정보를 분석.가공하여 1분 단위로 현재날씨 정보를 제공한다
        public JObject GetCurrent1MinutelyWeather()
        {
            using(WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/current/minutely?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["minutely"][0];
            }
        }

        /// <summary>
        /// 현재날씨(시간별)
        /// </summary>
        /// 수집된 기상관측 정보를 격자단위로 분석.처리하여 1시간 단위로 현재날씨 정보를 제공한다.
        public JObject GetCurrent1HourlyWeather()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/current/hourly?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["hourly"][0];
            }
        }

        /// <summary>
        /// 초단기예보
        /// </summary>
        /// 1시간 간격으로 매일 24회, 5Km 격자 단위로 3시간까지의 초단기예보 정보를 제공한다.
        public JObject GetForecast3HourlyWeather()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/forecast/3hours?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["forecast3hours"][0];
            }
        }

        /// <summary>
        /// 단기예보
        /// </summary>
        /// 3시간 간격으로 매일 8회(2, 5, 8, 11, 14, 17, 20, 23시), 5Km 격자 단위로 단기예보 정보를 제공하며,
        /// 예보시간은 발표시간+4시간부터 최대 67시간(3일)까지 제공한다.
        public JObject GetForecast3DaysWeather()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/forecast/3days?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["forecast3days"][0];
            }
        }

        /// <summary>
        /// 중기예보
        /// </summary>
        /// 12시간 간격으로 매일 2회(6시, 18시), 주요 시도 단위로 중기예보 정보를 제공하며,
        /// 예보시간은 일단위로 +3일부터 +10일까지 제공한다.(+2일 예보는 ’14년 6월까지만 제공)
        public JObject GetForecast6DaysWeather()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/forecast/6days?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["forecast6days"][0];
            }
        }

        /// <summary>
        /// 기상특보
        /// </summary>
        /// 강풍, 호우, 한파, 건조, 해일, 풍랑, 태풍, 대설, 황사, 폭염 등의 특보 발생시에 200여개의 특보구역에 대해 기상특보를 제공한다.
        /// 또한, 동일 특보구역에 복수개의 기상특보가 존재할 경우에는 발생한 특보의 개수만큼을 응답한다.
        public JObject GetSevereAlertWeather()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/severe/alert?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["alert"][0];
            }
        }

        /// <summary>
        /// 태풍정보
        /// </summary>
        /// 태풍의 현 위치 및 예상위치를 지도상에 표시할 수 있도록 태풍예보에 대한 상세 정보를 제공한다. 
        /// 복수개의 태풍이 존재할 경우에는 발생한 태풍의 개수만큼을 응답한다.
        public JObject GetSevereStormWeather()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/severe/storm?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["storm"][0];
            }
        }

        /// <summary>
        /// 낙뢰정보
        /// </summary>
        /// 낙뢰 지점을 지도상에 표시할 수 있도록 10분 주기로 수집되는 낙뢰 상세 정보를 제공한다.
        /// 복수개의 낙뢰가 존재할 경우에는 발생한 낙뢰의 개수만큼을 응답한다.
        public JObject GetSevereLightningWeather()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                JObject Job = JObject.Parse(web.DownloadString(@"http://apis.skplanetx.com/weather/severe/lightning?version=1&lat=" + Latitude + "&lon=" + Longitude + "&appKey=" + GetWeatherAppkey));
                LastSearch = (JObject)Job.DeepClone();
                if (Convert.ToInt32(Job["result"]["code"]) != 9200)
                {
                    MessageBox.Show(null, Job["result"]["message"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return (JObject)Job["weather"]["lightning"][0];
            }
        }

    }
}
