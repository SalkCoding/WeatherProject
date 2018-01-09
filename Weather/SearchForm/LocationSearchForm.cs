using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Weather.GoogleMapAPI;
using Weather.Untill;

namespace Weather.SearchForm
{
    public partial class LocationSearchForm : MaterialForm
    {
        private Geocoding map;

        public delegate void RefreshEvent(Double lat,Double lon);
#pragma warning disable CS0108 // 멤버가 상속된 멤버를 숨깁니다. new 키워드가 없습니다.
        public event RefreshEvent Refresh;
#pragma warning restore CS0108 // 멤버가 상속된 멤버를 숨깁니다. new 키워드가 없습니다.


        public LocationSearchForm()
        {
            InitializeComponent();
            if(MainForm.SettingLocationIndex != null)
            {
                LocationIndex index = MainForm.SettingLocationIndex;
                AddressTextBox.Text = index.GetAddress;
                AddressLabel.Text = index.GetAddress;
                LocationLabel.Text = index.GetLatitude + ", " + index.GetLongitude;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (AddressTextBox.Text.Length == 0)
                return;
            map = new Geocoding(AddressTextBox.Text);
            SearchStatus.Text = map.GetStatus;
            AddressLabel.Text = map.GetAddress;
            if (map.GetLatitude != null || map.GetLongitude != null)
                LocationLabel.Text = map.GetLatitude + ", " + map.GetLongitude;
            else
                LocationLabel.Text = null;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (map == null || map.GetLatitude == null || map.GetLongitude == null)
            {
                MessageBox.Show(null,"잘못된 주소입니다.","경고!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            MainForm.SettingLocationIndex = new LocationIndex(map.GetLatitude, map.GetLongitude, map.GetAddress);
            Refresh(map.GetLatitude.Value, map.GetLongitude.Value);
        }

        private void LocationSearchForm_Closed(object sender, FormClosedEventArgs e)
        {
            MainForm.SettingDlg = null;
        }
    }
}
