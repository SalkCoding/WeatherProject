using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml;
using Weather.SKTPlanetAPI;

namespace Weather.GoogleMapAPI
{
    class Geocoding : AppKey
    {
        private Double? Latitude = null;
        private Double? Longitude = null;
        private String Status;
        private String Address;

        public Geocoding() { }

        public Geocoding(String address)
        {
            using(WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                String Info = web.DownloadString(@"https://maps.googleapis.com/maps/api/place/textsearch/xml?query=" + address + "&language=ko&key=" + GetMapAppkey);
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(Info);
                if (!xml.SelectSingleNode("/PlaceSearchResponse/status").InnerText.Equals("ZERO_RESULTS"))
                {
                    Latitude = Convert.ToDouble(xml.SelectSingleNode("/PlaceSearchResponse/result/geometry/location/lat").InnerText);
                    Longitude = Convert.ToDouble(xml.SelectSingleNode("/PlaceSearchResponse/result/geometry/location/lng").InnerText);
                    Address = xml.SelectSingleNode("/PlaceSearchResponse/result/formatted_address").InnerText;
                }
                Status = xml.SelectSingleNode("/PlaceSearchResponse/status").InnerText;
            }
        }

        public Double? GetLongitude => Longitude;

        public Double? GetLatitude => Latitude;

        public String GetStatus => Status;

        public String GetAddress => Address;

    }

}
