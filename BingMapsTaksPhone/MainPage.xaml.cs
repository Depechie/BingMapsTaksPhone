using System.Device.Location;
using System.Windows;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace BingMapsTaksPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GeoCoordinate location = new GeoCoordinate(51.40205, 4.46802);

            BingMapsTask task = new BingMapsTask();
            task.Center = location;
            task.SearchTerm = location.ToString();
            task.ZoomLevel = 9;
            task.Show();
        }
    }
}