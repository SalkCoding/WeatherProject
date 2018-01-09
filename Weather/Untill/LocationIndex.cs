using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Untill
{
    public class LocationIndex
    {
        private Double? Latitude = null;
        private Double? Longitude = null;
        private String Address = null;

        public LocationIndex(Double? lat,Double? lon,String address)
        {
            Latitude = lat;
            Longitude = lon;
            Address = address;
        }

        public String GetAddress => Address;

        public Double? GetLongitude => Longitude;

        public Double? GetLatitude => Latitude;

    }
}
