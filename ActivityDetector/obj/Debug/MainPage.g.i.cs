﻿#pragma checksum "C:\Users\farouk khouly\documents\visual studio 2015\Projects\ActivityDetector\ActivityDetector\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "467F7D3459CC23FEA740D8E347284208"
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
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.TextBlock textBlock;
        
        internal System.Windows.Controls.Button button_scan_activity;
        
        internal System.Windows.Controls.Button button_kmeans_editor;
        
        internal System.Windows.Controls.TextBlock title_accel;
        
        internal System.Windows.Controls.TextBlock label_accel_x;
        
        internal System.Windows.Controls.TextBlock label_accel_y;
        
        internal System.Windows.Controls.TextBlock label_accel_z;
        
        internal System.Windows.Controls.TextBlock value_accel_x;
        
        internal System.Windows.Controls.TextBlock value_accel_y;
        
        internal System.Windows.Controls.TextBlock value_accel_z;
        
        internal System.Windows.Controls.TextBlock title_compass;
        
        internal System.Windows.Controls.TextBlock label_compass_deg;
        
        internal System.Windows.Controls.TextBlock value_compass_deg;
        
        internal System.Windows.Controls.TextBlock title_gyro;
        
        internal System.Windows.Controls.TextBlock label_gyro_x;
        
        internal System.Windows.Controls.TextBlock value_gyro_x;
        
        internal System.Windows.Controls.TextBlock label_gyro_y;
        
        internal System.Windows.Controls.TextBlock value_gyro_y;
        
        internal System.Windows.Controls.TextBlock label_gyro_z;
        
        internal System.Windows.Controls.TextBlock value_gyro_z;
        
        internal System.Windows.Controls.TextBlock title_incli;
        
        internal System.Windows.Controls.TextBlock label_incli_yaw;
        
        internal System.Windows.Controls.TextBlock value_incli_yaw;
        
        internal System.Windows.Controls.TextBlock label_incli_pitch;
        
        internal System.Windows.Controls.TextBlock value_incli_pitch;
        
        internal System.Windows.Controls.TextBlock label_incli_roll;
        
        internal System.Windows.Controls.TextBlock value_incli_roll;
        
        internal System.Windows.Controls.TextBlock title_light;
        
        internal System.Windows.Controls.TextBlock label_light_lux;
        
        internal System.Windows.Controls.TextBlock value_light_lux;
        
        internal System.Windows.Controls.Button button_logger;
        
        internal System.Windows.Controls.Button button_del;
        
        internal System.Windows.Controls.Button button_add;
        
        internal System.Windows.Controls.TextBlock label_top_activity;
        
        internal System.Windows.Controls.TextBox textBox_activity;
        
        internal System.Windows.Controls.TextBlock textBlock_logquantity;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/ActivityDetector;component/MainPage.xaml", System.UriKind.Relative));
            this.textBlock = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock")));
            this.button_scan_activity = ((System.Windows.Controls.Button)(this.FindName("button_scan_activity")));
            this.button_kmeans_editor = ((System.Windows.Controls.Button)(this.FindName("button_kmeans_editor")));
            this.title_accel = ((System.Windows.Controls.TextBlock)(this.FindName("title_accel")));
            this.label_accel_x = ((System.Windows.Controls.TextBlock)(this.FindName("label_accel_x")));
            this.label_accel_y = ((System.Windows.Controls.TextBlock)(this.FindName("label_accel_y")));
            this.label_accel_z = ((System.Windows.Controls.TextBlock)(this.FindName("label_accel_z")));
            this.value_accel_x = ((System.Windows.Controls.TextBlock)(this.FindName("value_accel_x")));
            this.value_accel_y = ((System.Windows.Controls.TextBlock)(this.FindName("value_accel_y")));
            this.value_accel_z = ((System.Windows.Controls.TextBlock)(this.FindName("value_accel_z")));
            this.title_compass = ((System.Windows.Controls.TextBlock)(this.FindName("title_compass")));
            this.label_compass_deg = ((System.Windows.Controls.TextBlock)(this.FindName("label_compass_deg")));
            this.value_compass_deg = ((System.Windows.Controls.TextBlock)(this.FindName("value_compass_deg")));
            this.title_gyro = ((System.Windows.Controls.TextBlock)(this.FindName("title_gyro")));
            this.label_gyro_x = ((System.Windows.Controls.TextBlock)(this.FindName("label_gyro_x")));
            this.value_gyro_x = ((System.Windows.Controls.TextBlock)(this.FindName("value_gyro_x")));
            this.label_gyro_y = ((System.Windows.Controls.TextBlock)(this.FindName("label_gyro_y")));
            this.value_gyro_y = ((System.Windows.Controls.TextBlock)(this.FindName("value_gyro_y")));
            this.label_gyro_z = ((System.Windows.Controls.TextBlock)(this.FindName("label_gyro_z")));
            this.value_gyro_z = ((System.Windows.Controls.TextBlock)(this.FindName("value_gyro_z")));
            this.title_incli = ((System.Windows.Controls.TextBlock)(this.FindName("title_incli")));
            this.label_incli_yaw = ((System.Windows.Controls.TextBlock)(this.FindName("label_incli_yaw")));
            this.value_incli_yaw = ((System.Windows.Controls.TextBlock)(this.FindName("value_incli_yaw")));
            this.label_incli_pitch = ((System.Windows.Controls.TextBlock)(this.FindName("label_incli_pitch")));
            this.value_incli_pitch = ((System.Windows.Controls.TextBlock)(this.FindName("value_incli_pitch")));
            this.label_incli_roll = ((System.Windows.Controls.TextBlock)(this.FindName("label_incli_roll")));
            this.value_incli_roll = ((System.Windows.Controls.TextBlock)(this.FindName("value_incli_roll")));
            this.title_light = ((System.Windows.Controls.TextBlock)(this.FindName("title_light")));
            this.label_light_lux = ((System.Windows.Controls.TextBlock)(this.FindName("label_light_lux")));
            this.value_light_lux = ((System.Windows.Controls.TextBlock)(this.FindName("value_light_lux")));
            this.button_logger = ((System.Windows.Controls.Button)(this.FindName("button_logger")));
            this.button_del = ((System.Windows.Controls.Button)(this.FindName("button_del")));
            this.button_add = ((System.Windows.Controls.Button)(this.FindName("button_add")));
            this.label_top_activity = ((System.Windows.Controls.TextBlock)(this.FindName("label_top_activity")));
            this.textBox_activity = ((System.Windows.Controls.TextBox)(this.FindName("textBox_activity")));
            this.textBlock_logquantity = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock_logquantity")));
        }
    }
}

