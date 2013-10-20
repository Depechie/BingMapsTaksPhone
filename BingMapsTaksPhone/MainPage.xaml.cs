using Cimbalino.Phone.Toolkit.Services;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using System.Device.Location;
using System.Globalization;
using System.Windows;

namespace BingMapsTaksPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        GeoCoordinate _location = new GeoCoordinate(51.40205, 4.46802);

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BingMapsTask task = new BingMapsTask();
            task.Center = _location;
            task.SearchTerm = _location.ToString();
            task.ZoomLevel = 9;
            task.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MapsService mapsService = new MapsService();
            mapsService.Show(_location, _location.ToString(), 9);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MapsService mapsService = new MapsService();

            string search = string.Format("{0},{1}", _location.Latitude.ToString(CultureInfo.InvariantCulture),
                                          _location.Longitude.ToString(CultureInfo.InvariantCulture));

            mapsService.Show(_location, search, 9);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MapsService mapsService = new MapsService();

            string search = string.Format("{0},{1}", _location.Latitude.ToString(new CultureInfo("nl-BE")),
                                          _location.Longitude.ToString(new CultureInfo("nl-BE")));

            mapsService.Show(_location, search, 9);
        }
    }
}