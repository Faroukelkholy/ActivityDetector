﻿#pragma checksum "C:\Users\farouk khouly\documents\visual studio 2015\Projects\ActivityDetector\ActivityDetector\KMeansEditor.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "056418BD3B23F18ED82E3282D1734693"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ActivityDetector {
    
    
    public partial class KMeansEditor : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock textBlock;
        
        internal System.Windows.Controls.Button button_sensor_logger;
        
        internal System.Windows.Controls.Button button_profile;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.CheckBox checkBox_accel;
        
        internal System.Windows.Controls.CheckBox checkBox_compass;
        
        internal System.Windows.Controls.CheckBox checkBox_gyro;
        
        internal System.Windows.Controls.CheckBox checkBox_incli;
        
        internal System.Windows.Controls.CheckBox checkBox_lightsensor;
        
        internal System.Windows.Controls.TextBlock textBlock_klabel;
        
        internal System.Windows.Controls.TextBlock textBlock_Elabel;
        
        internal System.Windows.Controls.TextBox textBox_k;
        
        internal System.Windows.Controls.TextBox textBox_eps;
        
        internal System.Windows.Controls.Button button_start_kmeans;
        
        internal System.Windows.Controls.TextBlock testAsync;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/ActivityDetector;component/KMeansEditor.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.textBlock = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock")));
            this.button_sensor_logger = ((System.Windows.Controls.Button)(this.FindName("button_sensor_logger")));
            this.button_profile = ((System.Windows.Controls.Button)(this.FindName("button_profile")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.checkBox_accel = ((System.Windows.Controls.CheckBox)(this.FindName("checkBox_accel")));
            this.checkBox_compass = ((System.Windows.Controls.CheckBox)(this.FindName("checkBox_compass")));
            this.checkBox_gyro = ((System.Windows.Controls.CheckBox)(this.FindName("checkBox_gyro")));
            this.checkBox_incli = ((System.Windows.Controls.CheckBox)(this.FindName("checkBox_incli")));
            this.checkBox_lightsensor = ((System.Windows.Controls.CheckBox)(this.FindName("checkBox_lightsensor")));
            this.textBlock_klabel = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock_klabel")));
            this.textBlock_Elabel = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock_Elabel")));
            this.textBox_k = ((System.Windows.Controls.TextBox)(this.FindName("textBox_k")));
            this.textBox_eps = ((System.Windows.Controls.TextBox)(this.FindName("textBox_eps")));
            this.button_start_kmeans = ((System.Windows.Controls.Button)(this.FindName("button_start_kmeans")));
            this.testAsync = ((System.Windows.Controls.TextBlock)(this.FindName("testAsync")));
        }
    }
}

