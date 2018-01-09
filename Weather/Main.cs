using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GChartLib;
using MaterialSkin.Controls;
using Weather.SearchForm;
using Weather.SKTPlanetAPI;
using Weather.Untill;

namespace Weather
{
    public partial class MainForm : MaterialForm
    {

        private static LocationIndex RecentLoc;

        private static LocationSearchForm Dlg;

        public static LocationSearchForm SettingDlg
        {
            set
            {
                Dlg = value;
            }
        }

        public static LocationIndex SettingLocationIndex
        {
            set
            {
                RecentLoc = value;
            }
            get
            {
                return RecentLoc;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            RefreshTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            LocationSetTip.SetToolTip(this.LocationSetButton, "지역 검색 설정");
            RefreshTip.SetToolTip(this.RefreshButton, "새로고침");
            RefreshButton.Font = new Font("Wingdings 3", 20, FontStyle.Bold);
            RefreshButton.Text = Char.ConvertFromUtf32(81); // or 80
            //초기화
        }

        private void LocationSetButton_Click(object sender, EventArgs e)
        {
            if (Dlg != null)
            {
                Dlg.Focus();
                return;
            }
            Point location = new Point();
            LocationSearchForm form = new LocationSearchForm();
            form.Refresh += new LocationSearchForm.RefreshEvent(RefreshWeatherInfo);
            location.X = base.Location.X + base.Size.Width + 10;
            location.Y = base.Location.Y;
            form.Location = location;
            form.Show();
            Dlg = form;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (RecentLoc == null)
                return;
            RefreshWeatherInfo(RecentLoc.GetLatitude.Value, RecentLoc.GetLongitude.Value);
        }


        private void RefreshWeatherInfo(Double lat, Double lon)//적용시 이벤트 처리
        {
            RefreshTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            WeatherSearch Searcher = new WeatherSearch(lat, lon);
            //간편 날씨
            PrintSummaryWeather(Searcher);
            //현재 날씨 (분별)
            PrintCurrent1MinutelyWeather(Searcher);
            //초단기 예보
            PrintForecast3HourlyWeather(Searcher);
            //단기 예보
            PrintForecast3DaysWeather(Searcher);
            //중기 예보
            PrintForecast6DaysWeather(Searcher);
            //기상 특보
            PrintSevereAlertWeather(Searcher);
            //태풍 정보
            //PrintSevereStormWeather(Searcher);
            //낙뢰 정보
            //PrintSevereLightningWeather(Searcher);
        }

        #region 정보 출력 노가다 요약

        /// <summary>
        /// 간편 날씨
        /// </summary>
        /// 어제날씨와 더불어 오늘/내일/모레날씨 정보를 간략하게 제공한다.
        /// 어제날씨는 하늘상태/최고,최저기온/일누적 강수량 정보를 제공하고 
        /// 오늘/내일/모레날씨는 하늘상태/최고,최저기온 정보를 제공한다.
        private void PrintSummaryWeather(WeatherSearch Searcher)
        {
            TemperatureGraph1.Clear();
            TemperatureGraph2.Clear();
            TemperatureGraph3.Clear();
            TemperatureGraph4.Clear();
            
            var Summary = Searcher.GetSummaryWeather();

            String time = Summary["timeRelease"].ToString();
            ReleaseTime.Text = RecentLoc.GetAddress + " " + time;

            var temper = Summary["today"]["temperature"];
            var tmin = (float)Convert.ToDouble(temper["tmin"]);
            var tmax = (float)Convert.ToDouble(temper["tmax"]);
            var skyCode = Summary["today"]["sky"];
            Int32 hour = Convert.ToInt32(time.Split(' ')[1].Split(':')[0]);

            //오늘
            TemperatureGraph1.AddValue(tmin);
            TemperatureGraph1.AddValue(tmax);

            TodayTmax.Text = tmax.ToString() + "℃";
            TodayTmin.Text = tmin.ToString() + "℃";
            TemperatureGraph2.AddValue(tmin);
            TemperatureGraph2.AddValue(tmax);
            WeatherIcon1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code"].ToString()));
            WeatherExplain1.Text = skyCode["name"].ToString();

            temper = Summary["tomorrow"]["temperature"];//내일
            skyCode = Summary["tomorrow"]["sky"];
            tmin = (float)Convert.ToDouble(temper["tmin"]);
            tmax = (float)Convert.ToDouble(temper["tmax"]);
            TemperatureGraph1.AddValue(tmin);
            TemperatureGraph1.AddValue(tmax);

            TomorrowTmax.Text = tmax.ToString() + "℃";
            TomorrowTmin.Text = tmin.ToString() + "℃";
            TemperatureGraph3.AddValue(tmin);
            TemperatureGraph3.AddValue(tmax);
            WeatherIcon2.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code"].ToString()));
            WeatherExplain2.Text = skyCode["name"].ToString();

            temper = Summary["dayAfterTomorrow"]["temperature"];//모레
            skyCode = Summary["dayAfterTomorrow"]["sky"];
            tmin = (float)Convert.ToDouble(temper["tmin"]);
            tmax = (float)Convert.ToDouble(temper["tmax"]);
            TemperatureGraph1.AddValue(tmin);
            TemperatureGraph1.AddValue(tmax);

            AfterTomorrowTmax.Text = tmax.ToString() + "℃";
            AfterTomorrowTmin.Text = tmin.ToString() + "℃";
            TemperatureGraph4.AddValue(tmin);
            TemperatureGraph4.AddValue(tmax);
            WeatherIcon3.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code"].ToString()));
            WeatherExplain3.Text = skyCode["name"].ToString();

        }

        /// <summary>
        /// 현재날씨(분별)
        /// </summary>
        /// 기상청 자동기상관측장비(AWS: Automatic Weather Station)로부터 수집한
        /// 기상관측 정보를 분석.가공하여 1분 단위로 현재날씨 정보를 제공한다
        private void PrintCurrent1MinutelyWeather(WeatherSearch Searcher)
        {
            CurrentTemperatureGraph.Clear();
            CurrentRainGraph.Clear();

            var Current = Searcher.GetCurrent1MinutelyWeather();

            String time = Current["timeObservation"].ToString();
            ReleaseTime1.Text = RecentLoc.GetAddress + " " + time;

            var temper = Current["temperature"];
            var tmin = (float)Convert.ToDouble(temper["tmin"]);
            var tcurrent = (float)Convert.ToDouble(temper["tc"]);
            var tmax = (float)Convert.ToDouble(temper["tmax"]);
            var skyCode = Current["sky"];
            Int32 hour = Convert.ToInt32(time.Split(' ')[1].Split(':')[0]);

            //오늘
            CurrentTemperatureGraph.AddValue(tmin);
            CurrentTemperatureGraph.AddValue(tcurrent);
            CurrentTemperatureGraph.AddValue(tmax);
            CurrentTMax.Text = tmax.ToString() + "℃";
            CurrentTCurrent.Text = tcurrent.ToString() + "℃";
            CurrentTmin.Text = tmin.ToString() + "℃";
            CurrentWeatherIcon.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code"].ToString()));
            CurrentWeatherExplain.Text = skyCode["name"].ToString();

            var rain = Current["rain"];
            float[] last = new float[] {
                (float)Convert.ToDouble(rain["last10min"]) ,
                (float)Convert.ToDouble(rain["last15min"]) ,
                (float)Convert.ToDouble(rain["last30min"]) ,
                (float)Convert.ToDouble(rain["last1hour"]) ,
                (float)Convert.ToDouble(rain["last6hour"]) ,
                (float)Convert.ToDouble(rain["last12hour"]) ,
                (float)Convert.ToDouble(rain["last24hour"]) ,
            };
            float sinceOntime = (float)Convert.ToDouble(rain["sinceOntime"]);
            CurrentRainGraph.AddValues(last);
            last10min.Text = last[0].ToString();
            last15min.Text = last[1].ToString();
            last30min.Text = last[2].ToString();
            last1hour.Text = last[3].ToString();
            last6hour.Text = last[4].ToString();
            last12hour.Text = last[5].ToString();
            last24hour.Text = last[6].ToString();
            try
            {
                CurrentHumidityPercent.Value = (Int32)Convert.ToDouble(Current["humidity"]);
                CurrentHumidity.Text = Current["humidity"].ToString() + "%";
            }
            catch
            {
                CurrentHumidityPercent.Value = 0;
                CurrentHumidity.Text = "정보 없음";
            }
        }

        /// <summary>
        /// 초단기예보
        /// </summary>
        /// 1시간 간격으로 매일 24회, 5Km 격자 단위로 3시간까지의 초단기예보 정보를 제공한다.
        private void PrintForecast3HourlyWeather(WeatherSearch Searcher)
        {
            HourTemperatureGraph.Clear();

            var Forecast = Searcher.GetForecast3HourlyWeather();

            String time = Forecast["timeRelease"].ToString();
            ReleaseTime2.Text = RecentLoc.GetAddress + " " + time;
            Int32 hour = Convert.ToInt32(time.Split(' ')[1].Split(':')[0]);

            var skyCode = Forecast["sky"];

            if (!String.IsNullOrWhiteSpace(skyCode["name1hour"].ToString()))
            {
                OneHourWeatherExplain.Text = skyCode["name1hour"].ToString();
                OneHourWeatherIcon.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code1hour"].ToString()));
            }
            else
            {
                OneHourWeatherExplain.Text = "정보 없음";
                OneHourWeatherIcon.Image = (Bitmap)Properties.Resources._38;
            }
            if (!String.IsNullOrWhiteSpace(skyCode["name2hour"].ToString()))
            {
                TwoHourWeatherExplain.Text = skyCode["name2hour"].ToString();
                TwoHourWeatherIcon.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code2hour"].ToString()));
            }
            else
            {
                TwoHourWeatherExplain.Text = "정보 없음";
                TwoHourWeatherIcon.Image = (Bitmap)Properties.Resources._38;
            }
            if (!String.IsNullOrWhiteSpace(skyCode["name3hour"].ToString()))
            {
                ThreeHourWeatherExplain.Text = skyCode["name3hour"].ToString();
                ThreeHourWeatherIcon.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code3hour"].ToString()));
            }
            else
            {
                ThreeHourWeatherExplain.Text = "정보 없음";
                ThreeHourWeatherIcon.Image = (Bitmap)Properties.Resources._38;
            }
            if (!String.IsNullOrWhiteSpace(skyCode["name4hour"].ToString()))
            {
                FourHourWeatherExplain.Text = skyCode["name4hour"].ToString();
                FourHourWeatherIcon.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code4hour"].ToString()));
            }
            else
            {
                FourHourWeatherExplain.Text = "정보 없음";
                FourHourWeatherIcon.Image = (Bitmap)Properties.Resources._38;
            }

            var temperature = Forecast["temperature"];
            float[] templist = new float[4];
            if (!String.IsNullOrWhiteSpace(temperature["temp1hour"].ToString()))
                templist[0] = (float)Convert.ToDouble(temperature["temp1hour"]);
            if (!String.IsNullOrWhiteSpace(temperature["temp2hour"].ToString()))
                templist[1] = (float)Convert.ToDouble(temperature["temp2hour"]);
            if (!String.IsNullOrWhiteSpace(temperature["temp3hour"].ToString()))
                templist[2] = (float)Convert.ToDouble(temperature["temp3hour"]);
            if (!String.IsNullOrWhiteSpace(temperature["temp4hour"].ToString()))
                templist[3] = (float)Convert.ToDouble(temperature["temp4hour"]);

            foreach(float temper in templist)
            {
                if (temper == 0)
                    continue;
                else
                    HourTemperatureGraph.AddValue(temper);
            }

            if (templist[0] ==0)
                OneHourTemperature.Text = "정보 없음";
            else
                OneHourTemperature.Text = templist[0].ToString() + "℃";
            if (templist[1] == 0)
                TwoHourTemperature.Text = "정보 없음";
            else
                TwoHourTemperature.Text = templist[1].ToString() + "℃";
            if (templist[2] == 0)
                ThreeHourTemperature.Text = "정보 없음";
            else
                ThreeHourTemperature.Text = templist[2].ToString() + "℃";
            if (templist[3] == 0)
                FourHourTemperature.Text = "정보 없음";
            else
                FourHourTemperature.Text = templist[3].ToString() + "℃";

            var humidity = Forecast["humidity"];

            var humi = humidity["rh1hour"].ToString();
            if (String.IsNullOrWhiteSpace(humi))
            {
                OneHourHumidity.Text = "정보 없음";
                OneHourHumidityPercent.Value = 0;
            }
            else
            {
                OneHourHumidity.Text = humidity["rh1hour"].ToString() + "%";
                OneHourHumidityPercent.Value = (Int32)Convert.ToDouble(humidity["rh1hour"]);
            }
            humi = humidity["rh2hour"].ToString();
            if (String.IsNullOrWhiteSpace(humi))
            {
                TwoHourHumidity.Text = "정보 없음";
                TwoHourHumidityPercent.Value = 0;
            }
            else
            {
                TwoHourHumidity.Text = humidity["rh2hour"].ToString() + "%";
                TwoHourHumidityPercent.Value = (Int32)Convert.ToDouble(humidity["rh2hour"]);
            }
            humi = humidity["rh3hour"].ToString();
            if (String.IsNullOrWhiteSpace(humi))
            {
                ThreeHourHumidity.Text = "정보 없음";
                ThreeHourHumidityPercent.Value = 0;
            }
            else
            {
                ThreeHourHumidity.Text = humidity["rh3hour"].ToString() + "%";
                ThreeHourHumidityPercent.Value = (Int32)Convert.ToDouble(humidity["rh3hour"]);
            }
            humi = humidity["rh4hour"].ToString();
            if (String.IsNullOrWhiteSpace(humi))
            {
                FourHourHumidity.Text = "정보 없음";
                FourHourHumidityPercent.Value = 0;
            }
            else
            {
                FourHourHumidity.Text = humidity["rh4hour"].ToString() + "%";
                FourHourHumidityPercent.Value = (Int32)Convert.ToDouble(humidity["rh4hour"]);
            }
        }

        /// <summary>
        /// 단기예보
        /// </summary>
        /// 3시간 간격으로 매일 8회(2, 5, 8, 11, 14, 17, 20, 23시), 5Km 격자 단위로 단기예보 정보를 제공하며,
        /// 예보시간은 발표시간+4시간부터 최대 67시간(3일)까지 제공한다.
        private void PrintForecast3DaysWeather(WeatherSearch Searcher)
        {
            ShortTGraph.Clear();
            ShortTemperatureGraph.Clear();
            ShortHumidityGraph.Clear();

            var Forecast = Searcher.GetForecast3DaysWeather();

            String time = Forecast["timeRelease"].ToString();
            ReleaseTime3.Text = RecentLoc.GetAddress + " " + time;
            Int32 hour = Convert.ToInt32(time.Split(' ')[1].Split(':')[0]);

            var skyCode = Forecast["fcst3hour"]["sky"];
            var temperature = Forecast["fcst3hour"]["temperature"];
            var humidity = Forecast["fcst3hour"]["humidity"];

            if (!String.IsNullOrWhiteSpace(skyCode["name4hour"].ToString()))
            {
                ShortWeatherExplain1.Text = skyCode["name4hour"].ToString();
                ShortWeatherIcon1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code4hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain1.Text = "정보 없음";
                ShortWeatherIcon1.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name7hour"].ToString()))
            {
                ShortWeatherExplain2.Text = skyCode["name7hour"].ToString();
                ShortWeatherIcon2.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code7hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain2.Text = "정보 없음";
                ShortWeatherIcon2.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name10hour"].ToString()))
            {
                ShortWeatherExplain3.Text = skyCode["name10hour"].ToString();
                ShortWeatherIcon3.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code10hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain3.Text = "정보 없음";
                ShortWeatherIcon3.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name13hour"].ToString()))
            {
                ShortWeatherExplain4.Text = skyCode["name13hour"].ToString();
                ShortWeatherIcon4.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code13hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain4.Text = "정보 없음";
                ShortWeatherIcon4.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name16hour"].ToString()))
            {
                ShortWeatherExplain5.Text = skyCode["name16hour"].ToString();
                ShortWeatherIcon5.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code16hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain5.Text = "정보 없음";
                ShortWeatherIcon5.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name19hour"].ToString()))
            {
                ShortWeatherExplain6.Text = skyCode["name19hour"].ToString();
                ShortWeatherIcon6.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code19hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain6.Text = "정보 없음";
                ShortWeatherIcon6.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name22hour"].ToString()))
            {
                ShortWeatherExplain7.Text = skyCode["name22hour"].ToString();
                ShortWeatherIcon7.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code22hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain7.Text = "정보 없음";
                ShortWeatherIcon7.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name25hour"].ToString()))
            {
                ShortWeatherExplain8.Text = skyCode["name25hour"].ToString();
                ShortWeatherIcon8.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code25hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain8.Text = "정보 없음";
                ShortWeatherIcon8.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name28hour"].ToString()))
            {
                ShortWeatherExplain9.Text = skyCode["name28hour"].ToString();
                ShortWeatherIcon9.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code28hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain9.Text = "정보 없음";
                ShortWeatherIcon9.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name31hour"].ToString()))
            {
                ShortWeatherExplain10.Text = skyCode["name31hour"].ToString();
                ShortWeatherIcon10.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code31hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain1.Text = "정보 없음";
                ShortWeatherIcon1.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name34hour"].ToString()))
            {
                ShortWeatherExplain11.Text = skyCode["name34hour"].ToString();
                ShortWeatherIcon11.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code34hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain11.Text = "정보 없음";
                ShortWeatherIcon11.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name37hour"].ToString()))
            {
                ShortWeatherExplain12.Text = skyCode["name37hour"].ToString();
                ShortWeatherIcon12.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code37hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain12.Text = "정보 없음";
                ShortWeatherIcon12.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name40hour"].ToString()))
            {
                ShortWeatherExplain13.Text = skyCode["name40hour"].ToString();
                ShortWeatherIcon13.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code40hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain13.Text = "정보 없음";
                ShortWeatherIcon13.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name43hour"].ToString()))
            {
                ShortWeatherExplain14.Text = skyCode["name43hour"].ToString();
                ShortWeatherIcon14.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code43hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain14.Text = "정보 없음";
                ShortWeatherIcon14.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name46hour"].ToString()))
            {
                ShortWeatherExplain15.Text = skyCode["name46hour"].ToString();
                ShortWeatherIcon15.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code46hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain15.Text = "정보 없음";
                ShortWeatherIcon15.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name49hour"].ToString()))
            {
                ShortWeatherExplain16.Text = skyCode["name49hour"].ToString();
                ShortWeatherIcon16.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code49hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain16.Text = "정보 없음";
                ShortWeatherIcon16.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name52hour"].ToString()))
            {
                ShortWeatherExplain17.Text = skyCode["name52hour"].ToString();
                ShortWeatherIcon17.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code52hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain17.Text = "정보 없음";
                ShortWeatherIcon17.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name55hour"].ToString()))
            {
                ShortWeatherExplain18.Text = skyCode["name55hour"].ToString();
                ShortWeatherIcon18.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code55hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain18.Text = "정보 없음";
                ShortWeatherIcon18.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name58hour"].ToString()))
            {
                ShortWeatherExplain19.Text = skyCode["name58hour"].ToString();
                ShortWeatherIcon19.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code58hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain19.Text = "정보 없음";
                ShortWeatherIcon19.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name61hour"].ToString()))
            {
                ShortWeatherExplain20.Text = skyCode["name61hour"].ToString();
                ShortWeatherIcon20.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code61hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain20.Text = "정보 없음";
                ShortWeatherIcon20.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name64hour"].ToString()))
            {
                ShortWeatherExplain21.Text = skyCode["name64hour"].ToString();
                ShortWeatherIcon21.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code64hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain21.Text = "정보 없음";
                ShortWeatherIcon21.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["name67hour"].ToString()))
            {
                ShortWeatherExplain22.Text = skyCode["name67hour"].ToString();
                ShortWeatherIcon22.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(hour, skyCode["code67hour"].ToString()));
            }
            else
            {
                ShortWeatherExplain22.Text = "정보 없음";
                ShortWeatherIcon22.Image = (Bitmap)Properties.Resources._38;
            }

            float?[] templist = new float?[22];

            if (!String.IsNullOrWhiteSpace(temperature["temp4hour"].ToString()))
            {
                ShortTemperature1.Text = temperature["temp4hour"].ToString() + "℃";
                templist[0] = (float)Convert.ToDouble(temperature["temp4hour"].ToString());
            }
            else
            {
                ShortTemperature1.Text = "정보 없음";
                templist[0] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp7hour"].ToString()))
            {
                ShortTemperature2.Text = temperature["temp7hour"].ToString() + "℃";
                templist[1] = (float)Convert.ToDouble(temperature["temp7hour"].ToString());
            }
            else
            {
                ShortTemperature2.Text = "정보 없음";
                templist[1] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp10hour"].ToString()))
            {
                ShortTemperature3.Text = temperature["temp10hour"].ToString() + "℃";
                templist[2] = (float)Convert.ToDouble(temperature["temp10hour"].ToString());
            }
            else
            {
                ShortTemperature3.Text = "정보 없음";
                templist[2] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp13hour"].ToString()))
            {
                ShortTemperature4.Text = temperature["temp13hour"].ToString() + "℃";
                templist[3] = (float)Convert.ToDouble(temperature["temp13hour"].ToString());
            }
            else
            {
                ShortTemperature4.Text = "정보 없음";
                templist[3] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp16hour"].ToString()))
            {
                ShortTemperature5.Text = temperature["temp16hour"].ToString() + "℃";
                templist[4] = (float)Convert.ToDouble(temperature["temp16hour"].ToString());
            }
            else
            {
                ShortTemperature5.Text = "정보 없음";
                templist[4] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp19hour"].ToString()))
            {
                ShortTemperature6.Text = temperature["temp19hour"].ToString() + "℃";
                templist[5] = (float)Convert.ToDouble(temperature["temp19hour"].ToString());
            }
            else
            {
                ShortTemperature6.Text = "정보 없음";
                templist[5] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp22hour"].ToString()))
            {
                ShortTemperature7.Text = temperature["temp22hour"].ToString() + "℃";
                templist[6] = (float)Convert.ToDouble(temperature["temp22hour"].ToString());
            }
            else
            {
                ShortTemperature7.Text = "정보 없음";
                templist[6] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp25hour"].ToString()))
            {
                ShortTemperature8.Text = temperature["temp25hour"].ToString() + "℃";
                templist[7] = (float)Convert.ToDouble(temperature["temp25hour"].ToString());
            }
            else
            {
                ShortTemperature8.Text = "정보 없음";
                templist[7] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp28hour"].ToString()))
            {
                ShortTemperature9.Text = temperature["temp28hour"].ToString() + "℃";
                templist[8] = (float)Convert.ToDouble(temperature["temp28hour"].ToString());
            }
            else
            {
                ShortTemperature9.Text = "정보 없음";
                templist[8] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp31hour"].ToString()))
            {
                ShortTemperature10.Text = temperature["temp31hour"].ToString() + "℃";
                templist[9] = (float)Convert.ToDouble(temperature["temp31hour"].ToString());
            }
            else
            {
                ShortTemperature10.Text = "정보 없음";
                templist[9] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp34hour"].ToString()))
            {
                ShortTemperature11.Text = temperature["temp34hour"].ToString() + "℃";
                templist[10] = (float)Convert.ToDouble(temperature["temp34hour"].ToString());
            }
            else
            {
                ShortTemperature11.Text = "정보 없음";
                templist[10] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp37hour"].ToString()))
            {
                ShortTemperature12.Text = temperature["temp37hour"].ToString() + "℃";
                templist[11] = (float)Convert.ToDouble(temperature["temp37hour"].ToString());
            }
            else
            {
                ShortTemperature12.Text = "정보 없음";
                templist[11] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp40hour"].ToString()))
            {
                ShortTemperature13.Text = temperature["temp40hour"].ToString() + "℃";
                templist[12] = (float)Convert.ToDouble(temperature["temp40hour"].ToString());
            }
            else
            {
                ShortTemperature13.Text = "정보 없음";
                templist[12] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp43hour"].ToString()))
            {
                ShortTemperature14.Text = temperature["temp43hour"].ToString() + "℃";
                templist[13] = (float)Convert.ToDouble(temperature["temp43hour"].ToString());
            }
            else
            {
                ShortTemperature14.Text = "정보 없음";
                templist[13] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp46hour"].ToString()))
            {
                ShortTemperature15.Text = temperature["temp46hour"].ToString() + "℃";
                templist[14] = (float)Convert.ToDouble(temperature["temp46hour"].ToString());
            }
            else
            {
                ShortTemperature15.Text = "정보 없음";
                templist[14] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp49hour"].ToString()))
            {
                ShortTemperature16.Text = temperature["temp49hour"].ToString() + "℃";
                templist[15] = (float)Convert.ToDouble(temperature["temp49hour"].ToString());
            }
            else
            {
                ShortTemperature16.Text = "정보 없음";
                templist[15] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp52hour"].ToString()))
            {
                ShortTemperature17.Text = temperature["temp52hour"].ToString() + "℃";
                templist[16] = (float)Convert.ToDouble(temperature["temp52hour"].ToString());
            }
            else
            {
                ShortTemperature17.Text = "정보 없음";
                templist[16] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp55hour"].ToString()))
            {
                ShortTemperature18.Text = temperature["temp55hour"].ToString() + "℃";
                templist[17] = (float)Convert.ToDouble(temperature["temp55hour"].ToString());
            }
            else
            {
                ShortTemperature18.Text = "정보 없음";
                templist[17] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp58hour"].ToString()))
            {
                ShortTemperature19.Text = temperature["temp58hour"].ToString() + "℃";
                templist[18] = (float)Convert.ToDouble(temperature["temp58hour"].ToString());
            }
            else
            {
                ShortTemperature19.Text = "정보 없음";
                templist[18] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp61hour"].ToString()))
            {
                ShortTemperature20.Text = temperature["temp61hour"].ToString() + "℃";
                templist[19] = (float)Convert.ToDouble(temperature["temp61hour"].ToString());
            }
            else
            {
                ShortTemperature20.Text = "정보 없음";
                templist[19] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp64hour"].ToString()))
            {
                ShortTemperature21.Text = temperature["temp64hour"].ToString() + "℃";
                templist[20] = (float)Convert.ToDouble(temperature["temp64hour"].ToString());
            }
            else
            {
                ShortTemperature21.Text = "정보 없음";
                templist[20] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["temp67hour"].ToString()))
            {
                ShortTemperature22.Text = temperature["temp67hour"].ToString() + "℃";
                templist[21] = (float)Convert.ToDouble(temperature["temp67hour"].ToString());
            }
            else
            {
                ShortTemperature22.Text = "정보 없음";
                templist[21] = null;
            }

            foreach(float? temper in templist)
            {
                if(temper.HasValue)
                {
                    ShortTemperatureGraph.AddValue(temper.Value);
                }
            }

            var daylist = Forecast["fcstdaily"]["temperature"];
            float?[] tdaylist = new float?[6];

            if (!String.IsNullOrWhiteSpace(daylist["tmin1day"].ToString()))
            {
                ShortTMin1.Text = daylist["tmin1day"].ToString() + "℃";
                tdaylist[0] = (float)Convert.ToDouble(daylist["tmin1day"].ToString());
            }
            else
            {
                ShortTMin1.Text = "정보 없음";
                tdaylist[0] = null;
            }

            if (!String.IsNullOrWhiteSpace(daylist["tmax1day"].ToString()))
            {
                ShortTMax1.Text = daylist["tmax1day"].ToString() + "℃";
                tdaylist[1] = (float)Convert.ToDouble(daylist["tmax1day"].ToString());
            }
            else
            {
                ShortTMax1.Text = "정보 없음";
                tdaylist[1] = null;
            }

            if (!String.IsNullOrWhiteSpace(daylist["tmin2day"].ToString()))
            {
                ShortTMin2.Text = daylist["tmin2day"].ToString() + "℃";
                tdaylist[2] = (float)Convert.ToDouble(daylist["tmin2day"].ToString());
            }
            else
            {
                ShortTMin2.Text = "정보 없음";
                tdaylist[2] = null;
            }

            if (!String.IsNullOrWhiteSpace(daylist["tmax2day"].ToString()))
            {
                ShortTMax2.Text = daylist["tmax2day"].ToString() + "℃";
                tdaylist[3] = (float)Convert.ToDouble(daylist["tmax2day"].ToString());
            }
            else
            {
                ShortTMax2.Text = "정보 없음";
                tdaylist[3] = null;
            }

            if (!String.IsNullOrWhiteSpace(daylist["tmin3day"].ToString()))
            {
                ShortTMin3.Text = daylist["tmin3day"].ToString() + "℃";
                tdaylist[4] = (float)Convert.ToDouble(daylist["tmin3day"].ToString());
            }
            else
            {
                ShortTMin3.Text = "정보 없음";
                tdaylist[4] = null;
            }

            if (!String.IsNullOrWhiteSpace(daylist["tmax3day"].ToString()))
            {
                ShortTMax3.Text = daylist["tmax3day"].ToString() + "℃";
                tdaylist[5] = (float)Convert.ToDouble(daylist["tmax3day"].ToString());
            }
            else
            {
                ShortTMax3.Text = "정보 없음";
                tdaylist[5] = null;
            }

            foreach(float? tday in tdaylist)
            {
                if (tday.HasValue)
                {
                    ShortTGraph.AddValue(tday.Value);
                }
            }

            var humi = Forecast["fcst3hour"]["humidity"];

            float?[] humiditylist = new float?[22];

            if (!String.IsNullOrWhiteSpace(humi["rh4hour"].ToString()))
            {
                ShortHumidity1.Text = humi["rh4hour"].ToString() + "%";
                humiditylist[0] = (float)Convert.ToDouble(humi["rh4hour"].ToString());
            }
            else
            {
                ShortHumidity1.Text = "정보 없음";
                humiditylist[0] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh7hour"].ToString()))
            {
                ShortHumidity2.Text = humi["rh7hour"].ToString() + "%";
                humiditylist[1] = (float)Convert.ToDouble(humi["rh7hour"].ToString());
            }
            else
            {
                ShortHumidity2.Text = "정보 없음";
                humiditylist[1] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh10hour"].ToString()))
            {
                ShortHumidity3.Text = humi["rh10hour"].ToString() + "%";
                humiditylist[2] = (float)Convert.ToDouble(humi["rh10hour"].ToString());
            }
            else
            {
                ShortHumidity3.Text = "정보 없음";
                humiditylist[2] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh13hour"].ToString()))
            {
                ShortHumidity4.Text = humi["rh13hour"].ToString() + "%";
                humiditylist[3] = (float)Convert.ToDouble(humi["rh13hour"].ToString());
            }
            else
            {
                ShortHumidity4.Text = "정보 없음";
                humiditylist[3] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh16hour"].ToString()))
            {
                ShortHumidity5.Text = humi["rh16hour"].ToString() + "%";
                humiditylist[4] = (float)Convert.ToDouble(humi["rh16hour"].ToString());
            }
            else
            {
                ShortHumidity5.Text = "정보 없음";
                humiditylist[4] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh19hour"].ToString()))
            {
                ShortHumidity6.Text = humi["rh19hour"].ToString() + "%";
                humiditylist[5] = (float)Convert.ToDouble(humi["rh19hour"].ToString());
            }
            else
            {
                ShortHumidity6.Text = "정보 없음";
                humiditylist[5] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh22hour"].ToString()))
            {
                ShortHumidity7.Text = humi["rh22hour"].ToString() + "%";
                humiditylist[6] = (float)Convert.ToDouble(humi["rh22hour"].ToString());
            }
            else
            {
                ShortHumidity7.Text = "정보 없음";
                humiditylist[6] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh25hour"].ToString()))
            {
                ShortHumidity8.Text = humi["rh25hour"].ToString() + "%";
                humiditylist[7] = (float)Convert.ToDouble(humi["rh25hour"].ToString());
            }
            else
            {
                ShortHumidity8.Text = "정보 없음";
                humiditylist[7] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh28hour"].ToString()))
            {
                ShortHumidity9.Text = humi["rh28hour"].ToString() + "%";
                humiditylist[8] = (float)Convert.ToDouble(humi["rh28hour"].ToString());
            }
            else
            {
                ShortHumidity9.Text = "정보 없음";
                humiditylist[8] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh31hour"].ToString()))
            {
                ShortHumidity10.Text = humi["rh31hour"].ToString() + "%";
                humiditylist[9] = (float)Convert.ToDouble(humi["rh31hour"].ToString());
            }
            else
            {
                ShortHumidity10.Text = "정보 없음";
                humiditylist[9] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh34hour"].ToString()))
            {
                ShortHumidity11.Text = humi["rh34hour"].ToString() + "%";
                humiditylist[10] = (float)Convert.ToDouble(humi["rh34hour"].ToString());
            }
            else
            {
                ShortHumidity11.Text = "정보 없음";
                humiditylist[10] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh37hour"].ToString()))
            {
                ShortHumidity12.Text = humi["rh37hour"].ToString() + "%";
                humiditylist[11] = (float)Convert.ToDouble(humi["rh37hour"].ToString());
            }
            else
            {
                ShortHumidity12.Text = "정보 없음";
                humiditylist[11] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh40hour"].ToString()))
            {
                ShortHumidity13.Text = humi["rh40hour"].ToString() + "%";
                humiditylist[12] = (float)Convert.ToDouble(humi["rh40hour"].ToString());
            }
            else
            {
                ShortHumidity13.Text = "정보 없음";
                humiditylist[12] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh43hour"].ToString()))
            {
                ShortHumidity14.Text = humi["rh43hour"].ToString() + "%";
                humiditylist[13] = (float)Convert.ToDouble(humi["rh43hour"].ToString());
            }
            else
            {
                ShortHumidity14.Text = "정보 없음";
                humiditylist[13] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh46hour"].ToString()))
            {
                ShortHumidity15.Text = humi["rh46hour"].ToString() + "%";
                humiditylist[14] = (float)Convert.ToDouble(humi["rh46hour"].ToString());
            }
            else
            {
                ShortHumidity15.Text = "정보 없음";
                humiditylist[14] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh49hour"].ToString()))
            {
                ShortHumidity16.Text = humi["rh49hour"].ToString() + "%";
                humiditylist[15] = (float)Convert.ToDouble(humi["rh49hour"].ToString());
            }
            else
            {
                ShortHumidity16.Text = "정보 없음";
                humiditylist[15] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh52hour"].ToString()))
            {
                ShortHumidity17.Text = humi["rh52hour"].ToString() + "%";
                humiditylist[16] = (float)Convert.ToDouble(humi["rh52hour"].ToString());
            }
            else
            {
                ShortHumidity17.Text = "정보 없음";
                humiditylist[16] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh55hour"].ToString()))
            {
                ShortHumidity18.Text = humi["rh55hour"].ToString() + "%";
                humiditylist[17] = (float)Convert.ToDouble(humi["rh55hour"].ToString());
            }
            else
            {
                ShortHumidity18.Text = "정보 없음";
                humiditylist[17] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh58hour"].ToString()))
            {
                ShortHumidity19.Text = humi["rh58hour"].ToString() + "%";
                humiditylist[18] = (float)Convert.ToDouble(humi["rh58hour"].ToString());
            }
            else
            {
                ShortHumidity19.Text = "정보 없음";
                humiditylist[18] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh61hour"].ToString()))
            {
                ShortHumidity20.Text = humi["rh61hour"].ToString() + "%";
                humiditylist[19] = (float)Convert.ToDouble(humi["rh61hour"].ToString());
            }
            else
            {
                ShortHumidity20.Text = "정보 없음";
                humiditylist[19] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh64hour"].ToString()))
            {
                ShortHumidity21.Text = humi["rh64hour"].ToString() + "%";
                humiditylist[20] = (float)Convert.ToDouble(humi["rh64hour"].ToString());
            }
            else
            {
                ShortHumidity21.Text = "정보 없음";
                humiditylist[20] = null;
            }

            if (!String.IsNullOrWhiteSpace(humi["rh67hour"].ToString()))
            {
                ShortHumidity22.Text = humi["rh67hour"].ToString() + "%";
                humiditylist[21] = (float)Convert.ToDouble(humi["rh67hour"].ToString());
            }
            else
            {
                ShortHumidity22.Text = "정보 없음";
                humiditylist[21] = null;
            }

            foreach(float? index in humiditylist)
            {
                if (index.HasValue)
                {
                    ShortHumidityGraph.AddValue(index.Value);
                }
            }

        }

        /// <summary>
        /// 중기예보
        /// </summary>
        /// 12시간 간격으로 매일 2회(6시, 18시), 주요 시도 단위로 중기예보 정보를 제공하며,
        /// 예보시간은 일단위로 +3일부터 +10일까지 제공한다.(+2일 예보는 ’14년 6월까지만 제공)
        private void PrintForecast6DaysWeather(WeatherSearch Searcher)
        {
            var Forecast = Searcher.GetForecast6DaysWeather();
            var skyCode = Forecast["sky"];

            String time = Forecast["timeRelease"].ToString();
            ReleaseTime3.Text = RecentLoc.GetAddress + " " + time;

            //아침
            if (!String.IsNullOrWhiteSpace(skyCode["amName2day"].ToString()))
            {
                LongWeatherExplain1.Text = skyCode["amName2day"].ToString();
                LongWeatherIcon1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(8, skyCode["amCode2day"].ToString()));
            }
            else
            {
                LongWeatherExplain1.Text = "정보 없음";
                LongWeatherIcon1.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["amName3day"].ToString()))
            {
                LongWeatherExplain2.Text = skyCode["amName3day"].ToString();
                LongWeatherIcon2.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(8, skyCode["amCode3day"].ToString()));
            }
            else
            {
                LongWeatherExplain2.Text = "정보 없음";
                LongWeatherIcon2.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["amName4day"].ToString()))
            {
                LongWeatherExplain3.Text = skyCode["amName4day"].ToString();
                LongWeatherIcon3.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(8, skyCode["amCode4day"].ToString()));
            }
            else
            {
                LongWeatherExplain3.Text = "정보 없음";
                LongWeatherIcon3.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["amName5day"].ToString()))
            {
                LongWeatherExplain4.Text = skyCode["amName5day"].ToString();
                LongWeatherIcon4.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(8, skyCode["amCode5day"].ToString()));
            }
            else
            {
                LongWeatherExplain4.Text = "정보 없음";
                LongWeatherIcon4.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["amName6day"].ToString()))
            {
                LongWeatherExplain5.Text = skyCode["amName6day"].ToString();
                LongWeatherIcon5.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(8, skyCode["amCode6day"].ToString()));
            }
            else
            {
                LongWeatherExplain5.Text = "정보 없음";
                LongWeatherIcon5.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["amName7day"].ToString()))
            {
                LongWeatherExplain6.Text = skyCode["amName7day"].ToString();
                LongWeatherIcon6.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(8, skyCode["amCode7day"].ToString()));
            }
            else
            {
                LongWeatherExplain6.Text = "정보 없음";
                LongWeatherIcon6.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["amName8day"].ToString()))
            {
                LongWeatherExplain7.Text = skyCode["amName8day"].ToString();
                LongWeatherIcon7.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(8, skyCode["amCode8day"].ToString()));
            }
            else
            {
                LongWeatherExplain7.Text = "정보 없음";
                LongWeatherIcon7.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["amName9day"].ToString()))
            {
                LongWeatherExplain8.Text = skyCode["amName9day"].ToString();
                LongWeatherIcon8.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(8, skyCode["amCode9day"].ToString()));
            }
            else
            {
                LongWeatherExplain8.Text = "정보 없음";
                LongWeatherIcon8.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["amName10day"].ToString()))
            {
                LongWeatherExplain9.Text = skyCode["amName10day"].ToString();
                LongWeatherIcon9.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(8, skyCode["amCode10day"].ToString()));
            }
            else
            {
                LongWeatherExplain9.Text = "정보 없음";
                LongWeatherIcon9.Image = (Bitmap)Properties.Resources._38;
            }

            //밤
            if (!String.IsNullOrWhiteSpace(skyCode["pmName2day"].ToString()))
            {
                LongWeatherExplain10.Text = skyCode["pmName2day"].ToString();
                LongWeatherIcon10.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(24, skyCode["pmCode2day"].ToString()));
            }
            else
            {
                LongWeatherExplain10.Text = "정보 없음";
                LongWeatherIcon10.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["pmName3day"].ToString()))
            {
                LongWeatherExplain11.Text = skyCode["pmName3day"].ToString();
                LongWeatherIcon11.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(24, skyCode["pmCode3day"].ToString()));
            }
            else
            {
                LongWeatherExplain11.Text = "정보 없음";
                LongWeatherIcon11.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["pmName4day"].ToString()))
            {
                LongWeatherExplain12.Text = skyCode["pmName4day"].ToString();
                LongWeatherIcon12.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(24, skyCode["pmCode4day"].ToString()));
            }
            else
            {
                LongWeatherExplain12.Text = "정보 없음";
                LongWeatherIcon12.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["pmName5day"].ToString()))
            {
                LongWeatherExplain13.Text = skyCode["pmName5day"].ToString();
                LongWeatherIcon13.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(24, skyCode["pmCode5day"].ToString()));
            }
            else
            {
                LongWeatherExplain13.Text = "정보 없음";
                LongWeatherIcon13.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["pmName6day"].ToString()))
            {
                LongWeatherExplain14.Text = skyCode["pmName6day"].ToString();
                LongWeatherIcon14.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(24, skyCode["pmCode6day"].ToString()));
            }
            else
            {
                LongWeatherExplain14.Text = "정보 없음";
                LongWeatherIcon14.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["pmName7day"].ToString()))
            {
                LongWeatherExplain15.Text = skyCode["pmName7day"].ToString();
                LongWeatherIcon15.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(24, skyCode["pmCode7day"].ToString()));
            }
            else
            {
                LongWeatherExplain15.Text = "정보 없음";
                LongWeatherIcon15.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["pmName8day"].ToString()))
            {
                LongWeatherExplain16.Text = skyCode["pmName8day"].ToString();
                LongWeatherIcon16.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(24, skyCode["pmCode8day"].ToString()));
            }
            else
            {
                LongWeatherExplain16.Text = "정보 없음";
                LongWeatherIcon16.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["pmName9day"].ToString()))
            {
                LongWeatherExplain17.Text = skyCode["pmName9day"].ToString();
                LongWeatherIcon17.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(24, skyCode["pmCode9day"].ToString()));
            }
            else
            {
                LongWeatherExplain17.Text = "정보 없음";
                LongWeatherIcon17.Image = (Bitmap)Properties.Resources._38;
            }

            if (!String.IsNullOrWhiteSpace(skyCode["pmName10day"].ToString()))
            {
                LongWeatherExplain18.Text = skyCode["pmName10day"].ToString();
                LongWeatherIcon18.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(SkyCode.GetSkyIcon(24, skyCode["pmCode10day"].ToString()));
            }
            else
            {
                LongWeatherExplain9.Text = "정보 없음";
                LongWeatherIcon9.Image = (Bitmap)Properties.Resources._38;
            }

            var temperature = Forecast["temperature"];

            float?[] templist = new float?[18];

            if (!String.IsNullOrWhiteSpace(temperature["tmin2day"].ToString()))
            {
                LongTMin1.Text = temperature["tmin2day"].ToString() + "℃";
                templist[0] = (float)Convert.ToDouble(temperature["tmin2day"].ToString());
            }
            else
            {
                LongTMin1.Text = "정보 없음";
                templist[0] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmax2day"].ToString()))
            {
                LongTMax1.Text = temperature["tmax2day"].ToString() + "℃";
                templist[1] = (float)Convert.ToDouble(temperature["tmax2day"].ToString());
            }
            else
            {
                LongTMax1.Text = "정보 없음";
                templist[1] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmin3day"].ToString()))
            {
                LongTMin2.Text = temperature["tmin3day"].ToString() + "℃";
                templist[2] = (float)Convert.ToDouble(temperature["tmin3day"].ToString());
            }
            else
            {
                LongTMin2.Text = "정보 없음";
                templist[2] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmax3day"].ToString()))
            {
                LongTMax2.Text = temperature["tmax2day"].ToString() + "℃";
                templist[3] = (float)Convert.ToDouble(temperature["tmax3day"].ToString());
            }
            else
            {
                LongTMax2.Text = "정보 없음";
                templist[3] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmin3day"].ToString()))
            {
                LongTMin3.Text = temperature["tmin3day"].ToString() + "℃";
                templist[4] = (float)Convert.ToDouble(temperature["tmin3day"].ToString());
            }
            else
            {
                LongTMin3.Text = "정보 없음";
                templist[4] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmax4day"].ToString()))
            {
                LongTMax3.Text = temperature["tmax4day"].ToString() + "℃";
                templist[5] = (float)Convert.ToDouble(temperature["tmax4day"].ToString());
            }
            else
            {
                LongTMax3.Text = "정보 없음";
                templist[5] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmin4day"].ToString()))
            {
                LongTMin4.Text = temperature["tmin4day"].ToString() + "℃";
                templist[6] = (float)Convert.ToDouble(temperature["tmin4day"].ToString());
            }
            else
            {
                LongTMin4.Text = "정보 없음";
                templist[6] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmax5day"].ToString()))
            {
                LongTMax4.Text = temperature["tmax5day"].ToString() + "℃";
                templist[7] = (float)Convert.ToDouble(temperature["tmax5day"].ToString());
            }
            else
            {
                LongTMax4.Text = "정보 없음";
                templist[7] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmin5day"].ToString()))
            {
                LongTMin5.Text = temperature["tmin5day"].ToString() + "℃";
                templist[8] = (float)Convert.ToDouble(temperature["tmin5day"].ToString());
            }
            else
            {
                LongTMin5.Text = "정보 없음";
                templist[8] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmax5day"].ToString()))
            {
                LongTMax5.Text = temperature["tmax5day"].ToString() + "℃";
                templist[9] = (float)Convert.ToDouble(temperature["tmax5day"].ToString());
            }
            else
            {
                LongTMax5.Text = "정보 없음";
                templist[9] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmin6day"].ToString()))
            {
                LongTMin6.Text = temperature["tmin6day"].ToString() + "℃";
                templist[10] = (float)Convert.ToDouble(temperature["tmin6day"].ToString());
            }
            else
            {
                LongTMin6.Text = "정보 없음";
                templist[10] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmax6day"].ToString()))
            {
                LongTMax6.Text = temperature["tmax6day"].ToString() + "℃";
                templist[11] = (float)Convert.ToDouble(temperature["tmax6day"].ToString());
            }
            else
            {
                LongTMax6.Text = "정보 없음";
                templist[11] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmin7day"].ToString()))
            {
                LongTMin7.Text = temperature["tmin7day"].ToString() + "℃";
                templist[12] = (float)Convert.ToDouble(temperature["tmin7day"].ToString());
            }
            else
            {
                LongTMin7.Text = "정보 없음";
                templist[12] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmax7day"].ToString()))
            {
                LongTMax7.Text = temperature["tmax7day"].ToString() + "℃";
                templist[13] = (float)Convert.ToDouble(temperature["tmax7day"].ToString());
            }
            else
            {
                LongTMax7.Text = "정보 없음";
                templist[13] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmin8day"].ToString()))
            {
                LongTMin8.Text = temperature["tmin8day"].ToString() + "℃";
                templist[14] = (float)Convert.ToDouble(temperature["tmin8day"].ToString());
            }
            else
            {
                LongTMin8.Text = "정보 없음";
                templist[14] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmax8day"].ToString()))
            {
                LongTMax8.Text = temperature["tmax8day"].ToString() + "℃";
                templist[15] = (float)Convert.ToDouble(temperature["tmax8day"].ToString());
            }
            else
            {
                LongTMax8.Text = "정보 없음";
                templist[15] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmin9day"].ToString()))
            {
                LongTMin9.Text = temperature["tmin9day"].ToString() + "℃";
                templist[16] = (float)Convert.ToDouble(temperature["tmin9day"].ToString());
            }
            else
            {
                LongTMin9.Text = "정보 없음";
                templist[16] = null;
            }

            if (!String.IsNullOrWhiteSpace(temperature["tmax9day"].ToString()))
            {
                LongTMax9.Text = temperature["tmax9day"].ToString() + "℃";
                templist[17] = (float)Convert.ToDouble(temperature["tmax9day"].ToString());
            }
            else
            {
                LongTMax9.Text = "정보 없음";
                templist[17] = null;
            }

            foreach(float? temp in templist)
            {
                if (temp.HasValue)
                {
                    LongTemperatureGraph.AddValue(temp.Value);
                }
            }

        }

        /// <summary>
        /// 기상특보
        /// </summary>
        /// 강풍, 호우, 한파, 건조, 해일, 풍랑, 태풍, 대설, 황사, 폭염 등의 특보 발생시에 200여개의 특보구역에 대해 기상특보를 제공한다.
        /// 또한, 동일 특보구역에 복수개의 기상특보가 존재할 경우에는 발생한 특보의 개수만큼을 응답한다.
        private void PrintSevereAlertWeather(WeatherSearch Searcher)
        {

        }

        /// <summary>
        /// 태풍정보
        /// </summary>
        /// 태풍의 현 위치 및 예상위치를 지도상에 표시할 수 있도록 태풍예보에 대한 상세 정보를 제공한다. 
        /// 복수개의 태풍이 존재할 경우에는 발생한 태풍의 개수만큼을 응답한다.
       /* private void PrintSevereStormWeather(WeatherSearch Searcher)
        {

        }

        /// <summary>
        /// 낙뢰정보
        /// </summary>
        /// 낙뢰 지점을 지도상에 표시할 수 있도록 10분 주기로 수집되는 낙뢰 상세 정보를 제공한다.
        /// 복수개의 낙뢰가 존재할 경우에는 발생한 낙뢰의 개수만큼을 응답한다.
        private void PrintSevereLightningWeather(WeatherSearch Searcher)
        {

        }*/

        #endregion
    }
}
