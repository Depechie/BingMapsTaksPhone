using System.Device.Location;
using System.Windows;
using Cimbalino.Phone.Toolkit.Services;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

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
    }
}