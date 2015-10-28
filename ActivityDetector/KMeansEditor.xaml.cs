using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;


namespace ActivityDetector
{
    public partial class KMeansEditor : PhoneApplicationPage
    {
        public KMeansEditor()
        {
            InitializeComponent();
        }
        private void button_sensor_logger_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri(@"/MainPage.xaml", UriKind.Relative));
        }

        private void button_start_kmeans_Click_1(object sender, RoutedEventArgs e)
        {
            List<String> filter = new List<string>();
            if (this.checkBox_accel.IsChecked == true)
            {
                filter.Add("accelX");
                filter.Add("accelY");
                filter.Add("accelZ");
            }
            if (this.checkBox_gyro.IsChecked == true)
            {
                filter.Add("gyroX");
                filter.Add("gyroY");
                filter.Add("gyroZ");
            }
            if (this.checkBox_incli.IsChecked == true)
            {
                filter.Add("incliYaw");
                filter.Add("incliPitch");
                filter.Add("incliRoll");
            }
            if (this.checkBox_compass.IsChecked == true)
            {
                filter.Add("compass");
            }
            if (this.checkBox_lightsensor.IsChecked == true)
            {
                filter.Add("light");
            }
            DataEntry.filterAndPreprossDatas(filter);

            // call Kmeans here
            int k = 0;
            double eps = 0;
            int.TryParse(this.textBox_k.Text, out k);
            double.TryParse(this.textBox_eps.Text, out eps);

            this.testAsync.Text = "waiting for kmeans";

            KmeansMethode.DoKmean(k, eps);

            this.testAsync.Text = "kmeans over";

        }
    }
}