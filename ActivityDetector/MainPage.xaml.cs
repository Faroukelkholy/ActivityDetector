using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ActivityDetector.Resources;

using Windows.Devices.Sensors;
using Windows.Foundation;
using System.Diagnostics;

namespace ActivityDetector
{
    public partial class MainPage : PhoneApplicationPage
    {
        private Accelerometer accelSensor;
        private Compass compSensor;
        private Gyrometer gyroSensor;
        private Inclinometer incliSensor;
        private LightSensor lightSensor;
        private bool started = false;
        private List<String> activities = new List<String>();
        private double accelX, accelY, accelZ, comp, gyroX, gyroY, gyroZ, incliYaw, incliPitch, incliRoll, light;

        public MainPage()
        {
            InitializeComponent();

            // this.NavigationCacheMode = NavigationCacheMode.Required;
            //DataEntry.saveAll();
            //DataEntry.loadAll();

            this.accelSensor = Accelerometer.GetDefault();
            if (this.accelSensor != null) this.accelSensor.ReadingChanged += new TypedEventHandler<Accelerometer, AccelerometerReadingChangedEventArgs>(myAccelHandler);

            this.compSensor = Compass.GetDefault();
            if (this.compSensor != null) this.compSensor.ReadingChanged += new TypedEventHandler<Compass, CompassReadingChangedEventArgs>(myCompassHandler);

            this.gyroSensor = Gyrometer.GetDefault();
            if (this.gyroSensor != null) this.gyroSensor.ReadingChanged += new TypedEventHandler<Gyrometer, GyrometerReadingChangedEventArgs>(myGyroHandler);

            this.incliSensor = Inclinometer.GetDefault();
            if (this.incliSensor != null) this.incliSensor.ReadingChanged += new TypedEventHandler<Inclinometer, InclinometerReadingChangedEventArgs>(myIncliHandler);

            this.lightSensor = LightSensor.GetDefault();
            if (this.lightSensor != null) this.lightSensor.ReadingChanged += new TypedEventHandler<LightSensor, LightSensorReadingChangedEventArgs>(myLightHandler);

            accelX = accelY = accelZ = comp = gyroX = gyroY = gyroZ = incliYaw = incliPitch = incliRoll = light = 0;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        private DateTime lastTime;

        private void checkTimeToLog()
        {
            if (started)
            {
                DateTime dt = DateTime.Now;
                if (lastTime != null)
                {
                    if ((dt - lastTime).Seconds > 0)
                    {
                        DataEntry dE = new DataEntry();
                        
                        if (this.activities.Count > 0)
                        {
                            dE.activity = this.activities.ElementAt<string>(this.activities.Count - 1);
                        }
                        dE.datas.Add("accelX", accelX);
                        Dnary dnaccelX = new Dnary();
                        dnaccelX.DataKey = "accelX";
                        dnaccelX.DataValue = accelX;
                        dnaccelX.datetimeDataEntry = dE.dateTime;
                        dnaccelX.activity = dE.activity;
                        DataEntry.addDictionaryToList(dnaccelX);
                        dE.datas.Add("accelY", accelY);
                        Dnary dnaccelY = new Dnary();
                        dnaccelY.DataKey = "accelY";
                        dnaccelY.DataValue = accelY;
                        dnaccelY.datetimeDataEntry = dE.dateTime;
                        dnaccelY.activity = dE.activity;
                        DataEntry.addDictionaryToList(dnaccelY);
                        dE.datas.Add("accelZ", accelZ);
                        Dnary dnaccelZ = new Dnary();
                        dnaccelZ.DataKey = "accelZ";
                        dnaccelZ.DataValue = accelZ;
                        dnaccelZ.datetimeDataEntry = dE.dateTime;
                        dnaccelZ.activity = dE.activity;
                        DataEntry.addDictionaryToList(dnaccelZ);
                        dE.datas.Add("compass", comp);
                        Dnary dncompass = new Dnary();
                        dncompass.DataKey = "compass";
                        dncompass.DataValue = comp;
                        dncompass.datetimeDataEntry = dE.dateTime;
                        dncompass.activity = dE.activity;
                        DataEntry.addDictionaryToList(dncompass);
                        dE.datas.Add("gyroX", gyroX);
                        Dnary dngyroX = new Dnary();
                        dngyroX.DataKey = "gyroX";
                        dngyroX.DataValue = gyroX;
                        dngyroX.datetimeDataEntry = dE.dateTime;
                        dngyroX.activity = dE.activity;
                        DataEntry.addDictionaryToList(dngyroX);
                        dE.datas.Add("gyroY", gyroY);
                        Dnary dngyroY = new Dnary();
                        dngyroY.DataKey = "gyroY";
                        dngyroY.DataValue = gyroY;
                        dngyroY.datetimeDataEntry = dE.dateTime;
                        dngyroY.activity = dE.activity;
                        DataEntry.addDictionaryToList(dngyroY);
                        dE.datas.Add("gyroZ", gyroZ);
                        Dnary dngyroZ = new Dnary();
                        dngyroZ.DataKey = "gyroZ";
                        dngyroZ.DataValue = gyroZ;
                        dngyroZ.datetimeDataEntry = dE.dateTime;
                        dngyroZ.activity = dE.activity;
                        DataEntry.addDictionaryToList(dngyroZ);
                        dE.datas.Add("incliYaw", incliYaw);
                        Dnary dnincliYaw = new Dnary();
                        dnincliYaw.DataKey = "incliYaw";
                        dnincliYaw.DataValue = incliYaw;
                        dnincliYaw.datetimeDataEntry = dE.dateTime;
                        dnincliYaw.activity = dE.activity;
                        DataEntry.addDictionaryToList(dnincliYaw);
                        dE.datas.Add("incliPitch", incliPitch);
                        Dnary dnincliPitch = new Dnary();
                        dnincliPitch.DataKey = "incliPitch";
                        dnincliPitch.DataValue = incliPitch;
                        dnincliPitch.datetimeDataEntry = dE.dateTime;
                        dnincliPitch.activity = dE.activity;
                        DataEntry.addDictionaryToList(dnincliPitch);
                        dE.datas.Add("incliRoll", incliRoll);
                        Dnary dnincliRoll = new Dnary();
                        dnincliRoll.DataKey = "incliRoll";
                        dnincliRoll.DataValue = incliRoll;
                        dnincliRoll.datetimeDataEntry = dE.dateTime;
                        dnincliRoll.activity = dE.activity;
                        DataEntry.addDictionaryToList(dnincliRoll);
                        dE.datas.Add("light", light);
                        Dnary dnlight = new Dnary();
                        dnlight.DataKey = "light";
                        dnlight.DataValue = light;
                        dnlight.datetimeDataEntry = dE.dateTime;
                        dnlight.activity = dE.activity;
                        DataEntry.addEntryToList(dE);
                        DataEntry.addDictionaryToList(dnlight);
                        lastTime = dt;
                        this.textBlock_logquantity.Text = DataEntry.dataEntries.Count().ToString("0.0");
                    }
                }
                else
                {
                    lastTime = dt;
                }
            }
        }

        public void myIncliHandler(Inclinometer i, InclinometerReadingChangedEventArgs e)
        {
            Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                () =>
                {
                    this.value_incli_yaw.Text = e.Reading.YawDegrees.ToString("0.00");
                    this.incliYaw = e.Reading.YawDegrees;
                    this.value_incli_pitch.Text = e.Reading.PitchDegrees.ToString("0.00");
                    this.incliPitch = e.Reading.PitchDegrees;
                    this.value_incli_roll.Text = e.Reading.RollDegrees.ToString("0.00");
                    this.incliRoll = e.Reading.RollDegrees;
                    checkTimeToLog();
                }
            );
        }

        public void myGyroHandler(Gyrometer g, GyrometerReadingChangedEventArgs e)
        {
            Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                () =>
                {
                    this.value_gyro_x.Text = e.Reading.AngularVelocityX.ToString("0.00");
                    this.gyroX = e.Reading.AngularVelocityX;
                    this.value_gyro_y.Text = e.Reading.AngularVelocityY.ToString("0.00");
                    this.gyroY = e.Reading.AngularVelocityY;
                    this.value_gyro_z.Text = e.Reading.AngularVelocityZ.ToString("0.00");
                    this.gyroZ = e.Reading.AngularVelocityZ;
                    checkTimeToLog();
                }
            );
        }

        public void myLightHandler(LightSensor l, LightSensorReadingChangedEventArgs e)
        {
            Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                () =>
                {
                    this.value_light_lux.Text = e.Reading.IlluminanceInLux.ToString("0.00");
                    this.light = e.Reading.IlluminanceInLux;
                    checkTimeToLog();
                }
            );
        }

        public void myCompassHandler(Compass c, CompassReadingChangedEventArgs e)
        {
            Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                () =>
                {
                    this.value_compass_deg.Text = e.Reading.HeadingMagneticNorth.ToString("0.00");
                    this.comp = e.Reading.HeadingMagneticNorth;
                    checkTimeToLog();
                }
            );
        }

        public void myAccelHandler(Windows.Devices.Sensors.Accelerometer a, AccelerometerReadingChangedEventArgs e)
        {
            Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                () =>
                {
                    this.value_accel_x.Text = e.Reading.AccelerationX.ToString("0.00");
                    this.accelX = e.Reading.AccelerationX;
                    this.value_accel_y.Text = e.Reading.AccelerationY.ToString("0.00");
                    this.accelY = e.Reading.AccelerationY;
                    this.value_accel_z.Text = e.Reading.AccelerationZ.ToString("0.00");
                    this.accelZ = e.Reading.AccelerationZ;
                    checkTimeToLog();
                }
            );
        }

        /// <summary>
        /// Invoqué lorsque cette page est sur le point d'être affichée dans un frame.
        /// </summary>
        /// <param name="e">Données d'événement décrivant la manière dont l'utilisateur a accédé à cette page.
        /// Ce paramètre est généralement utilisé pour configurer la page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            started = !started;
            if (started)
            {
                this.button_logger.Content = "STOP LOGGING";
            }
            else
            {
                this.button_logger.Content = "START LOGGING";
            }
        }

        private void button_del_Click(object sender, RoutedEventArgs e)
        {
            if (this.activities.Count > 0)
            {
                String lastTopActivity = this.activities.ElementAt(this.activities.Count - 1);
                this.activities.RemoveAt(this.activities.Count - 1);
                this.textBox_activity.Text = lastTopActivity;

                if (this.activities.Count > 0)
                {
                    String topActivity = this.activities.ElementAt(this.activities.Count - 1);
                    this.label_top_activity.Text = "- " + topActivity + " -";
                }
                else
                {
                    this.label_top_activity.Text = "";
                }
            }
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            String topActivity = this.textBox_activity.Text;
            this.label_top_activity.Text = "- " + topActivity + " -";
            this.activities.Add(topActivity);
            this.textBox_activity.Text = "select activity ...";
        }

        private void button_kmeans_editor_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("saveAll in kmeans editor");
            DataEntry.saveAll();
            NavigationService.Navigate(new Uri(@"/KmeansEditor.xaml", UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}