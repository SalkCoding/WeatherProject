namespace Weather
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.regionSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selfSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocationSetButton = new MetroSuite.MetroNavigationButton();
            this.LocationSetTip = new System.Windows.Forms.ToolTip(this.components);
            this.WeatherInfo = new MetroSuite.MetroTabControl();
            this.SummaryWeather = new System.Windows.Forms.TabPage();
            this.ReleaseTime = new MetroSuite.MetroLabel();
            this.metroLabel5 = new MetroSuite.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AfterTomorrowTmin = new MetroSuite.MetroLabel();
            this.metroLabel15 = new MetroSuite.MetroLabel();
            this.AfterTomorrowTmax = new MetroSuite.MetroLabel();
            this.metroLabel17 = new MetroSuite.MetroLabel();
            this.TemperatureGraph4 = new MetroSuite.MetroGraph();
            this.WeatherIcon3 = new System.Windows.Forms.PictureBox();
            this.WeatherExplain3 = new MetroSuite.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TodayTmin = new MetroSuite.MetroLabel();
            this.metroLabel9 = new MetroSuite.MetroLabel();
            this.TodayTmax = new MetroSuite.MetroLabel();
            this.metroLabel11 = new MetroSuite.MetroLabel();
            this.TemperatureGraph2 = new MetroSuite.MetroGraph();
            this.WeatherIcon1 = new System.Windows.Forms.PictureBox();
            this.WeatherExplain1 = new MetroSuite.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TomorrowTmin = new MetroSuite.MetroLabel();
            this.metroLabel10 = new MetroSuite.MetroLabel();
            this.TomorrowTmax = new MetroSuite.MetroLabel();
            this.metroLabel13 = new MetroSuite.MetroLabel();
            this.TemperatureGraph3 = new MetroSuite.MetroGraph();
            this.WeatherIcon2 = new System.Windows.Forms.PictureBox();
            this.WeatherExplain2 = new MetroSuite.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TemperatureGraph1 = new MetroSuite.MetroGraph();
            this.Current1MinutelyWeather = new System.Windows.Forms.TabPage();
            this.CurrentHumidity = new MetroSuite.MetroLabel();
            this.metroLabel6 = new MetroSuite.MetroLabel();
            this.metroLabel1 = new MetroSuite.MetroLabel();
            this.CurrentHumidityPercent = new GChartLib.GCircularProgress();
            this.CurrentTCurrent = new MetroSuite.MetroLabel();
            this.metroLabel16 = new MetroSuite.MetroLabel();
            this.last24hour = new MetroSuite.MetroLabel();
            this.last12hour = new MetroSuite.MetroLabel();
            this.metroLabel28 = new MetroSuite.MetroLabel();
            this.metroLabel14 = new MetroSuite.MetroLabel();
            this.last1hour = new MetroSuite.MetroLabel();
            this.metroLabel30 = new MetroSuite.MetroLabel();
            this.metroLabel26 = new MetroSuite.MetroLabel();
            this.last6hour = new MetroSuite.MetroLabel();
            this.last30min = new MetroSuite.MetroLabel();
            this.metroLabel24 = new MetroSuite.MetroLabel();
            this.last15min = new MetroSuite.MetroLabel();
            this.metroLabel22 = new MetroSuite.MetroLabel();
            this.last10min = new MetroSuite.MetroLabel();
            this.metroLabel20 = new MetroSuite.MetroLabel();
            this.SinceMidNight = new MetroSuite.MetroLabel();
            this.mertolabel14 = new MetroSuite.MetroLabel();
            this.CurrentRainGraph = new MetroSuite.MetroGraph();
            this.CurrentTmin = new MetroSuite.MetroLabel();
            this.metroLabel3 = new MetroSuite.MetroLabel();
            this.CurrentTMax = new MetroSuite.MetroLabel();
            this.metroLabel7 = new MetroSuite.MetroLabel();
            this.CurrentTemperatureGraph = new MetroSuite.MetroGraph();
            this.CurrentWeatherIcon = new System.Windows.Forms.PictureBox();
            this.CurrentWeatherExplain = new MetroSuite.MetroLabel();
            this.ReleaseTime1 = new MetroSuite.MetroLabel();
            this.metroLabel2 = new MetroSuite.MetroLabel();
            this.Forecast3HourlyWeather = new System.Windows.Forms.TabPage();
            this.FourHourWeatherIcon = new System.Windows.Forms.PictureBox();
            this.FourHourWeatherExplain = new MetroSuite.MetroLabel();
            this.FourHourHumidity = new MetroSuite.MetroLabel();
            this.metroLabel27 = new MetroSuite.MetroLabel();
            this.FourHourHumidityPercent = new GChartLib.GCircularProgress();
            this.FourHourTemperature = new MetroSuite.MetroLabel();
            this.metroLabel19 = new MetroSuite.MetroLabel();
            this.ThreeHourHumidity = new MetroSuite.MetroLabel();
            this.metroLabel33 = new MetroSuite.MetroLabel();
            this.ThreeHourHumidityPercent = new GChartLib.GCircularProgress();
            this.TwoHourHumidity = new MetroSuite.MetroLabel();
            this.metroLabel31 = new MetroSuite.MetroLabel();
            this.TwoHourHumidityPercent = new GChartLib.GCircularProgress();
            this.OneHourHumidity = new MetroSuite.MetroLabel();
            this.metroLabel23 = new MetroSuite.MetroLabel();
            this.OneHourHumidityPercent = new GChartLib.GCircularProgress();
            this.ThreeHourTemperature = new MetroSuite.MetroLabel();
            this.metroLabel18 = new MetroSuite.MetroLabel();
            this.TwoHourTemperature = new MetroSuite.MetroLabel();
            this.metroLabel25 = new MetroSuite.MetroLabel();
            this.OneHourTemperature = new MetroSuite.MetroLabel();
            this.metroLabel29 = new MetroSuite.MetroLabel();
            this.HourTemperatureGraph = new MetroSuite.MetroGraph();
            this.metroLabel8 = new MetroSuite.MetroLabel();
            this.TwoHourWeatherExplain = new MetroSuite.MetroLabel();
            this.ReleaseTime2 = new MetroSuite.MetroLabel();
            this.OneHourWeatherExplain = new MetroSuite.MetroLabel();
            this.metroLabel21 = new MetroSuite.MetroLabel();
            this.TwoHourWeatherIcon = new System.Windows.Forms.PictureBox();
            this.ThreeHourWeatherIcon = new System.Windows.Forms.PictureBox();
            this.OneHourWeatherIcon = new System.Windows.Forms.PictureBox();
            this.ThreeHourWeatherExplain = new MetroSuite.MetroLabel();
            this.Forecast3DaysWeather = new System.Windows.Forms.TabPage();
            this.ShortHumidity22 = new MetroSuite.MetroLabel();
            this.ShortHumidity21 = new MetroSuite.MetroLabel();
            this.ShortHumidity20 = new MetroSuite.MetroLabel();
            this.ShortHumidity19 = new MetroSuite.MetroLabel();
            this.ShortHumidity18 = new MetroSuite.MetroLabel();
            this.ShortHumidity17 = new MetroSuite.MetroLabel();
            this.ShortHumidity16 = new MetroSuite.MetroLabel();
            this.ShortHumidity15 = new MetroSuite.MetroLabel();
            this.ShortHumidity14 = new MetroSuite.MetroLabel();
            this.ShortHumidity13 = new MetroSuite.MetroLabel();
            this.ShortHumidity12 = new MetroSuite.MetroLabel();
            this.ShortHumidity11 = new MetroSuite.MetroLabel();
            this.ShortHumidity10 = new MetroSuite.MetroLabel();
            this.ShortHumidity9 = new MetroSuite.MetroLabel();
            this.ShortHumidity8 = new MetroSuite.MetroLabel();
            this.ShortHumidity7 = new MetroSuite.MetroLabel();
            this.ShortHumidity6 = new MetroSuite.MetroLabel();
            this.ShortHumidity5 = new MetroSuite.MetroLabel();
            this.ShortHumidity4 = new MetroSuite.MetroLabel();
            this.ShortHumidity2 = new MetroSuite.MetroLabel();
            this.ShortHumidity3 = new MetroSuite.MetroLabel();
            this.ShortHumidity1 = new MetroSuite.MetroLabel();
            this.metroLabel85 = new MetroSuite.MetroLabel();
            this.metroLabel86 = new MetroSuite.MetroLabel();
            this.metroLabel87 = new MetroSuite.MetroLabel();
            this.metroLabel88 = new MetroSuite.MetroLabel();
            this.metroLabel89 = new MetroSuite.MetroLabel();
            this.metroLabel90 = new MetroSuite.MetroLabel();
            this.metroLabel91 = new MetroSuite.MetroLabel();
            this.metroLabel92 = new MetroSuite.MetroLabel();
            this.metroLabel93 = new MetroSuite.MetroLabel();
            this.metroLabel94 = new MetroSuite.MetroLabel();
            this.metroLabel95 = new MetroSuite.MetroLabel();
            this.metroLabel96 = new MetroSuite.MetroLabel();
            this.metroLabel97 = new MetroSuite.MetroLabel();
            this.metroLabel98 = new MetroSuite.MetroLabel();
            this.metroLabel99 = new MetroSuite.MetroLabel();
            this.metroLabel100 = new MetroSuite.MetroLabel();
            this.metroLabel101 = new MetroSuite.MetroLabel();
            this.metroLabel102 = new MetroSuite.MetroLabel();
            this.metroLabel103 = new MetroSuite.MetroLabel();
            this.metroLabel104 = new MetroSuite.MetroLabel();
            this.metroLabel105 = new MetroSuite.MetroLabel();
            this.metroLabel106 = new MetroSuite.MetroLabel();
            this.ShortHumidityGraph = new MetroSuite.MetroGraph();
            this.metroLabel69 = new MetroSuite.MetroLabel();
            this.metroLabel70 = new MetroSuite.MetroLabel();
            this.metroLabel71 = new MetroSuite.MetroLabel();
            this.ShortTMin3 = new MetroSuite.MetroLabel();
            this.ShortTMin2 = new MetroSuite.MetroLabel();
            this.ShortTMin1 = new MetroSuite.MetroLabel();
            this.ShortTMax3 = new MetroSuite.MetroLabel();
            this.metroLabel61 = new MetroSuite.MetroLabel();
            this.ShortTMax2 = new MetroSuite.MetroLabel();
            this.metroLabel59 = new MetroSuite.MetroLabel();
            this.ShortTMax1 = new MetroSuite.MetroLabel();
            this.metroLabel57 = new MetroSuite.MetroLabel();
            this.ShortTGraph = new MetroSuite.MetroGraph();
            this.ShortTemperature22 = new MetroSuite.MetroLabel();
            this.ShortTemperature21 = new MetroSuite.MetroLabel();
            this.ShortTemperature20 = new MetroSuite.MetroLabel();
            this.ShortTemperature19 = new MetroSuite.MetroLabel();
            this.ShortTemperature18 = new MetroSuite.MetroLabel();
            this.ShortTemperature17 = new MetroSuite.MetroLabel();
            this.ShortTemperature16 = new MetroSuite.MetroLabel();
            this.ShortTemperature15 = new MetroSuite.MetroLabel();
            this.ShortTemperature14 = new MetroSuite.MetroLabel();
            this.ShortTemperature13 = new MetroSuite.MetroLabel();
            this.ShortTemperature12 = new MetroSuite.MetroLabel();
            this.ShortTemperature11 = new MetroSuite.MetroLabel();
            this.ShortTemperature10 = new MetroSuite.MetroLabel();
            this.ShortTemperature9 = new MetroSuite.MetroLabel();
            this.ShortTemperature8 = new MetroSuite.MetroLabel();
            this.ShortTemperature7 = new MetroSuite.MetroLabel();
            this.ShortTemperature6 = new MetroSuite.MetroLabel();
            this.ShortTemperature5 = new MetroSuite.MetroLabel();
            this.ShortTemperature4 = new MetroSuite.MetroLabel();
            this.ShortTemperature2 = new MetroSuite.MetroLabel();
            this.ShortTemperature3 = new MetroSuite.MetroLabel();
            this.ShortTemperature1 = new MetroSuite.MetroLabel();
            this.metroLabel56 = new MetroSuite.MetroLabel();
            this.metroLabel55 = new MetroSuite.MetroLabel();
            this.metroLabel54 = new MetroSuite.MetroLabel();
            this.metroLabel53 = new MetroSuite.MetroLabel();
            this.metroLabel52 = new MetroSuite.MetroLabel();
            this.metroLabel51 = new MetroSuite.MetroLabel();
            this.metroLabel50 = new MetroSuite.MetroLabel();
            this.metroLabel49 = new MetroSuite.MetroLabel();
            this.metroLabel48 = new MetroSuite.MetroLabel();
            this.metroLabel47 = new MetroSuite.MetroLabel();
            this.metroLabel46 = new MetroSuite.MetroLabel();
            this.metroLabel45 = new MetroSuite.MetroLabel();
            this.metroLabel44 = new MetroSuite.MetroLabel();
            this.metroLabel43 = new MetroSuite.MetroLabel();
            this.metroLabel42 = new MetroSuite.MetroLabel();
            this.metroLabel41 = new MetroSuite.MetroLabel();
            this.metroLabel40 = new MetroSuite.MetroLabel();
            this.metroLabel39 = new MetroSuite.MetroLabel();
            this.metroLabel38 = new MetroSuite.MetroLabel();
            this.metroLabel36 = new MetroSuite.MetroLabel();
            this.metroLabel34 = new MetroSuite.MetroLabel();
            this.metroLabel12 = new MetroSuite.MetroLabel();
            this.ShortTemperatureGraph = new MetroSuite.MetroGraph();
            this.ShortWeatherExplain22 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain21 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain20 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain19 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain18 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain17 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain2 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain3 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain4 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain5 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain7 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain6 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain8 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain9 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain10 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain11 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain12 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain13 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain14 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain15 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain16 = new MetroSuite.MetroLabel();
            this.ShortWeatherIcon17 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon18 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon20 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon21 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon22 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon19 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon16 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon7 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon8 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon9 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon15 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon14 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon13 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon12 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon11 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon6 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon10 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon5 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon4 = new System.Windows.Forms.PictureBox();
            this.metroLabel32 = new MetroSuite.MetroLabel();
            this.ShortWeatherExplain1 = new MetroSuite.MetroLabel();
            this.ReleaseTime3 = new MetroSuite.MetroLabel();
            this.metroLabel37 = new MetroSuite.MetroLabel();
            this.ShortWeatherIcon2 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon3 = new System.Windows.Forms.PictureBox();
            this.ShortWeatherIcon1 = new System.Windows.Forms.PictureBox();
            this.Forecast6DaysWeather = new System.Windows.Forms.TabPage();
            this.SevereAlertWeather = new System.Windows.Forms.TabPage();
            this.RefreshButton = new MetroSuite.MetroButton();
            this.RefreshTip = new System.Windows.Forms.ToolTip(this.components);
            this.MetroLabel4 = new MetroSuite.MetroLabel();
            this.RefreshTime = new MetroSuite.MetroLabel();
            this.SummaryTip = new System.Windows.Forms.ToolTip(this.components);
            this.CurrentTip = new System.Windows.Forms.ToolTip(this.components);
            this.ShortTip = new System.Windows.Forms.ToolTip(this.components);
            this.NormalTip = new System.Windows.Forms.ToolTip(this.components);
            this.LongTip = new System.Windows.Forms.ToolTip(this.components);
            this.AlertTip = new System.Windows.Forms.ToolTip(this.components);
            this.LongWeatherExplain2 = new MetroSuite.MetroLabel();
            this.LongWeatherExplain3 = new MetroSuite.MetroLabel();
            this.LongWeatherExplain4 = new MetroSuite.MetroLabel();
            this.LongWeatherExplain5 = new MetroSuite.MetroLabel();
            this.LongWeatherIcon5 = new System.Windows.Forms.PictureBox();
            this.LongWeatherIcon4 = new System.Windows.Forms.PictureBox();
            this.LongWeatherExplain1 = new MetroSuite.MetroLabel();
            this.LongWeatherIcon2 = new System.Windows.Forms.PictureBox();
            this.LongWeatherIcon3 = new System.Windows.Forms.PictureBox();
            this.LongWeatherIcon1 = new System.Windows.Forms.PictureBox();
            this.metroLabel72 = new MetroSuite.MetroLabel();
            this.ReleaseTime4 = new MetroSuite.MetroLabel();
            this.metroLabel74 = new MetroSuite.MetroLabel();
            this.LongWeatherExplain7 = new MetroSuite.MetroLabel();
            this.LongWeatherExplain8 = new MetroSuite.MetroLabel();
            this.LongWeatherExplain9 = new MetroSuite.MetroLabel();
            this.LongWeatherIcon9 = new System.Windows.Forms.PictureBox();
            this.LongWeatherExplain6 = new MetroSuite.MetroLabel();
            this.LongWeatherIcon7 = new System.Windows.Forms.PictureBox();
            this.LongWeatherIcon8 = new System.Windows.Forms.PictureBox();
            this.LongWeatherIcon6 = new System.Windows.Forms.PictureBox();
            this.LongTemperatureGraph = new MetroSuite.MetroGraph();
            this.metroLabel35 = new MetroSuite.MetroLabel();
            this.metroLabel58 = new MetroSuite.MetroLabel();
            this.LongTMin3 = new MetroSuite.MetroLabel();
            this.LongTMin2 = new MetroSuite.MetroLabel();
            this.LongTMax3 = new MetroSuite.MetroLabel();
            this.metroLabel66 = new MetroSuite.MetroLabel();
            this.LongTMax2 = new MetroSuite.MetroLabel();
            this.metroLabel68 = new MetroSuite.MetroLabel();
            this.metroLabel78 = new MetroSuite.MetroLabel();
            this.metroLabel79 = new MetroSuite.MetroLabel();
            this.LongTMin5 = new MetroSuite.MetroLabel();
            this.LongTMin4 = new MetroSuite.MetroLabel();
            this.LongTMax5 = new MetroSuite.MetroLabel();
            this.metroLabel108 = new MetroSuite.MetroLabel();
            this.LongTMax4 = new MetroSuite.MetroLabel();
            this.metroLabel110 = new MetroSuite.MetroLabel();
            this.metroLabel77 = new MetroSuite.MetroLabel();
            this.metroLabel80 = new MetroSuite.MetroLabel();
            this.LongTMin9 = new MetroSuite.MetroLabel();
            this.metroLabel112 = new MetroSuite.MetroLabel();
            this.LongTMax9 = new MetroSuite.MetroLabel();
            this.metroLabel114 = new MetroSuite.MetroLabel();
            this.metroLabel115 = new MetroSuite.MetroLabel();
            this.metroLabel116 = new MetroSuite.MetroLabel();
            this.metroLabel117 = new MetroSuite.MetroLabel();
            this.LongTMin8 = new MetroSuite.MetroLabel();
            this.LongTMin7 = new MetroSuite.MetroLabel();
            this.LongTMin6 = new MetroSuite.MetroLabel();
            this.LongTMax8 = new MetroSuite.MetroLabel();
            this.metroLabel122 = new MetroSuite.MetroLabel();
            this.LongTMax7 = new MetroSuite.MetroLabel();
            this.metroLabel124 = new MetroSuite.MetroLabel();
            this.LongTMax6 = new MetroSuite.MetroLabel();
            this.metroLabel126 = new MetroSuite.MetroLabel();
            this.metroLabel62 = new MetroSuite.MetroLabel();
            this.LongWeatherExplain10 = new MetroSuite.MetroLabel();
            this.LongWeatherIcon10 = new System.Windows.Forms.PictureBox();
            this.metroLabel63 = new MetroSuite.MetroLabel();
            this.LongWeatherExplain16 = new MetroSuite.MetroLabel();
            this.LongWeatherExplain17 = new MetroSuite.MetroLabel();
            this.LongWeatherExplain18 = new MetroSuite.MetroLabel();
            this.LongWeatherIcon18 = new System.Windows.Forms.PictureBox();
            this.LongWeatherExplain15 = new MetroSuite.MetroLabel();
            this.LongWeatherIcon16 = new System.Windows.Forms.PictureBox();
            this.LongWeatherIcon17 = new System.Windows.Forms.PictureBox();
            this.LongWeatherIcon15 = new System.Windows.Forms.PictureBox();
            this.LongWeatherExplain11 = new MetroSuite.MetroLabel();
            this.LongWeatherExplain12 = new MetroSuite.MetroLabel();
            this.LongWeatherExplain13 = new MetroSuite.MetroLabel();
            this.LongWeatherExplain14 = new MetroSuite.MetroLabel();
            this.LongWeatherIcon14 = new System.Windows.Forms.PictureBox();
            this.LongWeatherIcon13 = new System.Windows.Forms.PictureBox();
            this.LongWeatherIcon11 = new System.Windows.Forms.PictureBox();
            this.LongWeatherIcon12 = new System.Windows.Forms.PictureBox();
            this.LongTMax1 = new MetroSuite.MetroLabel();
            this.LongTMin1 = new MetroSuite.MetroLabel();
            this.metroLabel60 = new MetroSuite.MetroLabel();
            this.WeatherInfo.SuspendLayout();
            this.SummaryWeather.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Current1MinutelyWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentWeatherIcon)).BeginInit();
            this.Forecast3HourlyWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FourHourWeatherIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoHourWeatherIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreeHourWeatherIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneHourWeatherIcon)).BeginInit();
            this.Forecast3DaysWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon1)).BeginInit();
            this.Forecast6DaysWeather.SuspendLayout();
            this.SevereAlertWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon12)).BeginInit();
            this.SuspendLayout();
            // 
            // regionSettingToolStripMenuItem
            // 
            this.regionSettingToolStripMenuItem.Name = "regionSettingToolStripMenuItem";
            this.regionSettingToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // selfSelectToolStripMenuItem
            // 
            this.selfSelectToolStripMenuItem.Name = "selfSelectToolStripMenuItem";
            this.selfSelectToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // LocationSetButton
            // 
            this.LocationSetButton.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.LocationSetButton.ArrowDirection = System.Windows.Forms.ArrowDirection.Right;
            this.LocationSetButton.ArrowHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.LocationSetButton.ArrowPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.LocationSetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.LocationSetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LocationSetButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.LocationSetButton.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.LocationSetButton.BorderPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.LocationSetButton.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.LocationSetButton.DisabledArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LocationSetButton.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.LocationSetButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LocationSetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LocationSetButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.LocationSetButton.Location = new System.Drawing.Point(771, 25);
            this.LocationSetButton.Name = "LocationSetButton";
            this.LocationSetButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.LocationSetButton.Size = new System.Drawing.Size(36, 36);
            this.LocationSetButton.TabIndex = 0;
            this.LocationSetButton.Click += new System.EventHandler(this.LocationSetButton_Click);
            // 
            // WeatherInfo
            // 
            this.WeatherInfo.Alignment = System.Windows.Forms.TabAlignment.Top;
            this.WeatherInfo.Appearance = System.Windows.Forms.Appearance.Normal;
            this.WeatherInfo.AutoStyle = false;
            this.WeatherInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WeatherInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.WeatherInfo.Controls.Add(this.SummaryWeather);
            this.WeatherInfo.Controls.Add(this.Current1MinutelyWeather);
            this.WeatherInfo.Controls.Add(this.Forecast3HourlyWeather);
            this.WeatherInfo.Controls.Add(this.Forecast3DaysWeather);
            this.WeatherInfo.Controls.Add(this.Forecast6DaysWeather);
            this.WeatherInfo.Controls.Add(this.SevereAlertWeather);
            this.WeatherInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WeatherInfo.ForeColor = System.Drawing.Color.Black;
            this.WeatherInfo.HasAnimation = false;
            this.WeatherInfo.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(115)))), ((int)(((byte)(124)))));
            this.WeatherInfo.HeaderItemColor = System.Drawing.Color.White;
            this.WeatherInfo.HotTrack = true;
            this.WeatherInfo.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.WeatherInfo.HoverColor = System.Drawing.Color.White;
            this.WeatherInfo.ItemColor = System.Drawing.Color.White;
            this.WeatherInfo.ItemForeColor = System.Drawing.Color.Black;
            this.WeatherInfo.ItemSize = new System.Drawing.Size(120, 45);
            this.WeatherInfo.Location = new System.Drawing.Point(12, 76);
            this.WeatherInfo.Multiline = true;
            this.WeatherInfo.Name = "WeatherInfo";
            this.WeatherInfo.SelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.WeatherInfo.SelectedForeColor = System.Drawing.Color.White;
            this.WeatherInfo.SelectedIndex = 0;
            this.WeatherInfo.SelectedItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.WeatherInfo.SelectedItemLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.WeatherInfo.Size = new System.Drawing.Size(826, 572);
            this.WeatherInfo.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.WeatherInfo.TabContainerColor = System.Drawing.Color.White;
            this.WeatherInfo.TabIndex = 1;
            // 
            // SummaryWeather
            // 
            this.SummaryWeather.AutoScroll = true;
            this.SummaryWeather.BackColor = System.Drawing.Color.White;
            this.SummaryWeather.Controls.Add(this.ReleaseTime);
            this.SummaryWeather.Controls.Add(this.metroLabel5);
            this.SummaryWeather.Controls.Add(this.groupBox4);
            this.SummaryWeather.Controls.Add(this.groupBox2);
            this.SummaryWeather.Controls.Add(this.groupBox3);
            this.SummaryWeather.Controls.Add(this.groupBox1);
            this.SummaryWeather.Location = new System.Drawing.Point(4, 49);
            this.SummaryWeather.Name = "SummaryWeather";
            this.SummaryWeather.Padding = new System.Windows.Forms.Padding(3);
            this.SummaryWeather.Size = new System.Drawing.Size(818, 519);
            this.SummaryWeather.TabIndex = 1;
            this.SummaryWeather.Text = "간편 날씨";
            // 
            // ReleaseTime
            // 
            this.ReleaseTime.AutoSize = true;
            this.ReleaseTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ReleaseTime.Location = new System.Drawing.Point(97, 3);
            this.ReleaseTime.Name = "ReleaseTime";
            this.ReleaseTime.Size = new System.Drawing.Size(19, 21);
            this.ReleaseTime.TabIndex = 8;
            this.ReleaseTime.Text = "0";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel5.Location = new System.Drawing.Point(6, 3);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(85, 21);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "관측 시간 :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AfterTomorrowTmin);
            this.groupBox4.Controls.Add(this.metroLabel15);
            this.groupBox4.Controls.Add(this.AfterTomorrowTmax);
            this.groupBox4.Controls.Add(this.metroLabel17);
            this.groupBox4.Controls.Add(this.TemperatureGraph4);
            this.groupBox4.Controls.Add(this.WeatherIcon3);
            this.groupBox4.Controls.Add(this.WeatherExplain3);
            this.groupBox4.Location = new System.Drawing.Point(6, 837);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(789, 264);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "모레";
            // 
            // AfterTomorrowTmin
            // 
            this.AfterTomorrowTmin.AutoSize = true;
            this.AfterTomorrowTmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AfterTomorrowTmin.Location = new System.Drawing.Point(620, 178);
            this.AfterTomorrowTmin.Name = "AfterTomorrowTmin";
            this.AfterTomorrowTmin.Size = new System.Drawing.Size(19, 21);
            this.AfterTomorrowTmin.TabIndex = 18;
            this.AfterTomorrowTmin.Text = "0";
            this.AfterTomorrowTmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel15.Location = new System.Drawing.Point(592, 157);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(78, 21);
            this.metroLabel15.TabIndex = 17;
            this.metroLabel15.Text = "최저 온도";
            // 
            // AfterTomorrowTmax
            // 
            this.AfterTomorrowTmax.AutoSize = true;
            this.AfterTomorrowTmax.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AfterTomorrowTmax.Location = new System.Drawing.Point(620, 92);
            this.AfterTomorrowTmax.Name = "AfterTomorrowTmax";
            this.AfterTomorrowTmax.Size = new System.Drawing.Size(19, 21);
            this.AfterTomorrowTmax.TabIndex = 16;
            this.AfterTomorrowTmax.Text = "0";
            this.AfterTomorrowTmax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel17.Location = new System.Drawing.Point(592, 71);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(78, 21);
            this.metroLabel17.TabIndex = 15;
            this.metroLabel17.Text = "최고 기온";
            // 
            // TemperatureGraph4
            // 
            this.TemperatureGraph4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TemperatureGraph4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.TemperatureGraph4.ClassicFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TemperatureGraph4.ClassicLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TemperatureGraph4.DefaultColor = System.Drawing.Color.White;
            this.TemperatureGraph4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TemperatureGraph4.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.TemperatureGraph4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TemperatureGraph4.HoverBoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TemperatureGraph4.HoverBoxColor = System.Drawing.Color.White;
            this.TemperatureGraph4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TemperatureGraph4.Location = new System.Drawing.Point(212, 22);
            this.TemperatureGraph4.Name = "TemperatureGraph4";
            this.TemperatureGraph4.SidePadding = true;
            this.TemperatureGraph4.SingleLine = true;
            this.TemperatureGraph4.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TemperatureGraph4.Size = new System.Drawing.Size(277, 218);
            this.TemperatureGraph4.TabIndex = 6;
            this.TemperatureGraph4.Text = "metroGraph1";
            // 
            // WeatherIcon3
            // 
            this.WeatherIcon3.Location = new System.Drawing.Point(6, 22);
            this.WeatherIcon3.Name = "WeatherIcon3";
            this.WeatherIcon3.Size = new System.Drawing.Size(200, 200);
            this.WeatherIcon3.TabIndex = 4;
            this.WeatherIcon3.TabStop = false;
            // 
            // WeatherExplain3
            // 
            this.WeatherExplain3.AutoSize = true;
            this.WeatherExplain3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WeatherExplain3.Location = new System.Drawing.Point(82, 225);
            this.WeatherExplain3.Name = "WeatherExplain3";
            this.WeatherExplain3.Size = new System.Drawing.Size(49, 21);
            this.WeatherExplain3.TabIndex = 5;
            this.WeatherExplain3.Text = "NULL";
            this.WeatherExplain3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TodayTmin);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.TodayTmax);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.TemperatureGraph2);
            this.groupBox2.Controls.Add(this.WeatherIcon1);
            this.groupBox2.Controls.Add(this.WeatherExplain1);
            this.groupBox2.Location = new System.Drawing.Point(6, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 264);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "오늘";
            // 
            // TodayTmin
            // 
            this.TodayTmin.AutoSize = true;
            this.TodayTmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TodayTmin.Location = new System.Drawing.Point(620, 175);
            this.TodayTmin.Name = "TodayTmin";
            this.TodayTmin.Size = new System.Drawing.Size(19, 21);
            this.TodayTmin.TabIndex = 10;
            this.TodayTmin.Text = "0";
            this.TodayTmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel9.Location = new System.Drawing.Point(592, 154);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(78, 21);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "최저 온도";
            // 
            // TodayTmax
            // 
            this.TodayTmax.AutoSize = true;
            this.TodayTmax.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TodayTmax.Location = new System.Drawing.Point(620, 89);
            this.TodayTmax.Name = "TodayTmax";
            this.TodayTmax.Size = new System.Drawing.Size(19, 21);
            this.TodayTmax.TabIndex = 8;
            this.TodayTmax.Text = "0";
            this.TodayTmax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel11.Location = new System.Drawing.Point(592, 68);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(78, 21);
            this.metroLabel11.TabIndex = 7;
            this.metroLabel11.Text = "최고 기온";
            // 
            // TemperatureGraph2
            // 
            this.TemperatureGraph2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TemperatureGraph2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.TemperatureGraph2.ClassicFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TemperatureGraph2.ClassicLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TemperatureGraph2.DefaultColor = System.Drawing.Color.White;
            this.TemperatureGraph2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TemperatureGraph2.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.TemperatureGraph2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TemperatureGraph2.HoverBoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TemperatureGraph2.HoverBoxColor = System.Drawing.Color.White;
            this.TemperatureGraph2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TemperatureGraph2.Location = new System.Drawing.Point(212, 22);
            this.TemperatureGraph2.Name = "TemperatureGraph2";
            this.TemperatureGraph2.SidePadding = true;
            this.TemperatureGraph2.SingleLine = true;
            this.TemperatureGraph2.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TemperatureGraph2.Size = new System.Drawing.Size(277, 218);
            this.TemperatureGraph2.TabIndex = 6;
            this.TemperatureGraph2.Text = "metroGraph1";
            // 
            // WeatherIcon1
            // 
            this.WeatherIcon1.Location = new System.Drawing.Point(6, 22);
            this.WeatherIcon1.Name = "WeatherIcon1";
            this.WeatherIcon1.Size = new System.Drawing.Size(200, 200);
            this.WeatherIcon1.TabIndex = 4;
            this.WeatherIcon1.TabStop = false;
            // 
            // WeatherExplain1
            // 
            this.WeatherExplain1.AutoSize = true;
            this.WeatherExplain1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WeatherExplain1.Location = new System.Drawing.Point(82, 225);
            this.WeatherExplain1.Name = "WeatherExplain1";
            this.WeatherExplain1.Size = new System.Drawing.Size(49, 21);
            this.WeatherExplain1.TabIndex = 5;
            this.WeatherExplain1.Text = "NULL";
            this.WeatherExplain1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TomorrowTmin);
            this.groupBox3.Controls.Add(this.metroLabel10);
            this.groupBox3.Controls.Add(this.TomorrowTmax);
            this.groupBox3.Controls.Add(this.metroLabel13);
            this.groupBox3.Controls.Add(this.TemperatureGraph3);
            this.groupBox3.Controls.Add(this.WeatherIcon2);
            this.groupBox3.Controls.Add(this.WeatherExplain2);
            this.groupBox3.Location = new System.Drawing.Point(6, 567);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(789, 264);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "내일";
            // 
            // TomorrowTmin
            // 
            this.TomorrowTmin.AutoSize = true;
            this.TomorrowTmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TomorrowTmin.Location = new System.Drawing.Point(620, 170);
            this.TomorrowTmin.Name = "TomorrowTmin";
            this.TomorrowTmin.Size = new System.Drawing.Size(19, 21);
            this.TomorrowTmin.TabIndex = 14;
            this.TomorrowTmin.Text = "0";
            this.TomorrowTmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel10.Location = new System.Drawing.Point(592, 149);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(78, 21);
            this.metroLabel10.TabIndex = 13;
            this.metroLabel10.Text = "최저 온도";
            // 
            // TomorrowTmax
            // 
            this.TomorrowTmax.AutoSize = true;
            this.TomorrowTmax.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TomorrowTmax.Location = new System.Drawing.Point(620, 84);
            this.TomorrowTmax.Name = "TomorrowTmax";
            this.TomorrowTmax.Size = new System.Drawing.Size(19, 21);
            this.TomorrowTmax.TabIndex = 12;
            this.TomorrowTmax.Text = "0";
            this.TomorrowTmax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel13.Location = new System.Drawing.Point(592, 63);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(78, 21);
            this.metroLabel13.TabIndex = 11;
            this.metroLabel13.Text = "최고 기온";
            // 
            // TemperatureGraph3
            // 
            this.TemperatureGraph3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TemperatureGraph3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.TemperatureGraph3.ClassicFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TemperatureGraph3.ClassicLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TemperatureGraph3.DefaultColor = System.Drawing.Color.White;
            this.TemperatureGraph3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TemperatureGraph3.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.TemperatureGraph3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TemperatureGraph3.HoverBoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TemperatureGraph3.HoverBoxColor = System.Drawing.Color.White;
            this.TemperatureGraph3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TemperatureGraph3.Location = new System.Drawing.Point(212, 22);
            this.TemperatureGraph3.Name = "TemperatureGraph3";
            this.TemperatureGraph3.SidePadding = true;
            this.TemperatureGraph3.SingleLine = true;
            this.TemperatureGraph3.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TemperatureGraph3.Size = new System.Drawing.Size(277, 218);
            this.TemperatureGraph3.TabIndex = 6;
            this.TemperatureGraph3.Text = "metroGraph1";
            // 
            // WeatherIcon2
            // 
            this.WeatherIcon2.Location = new System.Drawing.Point(6, 22);
            this.WeatherIcon2.Name = "WeatherIcon2";
            this.WeatherIcon2.Size = new System.Drawing.Size(200, 200);
            this.WeatherIcon2.TabIndex = 4;
            this.WeatherIcon2.TabStop = false;
            // 
            // WeatherExplain2
            // 
            this.WeatherExplain2.AutoSize = true;
            this.WeatherExplain2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WeatherExplain2.Location = new System.Drawing.Point(82, 225);
            this.WeatherExplain2.Name = "WeatherExplain2";
            this.WeatherExplain2.Size = new System.Drawing.Size(49, 21);
            this.WeatherExplain2.TabIndex = 5;
            this.WeatherExplain2.Text = "NULL";
            this.WeatherExplain2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TemperatureGraph1);
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 264);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "기온 요약 (오늘~모레)";
            // 
            // TemperatureGraph1
            // 
            this.TemperatureGraph1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TemperatureGraph1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.TemperatureGraph1.ClassicFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TemperatureGraph1.ClassicLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TemperatureGraph1.DefaultColor = System.Drawing.Color.White;
            this.TemperatureGraph1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TemperatureGraph1.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.TemperatureGraph1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TemperatureGraph1.HoverBoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TemperatureGraph1.HoverBoxColor = System.Drawing.Color.White;
            this.TemperatureGraph1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TemperatureGraph1.Location = new System.Drawing.Point(6, 22);
            this.TemperatureGraph1.Name = "TemperatureGraph1";
            this.TemperatureGraph1.SidePadding = true;
            this.TemperatureGraph1.SingleLine = true;
            this.TemperatureGraph1.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TemperatureGraph1.Size = new System.Drawing.Size(777, 236);
            this.TemperatureGraph1.TabIndex = 2;
            this.TemperatureGraph1.Text = "metroGraph1";
            // 
            // Current1MinutelyWeather
            // 
            this.Current1MinutelyWeather.AutoScroll = true;
            this.Current1MinutelyWeather.BackColor = System.Drawing.Color.Transparent;
            this.Current1MinutelyWeather.Controls.Add(this.CurrentHumidity);
            this.Current1MinutelyWeather.Controls.Add(this.metroLabel6);
            this.Current1MinutelyWeather.Controls.Add(this.metroLabel1);
            this.Current1MinutelyWeather.Controls.Add(this.CurrentHumidityPercent);
            this.Current1MinutelyWeather.Controls.Add(this.CurrentTCurrent);
            this.Current1MinutelyWeather.Controls.Add(this.metroLabel16);
            this.Current1MinutelyWeather.Controls.Add(this.last24hour);
            this.Current1MinutelyWeather.Controls.Add(this.last12hour);
            this.Current1MinutelyWeather.Controls.Add(this.metroLabel28);
            this.Current1MinutelyWeather.Controls.Add(this.metroLabel14);
            this.Current1MinutelyWeather.Controls.Add(this.last1hour);
            this.Current1MinutelyWeather.Controls.Add(this.metroLabel30);
            this.Current1MinutelyWeather.Controls.Add(this.metroLabel26);
            this.Current1MinutelyWeather.Controls.Add(this.last6hour);
            this.Current1MinutelyWeather.Controls.Add(this.last30min);
            this.Current1MinutelyWeather.Controls.Add(this.metroLabel24);
            this.Current1MinutelyWeather.Controls.Add(this.last15min);
            this.Current1MinutelyWeather.Controls.Add(this.metroLabel22);
            this.Current1MinutelyWeather.Controls.Add(this.last10min);
            this.Current1MinutelyWeather.Controls.Add(this.metroLabel20);
            this.Current1MinutelyWeather.Controls.Add(this.SinceMidNight);
            this.Current1MinutelyWeather.Controls.Add(this.mertolabel14);
            this.Current1MinutelyWeather.Controls.Add(this.CurrentRainGraph);
            this.Current1MinutelyWeather.Controls.Add(this.CurrentTmin);
            this.Current1MinutelyWeather.Controls.Add(this.metroLabel3);
            this.Current1MinutelyWeather.Controls.Add(this.CurrentTMax);
            this.Current1MinutelyWeather.Controls.Add(this.metroLabel7);
            this.Current1MinutelyWeather.Controls.Add(this.CurrentTemperatureGraph);
            this.Current1MinutelyWeather.Controls.Add(this.CurrentWeatherIcon);
            this.Current1MinutelyWeather.Controls.Add(this.CurrentWeatherExplain);
            this.Current1MinutelyWeather.Controls.Add(this.ReleaseTime1);
            this.Current1MinutelyWeather.Controls.Add(this.metroLabel2);
            this.Current1MinutelyWeather.Location = new System.Drawing.Point(4, 49);
            this.Current1MinutelyWeather.Name = "Current1MinutelyWeather";
            this.Current1MinutelyWeather.Padding = new System.Windows.Forms.Padding(3);
            this.Current1MinutelyWeather.Size = new System.Drawing.Size(818, 519);
            this.Current1MinutelyWeather.TabIndex = 0;
            this.Current1MinutelyWeather.Text = "현재 날씨";
            // 
            // CurrentHumidity
            // 
            this.CurrentHumidity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CurrentHumidity.Location = new System.Drawing.Point(504, 837);
            this.CurrentHumidity.Name = "CurrentHumidity";
            this.CurrentHumidity.Size = new System.Drawing.Size(291, 21);
            this.CurrentHumidity.TabIndex = 43;
            this.CurrentHumidity.Text = "0";
            this.CurrentHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel6.Location = new System.Drawing.Point(138, 258);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(237, 21);
            this.metroLabel6.TabIndex = 41;
            this.metroLabel6.Text = "지난 10분 ~ 24시간 누적 강우량";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel1.Location = new System.Drawing.Point(611, 630);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 21);
            this.metroLabel1.TabIndex = 40;
            this.metroLabel1.Text = "상대 습도";
            // 
            // CurrentHumidityPercent
            // 
            this.CurrentHumidityPercent.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CurrentHumidityPercent.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.CurrentHumidityPercent.ForeColor = System.Drawing.Color.White;
            this.CurrentHumidityPercent.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CurrentHumidityPercent.InnerCircleSize = 135;
            this.CurrentHumidityPercent.Location = new System.Drawing.Point(562, 654);
            this.CurrentHumidityPercent.Name = "CurrentHumidityPercent";
            this.CurrentHumidityPercent.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CurrentHumidityPercent.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(116)))), ((int)(((byte)(178)))));
            this.CurrentHumidityPercent.Size = new System.Drawing.Size(180, 180);
            this.CurrentHumidityPercent.TabIndex = 39;
            // 
            // CurrentTCurrent
            // 
            this.CurrentTCurrent.AutoSize = true;
            this.CurrentTCurrent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CurrentTCurrent.Location = new System.Drawing.Point(642, 133);
            this.CurrentTCurrent.Name = "CurrentTCurrent";
            this.CurrentTCurrent.Size = new System.Drawing.Size(19, 21);
            this.CurrentTCurrent.TabIndex = 38;
            this.CurrentTCurrent.Text = "0";
            this.CurrentTCurrent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel16.Location = new System.Drawing.Point(614, 112);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(78, 21);
            this.metroLabel16.TabIndex = 37;
            this.metroLabel16.Text = "현재 기온";
            // 
            // last24hour
            // 
            this.last24hour.AutoSize = true;
            this.last24hour.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.last24hour.Location = new System.Drawing.Point(642, 597);
            this.last24hour.Name = "last24hour";
            this.last24hour.Size = new System.Drawing.Size(19, 21);
            this.last24hour.TabIndex = 36;
            this.last24hour.Text = "0";
            this.last24hour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // last12hour
            // 
            this.last12hour.AutoSize = true;
            this.last12hour.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.last12hour.Location = new System.Drawing.Point(642, 555);
            this.last12hour.Name = "last12hour";
            this.last12hour.Size = new System.Drawing.Size(19, 21);
            this.last12hour.TabIndex = 34;
            this.last12hour.Text = "0";
            this.last12hour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel28
            // 
            this.metroLabel28.AutoSize = true;
            this.metroLabel28.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel28.Location = new System.Drawing.Point(541, 492);
            this.metroLabel28.Name = "metroLabel28";
            this.metroLabel28.Size = new System.Drawing.Size(207, 21);
            this.metroLabel28.TabIndex = 31;
            this.metroLabel28.Text = "지난6시간 이동 누적 강우량";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel14.Location = new System.Drawing.Point(541, 576);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(216, 21);
            this.metroLabel14.TabIndex = 35;
            this.metroLabel14.Text = "지난24시간 이동 누적 강우량";
            // 
            // last1hour
            // 
            this.last1hour.AutoSize = true;
            this.last1hour.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.last1hour.Location = new System.Drawing.Point(642, 471);
            this.last1hour.Name = "last1hour";
            this.last1hour.Size = new System.Drawing.Size(19, 21);
            this.last1hour.TabIndex = 30;
            this.last1hour.Text = "0";
            this.last1hour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel30
            // 
            this.metroLabel30.AutoSize = true;
            this.metroLabel30.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel30.Location = new System.Drawing.Point(541, 534);
            this.metroLabel30.Name = "metroLabel30";
            this.metroLabel30.Size = new System.Drawing.Size(216, 21);
            this.metroLabel30.TabIndex = 33;
            this.metroLabel30.Text = "지난12시간 이동 누적 강우량";
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel26.Location = new System.Drawing.Point(541, 450);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(207, 21);
            this.metroLabel26.TabIndex = 29;
            this.metroLabel26.Text = "지난1시간 이동 누적 강우량";
            // 
            // last6hour
            // 
            this.last6hour.AutoSize = true;
            this.last6hour.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.last6hour.Location = new System.Drawing.Point(642, 513);
            this.last6hour.Name = "last6hour";
            this.last6hour.Size = new System.Drawing.Size(19, 21);
            this.last6hour.TabIndex = 32;
            this.last6hour.Text = "0";
            this.last6hour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // last30min
            // 
            this.last30min.AutoSize = true;
            this.last30min.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.last30min.Location = new System.Drawing.Point(642, 429);
            this.last30min.Name = "last30min";
            this.last30min.Size = new System.Drawing.Size(19, 21);
            this.last30min.TabIndex = 28;
            this.last30min.Text = "0";
            this.last30min.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel24.Location = new System.Drawing.Point(541, 408);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(204, 21);
            this.metroLabel24.TabIndex = 27;
            this.metroLabel24.Text = "지난 30분 이동 누적 강우량";
            // 
            // last15min
            // 
            this.last15min.AutoSize = true;
            this.last15min.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.last15min.Location = new System.Drawing.Point(642, 387);
            this.last15min.Name = "last15min";
            this.last15min.Size = new System.Drawing.Size(19, 21);
            this.last15min.TabIndex = 26;
            this.last15min.Text = "0";
            this.last15min.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel22.Location = new System.Drawing.Point(541, 366);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(204, 21);
            this.metroLabel22.TabIndex = 25;
            this.metroLabel22.Text = "지난 15분 이동 누적 강우량";
            // 
            // last10min
            // 
            this.last10min.AutoSize = true;
            this.last10min.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.last10min.Location = new System.Drawing.Point(642, 345);
            this.last10min.Name = "last10min";
            this.last10min.Size = new System.Drawing.Size(19, 21);
            this.last10min.TabIndex = 24;
            this.last10min.Text = "0";
            this.last10min.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel20.Location = new System.Drawing.Point(541, 324);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(204, 21);
            this.metroLabel20.TabIndex = 23;
            this.metroLabel20.Text = "지난 10분 이동 누적 강우량";
            // 
            // SinceMidNight
            // 
            this.SinceMidNight.AutoSize = true;
            this.SinceMidNight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SinceMidNight.Location = new System.Drawing.Point(642, 303);
            this.SinceMidNight.Name = "SinceMidNight";
            this.SinceMidNight.Size = new System.Drawing.Size(19, 21);
            this.SinceMidNight.TabIndex = 20;
            this.SinceMidNight.Text = "0";
            this.SinceMidNight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mertolabel14
            // 
            this.mertolabel14.AutoSize = true;
            this.mertolabel14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mertolabel14.Location = new System.Drawing.Point(595, 282);
            this.mertolabel14.Name = "mertolabel14";
            this.mertolabel14.Size = new System.Drawing.Size(114, 21);
            this.mertolabel14.TabIndex = 19;
            this.mertolabel14.Text = "일 누적 강수량";
            // 
            // CurrentRainGraph
            // 
            this.CurrentRainGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CurrentRainGraph.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.CurrentRainGraph.ClassicFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CurrentRainGraph.ClassicLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CurrentRainGraph.DefaultColor = System.Drawing.Color.White;
            this.CurrentRainGraph.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CurrentRainGraph.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.CurrentRainGraph.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CurrentRainGraph.HoverBoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CurrentRainGraph.HoverBoxColor = System.Drawing.Color.White;
            this.CurrentRainGraph.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CurrentRainGraph.Location = new System.Drawing.Point(6, 282);
            this.CurrentRainGraph.Name = "CurrentRainGraph";
            this.CurrentRainGraph.SidePadding = true;
            this.CurrentRainGraph.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CurrentRainGraph.Size = new System.Drawing.Size(483, 330);
            this.CurrentRainGraph.TabIndex = 18;
            this.CurrentRainGraph.Text = "metroGraph2";
            // 
            // CurrentTmin
            // 
            this.CurrentTmin.AutoSize = true;
            this.CurrentTmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CurrentTmin.Location = new System.Drawing.Point(642, 193);
            this.CurrentTmin.Name = "CurrentTmin";
            this.CurrentTmin.Size = new System.Drawing.Size(19, 21);
            this.CurrentTmin.TabIndex = 17;
            this.CurrentTmin.Text = "0";
            this.CurrentTmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel3.Location = new System.Drawing.Point(614, 172);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 21);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "최저 온도";
            // 
            // CurrentTMax
            // 
            this.CurrentTMax.AutoSize = true;
            this.CurrentTMax.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CurrentTMax.Location = new System.Drawing.Point(642, 76);
            this.CurrentTMax.Name = "CurrentTMax";
            this.CurrentTMax.Size = new System.Drawing.Size(19, 21);
            this.CurrentTMax.TabIndex = 15;
            this.CurrentTMax.Text = "0";
            this.CurrentTMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel7.Location = new System.Drawing.Point(614, 55);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(78, 21);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "최고 기온";
            // 
            // CurrentTemperatureGraph
            // 
            this.CurrentTemperatureGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CurrentTemperatureGraph.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.CurrentTemperatureGraph.ClassicFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CurrentTemperatureGraph.ClassicLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CurrentTemperatureGraph.DefaultColor = System.Drawing.Color.White;
            this.CurrentTemperatureGraph.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CurrentTemperatureGraph.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.CurrentTemperatureGraph.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CurrentTemperatureGraph.HoverBoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CurrentTemperatureGraph.HoverBoxColor = System.Drawing.Color.White;
            this.CurrentTemperatureGraph.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CurrentTemperatureGraph.Location = new System.Drawing.Point(212, 27);
            this.CurrentTemperatureGraph.Name = "CurrentTemperatureGraph";
            this.CurrentTemperatureGraph.SidePadding = true;
            this.CurrentTemperatureGraph.SingleLine = true;
            this.CurrentTemperatureGraph.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CurrentTemperatureGraph.Size = new System.Drawing.Size(277, 218);
            this.CurrentTemperatureGraph.TabIndex = 13;
            this.CurrentTemperatureGraph.Text = "metroGraph1";
            // 
            // CurrentWeatherIcon
            // 
            this.CurrentWeatherIcon.Location = new System.Drawing.Point(6, 27);
            this.CurrentWeatherIcon.Name = "CurrentWeatherIcon";
            this.CurrentWeatherIcon.Size = new System.Drawing.Size(200, 200);
            this.CurrentWeatherIcon.TabIndex = 11;
            this.CurrentWeatherIcon.TabStop = false;
            // 
            // CurrentWeatherExplain
            // 
            this.CurrentWeatherExplain.AutoSize = true;
            this.CurrentWeatherExplain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CurrentWeatherExplain.Location = new System.Drawing.Point(82, 230);
            this.CurrentWeatherExplain.Name = "CurrentWeatherExplain";
            this.CurrentWeatherExplain.Size = new System.Drawing.Size(49, 21);
            this.CurrentWeatherExplain.TabIndex = 12;
            this.CurrentWeatherExplain.Text = "NULL";
            this.CurrentWeatherExplain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReleaseTime1
            // 
            this.ReleaseTime1.AutoSize = true;
            this.ReleaseTime1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ReleaseTime1.Location = new System.Drawing.Point(97, 3);
            this.ReleaseTime1.Name = "ReleaseTime1";
            this.ReleaseTime1.Size = new System.Drawing.Size(19, 21);
            this.ReleaseTime1.TabIndex = 10;
            this.ReleaseTime1.Text = "0";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel2.Location = new System.Drawing.Point(6, 3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 21);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "관측 시간 :";
            // 
            // Forecast3HourlyWeather
            // 
            this.Forecast3HourlyWeather.AutoScroll = true;
            this.Forecast3HourlyWeather.Controls.Add(this.FourHourWeatherIcon);
            this.Forecast3HourlyWeather.Controls.Add(this.FourHourWeatherExplain);
            this.Forecast3HourlyWeather.Controls.Add(this.FourHourHumidity);
            this.Forecast3HourlyWeather.Controls.Add(this.metroLabel27);
            this.Forecast3HourlyWeather.Controls.Add(this.FourHourHumidityPercent);
            this.Forecast3HourlyWeather.Controls.Add(this.FourHourTemperature);
            this.Forecast3HourlyWeather.Controls.Add(this.metroLabel19);
            this.Forecast3HourlyWeather.Controls.Add(this.ThreeHourHumidity);
            this.Forecast3HourlyWeather.Controls.Add(this.metroLabel33);
            this.Forecast3HourlyWeather.Controls.Add(this.ThreeHourHumidityPercent);
            this.Forecast3HourlyWeather.Controls.Add(this.TwoHourHumidity);
            this.Forecast3HourlyWeather.Controls.Add(this.metroLabel31);
            this.Forecast3HourlyWeather.Controls.Add(this.TwoHourHumidityPercent);
            this.Forecast3HourlyWeather.Controls.Add(this.OneHourHumidity);
            this.Forecast3HourlyWeather.Controls.Add(this.metroLabel23);
            this.Forecast3HourlyWeather.Controls.Add(this.OneHourHumidityPercent);
            this.Forecast3HourlyWeather.Controls.Add(this.ThreeHourTemperature);
            this.Forecast3HourlyWeather.Controls.Add(this.metroLabel18);
            this.Forecast3HourlyWeather.Controls.Add(this.TwoHourTemperature);
            this.Forecast3HourlyWeather.Controls.Add(this.metroLabel25);
            this.Forecast3HourlyWeather.Controls.Add(this.OneHourTemperature);
            this.Forecast3HourlyWeather.Controls.Add(this.metroLabel29);
            this.Forecast3HourlyWeather.Controls.Add(this.HourTemperatureGraph);
            this.Forecast3HourlyWeather.Controls.Add(this.metroLabel8);
            this.Forecast3HourlyWeather.Controls.Add(this.TwoHourWeatherExplain);
            this.Forecast3HourlyWeather.Controls.Add(this.ReleaseTime2);
            this.Forecast3HourlyWeather.Controls.Add(this.OneHourWeatherExplain);
            this.Forecast3HourlyWeather.Controls.Add(this.metroLabel21);
            this.Forecast3HourlyWeather.Controls.Add(this.TwoHourWeatherIcon);
            this.Forecast3HourlyWeather.Controls.Add(this.ThreeHourWeatherIcon);
            this.Forecast3HourlyWeather.Controls.Add(this.OneHourWeatherIcon);
            this.Forecast3HourlyWeather.Controls.Add(this.ThreeHourWeatherExplain);
            this.Forecast3HourlyWeather.Location = new System.Drawing.Point(4, 49);
            this.Forecast3HourlyWeather.Name = "Forecast3HourlyWeather";
            this.Forecast3HourlyWeather.Size = new System.Drawing.Size(818, 519);
            this.Forecast3HourlyWeather.TabIndex = 3;
            this.Forecast3HourlyWeather.Text = "초단기 예보";
            this.Forecast3HourlyWeather.UseVisualStyleBackColor = true;
            // 
            // FourHourWeatherIcon
            // 
            this.FourHourWeatherIcon.Location = new System.Drawing.Point(611, 48);
            this.FourHourWeatherIcon.Name = "FourHourWeatherIcon";
            this.FourHourWeatherIcon.Size = new System.Drawing.Size(180, 180);
            this.FourHourWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FourHourWeatherIcon.TabIndex = 58;
            this.FourHourWeatherIcon.TabStop = false;
            // 
            // FourHourWeatherExplain
            // 
            this.FourHourWeatherExplain.AutoSize = true;
            this.FourHourWeatherExplain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FourHourWeatherExplain.Location = new System.Drawing.Point(677, 231);
            this.FourHourWeatherExplain.Name = "FourHourWeatherExplain";
            this.FourHourWeatherExplain.Size = new System.Drawing.Size(49, 21);
            this.FourHourWeatherExplain.TabIndex = 59;
            this.FourHourWeatherExplain.Text = "NULL";
            this.FourHourWeatherExplain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FourHourHumidity
            // 
            this.FourHourHumidity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FourHourHumidity.Location = new System.Drawing.Point(618, 751);
            this.FourHourHumidity.Name = "FourHourHumidity";
            this.FourHourHumidity.Size = new System.Drawing.Size(180, 21);
            this.FourHourHumidity.TabIndex = 57;
            this.FourHourHumidity.Text = "0";
            this.FourHourHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel27.Location = new System.Drawing.Point(637, 544);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(143, 21);
            this.metroLabel27.TabIndex = 56;
            this.metroLabel27.Text = "4시간 후 상대 습도";
            // 
            // FourHourHumidityPercent
            // 
            this.FourHourHumidityPercent.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FourHourHumidityPercent.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.FourHourHumidityPercent.ForeColor = System.Drawing.Color.White;
            this.FourHourHumidityPercent.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.FourHourHumidityPercent.InnerCircleSize = 135;
            this.FourHourHumidityPercent.Location = new System.Drawing.Point(618, 568);
            this.FourHourHumidityPercent.Name = "FourHourHumidityPercent";
            this.FourHourHumidityPercent.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FourHourHumidityPercent.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(116)))), ((int)(((byte)(178)))));
            this.FourHourHumidityPercent.Size = new System.Drawing.Size(180, 180);
            this.FourHourHumidityPercent.TabIndex = 55;
            this.FourHourHumidityPercent.Value = 100;
            // 
            // FourHourTemperature
            // 
            this.FourHourTemperature.AutoSize = true;
            this.FourHourTemperature.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FourHourTemperature.Location = new System.Drawing.Point(663, 494);
            this.FourHourTemperature.Name = "FourHourTemperature";
            this.FourHourTemperature.Size = new System.Drawing.Size(19, 21);
            this.FourHourTemperature.TabIndex = 54;
            this.FourHourTemperature.Text = "0";
            this.FourHourTemperature.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel19.Location = new System.Drawing.Point(637, 473);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(107, 21);
            this.metroLabel19.TabIndex = 53;
            this.metroLabel19.Text = "4시간 후 기온";
            this.metroLabel19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ThreeHourHumidity
            // 
            this.ThreeHourHumidity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ThreeHourHumidity.Location = new System.Drawing.Point(416, 751);
            this.ThreeHourHumidity.Name = "ThreeHourHumidity";
            this.ThreeHourHumidity.Size = new System.Drawing.Size(180, 21);
            this.ThreeHourHumidity.TabIndex = 52;
            this.ThreeHourHumidity.Text = "0";
            this.ThreeHourHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel33
            // 
            this.metroLabel33.AutoSize = true;
            this.metroLabel33.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel33.Location = new System.Drawing.Point(435, 544);
            this.metroLabel33.Name = "metroLabel33";
            this.metroLabel33.Size = new System.Drawing.Size(143, 21);
            this.metroLabel33.TabIndex = 51;
            this.metroLabel33.Text = "3시간 후 상대 습도";
            // 
            // ThreeHourHumidityPercent
            // 
            this.ThreeHourHumidityPercent.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ThreeHourHumidityPercent.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.ThreeHourHumidityPercent.ForeColor = System.Drawing.Color.White;
            this.ThreeHourHumidityPercent.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ThreeHourHumidityPercent.InnerCircleSize = 135;
            this.ThreeHourHumidityPercent.Location = new System.Drawing.Point(416, 568);
            this.ThreeHourHumidityPercent.Name = "ThreeHourHumidityPercent";
            this.ThreeHourHumidityPercent.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ThreeHourHumidityPercent.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(116)))), ((int)(((byte)(178)))));
            this.ThreeHourHumidityPercent.Size = new System.Drawing.Size(180, 180);
            this.ThreeHourHumidityPercent.TabIndex = 50;
            this.ThreeHourHumidityPercent.Value = 100;
            // 
            // TwoHourHumidity
            // 
            this.TwoHourHumidity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TwoHourHumidity.Location = new System.Drawing.Point(205, 751);
            this.TwoHourHumidity.Name = "TwoHourHumidity";
            this.TwoHourHumidity.Size = new System.Drawing.Size(180, 21);
            this.TwoHourHumidity.TabIndex = 49;
            this.TwoHourHumidity.Text = "0";
            this.TwoHourHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel31
            // 
            this.metroLabel31.AutoSize = true;
            this.metroLabel31.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel31.Location = new System.Drawing.Point(227, 544);
            this.metroLabel31.Name = "metroLabel31";
            this.metroLabel31.Size = new System.Drawing.Size(143, 21);
            this.metroLabel31.TabIndex = 48;
            this.metroLabel31.Text = "2시간 후 상대 습도";
            // 
            // TwoHourHumidityPercent
            // 
            this.TwoHourHumidityPercent.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TwoHourHumidityPercent.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.TwoHourHumidityPercent.ForeColor = System.Drawing.Color.White;
            this.TwoHourHumidityPercent.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TwoHourHumidityPercent.InnerCircleSize = 135;
            this.TwoHourHumidityPercent.Location = new System.Drawing.Point(205, 568);
            this.TwoHourHumidityPercent.Name = "TwoHourHumidityPercent";
            this.TwoHourHumidityPercent.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TwoHourHumidityPercent.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(116)))), ((int)(((byte)(178)))));
            this.TwoHourHumidityPercent.Size = new System.Drawing.Size(180, 180);
            this.TwoHourHumidityPercent.TabIndex = 47;
            this.TwoHourHumidityPercent.Value = 100;
            // 
            // OneHourHumidity
            // 
            this.OneHourHumidity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OneHourHumidity.Location = new System.Drawing.Point(3, 751);
            this.OneHourHumidity.Name = "OneHourHumidity";
            this.OneHourHumidity.Size = new System.Drawing.Size(180, 21);
            this.OneHourHumidity.TabIndex = 46;
            this.OneHourHumidity.Text = "0";
            this.OneHourHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel23.Location = new System.Drawing.Point(23, 544);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(143, 21);
            this.metroLabel23.TabIndex = 45;
            this.metroLabel23.Text = "1시간 후 상대 습도";
            // 
            // OneHourHumidityPercent
            // 
            this.OneHourHumidityPercent.CircleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OneHourHumidityPercent.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.OneHourHumidityPercent.ForeColor = System.Drawing.Color.White;
            this.OneHourHumidityPercent.InnerCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.OneHourHumidityPercent.InnerCircleSize = 135;
            this.OneHourHumidityPercent.Location = new System.Drawing.Point(3, 568);
            this.OneHourHumidityPercent.Name = "OneHourHumidityPercent";
            this.OneHourHumidityPercent.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OneHourHumidityPercent.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(116)))), ((int)(((byte)(178)))));
            this.OneHourHumidityPercent.Size = new System.Drawing.Size(180, 180);
            this.OneHourHumidityPercent.TabIndex = 44;
            this.OneHourHumidityPercent.Value = 100;
            // 
            // ThreeHourTemperature
            // 
            this.ThreeHourTemperature.AutoSize = true;
            this.ThreeHourTemperature.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ThreeHourTemperature.Location = new System.Drawing.Point(663, 432);
            this.ThreeHourTemperature.Name = "ThreeHourTemperature";
            this.ThreeHourTemperature.Size = new System.Drawing.Size(19, 21);
            this.ThreeHourTemperature.TabIndex = 32;
            this.ThreeHourTemperature.Text = "0";
            this.ThreeHourTemperature.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel18.Location = new System.Drawing.Point(637, 411);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(107, 21);
            this.metroLabel18.TabIndex = 31;
            this.metroLabel18.Text = "3시간 후 기온";
            this.metroLabel18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TwoHourTemperature
            // 
            this.TwoHourTemperature.AutoSize = true;
            this.TwoHourTemperature.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TwoHourTemperature.Location = new System.Drawing.Point(663, 365);
            this.TwoHourTemperature.Name = "TwoHourTemperature";
            this.TwoHourTemperature.Size = new System.Drawing.Size(19, 21);
            this.TwoHourTemperature.TabIndex = 30;
            this.TwoHourTemperature.Text = "0";
            this.TwoHourTemperature.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel25.Location = new System.Drawing.Point(637, 344);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(107, 21);
            this.metroLabel25.TabIndex = 29;
            this.metroLabel25.Text = "2시간 후 기온";
            this.metroLabel25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OneHourTemperature
            // 
            this.OneHourTemperature.AutoSize = true;
            this.OneHourTemperature.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OneHourTemperature.Location = new System.Drawing.Point(663, 298);
            this.OneHourTemperature.Name = "OneHourTemperature";
            this.OneHourTemperature.Size = new System.Drawing.Size(19, 21);
            this.OneHourTemperature.TabIndex = 28;
            this.OneHourTemperature.Text = "0";
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel29.Location = new System.Drawing.Point(637, 277);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(107, 21);
            this.metroLabel29.TabIndex = 27;
            this.metroLabel29.Text = "1시간 후 기온";
            // 
            // HourTemperatureGraph
            // 
            this.HourTemperatureGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HourTemperatureGraph.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.HourTemperatureGraph.ClassicFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.HourTemperatureGraph.ClassicLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.HourTemperatureGraph.DefaultColor = System.Drawing.Color.White;
            this.HourTemperatureGraph.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HourTemperatureGraph.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.HourTemperatureGraph.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.HourTemperatureGraph.HoverBoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.HourTemperatureGraph.HoverBoxColor = System.Drawing.Color.White;
            this.HourTemperatureGraph.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HourTemperatureGraph.Location = new System.Drawing.Point(10, 277);
            this.HourTemperatureGraph.Name = "HourTemperatureGraph";
            this.HourTemperatureGraph.SidePadding = true;
            this.HourTemperatureGraph.SingleLine = true;
            this.HourTemperatureGraph.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.HourTemperatureGraph.Size = new System.Drawing.Size(554, 264);
            this.HourTemperatureGraph.TabIndex = 17;
            this.HourTemperatureGraph.Text = "metroGraph1";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel8.Location = new System.Drawing.Point(6, 24);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(182, 21);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "1~3시간 후 (1시간 간격)";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TwoHourWeatherExplain
            // 
            this.TwoHourWeatherExplain.AutoSize = true;
            this.TwoHourWeatherExplain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TwoHourWeatherExplain.Location = new System.Drawing.Point(274, 231);
            this.TwoHourWeatherExplain.Name = "TwoHourWeatherExplain";
            this.TwoHourWeatherExplain.Size = new System.Drawing.Size(49, 21);
            this.TwoHourWeatherExplain.TabIndex = 7;
            this.TwoHourWeatherExplain.Text = "NULL";
            this.TwoHourWeatherExplain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReleaseTime2
            // 
            this.ReleaseTime2.AutoSize = true;
            this.ReleaseTime2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ReleaseTime2.Location = new System.Drawing.Point(97, 3);
            this.ReleaseTime2.Name = "ReleaseTime2";
            this.ReleaseTime2.Size = new System.Drawing.Size(19, 21);
            this.ReleaseTime2.TabIndex = 15;
            this.ReleaseTime2.Text = "0";
            // 
            // OneHourWeatherExplain
            // 
            this.OneHourWeatherExplain.AutoSize = true;
            this.OneHourWeatherExplain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OneHourWeatherExplain.Location = new System.Drawing.Point(72, 231);
            this.OneHourWeatherExplain.Name = "OneHourWeatherExplain";
            this.OneHourWeatherExplain.Size = new System.Drawing.Size(49, 21);
            this.OneHourWeatherExplain.TabIndex = 5;
            this.OneHourWeatherExplain.Text = "NULL";
            this.OneHourWeatherExplain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel21.Location = new System.Drawing.Point(6, 3);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(85, 21);
            this.metroLabel21.TabIndex = 14;
            this.metroLabel21.Text = "관측 시간 :";
            // 
            // TwoHourWeatherIcon
            // 
            this.TwoHourWeatherIcon.Location = new System.Drawing.Point(210, 48);
            this.TwoHourWeatherIcon.Name = "TwoHourWeatherIcon";
            this.TwoHourWeatherIcon.Size = new System.Drawing.Size(180, 180);
            this.TwoHourWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TwoHourWeatherIcon.TabIndex = 6;
            this.TwoHourWeatherIcon.TabStop = false;
            // 
            // ThreeHourWeatherIcon
            // 
            this.ThreeHourWeatherIcon.Location = new System.Drawing.Point(411, 48);
            this.ThreeHourWeatherIcon.Name = "ThreeHourWeatherIcon";
            this.ThreeHourWeatherIcon.Size = new System.Drawing.Size(180, 180);
            this.ThreeHourWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThreeHourWeatherIcon.TabIndex = 8;
            this.ThreeHourWeatherIcon.TabStop = false;
            // 
            // OneHourWeatherIcon
            // 
            this.OneHourWeatherIcon.Location = new System.Drawing.Point(10, 48);
            this.OneHourWeatherIcon.Name = "OneHourWeatherIcon";
            this.OneHourWeatherIcon.Size = new System.Drawing.Size(180, 180);
            this.OneHourWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OneHourWeatherIcon.TabIndex = 4;
            this.OneHourWeatherIcon.TabStop = false;
            // 
            // ThreeHourWeatherExplain
            // 
            this.ThreeHourWeatherExplain.AutoSize = true;
            this.ThreeHourWeatherExplain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ThreeHourWeatherExplain.Location = new System.Drawing.Point(478, 231);
            this.ThreeHourWeatherExplain.Name = "ThreeHourWeatherExplain";
            this.ThreeHourWeatherExplain.Size = new System.Drawing.Size(49, 21);
            this.ThreeHourWeatherExplain.TabIndex = 9;
            this.ThreeHourWeatherExplain.Text = "NULL";
            this.ThreeHourWeatherExplain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Forecast3DaysWeather
            // 
            this.Forecast3DaysWeather.AutoScroll = true;
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity22);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity21);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity20);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity19);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity18);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity17);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity16);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity15);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity14);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity13);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity12);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity11);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity10);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity9);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity8);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity7);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity6);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity5);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity4);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity2);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity3);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidity1);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel85);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel86);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel87);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel88);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel89);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel90);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel91);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel92);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel93);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel94);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel95);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel96);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel97);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel98);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel99);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel100);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel101);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel102);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel103);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel104);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel105);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel106);
            this.Forecast3DaysWeather.Controls.Add(this.ShortHumidityGraph);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel69);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel70);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel71);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTMin3);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTMin2);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTMin1);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTMax3);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel61);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTMax2);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel59);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTMax1);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel57);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTGraph);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature22);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature21);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature20);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature19);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature18);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature17);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature16);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature15);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature14);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature13);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature12);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature11);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature10);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature9);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature8);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature7);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature6);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature5);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature4);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature2);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature3);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperature1);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel56);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel55);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel54);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel53);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel52);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel51);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel50);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel49);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel48);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel47);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel46);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel45);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel44);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel43);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel42);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel41);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel40);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel39);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel38);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel36);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel34);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel12);
            this.Forecast3DaysWeather.Controls.Add(this.ShortTemperatureGraph);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain22);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain21);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain20);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain19);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain18);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain17);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain2);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain3);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain4);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain5);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain7);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain6);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain8);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain9);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain10);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain11);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain12);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain13);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain14);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain15);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain16);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon17);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon18);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon20);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon21);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon22);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon19);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon16);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon7);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon8);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon9);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon15);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon14);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon13);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon12);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon11);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon6);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon10);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon5);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon4);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel32);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherExplain1);
            this.Forecast3DaysWeather.Controls.Add(this.ReleaseTime3);
            this.Forecast3DaysWeather.Controls.Add(this.metroLabel37);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon2);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon3);
            this.Forecast3DaysWeather.Controls.Add(this.ShortWeatherIcon1);
            this.Forecast3DaysWeather.Location = new System.Drawing.Point(4, 49);
            this.Forecast3DaysWeather.Name = "Forecast3DaysWeather";
            this.Forecast3DaysWeather.Size = new System.Drawing.Size(818, 519);
            this.Forecast3DaysWeather.TabIndex = 4;
            this.Forecast3DaysWeather.Text = "단기 예보";
            this.Forecast3DaysWeather.UseVisualStyleBackColor = true;
            // 
            // ShortHumidity22
            // 
            this.ShortHumidity22.AutoSize = true;
            this.ShortHumidity22.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity22.Location = new System.Drawing.Point(657, 1659);
            this.ShortHumidity22.Name = "ShortHumidity22";
            this.ShortHumidity22.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity22.TabIndex = 240;
            this.ShortHumidity22.Text = "0";
            this.ShortHumidity22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity21
            // 
            this.ShortHumidity21.AutoSize = true;
            this.ShortHumidity21.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity21.Location = new System.Drawing.Point(657, 1638);
            this.ShortHumidity21.Name = "ShortHumidity21";
            this.ShortHumidity21.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity21.TabIndex = 239;
            this.ShortHumidity21.Text = "0";
            this.ShortHumidity21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity20
            // 
            this.ShortHumidity20.AutoSize = true;
            this.ShortHumidity20.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity20.Location = new System.Drawing.Point(657, 1617);
            this.ShortHumidity20.Name = "ShortHumidity20";
            this.ShortHumidity20.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity20.TabIndex = 238;
            this.ShortHumidity20.Text = "0";
            this.ShortHumidity20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity19
            // 
            this.ShortHumidity19.AutoSize = true;
            this.ShortHumidity19.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity19.Location = new System.Drawing.Point(657, 1596);
            this.ShortHumidity19.Name = "ShortHumidity19";
            this.ShortHumidity19.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity19.TabIndex = 237;
            this.ShortHumidity19.Text = "0";
            this.ShortHumidity19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity18
            // 
            this.ShortHumidity18.AutoSize = true;
            this.ShortHumidity18.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity18.Location = new System.Drawing.Point(657, 1575);
            this.ShortHumidity18.Name = "ShortHumidity18";
            this.ShortHumidity18.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity18.TabIndex = 236;
            this.ShortHumidity18.Text = "0";
            this.ShortHumidity18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity17
            // 
            this.ShortHumidity17.AutoSize = true;
            this.ShortHumidity17.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity17.Location = new System.Drawing.Point(657, 1554);
            this.ShortHumidity17.Name = "ShortHumidity17";
            this.ShortHumidity17.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity17.TabIndex = 235;
            this.ShortHumidity17.Text = "0";
            this.ShortHumidity17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity16
            // 
            this.ShortHumidity16.AutoSize = true;
            this.ShortHumidity16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity16.Location = new System.Drawing.Point(657, 1533);
            this.ShortHumidity16.Name = "ShortHumidity16";
            this.ShortHumidity16.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity16.TabIndex = 234;
            this.ShortHumidity16.Text = "0";
            this.ShortHumidity16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity15
            // 
            this.ShortHumidity15.AutoSize = true;
            this.ShortHumidity15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity15.Location = new System.Drawing.Point(657, 1512);
            this.ShortHumidity15.Name = "ShortHumidity15";
            this.ShortHumidity15.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity15.TabIndex = 233;
            this.ShortHumidity15.Text = "0";
            this.ShortHumidity15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity14
            // 
            this.ShortHumidity14.AutoSize = true;
            this.ShortHumidity14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity14.Location = new System.Drawing.Point(657, 1491);
            this.ShortHumidity14.Name = "ShortHumidity14";
            this.ShortHumidity14.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity14.TabIndex = 232;
            this.ShortHumidity14.Text = "0";
            this.ShortHumidity14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity13
            // 
            this.ShortHumidity13.AutoSize = true;
            this.ShortHumidity13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity13.Location = new System.Drawing.Point(657, 1470);
            this.ShortHumidity13.Name = "ShortHumidity13";
            this.ShortHumidity13.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity13.TabIndex = 231;
            this.ShortHumidity13.Text = "0";
            this.ShortHumidity13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity12
            // 
            this.ShortHumidity12.AutoSize = true;
            this.ShortHumidity12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity12.Location = new System.Drawing.Point(657, 1449);
            this.ShortHumidity12.Name = "ShortHumidity12";
            this.ShortHumidity12.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity12.TabIndex = 230;
            this.ShortHumidity12.Text = "0";
            this.ShortHumidity12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity11
            // 
            this.ShortHumidity11.AutoSize = true;
            this.ShortHumidity11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity11.Location = new System.Drawing.Point(284, 1659);
            this.ShortHumidity11.Name = "ShortHumidity11";
            this.ShortHumidity11.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity11.TabIndex = 229;
            this.ShortHumidity11.Text = "0";
            this.ShortHumidity11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity10
            // 
            this.ShortHumidity10.AutoSize = true;
            this.ShortHumidity10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity10.Location = new System.Drawing.Point(284, 1638);
            this.ShortHumidity10.Name = "ShortHumidity10";
            this.ShortHumidity10.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity10.TabIndex = 228;
            this.ShortHumidity10.Text = "0";
            this.ShortHumidity10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity9
            // 
            this.ShortHumidity9.AutoSize = true;
            this.ShortHumidity9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity9.Location = new System.Drawing.Point(284, 1617);
            this.ShortHumidity9.Name = "ShortHumidity9";
            this.ShortHumidity9.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity9.TabIndex = 227;
            this.ShortHumidity9.Text = "0";
            this.ShortHumidity9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity8
            // 
            this.ShortHumidity8.AutoSize = true;
            this.ShortHumidity8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity8.Location = new System.Drawing.Point(284, 1596);
            this.ShortHumidity8.Name = "ShortHumidity8";
            this.ShortHumidity8.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity8.TabIndex = 226;
            this.ShortHumidity8.Text = "0";
            this.ShortHumidity8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity7
            // 
            this.ShortHumidity7.AutoSize = true;
            this.ShortHumidity7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity7.Location = new System.Drawing.Point(284, 1575);
            this.ShortHumidity7.Name = "ShortHumidity7";
            this.ShortHumidity7.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity7.TabIndex = 225;
            this.ShortHumidity7.Text = "0";
            this.ShortHumidity7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity6
            // 
            this.ShortHumidity6.AutoSize = true;
            this.ShortHumidity6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity6.Location = new System.Drawing.Point(284, 1554);
            this.ShortHumidity6.Name = "ShortHumidity6";
            this.ShortHumidity6.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity6.TabIndex = 224;
            this.ShortHumidity6.Text = "0";
            this.ShortHumidity6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity5
            // 
            this.ShortHumidity5.AutoSize = true;
            this.ShortHumidity5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity5.Location = new System.Drawing.Point(284, 1533);
            this.ShortHumidity5.Name = "ShortHumidity5";
            this.ShortHumidity5.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity5.TabIndex = 223;
            this.ShortHumidity5.Text = "0";
            this.ShortHumidity5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity4
            // 
            this.ShortHumidity4.AutoSize = true;
            this.ShortHumidity4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity4.Location = new System.Drawing.Point(284, 1512);
            this.ShortHumidity4.Name = "ShortHumidity4";
            this.ShortHumidity4.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity4.TabIndex = 222;
            this.ShortHumidity4.Text = "0";
            this.ShortHumidity4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity2
            // 
            this.ShortHumidity2.AutoSize = true;
            this.ShortHumidity2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity2.Location = new System.Drawing.Point(275, 1470);
            this.ShortHumidity2.Name = "ShortHumidity2";
            this.ShortHumidity2.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity2.TabIndex = 221;
            this.ShortHumidity2.Text = "0";
            this.ShortHumidity2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity3
            // 
            this.ShortHumidity3.AutoSize = true;
            this.ShortHumidity3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity3.Location = new System.Drawing.Point(284, 1491);
            this.ShortHumidity3.Name = "ShortHumidity3";
            this.ShortHumidity3.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity3.TabIndex = 220;
            this.ShortHumidity3.Text = "0";
            this.ShortHumidity3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidity1
            // 
            this.ShortHumidity1.AutoSize = true;
            this.ShortHumidity1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortHumidity1.Location = new System.Drawing.Point(275, 1449);
            this.ShortHumidity1.Name = "ShortHumidity1";
            this.ShortHumidity1.Size = new System.Drawing.Size(19, 21);
            this.ShortHumidity1.TabIndex = 219;
            this.ShortHumidity1.Text = "0";
            this.ShortHumidity1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel85
            // 
            this.metroLabel85.AutoSize = true;
            this.metroLabel85.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel85.Location = new System.Drawing.Point(492, 1659);
            this.metroLabel85.Name = "metroLabel85";
            this.metroLabel85.Size = new System.Drawing.Size(159, 21);
            this.metroLabel85.TabIndex = 218;
            this.metroLabel85.Text = "67시간 후 상대 습도 :";
            this.metroLabel85.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel86
            // 
            this.metroLabel86.AutoSize = true;
            this.metroLabel86.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel86.Location = new System.Drawing.Point(492, 1638);
            this.metroLabel86.Name = "metroLabel86";
            this.metroLabel86.Size = new System.Drawing.Size(159, 21);
            this.metroLabel86.TabIndex = 217;
            this.metroLabel86.Text = "64시간 후 상대 습도 :";
            this.metroLabel86.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel87
            // 
            this.metroLabel87.AutoSize = true;
            this.metroLabel87.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel87.Location = new System.Drawing.Point(492, 1617);
            this.metroLabel87.Name = "metroLabel87";
            this.metroLabel87.Size = new System.Drawing.Size(159, 21);
            this.metroLabel87.TabIndex = 216;
            this.metroLabel87.Text = "61시간 후 상대 습도 :";
            this.metroLabel87.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel88
            // 
            this.metroLabel88.AutoSize = true;
            this.metroLabel88.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel88.Location = new System.Drawing.Point(492, 1596);
            this.metroLabel88.Name = "metroLabel88";
            this.metroLabel88.Size = new System.Drawing.Size(159, 21);
            this.metroLabel88.TabIndex = 215;
            this.metroLabel88.Text = "58시간 후 상대 습도 :";
            this.metroLabel88.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel89
            // 
            this.metroLabel89.AutoSize = true;
            this.metroLabel89.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel89.Location = new System.Drawing.Point(492, 1575);
            this.metroLabel89.Name = "metroLabel89";
            this.metroLabel89.Size = new System.Drawing.Size(159, 21);
            this.metroLabel89.TabIndex = 214;
            this.metroLabel89.Text = "55시간 후 상대 습도 :";
            this.metroLabel89.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel90
            // 
            this.metroLabel90.AutoSize = true;
            this.metroLabel90.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel90.Location = new System.Drawing.Point(492, 1554);
            this.metroLabel90.Name = "metroLabel90";
            this.metroLabel90.Size = new System.Drawing.Size(159, 21);
            this.metroLabel90.TabIndex = 213;
            this.metroLabel90.Text = "52시간 후 상대 습도 :";
            this.metroLabel90.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel91
            // 
            this.metroLabel91.AutoSize = true;
            this.metroLabel91.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel91.Location = new System.Drawing.Point(492, 1533);
            this.metroLabel91.Name = "metroLabel91";
            this.metroLabel91.Size = new System.Drawing.Size(159, 21);
            this.metroLabel91.TabIndex = 212;
            this.metroLabel91.Text = "49시간 후 상대 습도 :";
            this.metroLabel91.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel92
            // 
            this.metroLabel92.AutoSize = true;
            this.metroLabel92.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel92.Location = new System.Drawing.Point(492, 1512);
            this.metroLabel92.Name = "metroLabel92";
            this.metroLabel92.Size = new System.Drawing.Size(159, 21);
            this.metroLabel92.TabIndex = 211;
            this.metroLabel92.Text = "46시간 후 상대 습도 :";
            this.metroLabel92.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel93
            // 
            this.metroLabel93.AutoSize = true;
            this.metroLabel93.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel93.Location = new System.Drawing.Point(492, 1491);
            this.metroLabel93.Name = "metroLabel93";
            this.metroLabel93.Size = new System.Drawing.Size(159, 21);
            this.metroLabel93.TabIndex = 210;
            this.metroLabel93.Text = "43시간 후 상대 습도 :";
            this.metroLabel93.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel94
            // 
            this.metroLabel94.AutoSize = true;
            this.metroLabel94.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel94.Location = new System.Drawing.Point(492, 1470);
            this.metroLabel94.Name = "metroLabel94";
            this.metroLabel94.Size = new System.Drawing.Size(159, 21);
            this.metroLabel94.TabIndex = 209;
            this.metroLabel94.Text = "40시간 후 상대 습도 :";
            this.metroLabel94.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel95
            // 
            this.metroLabel95.AutoSize = true;
            this.metroLabel95.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel95.Location = new System.Drawing.Point(492, 1449);
            this.metroLabel95.Name = "metroLabel95";
            this.metroLabel95.Size = new System.Drawing.Size(159, 21);
            this.metroLabel95.TabIndex = 208;
            this.metroLabel95.Text = "37시간 후 상대 습도 :";
            this.metroLabel95.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel96
            // 
            this.metroLabel96.AutoSize = true;
            this.metroLabel96.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel96.Location = new System.Drawing.Point(119, 1659);
            this.metroLabel96.Name = "metroLabel96";
            this.metroLabel96.Size = new System.Drawing.Size(159, 21);
            this.metroLabel96.TabIndex = 207;
            this.metroLabel96.Text = "34시간 후 상대 습도 :";
            this.metroLabel96.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel97
            // 
            this.metroLabel97.AutoSize = true;
            this.metroLabel97.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel97.Location = new System.Drawing.Point(119, 1638);
            this.metroLabel97.Name = "metroLabel97";
            this.metroLabel97.Size = new System.Drawing.Size(159, 21);
            this.metroLabel97.TabIndex = 206;
            this.metroLabel97.Text = "31시간 후 상대 습도 :";
            this.metroLabel97.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel98
            // 
            this.metroLabel98.AutoSize = true;
            this.metroLabel98.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel98.Location = new System.Drawing.Point(119, 1617);
            this.metroLabel98.Name = "metroLabel98";
            this.metroLabel98.Size = new System.Drawing.Size(159, 21);
            this.metroLabel98.TabIndex = 205;
            this.metroLabel98.Text = "28시간 후 상대 습도 :";
            this.metroLabel98.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel99
            // 
            this.metroLabel99.AutoSize = true;
            this.metroLabel99.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel99.Location = new System.Drawing.Point(119, 1596);
            this.metroLabel99.Name = "metroLabel99";
            this.metroLabel99.Size = new System.Drawing.Size(159, 21);
            this.metroLabel99.TabIndex = 204;
            this.metroLabel99.Text = "25시간 후 상대 습도 :";
            this.metroLabel99.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel100
            // 
            this.metroLabel100.AutoSize = true;
            this.metroLabel100.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel100.Location = new System.Drawing.Point(119, 1575);
            this.metroLabel100.Name = "metroLabel100";
            this.metroLabel100.Size = new System.Drawing.Size(159, 21);
            this.metroLabel100.TabIndex = 203;
            this.metroLabel100.Text = "22시간 후 상대 습도 :";
            this.metroLabel100.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel101
            // 
            this.metroLabel101.AutoSize = true;
            this.metroLabel101.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel101.Location = new System.Drawing.Point(119, 1554);
            this.metroLabel101.Name = "metroLabel101";
            this.metroLabel101.Size = new System.Drawing.Size(159, 21);
            this.metroLabel101.TabIndex = 202;
            this.metroLabel101.Text = "19시간 후 상대 습도 :";
            this.metroLabel101.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel102
            // 
            this.metroLabel102.AutoSize = true;
            this.metroLabel102.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel102.Location = new System.Drawing.Point(119, 1533);
            this.metroLabel102.Name = "metroLabel102";
            this.metroLabel102.Size = new System.Drawing.Size(159, 21);
            this.metroLabel102.TabIndex = 201;
            this.metroLabel102.Text = "16시간 후 상대 습도 :";
            this.metroLabel102.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel103
            // 
            this.metroLabel103.AutoSize = true;
            this.metroLabel103.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel103.Location = new System.Drawing.Point(119, 1512);
            this.metroLabel103.Name = "metroLabel103";
            this.metroLabel103.Size = new System.Drawing.Size(159, 21);
            this.metroLabel103.TabIndex = 200;
            this.metroLabel103.Text = "13시간 후 상대 습도 :";
            this.metroLabel103.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel104
            // 
            this.metroLabel104.AutoSize = true;
            this.metroLabel104.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel104.Location = new System.Drawing.Point(119, 1470);
            this.metroLabel104.Name = "metroLabel104";
            this.metroLabel104.Size = new System.Drawing.Size(150, 21);
            this.metroLabel104.TabIndex = 199;
            this.metroLabel104.Text = "7시간 후 상대 습도 :";
            this.metroLabel104.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel105
            // 
            this.metroLabel105.AutoSize = true;
            this.metroLabel105.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel105.Location = new System.Drawing.Point(119, 1491);
            this.metroLabel105.Name = "metroLabel105";
            this.metroLabel105.Size = new System.Drawing.Size(159, 21);
            this.metroLabel105.TabIndex = 198;
            this.metroLabel105.Text = "10시간 후 상대 습도 :";
            this.metroLabel105.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel106
            // 
            this.metroLabel106.AutoSize = true;
            this.metroLabel106.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel106.Location = new System.Drawing.Point(119, 1449);
            this.metroLabel106.Name = "metroLabel106";
            this.metroLabel106.Size = new System.Drawing.Size(150, 21);
            this.metroLabel106.TabIndex = 197;
            this.metroLabel106.Text = "4시간 후 상대 습도 :";
            this.metroLabel106.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortHumidityGraph
            // 
            this.ShortHumidityGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShortHumidityGraph.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.ShortHumidityGraph.ClassicFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShortHumidityGraph.ClassicLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShortHumidityGraph.DefaultColor = System.Drawing.Color.White;
            this.ShortHumidityGraph.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ShortHumidityGraph.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.ShortHumidityGraph.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ShortHumidityGraph.HoverBoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ShortHumidityGraph.HoverBoxColor = System.Drawing.Color.White;
            this.ShortHumidityGraph.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ShortHumidityGraph.Location = new System.Drawing.Point(3, 1193);
            this.ShortHumidityGraph.Name = "ShortHumidityGraph";
            this.ShortHumidityGraph.SidePadding = true;
            this.ShortHumidityGraph.SingleLine = true;
            this.ShortHumidityGraph.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShortHumidityGraph.Size = new System.Drawing.Size(795, 253);
            this.ShortHumidityGraph.TabIndex = 196;
            this.ShortHumidityGraph.Text = "metroGraph1";
            // 
            // metroLabel69
            // 
            this.metroLabel69.AutoSize = true;
            this.metroLabel69.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel69.Location = new System.Drawing.Point(453, 679);
            this.metroLabel69.Name = "metroLabel69";
            this.metroLabel69.Size = new System.Drawing.Size(134, 21);
            this.metroLabel69.TabIndex = 195;
            this.metroLabel69.Text = "3일 후 최저 기온 :";
            // 
            // metroLabel70
            // 
            this.metroLabel70.AutoSize = true;
            this.metroLabel70.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel70.Location = new System.Drawing.Point(453, 658);
            this.metroLabel70.Name = "metroLabel70";
            this.metroLabel70.Size = new System.Drawing.Size(134, 21);
            this.metroLabel70.TabIndex = 194;
            this.metroLabel70.Text = "2일 후 최저 기온 :";
            // 
            // metroLabel71
            // 
            this.metroLabel71.AutoSize = true;
            this.metroLabel71.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel71.Location = new System.Drawing.Point(453, 637);
            this.metroLabel71.Name = "metroLabel71";
            this.metroLabel71.Size = new System.Drawing.Size(134, 21);
            this.metroLabel71.TabIndex = 193;
            this.metroLabel71.Text = "1일 후 최저 기온 :";
            // 
            // ShortTMin3
            // 
            this.ShortTMin3.AutoSize = true;
            this.ShortTMin3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTMin3.Location = new System.Drawing.Point(593, 679);
            this.ShortTMin3.Name = "ShortTMin3";
            this.ShortTMin3.Size = new System.Drawing.Size(19, 21);
            this.ShortTMin3.TabIndex = 192;
            this.ShortTMin3.Text = "0";
            // 
            // ShortTMin2
            // 
            this.ShortTMin2.AutoSize = true;
            this.ShortTMin2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTMin2.Location = new System.Drawing.Point(593, 658);
            this.ShortTMin2.Name = "ShortTMin2";
            this.ShortTMin2.Size = new System.Drawing.Size(19, 21);
            this.ShortTMin2.TabIndex = 190;
            this.ShortTMin2.Text = "0";
            // 
            // ShortTMin1
            // 
            this.ShortTMin1.AutoSize = true;
            this.ShortTMin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTMin1.Location = new System.Drawing.Point(593, 637);
            this.ShortTMin1.Name = "ShortTMin1";
            this.ShortTMin1.Size = new System.Drawing.Size(19, 21);
            this.ShortTMin1.TabIndex = 188;
            this.ShortTMin1.Text = "0";
            // 
            // ShortTMax3
            // 
            this.ShortTMax3.AutoSize = true;
            this.ShortTMax3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTMax3.Location = new System.Drawing.Point(248, 679);
            this.ShortTMax3.Name = "ShortTMax3";
            this.ShortTMax3.Size = new System.Drawing.Size(19, 21);
            this.ShortTMax3.TabIndex = 186;
            this.ShortTMax3.Text = "0";
            // 
            // metroLabel61
            // 
            this.metroLabel61.AutoSize = true;
            this.metroLabel61.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel61.Location = new System.Drawing.Point(108, 679);
            this.metroLabel61.Name = "metroLabel61";
            this.metroLabel61.Size = new System.Drawing.Size(134, 21);
            this.metroLabel61.TabIndex = 185;
            this.metroLabel61.Text = "3일 후 최고 기온 :";
            // 
            // ShortTMax2
            // 
            this.ShortTMax2.AutoSize = true;
            this.ShortTMax2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTMax2.Location = new System.Drawing.Point(248, 658);
            this.ShortTMax2.Name = "ShortTMax2";
            this.ShortTMax2.Size = new System.Drawing.Size(19, 21);
            this.ShortTMax2.TabIndex = 184;
            this.ShortTMax2.Text = "0";
            // 
            // metroLabel59
            // 
            this.metroLabel59.AutoSize = true;
            this.metroLabel59.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel59.Location = new System.Drawing.Point(108, 658);
            this.metroLabel59.Name = "metroLabel59";
            this.metroLabel59.Size = new System.Drawing.Size(134, 21);
            this.metroLabel59.TabIndex = 183;
            this.metroLabel59.Text = "2일 후 최고 기온 :";
            // 
            // ShortTMax1
            // 
            this.ShortTMax1.AutoSize = true;
            this.ShortTMax1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTMax1.Location = new System.Drawing.Point(248, 637);
            this.ShortTMax1.Name = "ShortTMax1";
            this.ShortTMax1.Size = new System.Drawing.Size(19, 21);
            this.ShortTMax1.TabIndex = 182;
            this.ShortTMax1.Text = "0";
            // 
            // metroLabel57
            // 
            this.metroLabel57.AutoSize = true;
            this.metroLabel57.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel57.Location = new System.Drawing.Point(108, 637);
            this.metroLabel57.Name = "metroLabel57";
            this.metroLabel57.Size = new System.Drawing.Size(134, 21);
            this.metroLabel57.TabIndex = 0;
            this.metroLabel57.Text = "1일 후 최고 기온 :";
            // 
            // ShortTGraph
            // 
            this.ShortTGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShortTGraph.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.ShortTGraph.ClassicFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShortTGraph.ClassicLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShortTGraph.DefaultColor = System.Drawing.Color.White;
            this.ShortTGraph.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ShortTGraph.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.ShortTGraph.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ShortTGraph.HoverBoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ShortTGraph.HoverBoxColor = System.Drawing.Color.White;
            this.ShortTGraph.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ShortTGraph.Location = new System.Drawing.Point(3, 415);
            this.ShortTGraph.Name = "ShortTGraph";
            this.ShortTGraph.SidePadding = true;
            this.ShortTGraph.SingleLine = true;
            this.ShortTGraph.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShortTGraph.Size = new System.Drawing.Size(795, 219);
            this.ShortTGraph.TabIndex = 181;
            this.ShortTGraph.Text = "metroGraph1";
            // 
            // ShortTemperature22
            // 
            this.ShortTemperature22.AutoSize = true;
            this.ShortTemperature22.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature22.Location = new System.Drawing.Point(621, 1169);
            this.ShortTemperature22.Name = "ShortTemperature22";
            this.ShortTemperature22.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature22.TabIndex = 180;
            this.ShortTemperature22.Text = "0";
            this.ShortTemperature22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature21
            // 
            this.ShortTemperature21.AutoSize = true;
            this.ShortTemperature21.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature21.Location = new System.Drawing.Point(621, 1148);
            this.ShortTemperature21.Name = "ShortTemperature21";
            this.ShortTemperature21.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature21.TabIndex = 179;
            this.ShortTemperature21.Text = "0";
            this.ShortTemperature21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature20
            // 
            this.ShortTemperature20.AutoSize = true;
            this.ShortTemperature20.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature20.Location = new System.Drawing.Point(621, 1127);
            this.ShortTemperature20.Name = "ShortTemperature20";
            this.ShortTemperature20.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature20.TabIndex = 178;
            this.ShortTemperature20.Text = "0";
            this.ShortTemperature20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature19
            // 
            this.ShortTemperature19.AutoSize = true;
            this.ShortTemperature19.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature19.Location = new System.Drawing.Point(621, 1106);
            this.ShortTemperature19.Name = "ShortTemperature19";
            this.ShortTemperature19.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature19.TabIndex = 177;
            this.ShortTemperature19.Text = "0";
            this.ShortTemperature19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature18
            // 
            this.ShortTemperature18.AutoSize = true;
            this.ShortTemperature18.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature18.Location = new System.Drawing.Point(621, 1085);
            this.ShortTemperature18.Name = "ShortTemperature18";
            this.ShortTemperature18.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature18.TabIndex = 176;
            this.ShortTemperature18.Text = "0";
            this.ShortTemperature18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature17
            // 
            this.ShortTemperature17.AutoSize = true;
            this.ShortTemperature17.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature17.Location = new System.Drawing.Point(621, 1064);
            this.ShortTemperature17.Name = "ShortTemperature17";
            this.ShortTemperature17.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature17.TabIndex = 175;
            this.ShortTemperature17.Text = "0";
            this.ShortTemperature17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature16
            // 
            this.ShortTemperature16.AutoSize = true;
            this.ShortTemperature16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature16.Location = new System.Drawing.Point(621, 1043);
            this.ShortTemperature16.Name = "ShortTemperature16";
            this.ShortTemperature16.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature16.TabIndex = 174;
            this.ShortTemperature16.Text = "0";
            this.ShortTemperature16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature15
            // 
            this.ShortTemperature15.AutoSize = true;
            this.ShortTemperature15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature15.Location = new System.Drawing.Point(621, 1022);
            this.ShortTemperature15.Name = "ShortTemperature15";
            this.ShortTemperature15.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature15.TabIndex = 173;
            this.ShortTemperature15.Text = "0";
            this.ShortTemperature15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature14
            // 
            this.ShortTemperature14.AutoSize = true;
            this.ShortTemperature14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature14.Location = new System.Drawing.Point(621, 1001);
            this.ShortTemperature14.Name = "ShortTemperature14";
            this.ShortTemperature14.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature14.TabIndex = 172;
            this.ShortTemperature14.Text = "0";
            this.ShortTemperature14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature13
            // 
            this.ShortTemperature13.AutoSize = true;
            this.ShortTemperature13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature13.Location = new System.Drawing.Point(621, 980);
            this.ShortTemperature13.Name = "ShortTemperature13";
            this.ShortTemperature13.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature13.TabIndex = 171;
            this.ShortTemperature13.Text = "0";
            this.ShortTemperature13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature12
            // 
            this.ShortTemperature12.AutoSize = true;
            this.ShortTemperature12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature12.Location = new System.Drawing.Point(621, 959);
            this.ShortTemperature12.Name = "ShortTemperature12";
            this.ShortTemperature12.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature12.TabIndex = 170;
            this.ShortTemperature12.Text = "0";
            this.ShortTemperature12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature11
            // 
            this.ShortTemperature11.AutoSize = true;
            this.ShortTemperature11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature11.Location = new System.Drawing.Point(248, 1169);
            this.ShortTemperature11.Name = "ShortTemperature11";
            this.ShortTemperature11.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature11.TabIndex = 169;
            this.ShortTemperature11.Text = "0";
            this.ShortTemperature11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature10
            // 
            this.ShortTemperature10.AutoSize = true;
            this.ShortTemperature10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature10.Location = new System.Drawing.Point(248, 1148);
            this.ShortTemperature10.Name = "ShortTemperature10";
            this.ShortTemperature10.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature10.TabIndex = 168;
            this.ShortTemperature10.Text = "0";
            this.ShortTemperature10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature9
            // 
            this.ShortTemperature9.AutoSize = true;
            this.ShortTemperature9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature9.Location = new System.Drawing.Point(248, 1127);
            this.ShortTemperature9.Name = "ShortTemperature9";
            this.ShortTemperature9.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature9.TabIndex = 167;
            this.ShortTemperature9.Text = "0";
            this.ShortTemperature9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature8
            // 
            this.ShortTemperature8.AutoSize = true;
            this.ShortTemperature8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature8.Location = new System.Drawing.Point(248, 1106);
            this.ShortTemperature8.Name = "ShortTemperature8";
            this.ShortTemperature8.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature8.TabIndex = 166;
            this.ShortTemperature8.Text = "0";
            this.ShortTemperature8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature7
            // 
            this.ShortTemperature7.AutoSize = true;
            this.ShortTemperature7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature7.Location = new System.Drawing.Point(248, 1085);
            this.ShortTemperature7.Name = "ShortTemperature7";
            this.ShortTemperature7.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature7.TabIndex = 165;
            this.ShortTemperature7.Text = "0";
            this.ShortTemperature7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature6
            // 
            this.ShortTemperature6.AutoSize = true;
            this.ShortTemperature6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature6.Location = new System.Drawing.Point(248, 1064);
            this.ShortTemperature6.Name = "ShortTemperature6";
            this.ShortTemperature6.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature6.TabIndex = 164;
            this.ShortTemperature6.Text = "0";
            this.ShortTemperature6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature5
            // 
            this.ShortTemperature5.AutoSize = true;
            this.ShortTemperature5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature5.Location = new System.Drawing.Point(248, 1043);
            this.ShortTemperature5.Name = "ShortTemperature5";
            this.ShortTemperature5.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature5.TabIndex = 163;
            this.ShortTemperature5.Text = "0";
            this.ShortTemperature5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature4
            // 
            this.ShortTemperature4.AutoSize = true;
            this.ShortTemperature4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature4.Location = new System.Drawing.Point(248, 1022);
            this.ShortTemperature4.Name = "ShortTemperature4";
            this.ShortTemperature4.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature4.TabIndex = 162;
            this.ShortTemperature4.Text = "0";
            this.ShortTemperature4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature2
            // 
            this.ShortTemperature2.AutoSize = true;
            this.ShortTemperature2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature2.Location = new System.Drawing.Point(239, 980);
            this.ShortTemperature2.Name = "ShortTemperature2";
            this.ShortTemperature2.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature2.TabIndex = 161;
            this.ShortTemperature2.Text = "0";
            this.ShortTemperature2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature3
            // 
            this.ShortTemperature3.AutoSize = true;
            this.ShortTemperature3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature3.Location = new System.Drawing.Point(248, 1001);
            this.ShortTemperature3.Name = "ShortTemperature3";
            this.ShortTemperature3.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature3.TabIndex = 160;
            this.ShortTemperature3.Text = "0";
            this.ShortTemperature3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperature1
            // 
            this.ShortTemperature1.AutoSize = true;
            this.ShortTemperature1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortTemperature1.Location = new System.Drawing.Point(239, 959);
            this.ShortTemperature1.Name = "ShortTemperature1";
            this.ShortTemperature1.Size = new System.Drawing.Size(19, 21);
            this.ShortTemperature1.TabIndex = 159;
            this.ShortTemperature1.Text = "0";
            this.ShortTemperature1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel56
            // 
            this.metroLabel56.AutoSize = true;
            this.metroLabel56.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel56.Location = new System.Drawing.Point(492, 1169);
            this.metroLabel56.Name = "metroLabel56";
            this.metroLabel56.Size = new System.Drawing.Size(123, 21);
            this.metroLabel56.TabIndex = 136;
            this.metroLabel56.Text = "67시간 후 온도 :";
            this.metroLabel56.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel55
            // 
            this.metroLabel55.AutoSize = true;
            this.metroLabel55.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel55.Location = new System.Drawing.Point(492, 1148);
            this.metroLabel55.Name = "metroLabel55";
            this.metroLabel55.Size = new System.Drawing.Size(123, 21);
            this.metroLabel55.TabIndex = 135;
            this.metroLabel55.Text = "64시간 후 온도 :";
            this.metroLabel55.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel54
            // 
            this.metroLabel54.AutoSize = true;
            this.metroLabel54.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel54.Location = new System.Drawing.Point(492, 1127);
            this.metroLabel54.Name = "metroLabel54";
            this.metroLabel54.Size = new System.Drawing.Size(123, 21);
            this.metroLabel54.TabIndex = 134;
            this.metroLabel54.Text = "61시간 후 온도 :";
            this.metroLabel54.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel53
            // 
            this.metroLabel53.AutoSize = true;
            this.metroLabel53.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel53.Location = new System.Drawing.Point(492, 1106);
            this.metroLabel53.Name = "metroLabel53";
            this.metroLabel53.Size = new System.Drawing.Size(123, 21);
            this.metroLabel53.TabIndex = 133;
            this.metroLabel53.Text = "58시간 후 온도 :";
            this.metroLabel53.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel52
            // 
            this.metroLabel52.AutoSize = true;
            this.metroLabel52.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel52.Location = new System.Drawing.Point(492, 1085);
            this.metroLabel52.Name = "metroLabel52";
            this.metroLabel52.Size = new System.Drawing.Size(123, 21);
            this.metroLabel52.TabIndex = 132;
            this.metroLabel52.Text = "55시간 후 온도 :";
            this.metroLabel52.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel51
            // 
            this.metroLabel51.AutoSize = true;
            this.metroLabel51.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel51.Location = new System.Drawing.Point(492, 1064);
            this.metroLabel51.Name = "metroLabel51";
            this.metroLabel51.Size = new System.Drawing.Size(123, 21);
            this.metroLabel51.TabIndex = 131;
            this.metroLabel51.Text = "52시간 후 온도 :";
            this.metroLabel51.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel50
            // 
            this.metroLabel50.AutoSize = true;
            this.metroLabel50.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel50.Location = new System.Drawing.Point(492, 1043);
            this.metroLabel50.Name = "metroLabel50";
            this.metroLabel50.Size = new System.Drawing.Size(123, 21);
            this.metroLabel50.TabIndex = 130;
            this.metroLabel50.Text = "49시간 후 온도 :";
            this.metroLabel50.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel49
            // 
            this.metroLabel49.AutoSize = true;
            this.metroLabel49.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel49.Location = new System.Drawing.Point(492, 1022);
            this.metroLabel49.Name = "metroLabel49";
            this.metroLabel49.Size = new System.Drawing.Size(123, 21);
            this.metroLabel49.TabIndex = 129;
            this.metroLabel49.Text = "46시간 후 온도 :";
            this.metroLabel49.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel48
            // 
            this.metroLabel48.AutoSize = true;
            this.metroLabel48.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel48.Location = new System.Drawing.Point(492, 1001);
            this.metroLabel48.Name = "metroLabel48";
            this.metroLabel48.Size = new System.Drawing.Size(123, 21);
            this.metroLabel48.TabIndex = 128;
            this.metroLabel48.Text = "43시간 후 온도 :";
            this.metroLabel48.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel47
            // 
            this.metroLabel47.AutoSize = true;
            this.metroLabel47.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel47.Location = new System.Drawing.Point(492, 980);
            this.metroLabel47.Name = "metroLabel47";
            this.metroLabel47.Size = new System.Drawing.Size(123, 21);
            this.metroLabel47.TabIndex = 127;
            this.metroLabel47.Text = "40시간 후 온도 :";
            this.metroLabel47.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel46
            // 
            this.metroLabel46.AutoSize = true;
            this.metroLabel46.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel46.Location = new System.Drawing.Point(492, 959);
            this.metroLabel46.Name = "metroLabel46";
            this.metroLabel46.Size = new System.Drawing.Size(123, 21);
            this.metroLabel46.TabIndex = 126;
            this.metroLabel46.Text = "37시간 후 온도 :";
            this.metroLabel46.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel45
            // 
            this.metroLabel45.AutoSize = true;
            this.metroLabel45.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel45.Location = new System.Drawing.Point(119, 1169);
            this.metroLabel45.Name = "metroLabel45";
            this.metroLabel45.Size = new System.Drawing.Size(123, 21);
            this.metroLabel45.TabIndex = 125;
            this.metroLabel45.Text = "34시간 후 온도 :";
            this.metroLabel45.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel44
            // 
            this.metroLabel44.AutoSize = true;
            this.metroLabel44.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel44.Location = new System.Drawing.Point(119, 1148);
            this.metroLabel44.Name = "metroLabel44";
            this.metroLabel44.Size = new System.Drawing.Size(123, 21);
            this.metroLabel44.TabIndex = 124;
            this.metroLabel44.Text = "31시간 후 온도 :";
            this.metroLabel44.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel43
            // 
            this.metroLabel43.AutoSize = true;
            this.metroLabel43.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel43.Location = new System.Drawing.Point(119, 1127);
            this.metroLabel43.Name = "metroLabel43";
            this.metroLabel43.Size = new System.Drawing.Size(123, 21);
            this.metroLabel43.TabIndex = 123;
            this.metroLabel43.Text = "28시간 후 온도 :";
            this.metroLabel43.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel42
            // 
            this.metroLabel42.AutoSize = true;
            this.metroLabel42.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel42.Location = new System.Drawing.Point(119, 1106);
            this.metroLabel42.Name = "metroLabel42";
            this.metroLabel42.Size = new System.Drawing.Size(123, 21);
            this.metroLabel42.TabIndex = 122;
            this.metroLabel42.Text = "25시간 후 온도 :";
            this.metroLabel42.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel41
            // 
            this.metroLabel41.AutoSize = true;
            this.metroLabel41.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel41.Location = new System.Drawing.Point(119, 1085);
            this.metroLabel41.Name = "metroLabel41";
            this.metroLabel41.Size = new System.Drawing.Size(123, 21);
            this.metroLabel41.TabIndex = 121;
            this.metroLabel41.Text = "22시간 후 온도 :";
            this.metroLabel41.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel40
            // 
            this.metroLabel40.AutoSize = true;
            this.metroLabel40.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel40.Location = new System.Drawing.Point(119, 1064);
            this.metroLabel40.Name = "metroLabel40";
            this.metroLabel40.Size = new System.Drawing.Size(123, 21);
            this.metroLabel40.TabIndex = 120;
            this.metroLabel40.Text = "19시간 후 온도 :";
            this.metroLabel40.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel39
            // 
            this.metroLabel39.AutoSize = true;
            this.metroLabel39.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel39.Location = new System.Drawing.Point(119, 1043);
            this.metroLabel39.Name = "metroLabel39";
            this.metroLabel39.Size = new System.Drawing.Size(123, 21);
            this.metroLabel39.TabIndex = 119;
            this.metroLabel39.Text = "16시간 후 온도 :";
            this.metroLabel39.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel38
            // 
            this.metroLabel38.AutoSize = true;
            this.metroLabel38.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel38.Location = new System.Drawing.Point(119, 1022);
            this.metroLabel38.Name = "metroLabel38";
            this.metroLabel38.Size = new System.Drawing.Size(123, 21);
            this.metroLabel38.TabIndex = 118;
            this.metroLabel38.Text = "13시간 후 온도 :";
            this.metroLabel38.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel36
            // 
            this.metroLabel36.AutoSize = true;
            this.metroLabel36.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel36.Location = new System.Drawing.Point(119, 980);
            this.metroLabel36.Name = "metroLabel36";
            this.metroLabel36.Size = new System.Drawing.Size(114, 21);
            this.metroLabel36.TabIndex = 117;
            this.metroLabel36.Text = "7시간 후 온도 :";
            this.metroLabel36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel34
            // 
            this.metroLabel34.AutoSize = true;
            this.metroLabel34.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel34.Location = new System.Drawing.Point(119, 1001);
            this.metroLabel34.Name = "metroLabel34";
            this.metroLabel34.Size = new System.Drawing.Size(123, 21);
            this.metroLabel34.TabIndex = 116;
            this.metroLabel34.Text = "10시간 후 온도 :";
            this.metroLabel34.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel12.Location = new System.Drawing.Point(119, 959);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(114, 21);
            this.metroLabel12.TabIndex = 115;
            this.metroLabel12.Text = "4시간 후 온도 :";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortTemperatureGraph
            // 
            this.ShortTemperatureGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShortTemperatureGraph.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.ShortTemperatureGraph.ClassicFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShortTemperatureGraph.ClassicLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShortTemperatureGraph.DefaultColor = System.Drawing.Color.White;
            this.ShortTemperatureGraph.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ShortTemperatureGraph.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.ShortTemperatureGraph.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ShortTemperatureGraph.HoverBoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ShortTemperatureGraph.HoverBoxColor = System.Drawing.Color.White;
            this.ShortTemperatureGraph.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ShortTemperatureGraph.Location = new System.Drawing.Point(3, 703);
            this.ShortTemperatureGraph.Name = "ShortTemperatureGraph";
            this.ShortTemperatureGraph.SidePadding = true;
            this.ShortTemperatureGraph.SingleLine = true;
            this.ShortTemperatureGraph.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShortTemperatureGraph.Size = new System.Drawing.Size(795, 253);
            this.ShortTemperatureGraph.TabIndex = 0;
            this.ShortTemperatureGraph.Text = "metroGraph1";
            // 
            // ShortWeatherExplain22
            // 
            this.ShortWeatherExplain22.AutoSize = true;
            this.ShortWeatherExplain22.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain22.Location = new System.Drawing.Point(526, 391);
            this.ShortWeatherExplain22.Name = "ShortWeatherExplain22";
            this.ShortWeatherExplain22.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain22.TabIndex = 113;
            this.ShortWeatherExplain22.Text = "NULL";
            this.ShortWeatherExplain22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain21
            // 
            this.ShortWeatherExplain21.AutoSize = true;
            this.ShortWeatherExplain21.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain21.Location = new System.Drawing.Point(426, 391);
            this.ShortWeatherExplain21.Name = "ShortWeatherExplain21";
            this.ShortWeatherExplain21.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain21.TabIndex = 112;
            this.ShortWeatherExplain21.Text = "NULL";
            this.ShortWeatherExplain21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain20
            // 
            this.ShortWeatherExplain20.AutoSize = true;
            this.ShortWeatherExplain20.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain20.Location = new System.Drawing.Point(327, 391);
            this.ShortWeatherExplain20.Name = "ShortWeatherExplain20";
            this.ShortWeatherExplain20.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain20.TabIndex = 111;
            this.ShortWeatherExplain20.Text = "NULL";
            this.ShortWeatherExplain20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain19
            // 
            this.ShortWeatherExplain19.AutoSize = true;
            this.ShortWeatherExplain19.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain19.Location = new System.Drawing.Point(227, 391);
            this.ShortWeatherExplain19.Name = "ShortWeatherExplain19";
            this.ShortWeatherExplain19.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain19.TabIndex = 110;
            this.ShortWeatherExplain19.Text = "NULL";
            this.ShortWeatherExplain19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain18
            // 
            this.ShortWeatherExplain18.AutoSize = true;
            this.ShortWeatherExplain18.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain18.Location = new System.Drawing.Point(127, 391);
            this.ShortWeatherExplain18.Name = "ShortWeatherExplain18";
            this.ShortWeatherExplain18.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain18.TabIndex = 109;
            this.ShortWeatherExplain18.Text = "NULL";
            this.ShortWeatherExplain18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain17
            // 
            this.ShortWeatherExplain17.AutoSize = true;
            this.ShortWeatherExplain17.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain17.Location = new System.Drawing.Point(27, 391);
            this.ShortWeatherExplain17.Name = "ShortWeatherExplain17";
            this.ShortWeatherExplain17.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain17.TabIndex = 108;
            this.ShortWeatherExplain17.Text = "NULL";
            this.ShortWeatherExplain17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain2
            // 
            this.ShortWeatherExplain2.AutoSize = true;
            this.ShortWeatherExplain2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain2.Location = new System.Drawing.Point(127, 145);
            this.ShortWeatherExplain2.Name = "ShortWeatherExplain2";
            this.ShortWeatherExplain2.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain2.TabIndex = 107;
            this.ShortWeatherExplain2.Text = "NULL";
            this.ShortWeatherExplain2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain3
            // 
            this.ShortWeatherExplain3.AutoSize = true;
            this.ShortWeatherExplain3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain3.Location = new System.Drawing.Point(227, 145);
            this.ShortWeatherExplain3.Name = "ShortWeatherExplain3";
            this.ShortWeatherExplain3.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain3.TabIndex = 106;
            this.ShortWeatherExplain3.Text = "NULL";
            this.ShortWeatherExplain3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain4
            // 
            this.ShortWeatherExplain4.AutoSize = true;
            this.ShortWeatherExplain4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain4.Location = new System.Drawing.Point(327, 146);
            this.ShortWeatherExplain4.Name = "ShortWeatherExplain4";
            this.ShortWeatherExplain4.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain4.TabIndex = 105;
            this.ShortWeatherExplain4.Text = "NULL";
            this.ShortWeatherExplain4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain5
            // 
            this.ShortWeatherExplain5.AutoSize = true;
            this.ShortWeatherExplain5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain5.Location = new System.Drawing.Point(426, 145);
            this.ShortWeatherExplain5.Name = "ShortWeatherExplain5";
            this.ShortWeatherExplain5.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain5.TabIndex = 104;
            this.ShortWeatherExplain5.Text = "NULL";
            this.ShortWeatherExplain5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain7
            // 
            this.ShortWeatherExplain7.AutoSize = true;
            this.ShortWeatherExplain7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain7.Location = new System.Drawing.Point(626, 145);
            this.ShortWeatherExplain7.Name = "ShortWeatherExplain7";
            this.ShortWeatherExplain7.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain7.TabIndex = 103;
            this.ShortWeatherExplain7.Text = "NULL";
            this.ShortWeatherExplain7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain6
            // 
            this.ShortWeatherExplain6.AutoSize = true;
            this.ShortWeatherExplain6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain6.Location = new System.Drawing.Point(526, 145);
            this.ShortWeatherExplain6.Name = "ShortWeatherExplain6";
            this.ShortWeatherExplain6.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain6.TabIndex = 102;
            this.ShortWeatherExplain6.Text = "NULL";
            this.ShortWeatherExplain6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain8
            // 
            this.ShortWeatherExplain8.AutoSize = true;
            this.ShortWeatherExplain8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain8.Location = new System.Drawing.Point(726, 145);
            this.ShortWeatherExplain8.Name = "ShortWeatherExplain8";
            this.ShortWeatherExplain8.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain8.TabIndex = 101;
            this.ShortWeatherExplain8.Text = "NULL";
            this.ShortWeatherExplain8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain9
            // 
            this.ShortWeatherExplain9.AutoSize = true;
            this.ShortWeatherExplain9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain9.Location = new System.Drawing.Point(27, 270);
            this.ShortWeatherExplain9.Name = "ShortWeatherExplain9";
            this.ShortWeatherExplain9.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain9.TabIndex = 100;
            this.ShortWeatherExplain9.Text = "NULL";
            this.ShortWeatherExplain9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain10
            // 
            this.ShortWeatherExplain10.AutoSize = true;
            this.ShortWeatherExplain10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain10.Location = new System.Drawing.Point(127, 270);
            this.ShortWeatherExplain10.Name = "ShortWeatherExplain10";
            this.ShortWeatherExplain10.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain10.TabIndex = 99;
            this.ShortWeatherExplain10.Text = "NULL";
            this.ShortWeatherExplain10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain11
            // 
            this.ShortWeatherExplain11.AutoSize = true;
            this.ShortWeatherExplain11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain11.Location = new System.Drawing.Point(227, 270);
            this.ShortWeatherExplain11.Name = "ShortWeatherExplain11";
            this.ShortWeatherExplain11.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain11.TabIndex = 98;
            this.ShortWeatherExplain11.Text = "NULL";
            this.ShortWeatherExplain11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain12
            // 
            this.ShortWeatherExplain12.AutoSize = true;
            this.ShortWeatherExplain12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain12.Location = new System.Drawing.Point(327, 270);
            this.ShortWeatherExplain12.Name = "ShortWeatherExplain12";
            this.ShortWeatherExplain12.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain12.TabIndex = 97;
            this.ShortWeatherExplain12.Text = "NULL";
            this.ShortWeatherExplain12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain13
            // 
            this.ShortWeatherExplain13.AutoSize = true;
            this.ShortWeatherExplain13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain13.Location = new System.Drawing.Point(426, 270);
            this.ShortWeatherExplain13.Name = "ShortWeatherExplain13";
            this.ShortWeatherExplain13.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain13.TabIndex = 96;
            this.ShortWeatherExplain13.Text = "NULL";
            this.ShortWeatherExplain13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain14
            // 
            this.ShortWeatherExplain14.AutoSize = true;
            this.ShortWeatherExplain14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain14.Location = new System.Drawing.Point(526, 270);
            this.ShortWeatherExplain14.Name = "ShortWeatherExplain14";
            this.ShortWeatherExplain14.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain14.TabIndex = 95;
            this.ShortWeatherExplain14.Text = "NULL";
            this.ShortWeatherExplain14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain15
            // 
            this.ShortWeatherExplain15.AutoSize = true;
            this.ShortWeatherExplain15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain15.Location = new System.Drawing.Point(626, 270);
            this.ShortWeatherExplain15.Name = "ShortWeatherExplain15";
            this.ShortWeatherExplain15.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain15.TabIndex = 94;
            this.ShortWeatherExplain15.Text = "NULL";
            this.ShortWeatherExplain15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain16
            // 
            this.ShortWeatherExplain16.AutoSize = true;
            this.ShortWeatherExplain16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain16.Location = new System.Drawing.Point(726, 270);
            this.ShortWeatherExplain16.Name = "ShortWeatherExplain16";
            this.ShortWeatherExplain16.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain16.TabIndex = 93;
            this.ShortWeatherExplain16.Text = "NULL";
            this.ShortWeatherExplain16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherIcon17
            // 
            this.ShortWeatherIcon17.Location = new System.Drawing.Point(4, 294);
            this.ShortWeatherIcon17.Name = "ShortWeatherIcon17";
            this.ShortWeatherIcon17.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon17.TabIndex = 92;
            this.ShortWeatherIcon17.TabStop = false;
            // 
            // ShortWeatherIcon18
            // 
            this.ShortWeatherIcon18.Location = new System.Drawing.Point(104, 294);
            this.ShortWeatherIcon18.Name = "ShortWeatherIcon18";
            this.ShortWeatherIcon18.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon18.TabIndex = 91;
            this.ShortWeatherIcon18.TabStop = false;
            // 
            // ShortWeatherIcon20
            // 
            this.ShortWeatherIcon20.Location = new System.Drawing.Point(304, 294);
            this.ShortWeatherIcon20.Name = "ShortWeatherIcon20";
            this.ShortWeatherIcon20.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon20.TabIndex = 90;
            this.ShortWeatherIcon20.TabStop = false;
            // 
            // ShortWeatherIcon21
            // 
            this.ShortWeatherIcon21.Location = new System.Drawing.Point(403, 294);
            this.ShortWeatherIcon21.Name = "ShortWeatherIcon21";
            this.ShortWeatherIcon21.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon21.TabIndex = 89;
            this.ShortWeatherIcon21.TabStop = false;
            // 
            // ShortWeatherIcon22
            // 
            this.ShortWeatherIcon22.Location = new System.Drawing.Point(503, 294);
            this.ShortWeatherIcon22.Name = "ShortWeatherIcon22";
            this.ShortWeatherIcon22.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon22.TabIndex = 88;
            this.ShortWeatherIcon22.TabStop = false;
            // 
            // ShortWeatherIcon19
            // 
            this.ShortWeatherIcon19.Location = new System.Drawing.Point(204, 294);
            this.ShortWeatherIcon19.Name = "ShortWeatherIcon19";
            this.ShortWeatherIcon19.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon19.TabIndex = 87;
            this.ShortWeatherIcon19.TabStop = false;
            // 
            // ShortWeatherIcon16
            // 
            this.ShortWeatherIcon16.Location = new System.Drawing.Point(703, 169);
            this.ShortWeatherIcon16.Name = "ShortWeatherIcon16";
            this.ShortWeatherIcon16.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon16.TabIndex = 86;
            this.ShortWeatherIcon16.TabStop = false;
            // 
            // ShortWeatherIcon7
            // 
            this.ShortWeatherIcon7.Location = new System.Drawing.Point(603, 48);
            this.ShortWeatherIcon7.Name = "ShortWeatherIcon7";
            this.ShortWeatherIcon7.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon7.TabIndex = 85;
            this.ShortWeatherIcon7.TabStop = false;
            // 
            // ShortWeatherIcon8
            // 
            this.ShortWeatherIcon8.Location = new System.Drawing.Point(703, 48);
            this.ShortWeatherIcon8.Name = "ShortWeatherIcon8";
            this.ShortWeatherIcon8.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon8.TabIndex = 84;
            this.ShortWeatherIcon8.TabStop = false;
            // 
            // ShortWeatherIcon9
            // 
            this.ShortWeatherIcon9.Location = new System.Drawing.Point(4, 169);
            this.ShortWeatherIcon9.Name = "ShortWeatherIcon9";
            this.ShortWeatherIcon9.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon9.TabIndex = 83;
            this.ShortWeatherIcon9.TabStop = false;
            // 
            // ShortWeatherIcon15
            // 
            this.ShortWeatherIcon15.Location = new System.Drawing.Point(603, 169);
            this.ShortWeatherIcon15.Name = "ShortWeatherIcon15";
            this.ShortWeatherIcon15.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon15.TabIndex = 82;
            this.ShortWeatherIcon15.TabStop = false;
            // 
            // ShortWeatherIcon14
            // 
            this.ShortWeatherIcon14.Location = new System.Drawing.Point(503, 169);
            this.ShortWeatherIcon14.Name = "ShortWeatherIcon14";
            this.ShortWeatherIcon14.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon14.TabIndex = 81;
            this.ShortWeatherIcon14.TabStop = false;
            // 
            // ShortWeatherIcon13
            // 
            this.ShortWeatherIcon13.Location = new System.Drawing.Point(403, 169);
            this.ShortWeatherIcon13.Name = "ShortWeatherIcon13";
            this.ShortWeatherIcon13.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon13.TabIndex = 80;
            this.ShortWeatherIcon13.TabStop = false;
            // 
            // ShortWeatherIcon12
            // 
            this.ShortWeatherIcon12.Location = new System.Drawing.Point(304, 169);
            this.ShortWeatherIcon12.Name = "ShortWeatherIcon12";
            this.ShortWeatherIcon12.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon12.TabIndex = 79;
            this.ShortWeatherIcon12.TabStop = false;
            // 
            // ShortWeatherIcon11
            // 
            this.ShortWeatherIcon11.Location = new System.Drawing.Point(204, 169);
            this.ShortWeatherIcon11.Name = "ShortWeatherIcon11";
            this.ShortWeatherIcon11.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon11.TabIndex = 77;
            this.ShortWeatherIcon11.TabStop = false;
            // 
            // ShortWeatherIcon6
            // 
            this.ShortWeatherIcon6.Location = new System.Drawing.Point(503, 48);
            this.ShortWeatherIcon6.Name = "ShortWeatherIcon6";
            this.ShortWeatherIcon6.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon6.TabIndex = 73;
            this.ShortWeatherIcon6.TabStop = false;
            // 
            // ShortWeatherIcon10
            // 
            this.ShortWeatherIcon10.Location = new System.Drawing.Point(104, 169);
            this.ShortWeatherIcon10.Name = "ShortWeatherIcon10";
            this.ShortWeatherIcon10.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon10.TabIndex = 75;
            this.ShortWeatherIcon10.TabStop = false;
            // 
            // ShortWeatherIcon5
            // 
            this.ShortWeatherIcon5.Location = new System.Drawing.Point(403, 48);
            this.ShortWeatherIcon5.Name = "ShortWeatherIcon5";
            this.ShortWeatherIcon5.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon5.TabIndex = 71;
            this.ShortWeatherIcon5.TabStop = false;
            // 
            // ShortWeatherIcon4
            // 
            this.ShortWeatherIcon4.Location = new System.Drawing.Point(304, 48);
            this.ShortWeatherIcon4.Name = "ShortWeatherIcon4";
            this.ShortWeatherIcon4.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon4.TabIndex = 69;
            this.ShortWeatherIcon4.TabStop = false;
            // 
            // metroLabel32
            // 
            this.metroLabel32.AutoSize = true;
            this.metroLabel32.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel32.Location = new System.Drawing.Point(6, 24);
            this.metroLabel32.Name = "metroLabel32";
            this.metroLabel32.Size = new System.Drawing.Size(191, 21);
            this.metroLabel32.TabIndex = 68;
            this.metroLabel32.Text = "4~67시간 후 (3시간 간격)";
            this.metroLabel32.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShortWeatherExplain1
            // 
            this.ShortWeatherExplain1.AutoSize = true;
            this.ShortWeatherExplain1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShortWeatherExplain1.Location = new System.Drawing.Point(27, 145);
            this.ShortWeatherExplain1.Name = "ShortWeatherExplain1";
            this.ShortWeatherExplain1.Size = new System.Drawing.Size(49, 21);
            this.ShortWeatherExplain1.TabIndex = 63;
            this.ShortWeatherExplain1.Text = "NULL";
            this.ShortWeatherExplain1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReleaseTime3
            // 
            this.ReleaseTime3.AutoSize = true;
            this.ReleaseTime3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ReleaseTime3.Location = new System.Drawing.Point(97, 3);
            this.ReleaseTime3.Name = "ReleaseTime3";
            this.ReleaseTime3.Size = new System.Drawing.Size(19, 21);
            this.ReleaseTime3.TabIndex = 67;
            this.ReleaseTime3.Text = "0";
            // 
            // metroLabel37
            // 
            this.metroLabel37.AutoSize = true;
            this.metroLabel37.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel37.Location = new System.Drawing.Point(6, 3);
            this.metroLabel37.Name = "metroLabel37";
            this.metroLabel37.Size = new System.Drawing.Size(85, 21);
            this.metroLabel37.TabIndex = 66;
            this.metroLabel37.Text = "관측 시간 :";
            // 
            // ShortWeatherIcon2
            // 
            this.ShortWeatherIcon2.Location = new System.Drawing.Point(104, 48);
            this.ShortWeatherIcon2.Name = "ShortWeatherIcon2";
            this.ShortWeatherIcon2.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon2.TabIndex = 62;
            this.ShortWeatherIcon2.TabStop = false;
            // 
            // ShortWeatherIcon3
            // 
            this.ShortWeatherIcon3.Location = new System.Drawing.Point(204, 48);
            this.ShortWeatherIcon3.Name = "ShortWeatherIcon3";
            this.ShortWeatherIcon3.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon3.TabIndex = 64;
            this.ShortWeatherIcon3.TabStop = false;
            // 
            // ShortWeatherIcon1
            // 
            this.ShortWeatherIcon1.Location = new System.Drawing.Point(4, 48);
            this.ShortWeatherIcon1.Name = "ShortWeatherIcon1";
            this.ShortWeatherIcon1.Size = new System.Drawing.Size(94, 94);
            this.ShortWeatherIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWeatherIcon1.TabIndex = 60;
            this.ShortWeatherIcon1.TabStop = false;
            // 
            // Forecast6DaysWeather
            // 
            this.Forecast6DaysWeather.AutoScroll = true;
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain16);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain17);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain18);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon18);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain15);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon16);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon17);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon15);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain11);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain12);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain13);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain14);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon14);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon13);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon11);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon12);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel63);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel62);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel77);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel80);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMin9);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel112);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMax9);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel114);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel115);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel116);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel117);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMin8);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMin7);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMin6);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMax8);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel122);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMax7);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel124);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMax6);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel126);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel78);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel79);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMin5);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMin4);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMax5);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel108);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMax4);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel110);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel35);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel58);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMin3);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMin2);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMin1);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMax3);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel66);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMax2);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel68);
            this.Forecast6DaysWeather.Controls.Add(this.LongTMax1);
            this.Forecast6DaysWeather.Controls.Add(this.LongTemperatureGraph);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain7);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain8);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain9);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain10);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon10);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon9);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain6);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon7);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon8);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon6);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel72);
            this.Forecast6DaysWeather.Controls.Add(this.ReleaseTime4);
            this.Forecast6DaysWeather.Controls.Add(this.metroLabel74);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain2);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain3);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain4);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain5);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon5);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon4);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherExplain1);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon2);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon3);
            this.Forecast6DaysWeather.Controls.Add(this.LongWeatherIcon1);
            this.Forecast6DaysWeather.Location = new System.Drawing.Point(4, 49);
            this.Forecast6DaysWeather.Name = "Forecast6DaysWeather";
            this.Forecast6DaysWeather.Size = new System.Drawing.Size(818, 519);
            this.Forecast6DaysWeather.TabIndex = 5;
            this.Forecast6DaysWeather.Text = "중기 예보";
            this.Forecast6DaysWeather.UseVisualStyleBackColor = true;
            // 
            // SevereAlertWeather
            // 
            this.SevereAlertWeather.AutoScroll = true;
            this.SevereAlertWeather.Controls.Add(this.metroLabel60);
            this.SevereAlertWeather.Location = new System.Drawing.Point(4, 49);
            this.SevereAlertWeather.Name = "SevereAlertWeather";
            this.SevereAlertWeather.Size = new System.Drawing.Size(818, 519);
            this.SevereAlertWeather.TabIndex = 6;
            this.SevereAlertWeather.Text = "기상 특보";
            this.SevereAlertWeather.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RefreshButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.RefreshButton.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.RefreshButton.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.RefreshButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.RefreshButton.Location = new System.Drawing.Point(813, 25);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.RefreshButton.Size = new System.Drawing.Size(36, 36);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MetroLabel4
            // 
            this.MetroLabel4.AutoSize = true;
            this.MetroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.MetroLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MetroLabel4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MetroLabel4.Location = new System.Drawing.Point(5, 5);
            this.MetroLabel4.Name = "MetroLabel4";
            this.MetroLabel4.Size = new System.Drawing.Size(88, 15);
            this.MetroLabel4.TabIndex = 3;
            this.MetroLabel4.Text = "새로고침 시각 :";
            // 
            // RefreshTime
            // 
            this.RefreshTime.AutoSize = true;
            this.RefreshTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.RefreshTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RefreshTime.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RefreshTime.Location = new System.Drawing.Point(99, 5);
            this.RefreshTime.Name = "RefreshTime";
            this.RefreshTime.Size = new System.Drawing.Size(13, 15);
            this.RefreshTime.TabIndex = 4;
            this.RefreshTime.Text = "0";
            // 
            // LongWeatherExplain2
            // 
            this.LongWeatherExplain2.AutoSize = true;
            this.LongWeatherExplain2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain2.Location = new System.Drawing.Point(215, 222);
            this.LongWeatherExplain2.Name = "LongWeatherExplain2";
            this.LongWeatherExplain2.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain2.TabIndex = 127;
            this.LongWeatherExplain2.Text = "NULL";
            this.LongWeatherExplain2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherExplain3
            // 
            this.LongWeatherExplain3.AutoSize = true;
            this.LongWeatherExplain3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain3.Location = new System.Drawing.Point(377, 222);
            this.LongWeatherExplain3.Name = "LongWeatherExplain3";
            this.LongWeatherExplain3.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain3.TabIndex = 126;
            this.LongWeatherExplain3.Text = "NULL";
            this.LongWeatherExplain3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherExplain4
            // 
            this.LongWeatherExplain4.AutoSize = true;
            this.LongWeatherExplain4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain4.Location = new System.Drawing.Point(538, 222);
            this.LongWeatherExplain4.Name = "LongWeatherExplain4";
            this.LongWeatherExplain4.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain4.TabIndex = 125;
            this.LongWeatherExplain4.Text = "NULL";
            this.LongWeatherExplain4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherExplain5
            // 
            this.LongWeatherExplain5.AutoSize = true;
            this.LongWeatherExplain5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain5.Location = new System.Drawing.Point(699, 222);
            this.LongWeatherExplain5.Name = "LongWeatherExplain5";
            this.LongWeatherExplain5.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain5.TabIndex = 124;
            this.LongWeatherExplain5.Text = "NULL";
            this.LongWeatherExplain5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherIcon5
            // 
            this.LongWeatherIcon5.Location = new System.Drawing.Point(648, 69);
            this.LongWeatherIcon5.Name = "LongWeatherIcon5";
            this.LongWeatherIcon5.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon5.TabIndex = 113;
            this.LongWeatherIcon5.TabStop = false;
            // 
            // LongWeatherIcon4
            // 
            this.LongWeatherIcon4.Location = new System.Drawing.Point(487, 69);
            this.LongWeatherIcon4.Name = "LongWeatherIcon4";
            this.LongWeatherIcon4.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon4.TabIndex = 112;
            this.LongWeatherIcon4.TabStop = false;
            // 
            // LongWeatherExplain1
            // 
            this.LongWeatherExplain1.AutoSize = true;
            this.LongWeatherExplain1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain1.Location = new System.Drawing.Point(54, 222);
            this.LongWeatherExplain1.Name = "LongWeatherExplain1";
            this.LongWeatherExplain1.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain1.TabIndex = 110;
            this.LongWeatherExplain1.Text = "NULL";
            this.LongWeatherExplain1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherIcon2
            // 
            this.LongWeatherIcon2.Location = new System.Drawing.Point(164, 69);
            this.LongWeatherIcon2.Name = "LongWeatherIcon2";
            this.LongWeatherIcon2.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon2.TabIndex = 109;
            this.LongWeatherIcon2.TabStop = false;
            // 
            // LongWeatherIcon3
            // 
            this.LongWeatherIcon3.Location = new System.Drawing.Point(326, 69);
            this.LongWeatherIcon3.Name = "LongWeatherIcon3";
            this.LongWeatherIcon3.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon3.TabIndex = 111;
            this.LongWeatherIcon3.TabStop = false;
            // 
            // LongWeatherIcon1
            // 
            this.LongWeatherIcon1.Location = new System.Drawing.Point(3, 69);
            this.LongWeatherIcon1.Name = "LongWeatherIcon1";
            this.LongWeatherIcon1.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon1.TabIndex = 108;
            this.LongWeatherIcon1.TabStop = false;
            // 
            // metroLabel72
            // 
            this.metroLabel72.AutoSize = true;
            this.metroLabel72.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel72.Location = new System.Drawing.Point(6, 24);
            this.metroLabel72.Name = "metroLabel72";
            this.metroLabel72.Size = new System.Drawing.Size(175, 21);
            this.metroLabel72.TabIndex = 130;
            this.metroLabel72.Text = "2일~10일 후 (1일 간격)";
            this.metroLabel72.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReleaseTime4
            // 
            this.ReleaseTime4.AutoSize = true;
            this.ReleaseTime4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ReleaseTime4.Location = new System.Drawing.Point(97, 3);
            this.ReleaseTime4.Name = "ReleaseTime4";
            this.ReleaseTime4.Size = new System.Drawing.Size(19, 21);
            this.ReleaseTime4.TabIndex = 129;
            this.ReleaseTime4.Text = "0";
            // 
            // metroLabel74
            // 
            this.metroLabel74.AutoSize = true;
            this.metroLabel74.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel74.Location = new System.Drawing.Point(6, 3);
            this.metroLabel74.Name = "metroLabel74";
            this.metroLabel74.Size = new System.Drawing.Size(85, 21);
            this.metroLabel74.TabIndex = 128;
            this.metroLabel74.Text = "관측 시간 :";
            // 
            // LongWeatherExplain7
            // 
            this.LongWeatherExplain7.AutoSize = true;
            this.LongWeatherExplain7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain7.Location = new System.Drawing.Point(215, 399);
            this.LongWeatherExplain7.Name = "LongWeatherExplain7";
            this.LongWeatherExplain7.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain7.TabIndex = 140;
            this.LongWeatherExplain7.Text = "NULL";
            this.LongWeatherExplain7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherExplain8
            // 
            this.LongWeatherExplain8.AutoSize = true;
            this.LongWeatherExplain8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain8.Location = new System.Drawing.Point(377, 399);
            this.LongWeatherExplain8.Name = "LongWeatherExplain8";
            this.LongWeatherExplain8.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain8.TabIndex = 139;
            this.LongWeatherExplain8.Text = "NULL";
            this.LongWeatherExplain8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherExplain9
            // 
            this.LongWeatherExplain9.AutoSize = true;
            this.LongWeatherExplain9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain9.Location = new System.Drawing.Point(538, 399);
            this.LongWeatherExplain9.Name = "LongWeatherExplain9";
            this.LongWeatherExplain9.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain9.TabIndex = 138;
            this.LongWeatherExplain9.Text = "NULL";
            this.LongWeatherExplain9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherIcon9
            // 
            this.LongWeatherIcon9.Location = new System.Drawing.Point(487, 246);
            this.LongWeatherIcon9.Name = "LongWeatherIcon9";
            this.LongWeatherIcon9.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon9.TabIndex = 135;
            this.LongWeatherIcon9.TabStop = false;
            // 
            // LongWeatherExplain6
            // 
            this.LongWeatherExplain6.AutoSize = true;
            this.LongWeatherExplain6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain6.Location = new System.Drawing.Point(54, 399);
            this.LongWeatherExplain6.Name = "LongWeatherExplain6";
            this.LongWeatherExplain6.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain6.TabIndex = 133;
            this.LongWeatherExplain6.Text = "NULL";
            this.LongWeatherExplain6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherIcon7
            // 
            this.LongWeatherIcon7.Location = new System.Drawing.Point(164, 246);
            this.LongWeatherIcon7.Name = "LongWeatherIcon7";
            this.LongWeatherIcon7.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon7.TabIndex = 132;
            this.LongWeatherIcon7.TabStop = false;
            // 
            // LongWeatherIcon8
            // 
            this.LongWeatherIcon8.Location = new System.Drawing.Point(326, 246);
            this.LongWeatherIcon8.Name = "LongWeatherIcon8";
            this.LongWeatherIcon8.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon8.TabIndex = 134;
            this.LongWeatherIcon8.TabStop = false;
            // 
            // LongWeatherIcon6
            // 
            this.LongWeatherIcon6.Location = new System.Drawing.Point(3, 246);
            this.LongWeatherIcon6.Name = "LongWeatherIcon6";
            this.LongWeatherIcon6.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon6.TabIndex = 131;
            this.LongWeatherIcon6.TabStop = false;
            // 
            // LongTemperatureGraph
            // 
            this.LongTemperatureGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LongTemperatureGraph.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.LongTemperatureGraph.ClassicFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LongTemperatureGraph.ClassicLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LongTemperatureGraph.DefaultColor = System.Drawing.Color.White;
            this.LongTemperatureGraph.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LongTemperatureGraph.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.LongTemperatureGraph.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.LongTemperatureGraph.HoverBoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.LongTemperatureGraph.HoverBoxColor = System.Drawing.Color.White;
            this.LongTemperatureGraph.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LongTemperatureGraph.Location = new System.Drawing.Point(3, 822);
            this.LongTemperatureGraph.Name = "LongTemperatureGraph";
            this.LongTemperatureGraph.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LongTemperatureGraph.Size = new System.Drawing.Size(795, 227);
            this.LongTemperatureGraph.TabIndex = 141;
            this.LongTemperatureGraph.Text = "metroGraph1";
            // 
            // metroLabel35
            // 
            this.metroLabel35.AutoSize = true;
            this.metroLabel35.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel35.Location = new System.Drawing.Point(456, 1073);
            this.metroLabel35.Name = "metroLabel35";
            this.metroLabel35.Size = new System.Drawing.Size(134, 21);
            this.metroLabel35.TabIndex = 207;
            this.metroLabel35.Text = "3일 후 최저 기온 :";
            // 
            // metroLabel58
            // 
            this.metroLabel58.AutoSize = true;
            this.metroLabel58.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel58.Location = new System.Drawing.Point(456, 1052);
            this.metroLabel58.Name = "metroLabel58";
            this.metroLabel58.Size = new System.Drawing.Size(134, 21);
            this.metroLabel58.TabIndex = 206;
            this.metroLabel58.Text = "2일 후 최저 기온 :";
            // 
            // LongTMin3
            // 
            this.LongTMin3.AutoSize = true;
            this.LongTMin3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMin3.Location = new System.Drawing.Point(596, 1094);
            this.LongTMin3.Name = "LongTMin3";
            this.LongTMin3.Size = new System.Drawing.Size(19, 21);
            this.LongTMin3.TabIndex = 204;
            this.LongTMin3.Text = "0";
            // 
            // LongTMin2
            // 
            this.LongTMin2.AutoSize = true;
            this.LongTMin2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMin2.Location = new System.Drawing.Point(596, 1073);
            this.LongTMin2.Name = "LongTMin2";
            this.LongTMin2.Size = new System.Drawing.Size(19, 21);
            this.LongTMin2.TabIndex = 203;
            this.LongTMin2.Text = "0";
            // 
            // LongTMax3
            // 
            this.LongTMax3.AutoSize = true;
            this.LongTMax3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMax3.Location = new System.Drawing.Point(251, 1094);
            this.LongTMax3.Name = "LongTMax3";
            this.LongTMax3.Size = new System.Drawing.Size(19, 21);
            this.LongTMax3.TabIndex = 201;
            this.LongTMax3.Text = "0";
            // 
            // metroLabel66
            // 
            this.metroLabel66.AutoSize = true;
            this.metroLabel66.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel66.Location = new System.Drawing.Point(111, 1073);
            this.metroLabel66.Name = "metroLabel66";
            this.metroLabel66.Size = new System.Drawing.Size(134, 21);
            this.metroLabel66.TabIndex = 200;
            this.metroLabel66.Text = "3일 후 최고 기온 :";
            // 
            // LongTMax2
            // 
            this.LongTMax2.AutoSize = true;
            this.LongTMax2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMax2.Location = new System.Drawing.Point(251, 1073);
            this.LongTMax2.Name = "LongTMax2";
            this.LongTMax2.Size = new System.Drawing.Size(19, 21);
            this.LongTMax2.TabIndex = 199;
            this.LongTMax2.Text = "0";
            // 
            // metroLabel68
            // 
            this.metroLabel68.AutoSize = true;
            this.metroLabel68.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel68.Location = new System.Drawing.Point(111, 1052);
            this.metroLabel68.Name = "metroLabel68";
            this.metroLabel68.Size = new System.Drawing.Size(134, 21);
            this.metroLabel68.TabIndex = 198;
            this.metroLabel68.Text = "2일 후 최고 기온 :";
            // 
            // metroLabel78
            // 
            this.metroLabel78.AutoSize = true;
            this.metroLabel78.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel78.Location = new System.Drawing.Point(456, 1115);
            this.metroLabel78.Name = "metroLabel78";
            this.metroLabel78.Size = new System.Drawing.Size(134, 21);
            this.metroLabel78.TabIndex = 218;
            this.metroLabel78.Text = "5일 후 최저 기온 :";
            // 
            // metroLabel79
            // 
            this.metroLabel79.AutoSize = true;
            this.metroLabel79.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel79.Location = new System.Drawing.Point(456, 1094);
            this.metroLabel79.Name = "metroLabel79";
            this.metroLabel79.Size = new System.Drawing.Size(134, 21);
            this.metroLabel79.TabIndex = 217;
            this.metroLabel79.Text = "4일 후 최저 기온 :";
            // 
            // LongTMin5
            // 
            this.LongTMin5.AutoSize = true;
            this.LongTMin5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMin5.Location = new System.Drawing.Point(596, 1136);
            this.LongTMin5.Name = "LongTMin5";
            this.LongTMin5.Size = new System.Drawing.Size(19, 21);
            this.LongTMin5.TabIndex = 215;
            this.LongTMin5.Text = "0";
            // 
            // LongTMin4
            // 
            this.LongTMin4.AutoSize = true;
            this.LongTMin4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMin4.Location = new System.Drawing.Point(596, 1115);
            this.LongTMin4.Name = "LongTMin4";
            this.LongTMin4.Size = new System.Drawing.Size(19, 21);
            this.LongTMin4.TabIndex = 214;
            this.LongTMin4.Text = "0";
            // 
            // LongTMax5
            // 
            this.LongTMax5.AutoSize = true;
            this.LongTMax5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMax5.Location = new System.Drawing.Point(251, 1136);
            this.LongTMax5.Name = "LongTMax5";
            this.LongTMax5.Size = new System.Drawing.Size(19, 21);
            this.LongTMax5.TabIndex = 211;
            this.LongTMax5.Text = "0";
            // 
            // metroLabel108
            // 
            this.metroLabel108.AutoSize = true;
            this.metroLabel108.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel108.Location = new System.Drawing.Point(111, 1115);
            this.metroLabel108.Name = "metroLabel108";
            this.metroLabel108.Size = new System.Drawing.Size(134, 21);
            this.metroLabel108.TabIndex = 210;
            this.metroLabel108.Text = "5일 후 최고 기온 :";
            // 
            // LongTMax4
            // 
            this.LongTMax4.AutoSize = true;
            this.LongTMax4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMax4.Location = new System.Drawing.Point(251, 1115);
            this.LongTMax4.Name = "LongTMax4";
            this.LongTMax4.Size = new System.Drawing.Size(19, 21);
            this.LongTMax4.TabIndex = 209;
            this.LongTMax4.Text = "0";
            // 
            // metroLabel110
            // 
            this.metroLabel110.AutoSize = true;
            this.metroLabel110.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel110.Location = new System.Drawing.Point(111, 1094);
            this.metroLabel110.Name = "metroLabel110";
            this.metroLabel110.Size = new System.Drawing.Size(134, 21);
            this.metroLabel110.TabIndex = 208;
            this.metroLabel110.Text = "4일 후 최고 기온 :";
            // 
            // metroLabel77
            // 
            this.metroLabel77.AutoSize = true;
            this.metroLabel77.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel77.Location = new System.Drawing.Point(456, 1220);
            this.metroLabel77.Name = "metroLabel77";
            this.metroLabel77.Size = new System.Drawing.Size(143, 21);
            this.metroLabel77.TabIndex = 238;
            this.metroLabel77.Text = "10일 후 최저 기온 :";
            // 
            // metroLabel80
            // 
            this.metroLabel80.AutoSize = true;
            this.metroLabel80.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel80.Location = new System.Drawing.Point(456, 1199);
            this.metroLabel80.Name = "metroLabel80";
            this.metroLabel80.Size = new System.Drawing.Size(134, 21);
            this.metroLabel80.TabIndex = 237;
            this.metroLabel80.Text = "9일 후 최저 기온 :";
            // 
            // LongTMin9
            // 
            this.LongTMin9.AutoSize = true;
            this.LongTMin9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMin9.Location = new System.Drawing.Point(605, 1220);
            this.LongTMin9.Name = "LongTMin9";
            this.LongTMin9.Size = new System.Drawing.Size(19, 21);
            this.LongTMin9.TabIndex = 235;
            this.LongTMin9.Text = "0";
            // 
            // metroLabel112
            // 
            this.metroLabel112.AutoSize = true;
            this.metroLabel112.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel112.Location = new System.Drawing.Point(111, 1220);
            this.metroLabel112.Name = "metroLabel112";
            this.metroLabel112.Size = new System.Drawing.Size(143, 21);
            this.metroLabel112.TabIndex = 233;
            this.metroLabel112.Text = "10일 후 최고 기온 :";
            // 
            // LongTMax9
            // 
            this.LongTMax9.AutoSize = true;
            this.LongTMax9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMax9.Location = new System.Drawing.Point(260, 1220);
            this.LongTMax9.Name = "LongTMax9";
            this.LongTMax9.Size = new System.Drawing.Size(19, 21);
            this.LongTMax9.TabIndex = 232;
            this.LongTMax9.Text = "0";
            // 
            // metroLabel114
            // 
            this.metroLabel114.AutoSize = true;
            this.metroLabel114.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel114.Location = new System.Drawing.Point(111, 1199);
            this.metroLabel114.Name = "metroLabel114";
            this.metroLabel114.Size = new System.Drawing.Size(134, 21);
            this.metroLabel114.TabIndex = 231;
            this.metroLabel114.Text = "9일 후 최고 기온 :";
            // 
            // metroLabel115
            // 
            this.metroLabel115.AutoSize = true;
            this.metroLabel115.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel115.Location = new System.Drawing.Point(456, 1178);
            this.metroLabel115.Name = "metroLabel115";
            this.metroLabel115.Size = new System.Drawing.Size(134, 21);
            this.metroLabel115.TabIndex = 230;
            this.metroLabel115.Text = "8일 후 최저 기온 :";
            // 
            // metroLabel116
            // 
            this.metroLabel116.AutoSize = true;
            this.metroLabel116.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel116.Location = new System.Drawing.Point(456, 1157);
            this.metroLabel116.Name = "metroLabel116";
            this.metroLabel116.Size = new System.Drawing.Size(134, 21);
            this.metroLabel116.TabIndex = 229;
            this.metroLabel116.Text = "7일 후 최저 기온 :";
            // 
            // metroLabel117
            // 
            this.metroLabel117.AutoSize = true;
            this.metroLabel117.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel117.Location = new System.Drawing.Point(456, 1136);
            this.metroLabel117.Name = "metroLabel117";
            this.metroLabel117.Size = new System.Drawing.Size(134, 21);
            this.metroLabel117.TabIndex = 228;
            this.metroLabel117.Text = "6일 후 최저 기온 :";
            // 
            // LongTMin8
            // 
            this.LongTMin8.AutoSize = true;
            this.LongTMin8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMin8.Location = new System.Drawing.Point(596, 1199);
            this.LongTMin8.Name = "LongTMin8";
            this.LongTMin8.Size = new System.Drawing.Size(19, 21);
            this.LongTMin8.TabIndex = 227;
            this.LongTMin8.Text = "0";
            // 
            // LongTMin7
            // 
            this.LongTMin7.AutoSize = true;
            this.LongTMin7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMin7.Location = new System.Drawing.Point(596, 1178);
            this.LongTMin7.Name = "LongTMin7";
            this.LongTMin7.Size = new System.Drawing.Size(19, 21);
            this.LongTMin7.TabIndex = 226;
            this.LongTMin7.Text = "0";
            // 
            // LongTMin6
            // 
            this.LongTMin6.AutoSize = true;
            this.LongTMin6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMin6.Location = new System.Drawing.Point(596, 1156);
            this.LongTMin6.Name = "LongTMin6";
            this.LongTMin6.Size = new System.Drawing.Size(19, 21);
            this.LongTMin6.TabIndex = 225;
            this.LongTMin6.Text = "0";
            // 
            // LongTMax8
            // 
            this.LongTMax8.AutoSize = true;
            this.LongTMax8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMax8.Location = new System.Drawing.Point(251, 1199);
            this.LongTMax8.Name = "LongTMax8";
            this.LongTMax8.Size = new System.Drawing.Size(19, 21);
            this.LongTMax8.TabIndex = 224;
            this.LongTMax8.Text = "0";
            // 
            // metroLabel122
            // 
            this.metroLabel122.AutoSize = true;
            this.metroLabel122.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel122.Location = new System.Drawing.Point(111, 1178);
            this.metroLabel122.Name = "metroLabel122";
            this.metroLabel122.Size = new System.Drawing.Size(134, 21);
            this.metroLabel122.TabIndex = 223;
            this.metroLabel122.Text = "8일 후 최고 기온 :";
            // 
            // LongTMax7
            // 
            this.LongTMax7.AutoSize = true;
            this.LongTMax7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMax7.Location = new System.Drawing.Point(251, 1178);
            this.LongTMax7.Name = "LongTMax7";
            this.LongTMax7.Size = new System.Drawing.Size(19, 21);
            this.LongTMax7.TabIndex = 222;
            this.LongTMax7.Text = "0";
            // 
            // metroLabel124
            // 
            this.metroLabel124.AutoSize = true;
            this.metroLabel124.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel124.Location = new System.Drawing.Point(111, 1157);
            this.metroLabel124.Name = "metroLabel124";
            this.metroLabel124.Size = new System.Drawing.Size(134, 21);
            this.metroLabel124.TabIndex = 221;
            this.metroLabel124.Text = "7일 후 최고 기온 :";
            // 
            // LongTMax6
            // 
            this.LongTMax6.AutoSize = true;
            this.LongTMax6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMax6.Location = new System.Drawing.Point(251, 1157);
            this.LongTMax6.Name = "LongTMax6";
            this.LongTMax6.Size = new System.Drawing.Size(19, 21);
            this.LongTMax6.TabIndex = 220;
            this.LongTMax6.Text = "0";
            // 
            // metroLabel126
            // 
            this.metroLabel126.AutoSize = true;
            this.metroLabel126.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel126.Location = new System.Drawing.Point(111, 1136);
            this.metroLabel126.Name = "metroLabel126";
            this.metroLabel126.Size = new System.Drawing.Size(134, 21);
            this.metroLabel126.TabIndex = 219;
            this.metroLabel126.Text = "6일 후 최고 기온 :";
            // 
            // metroLabel62
            // 
            this.metroLabel62.AutoSize = true;
            this.metroLabel62.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel62.Location = new System.Drawing.Point(6, 45);
            this.metroLabel62.Name = "metroLabel62";
            this.metroLabel62.Size = new System.Drawing.Size(78, 21);
            this.metroLabel62.TabIndex = 239;
            this.metroLabel62.Text = "아침 날씨";
            // 
            // LongWeatherExplain10
            // 
            this.LongWeatherExplain10.AutoSize = true;
            this.LongWeatherExplain10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain10.Location = new System.Drawing.Point(54, 621);
            this.LongWeatherExplain10.Name = "LongWeatherExplain10";
            this.LongWeatherExplain10.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain10.TabIndex = 137;
            this.LongWeatherExplain10.Text = "NULL";
            this.LongWeatherExplain10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherIcon10
            // 
            this.LongWeatherIcon10.Location = new System.Drawing.Point(3, 468);
            this.LongWeatherIcon10.Name = "LongWeatherIcon10";
            this.LongWeatherIcon10.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon10.TabIndex = 136;
            this.LongWeatherIcon10.TabStop = false;
            // 
            // metroLabel63
            // 
            this.metroLabel63.AutoSize = true;
            this.metroLabel63.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel63.Location = new System.Drawing.Point(6, 444);
            this.metroLabel63.Name = "metroLabel63";
            this.metroLabel63.Size = new System.Drawing.Size(78, 21);
            this.metroLabel63.TabIndex = 240;
            this.metroLabel63.Text = "저녁 날씨";
            // 
            // LongWeatherExplain16
            // 
            this.LongWeatherExplain16.AutoSize = true;
            this.LongWeatherExplain16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain16.Location = new System.Drawing.Point(215, 798);
            this.LongWeatherExplain16.Name = "LongWeatherExplain16";
            this.LongWeatherExplain16.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain16.TabIndex = 256;
            this.LongWeatherExplain16.Text = "NULL";
            this.LongWeatherExplain16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherExplain17
            // 
            this.LongWeatherExplain17.AutoSize = true;
            this.LongWeatherExplain17.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain17.Location = new System.Drawing.Point(377, 798);
            this.LongWeatherExplain17.Name = "LongWeatherExplain17";
            this.LongWeatherExplain17.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain17.TabIndex = 255;
            this.LongWeatherExplain17.Text = "NULL";
            this.LongWeatherExplain17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherExplain18
            // 
            this.LongWeatherExplain18.AutoSize = true;
            this.LongWeatherExplain18.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain18.Location = new System.Drawing.Point(538, 798);
            this.LongWeatherExplain18.Name = "LongWeatherExplain18";
            this.LongWeatherExplain18.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain18.TabIndex = 254;
            this.LongWeatherExplain18.Text = "NULL";
            this.LongWeatherExplain18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherIcon18
            // 
            this.LongWeatherIcon18.Location = new System.Drawing.Point(487, 645);
            this.LongWeatherIcon18.Name = "LongWeatherIcon18";
            this.LongWeatherIcon18.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon18.TabIndex = 253;
            this.LongWeatherIcon18.TabStop = false;
            // 
            // LongWeatherExplain15
            // 
            this.LongWeatherExplain15.AutoSize = true;
            this.LongWeatherExplain15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain15.Location = new System.Drawing.Point(54, 798);
            this.LongWeatherExplain15.Name = "LongWeatherExplain15";
            this.LongWeatherExplain15.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain15.TabIndex = 251;
            this.LongWeatherExplain15.Text = "NULL";
            this.LongWeatherExplain15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherIcon16
            // 
            this.LongWeatherIcon16.Location = new System.Drawing.Point(164, 645);
            this.LongWeatherIcon16.Name = "LongWeatherIcon16";
            this.LongWeatherIcon16.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon16.TabIndex = 250;
            this.LongWeatherIcon16.TabStop = false;
            // 
            // LongWeatherIcon17
            // 
            this.LongWeatherIcon17.Location = new System.Drawing.Point(326, 645);
            this.LongWeatherIcon17.Name = "LongWeatherIcon17";
            this.LongWeatherIcon17.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon17.TabIndex = 252;
            this.LongWeatherIcon17.TabStop = false;
            // 
            // LongWeatherIcon15
            // 
            this.LongWeatherIcon15.Location = new System.Drawing.Point(3, 645);
            this.LongWeatherIcon15.Name = "LongWeatherIcon15";
            this.LongWeatherIcon15.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon15.TabIndex = 249;
            this.LongWeatherIcon15.TabStop = false;
            // 
            // LongWeatherExplain11
            // 
            this.LongWeatherExplain11.AutoSize = true;
            this.LongWeatherExplain11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain11.Location = new System.Drawing.Point(215, 621);
            this.LongWeatherExplain11.Name = "LongWeatherExplain11";
            this.LongWeatherExplain11.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain11.TabIndex = 248;
            this.LongWeatherExplain11.Text = "NULL";
            this.LongWeatherExplain11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherExplain12
            // 
            this.LongWeatherExplain12.AutoSize = true;
            this.LongWeatherExplain12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain12.Location = new System.Drawing.Point(377, 621);
            this.LongWeatherExplain12.Name = "LongWeatherExplain12";
            this.LongWeatherExplain12.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain12.TabIndex = 247;
            this.LongWeatherExplain12.Text = "NULL";
            this.LongWeatherExplain12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherExplain13
            // 
            this.LongWeatherExplain13.AutoSize = true;
            this.LongWeatherExplain13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain13.Location = new System.Drawing.Point(538, 621);
            this.LongWeatherExplain13.Name = "LongWeatherExplain13";
            this.LongWeatherExplain13.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain13.TabIndex = 246;
            this.LongWeatherExplain13.Text = "NULL";
            this.LongWeatherExplain13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherExplain14
            // 
            this.LongWeatherExplain14.AutoSize = true;
            this.LongWeatherExplain14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongWeatherExplain14.Location = new System.Drawing.Point(699, 621);
            this.LongWeatherExplain14.Name = "LongWeatherExplain14";
            this.LongWeatherExplain14.Size = new System.Drawing.Size(49, 21);
            this.LongWeatherExplain14.TabIndex = 245;
            this.LongWeatherExplain14.Text = "NULL";
            this.LongWeatherExplain14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LongWeatherIcon14
            // 
            this.LongWeatherIcon14.Location = new System.Drawing.Point(648, 468);
            this.LongWeatherIcon14.Name = "LongWeatherIcon14";
            this.LongWeatherIcon14.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon14.TabIndex = 244;
            this.LongWeatherIcon14.TabStop = false;
            // 
            // LongWeatherIcon13
            // 
            this.LongWeatherIcon13.Location = new System.Drawing.Point(487, 468);
            this.LongWeatherIcon13.Name = "LongWeatherIcon13";
            this.LongWeatherIcon13.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon13.TabIndex = 243;
            this.LongWeatherIcon13.TabStop = false;
            // 
            // LongWeatherIcon11
            // 
            this.LongWeatherIcon11.Location = new System.Drawing.Point(164, 468);
            this.LongWeatherIcon11.Name = "LongWeatherIcon11";
            this.LongWeatherIcon11.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon11.TabIndex = 241;
            this.LongWeatherIcon11.TabStop = false;
            // 
            // LongWeatherIcon12
            // 
            this.LongWeatherIcon12.Location = new System.Drawing.Point(326, 468);
            this.LongWeatherIcon12.Name = "LongWeatherIcon12";
            this.LongWeatherIcon12.Size = new System.Drawing.Size(150, 150);
            this.LongWeatherIcon12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWeatherIcon12.TabIndex = 242;
            this.LongWeatherIcon12.TabStop = false;
            // 
            // LongTMax1
            // 
            this.LongTMax1.AutoSize = true;
            this.LongTMax1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMax1.Location = new System.Drawing.Point(251, 1052);
            this.LongTMax1.Name = "LongTMax1";
            this.LongTMax1.Size = new System.Drawing.Size(19, 21);
            this.LongTMax1.TabIndex = 197;
            this.LongTMax1.Text = "0";
            // 
            // LongTMin1
            // 
            this.LongTMin1.AutoSize = true;
            this.LongTMin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LongTMin1.Location = new System.Drawing.Point(596, 1051);
            this.LongTMin1.Name = "LongTMin1";
            this.LongTMin1.Size = new System.Drawing.Size(19, 21);
            this.LongTMin1.TabIndex = 202;
            this.LongTMin1.Text = "0";
            // 
            // metroLabel60
            // 
            this.metroLabel60.AutoSize = true;
            this.metroLabel60.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.metroLabel60.Location = new System.Drawing.Point(364, 290);
            this.metroLabel60.Name = "metroLabel60";
            this.metroLabel60.Size = new System.Drawing.Size(98, 37);
            this.metroLabel60.TabIndex = 0;
            this.metroLabel60.Text = "준비중";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 660);
            this.Controls.Add(this.RefreshTime);
            this.Controls.Add(this.MetroLabel4);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.WeatherInfo);
            this.Controls.Add(this.LocationSetButton);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "날씨";
            this.WeatherInfo.ResumeLayout(false);
            this.SummaryWeather.ResumeLayout(false);
            this.SummaryWeather.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.Current1MinutelyWeather.ResumeLayout(false);
            this.Current1MinutelyWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentWeatherIcon)).EndInit();
            this.Forecast3HourlyWeather.ResumeLayout(false);
            this.Forecast3HourlyWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FourHourWeatherIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoHourWeatherIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreeHourWeatherIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneHourWeatherIcon)).EndInit();
            this.Forecast3DaysWeather.ResumeLayout(false);
            this.Forecast3DaysWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWeatherIcon1)).EndInit();
            this.Forecast6DaysWeather.ResumeLayout(false);
            this.Forecast6DaysWeather.PerformLayout();
            this.SevereAlertWeather.ResumeLayout(false);
            this.SevereAlertWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWeatherIcon12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem regionSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selfSelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private MetroSuite.MetroNavigationButton LocationSetButton;
        private System.Windows.Forms.ToolTip LocationSetTip;
        private MetroSuite.MetroTabControl WeatherInfo;
        private System.Windows.Forms.TabPage Current1MinutelyWeather;
        private System.Windows.Forms.TabPage SummaryWeather;
        private System.Windows.Forms.TabPage Forecast3HourlyWeather;
        private System.Windows.Forms.TabPage Forecast3DaysWeather;
        private System.Windows.Forms.TabPage Forecast6DaysWeather;
        private System.Windows.Forms.TabPage SevereAlertWeather;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox WeatherIcon1;
        private MetroSuite.MetroLabel WeatherExplain1;
        private System.Windows.Forms.PictureBox WeatherIcon2;
        private MetroSuite.MetroLabel WeatherExplain2;
        private MetroSuite.MetroButton RefreshButton;
        private System.Windows.Forms.ToolTip RefreshTip;
        private MetroSuite.MetroLabel MetroLabel4;
        private MetroSuite.MetroLabel RefreshTime;
        private MetroSuite.MetroGraph TemperatureGraph1;
        private MetroSuite.MetroGraph TemperatureGraph2;
        private MetroSuite.MetroGraph TemperatureGraph3;
        private MetroSuite.MetroLabel TodayTmin;
        private MetroSuite.MetroLabel metroLabel9;
        private MetroSuite.MetroLabel TodayTmax;
        private MetroSuite.MetroLabel metroLabel11;
        private MetroSuite.MetroLabel TomorrowTmin;
        private MetroSuite.MetroLabel metroLabel10;
        private MetroSuite.MetroLabel TomorrowTmax;
        private MetroSuite.MetroLabel metroLabel13;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroSuite.MetroLabel AfterTomorrowTmin;
        private MetroSuite.MetroLabel metroLabel15;
        private MetroSuite.MetroLabel AfterTomorrowTmax;
        private MetroSuite.MetroLabel metroLabel17;
        private MetroSuite.MetroGraph TemperatureGraph4;
        private System.Windows.Forms.PictureBox WeatherIcon3;
        private MetroSuite.MetroLabel WeatherExplain3;
        private MetroSuite.MetroLabel ReleaseTime;
        private MetroSuite.MetroLabel metroLabel5;
        private MetroSuite.MetroLabel ReleaseTime1;
        private MetroSuite.MetroLabel metroLabel2;
        private MetroSuite.MetroLabel last12hour;
        private MetroSuite.MetroLabel metroLabel30;
        private MetroSuite.MetroLabel last6hour;
        private MetroSuite.MetroLabel metroLabel28;
        private MetroSuite.MetroLabel last1hour;
        private MetroSuite.MetroLabel metroLabel26;
        private MetroSuite.MetroLabel last30min;
        private MetroSuite.MetroLabel metroLabel24;
        private MetroSuite.MetroLabel last15min;
        private MetroSuite.MetroLabel metroLabel22;
        private MetroSuite.MetroLabel last10min;
        private MetroSuite.MetroLabel metroLabel20;
        private MetroSuite.MetroLabel SinceMidNight;
        private MetroSuite.MetroLabel mertolabel14;
        private MetroSuite.MetroGraph CurrentRainGraph;
        private MetroSuite.MetroLabel CurrentTmin;
        private MetroSuite.MetroLabel metroLabel3;
        private MetroSuite.MetroLabel CurrentTMax;
        private MetroSuite.MetroLabel metroLabel7;
        private MetroSuite.MetroGraph CurrentTemperatureGraph;
        private MetroSuite.MetroLabel last24hour;
        private MetroSuite.MetroLabel metroLabel14;
        private MetroSuite.MetroLabel CurrentTCurrent;
        private MetroSuite.MetroLabel metroLabel16;
        private System.Windows.Forms.PictureBox CurrentWeatherIcon;
        private MetroSuite.MetroLabel CurrentWeatherExplain;
        private MetroSuite.MetroLabel metroLabel1;
        private GChartLib.GCircularProgress CurrentHumidityPercent;
        private MetroSuite.MetroLabel metroLabel6;
        private MetroSuite.MetroLabel CurrentHumidity;
        private System.Windows.Forms.PictureBox ThreeHourWeatherIcon;
        private MetroSuite.MetroLabel ThreeHourWeatherExplain;
        private System.Windows.Forms.PictureBox OneHourWeatherIcon;
        private System.Windows.Forms.PictureBox TwoHourWeatherIcon;
        private MetroSuite.MetroLabel OneHourWeatherExplain;
        private MetroSuite.MetroLabel TwoHourWeatherExplain;
        private MetroSuite.MetroLabel ReleaseTime2;
        private MetroSuite.MetroLabel metroLabel21;
        private System.Windows.Forms.ToolTip SummaryTip;
        private System.Windows.Forms.ToolTip CurrentTip;
        private System.Windows.Forms.ToolTip ShortTip;
        private System.Windows.Forms.ToolTip NormalTip;
        private System.Windows.Forms.ToolTip LongTip;
        private System.Windows.Forms.ToolTip AlertTip;
        private MetroSuite.MetroGraph HourTemperatureGraph;
        private MetroSuite.MetroLabel metroLabel8;
        private MetroSuite.MetroLabel ThreeHourTemperature;
        private MetroSuite.MetroLabel metroLabel18;
        private MetroSuite.MetroLabel TwoHourTemperature;
        private MetroSuite.MetroLabel metroLabel25;
        private MetroSuite.MetroLabel OneHourTemperature;
        private MetroSuite.MetroLabel metroLabel29;
        private MetroSuite.MetroLabel ThreeHourHumidity;
        private MetroSuite.MetroLabel metroLabel33;
        private GChartLib.GCircularProgress ThreeHourHumidityPercent;
        private MetroSuite.MetroLabel TwoHourHumidity;
        private MetroSuite.MetroLabel metroLabel31;
        private GChartLib.GCircularProgress TwoHourHumidityPercent;
        private MetroSuite.MetroLabel OneHourHumidity;
        private MetroSuite.MetroLabel metroLabel23;
        private GChartLib.GCircularProgress OneHourHumidityPercent;
        private MetroSuite.MetroLabel FourHourTemperature;
        private MetroSuite.MetroLabel metroLabel19;
        private MetroSuite.MetroLabel FourHourHumidity;
        private MetroSuite.MetroLabel metroLabel27;
        private GChartLib.GCircularProgress FourHourHumidityPercent;
        private System.Windows.Forms.PictureBox FourHourWeatherIcon;
        private MetroSuite.MetroLabel FourHourWeatherExplain;
        private System.Windows.Forms.PictureBox ShortWeatherIcon14;
        private System.Windows.Forms.PictureBox ShortWeatherIcon13;
        private System.Windows.Forms.PictureBox ShortWeatherIcon12;
        private System.Windows.Forms.PictureBox ShortWeatherIcon11;
        private System.Windows.Forms.PictureBox ShortWeatherIcon6;
        private System.Windows.Forms.PictureBox ShortWeatherIcon10;
        private System.Windows.Forms.PictureBox ShortWeatherIcon5;
        private System.Windows.Forms.PictureBox ShortWeatherIcon4;
        private MetroSuite.MetroLabel metroLabel32;
        private MetroSuite.MetroLabel ShortWeatherExplain1;
        private MetroSuite.MetroLabel ReleaseTime3;
        private MetroSuite.MetroLabel metroLabel37;
        private System.Windows.Forms.PictureBox ShortWeatherIcon2;
        private System.Windows.Forms.PictureBox ShortWeatherIcon3;
        private System.Windows.Forms.PictureBox ShortWeatherIcon1;
        private MetroSuite.MetroLabel ShortWeatherExplain17;
        private MetroSuite.MetroLabel ShortWeatherExplain2;
        private MetroSuite.MetroLabel ShortWeatherExplain3;
        private MetroSuite.MetroLabel ShortWeatherExplain4;
        private MetroSuite.MetroLabel ShortWeatherExplain5;
        private MetroSuite.MetroLabel ShortWeatherExplain7;
        private MetroSuite.MetroLabel ShortWeatherExplain6;
        private MetroSuite.MetroLabel ShortWeatherExplain8;
        private MetroSuite.MetroLabel ShortWeatherExplain9;
        private MetroSuite.MetroLabel ShortWeatherExplain10;
        private MetroSuite.MetroLabel ShortWeatherExplain11;
        private MetroSuite.MetroLabel ShortWeatherExplain12;
        private MetroSuite.MetroLabel ShortWeatherExplain13;
        private MetroSuite.MetroLabel ShortWeatherExplain14;
        private MetroSuite.MetroLabel ShortWeatherExplain15;
        private MetroSuite.MetroLabel ShortWeatherExplain16;
        private System.Windows.Forms.PictureBox ShortWeatherIcon17;
        private System.Windows.Forms.PictureBox ShortWeatherIcon18;
        private System.Windows.Forms.PictureBox ShortWeatherIcon20;
        private System.Windows.Forms.PictureBox ShortWeatherIcon21;
        private System.Windows.Forms.PictureBox ShortWeatherIcon22;
        private System.Windows.Forms.PictureBox ShortWeatherIcon19;
        private System.Windows.Forms.PictureBox ShortWeatherIcon16;
        private System.Windows.Forms.PictureBox ShortWeatherIcon7;
        private System.Windows.Forms.PictureBox ShortWeatherIcon8;
        private System.Windows.Forms.PictureBox ShortWeatherIcon9;
        private System.Windows.Forms.PictureBox ShortWeatherIcon15;
        private MetroSuite.MetroLabel ShortWeatherExplain22;
        private MetroSuite.MetroLabel ShortWeatherExplain21;
        private MetroSuite.MetroLabel ShortWeatherExplain20;
        private MetroSuite.MetroLabel ShortWeatherExplain19;
        private MetroSuite.MetroLabel ShortWeatherExplain18;
        private MetroSuite.MetroGraph ShortTemperatureGraph;
        private MetroSuite.MetroLabel ShortTemperature22;
        private MetroSuite.MetroLabel ShortTemperature21;
        private MetroSuite.MetroLabel ShortTemperature20;
        private MetroSuite.MetroLabel ShortTemperature19;
        private MetroSuite.MetroLabel ShortTemperature18;
        private MetroSuite.MetroLabel ShortTemperature17;
        private MetroSuite.MetroLabel ShortTemperature16;
        private MetroSuite.MetroLabel ShortTemperature15;
        private MetroSuite.MetroLabel ShortTemperature14;
        private MetroSuite.MetroLabel ShortTemperature13;
        private MetroSuite.MetroLabel ShortTemperature12;
        private MetroSuite.MetroLabel ShortTemperature11;
        private MetroSuite.MetroLabel ShortTemperature10;
        private MetroSuite.MetroLabel ShortTemperature9;
        private MetroSuite.MetroLabel ShortTemperature8;
        private MetroSuite.MetroLabel ShortTemperature7;
        private MetroSuite.MetroLabel ShortTemperature6;
        private MetroSuite.MetroLabel ShortTemperature5;
        private MetroSuite.MetroLabel ShortTemperature4;
        private MetroSuite.MetroLabel ShortTemperature2;
        private MetroSuite.MetroLabel ShortTemperature3;
        private MetroSuite.MetroLabel ShortTemperature1;
        private MetroSuite.MetroLabel metroLabel56;
        private MetroSuite.MetroLabel metroLabel55;
        private MetroSuite.MetroLabel metroLabel54;
        private MetroSuite.MetroLabel metroLabel53;
        private MetroSuite.MetroLabel metroLabel52;
        private MetroSuite.MetroLabel metroLabel51;
        private MetroSuite.MetroLabel metroLabel50;
        private MetroSuite.MetroLabel metroLabel49;
        private MetroSuite.MetroLabel metroLabel48;
        private MetroSuite.MetroLabel metroLabel47;
        private MetroSuite.MetroLabel metroLabel46;
        private MetroSuite.MetroLabel metroLabel45;
        private MetroSuite.MetroLabel metroLabel44;
        private MetroSuite.MetroLabel metroLabel43;
        private MetroSuite.MetroLabel metroLabel42;
        private MetroSuite.MetroLabel metroLabel41;
        private MetroSuite.MetroLabel metroLabel40;
        private MetroSuite.MetroLabel metroLabel39;
        private MetroSuite.MetroLabel metroLabel38;
        private MetroSuite.MetroLabel metroLabel36;
        private MetroSuite.MetroLabel metroLabel34;
        private MetroSuite.MetroLabel metroLabel12;
        private MetroSuite.MetroLabel metroLabel69;
        private MetroSuite.MetroLabel metroLabel70;
        private MetroSuite.MetroLabel metroLabel71;
        private MetroSuite.MetroLabel ShortTMin3;
        private MetroSuite.MetroLabel ShortTMin2;
        private MetroSuite.MetroLabel ShortTMin1;
        private MetroSuite.MetroLabel ShortTMax3;
        private MetroSuite.MetroLabel metroLabel61;
        private MetroSuite.MetroLabel ShortTMax2;
        private MetroSuite.MetroLabel metroLabel59;
        private MetroSuite.MetroLabel ShortTMax1;
        private MetroSuite.MetroLabel metroLabel57;
        private MetroSuite.MetroGraph ShortTGraph;
        private MetroSuite.MetroLabel ShortHumidity22;
        private MetroSuite.MetroLabel ShortHumidity21;
        private MetroSuite.MetroLabel ShortHumidity20;
        private MetroSuite.MetroLabel ShortHumidity19;
        private MetroSuite.MetroLabel ShortHumidity18;
        private MetroSuite.MetroLabel ShortHumidity17;
        private MetroSuite.MetroLabel ShortHumidity16;
        private MetroSuite.MetroLabel ShortHumidity15;
        private MetroSuite.MetroLabel ShortHumidity14;
        private MetroSuite.MetroLabel ShortHumidity13;
        private MetroSuite.MetroLabel ShortHumidity12;
        private MetroSuite.MetroLabel ShortHumidity11;
        private MetroSuite.MetroLabel ShortHumidity10;
        private MetroSuite.MetroLabel ShortHumidity9;
        private MetroSuite.MetroLabel ShortHumidity8;
        private MetroSuite.MetroLabel ShortHumidity7;
        private MetroSuite.MetroLabel ShortHumidity6;
        private MetroSuite.MetroLabel ShortHumidity5;
        private MetroSuite.MetroLabel ShortHumidity4;
        private MetroSuite.MetroLabel ShortHumidity2;
        private MetroSuite.MetroLabel ShortHumidity3;
        private MetroSuite.MetroLabel ShortHumidity1;
        private MetroSuite.MetroLabel metroLabel85;
        private MetroSuite.MetroLabel metroLabel86;
        private MetroSuite.MetroLabel metroLabel87;
        private MetroSuite.MetroLabel metroLabel88;
        private MetroSuite.MetroLabel metroLabel89;
        private MetroSuite.MetroLabel metroLabel90;
        private MetroSuite.MetroLabel metroLabel91;
        private MetroSuite.MetroLabel metroLabel92;
        private MetroSuite.MetroLabel metroLabel93;
        private MetroSuite.MetroLabel metroLabel94;
        private MetroSuite.MetroLabel metroLabel95;
        private MetroSuite.MetroLabel metroLabel96;
        private MetroSuite.MetroLabel metroLabel97;
        private MetroSuite.MetroLabel metroLabel98;
        private MetroSuite.MetroLabel metroLabel99;
        private MetroSuite.MetroLabel metroLabel100;
        private MetroSuite.MetroLabel metroLabel101;
        private MetroSuite.MetroLabel metroLabel102;
        private MetroSuite.MetroLabel metroLabel103;
        private MetroSuite.MetroLabel metroLabel104;
        private MetroSuite.MetroLabel metroLabel105;
        private MetroSuite.MetroLabel metroLabel106;
        private MetroSuite.MetroGraph ShortHumidityGraph;
        private MetroSuite.MetroLabel metroLabel72;
        private MetroSuite.MetroLabel ReleaseTime4;
        private MetroSuite.MetroLabel metroLabel74;
        private MetroSuite.MetroLabel LongWeatherExplain2;
        private MetroSuite.MetroLabel LongWeatherExplain3;
        private MetroSuite.MetroLabel LongWeatherExplain4;
        private MetroSuite.MetroLabel LongWeatherExplain5;
        private System.Windows.Forms.PictureBox LongWeatherIcon5;
        private System.Windows.Forms.PictureBox LongWeatherIcon4;
        private MetroSuite.MetroLabel LongWeatherExplain1;
        private System.Windows.Forms.PictureBox LongWeatherIcon2;
        private System.Windows.Forms.PictureBox LongWeatherIcon3;
        private System.Windows.Forms.PictureBox LongWeatherIcon1;
        private MetroSuite.MetroGraph LongTemperatureGraph;
        private MetroSuite.MetroLabel LongWeatherExplain7;
        private MetroSuite.MetroLabel LongWeatherExplain8;
        private MetroSuite.MetroLabel LongWeatherExplain9;
        private System.Windows.Forms.PictureBox LongWeatherIcon9;
        private MetroSuite.MetroLabel LongWeatherExplain6;
        private System.Windows.Forms.PictureBox LongWeatherIcon7;
        private System.Windows.Forms.PictureBox LongWeatherIcon8;
        private System.Windows.Forms.PictureBox LongWeatherIcon6;
        private MetroSuite.MetroLabel metroLabel78;
        private MetroSuite.MetroLabel metroLabel79;
        private MetroSuite.MetroLabel LongTMin5;
        private MetroSuite.MetroLabel LongTMin4;
        private MetroSuite.MetroLabel LongTMax5;
        private MetroSuite.MetroLabel metroLabel108;
        private MetroSuite.MetroLabel LongTMax4;
        private MetroSuite.MetroLabel metroLabel110;
        private MetroSuite.MetroLabel metroLabel35;
        private MetroSuite.MetroLabel metroLabel58;
        private MetroSuite.MetroLabel LongTMin3;
        private MetroSuite.MetroLabel LongTMin2;
        private MetroSuite.MetroLabel LongTMax3;
        private MetroSuite.MetroLabel metroLabel66;
        private MetroSuite.MetroLabel LongTMax2;
        private MetroSuite.MetroLabel metroLabel68;
        private MetroSuite.MetroLabel metroLabel77;
        private MetroSuite.MetroLabel metroLabel80;
        private MetroSuite.MetroLabel LongTMin9;
        private MetroSuite.MetroLabel metroLabel112;
        private MetroSuite.MetroLabel LongTMax9;
        private MetroSuite.MetroLabel metroLabel114;
        private MetroSuite.MetroLabel metroLabel115;
        private MetroSuite.MetroLabel metroLabel116;
        private MetroSuite.MetroLabel metroLabel117;
        private MetroSuite.MetroLabel LongTMin8;
        private MetroSuite.MetroLabel LongTMin7;
        private MetroSuite.MetroLabel LongTMin6;
        private MetroSuite.MetroLabel LongTMax8;
        private MetroSuite.MetroLabel metroLabel122;
        private MetroSuite.MetroLabel LongTMax7;
        private MetroSuite.MetroLabel metroLabel124;
        private MetroSuite.MetroLabel LongTMax6;
        private MetroSuite.MetroLabel metroLabel126;
        private MetroSuite.MetroLabel LongWeatherExplain16;
        private MetroSuite.MetroLabel LongWeatherExplain17;
        private MetroSuite.MetroLabel LongWeatherExplain18;
        private System.Windows.Forms.PictureBox LongWeatherIcon18;
        private MetroSuite.MetroLabel LongWeatherExplain15;
        private System.Windows.Forms.PictureBox LongWeatherIcon16;
        private System.Windows.Forms.PictureBox LongWeatherIcon17;
        private System.Windows.Forms.PictureBox LongWeatherIcon15;
        private MetroSuite.MetroLabel LongWeatherExplain11;
        private MetroSuite.MetroLabel LongWeatherExplain12;
        private MetroSuite.MetroLabel LongWeatherExplain13;
        private MetroSuite.MetroLabel LongWeatherExplain14;
        private System.Windows.Forms.PictureBox LongWeatherIcon14;
        private System.Windows.Forms.PictureBox LongWeatherIcon13;
        private System.Windows.Forms.PictureBox LongWeatherIcon11;
        private System.Windows.Forms.PictureBox LongWeatherIcon12;
        private MetroSuite.MetroLabel metroLabel63;
        private MetroSuite.MetroLabel metroLabel62;
        private MetroSuite.MetroLabel LongWeatherExplain10;
        private System.Windows.Forms.PictureBox LongWeatherIcon10;
        private MetroSuite.MetroLabel LongTMin1;
        private MetroSuite.MetroLabel LongTMax1;
        private MetroSuite.MetroLabel metroLabel60;
    }
}

