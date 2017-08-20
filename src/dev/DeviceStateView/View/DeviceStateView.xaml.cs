using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeviceStateView.View
{
    /// <summary>
    /// DeviceStateView.xaml の相互作用ロジック
    /// </summary>
    public partial class DeviceStateView : UserControl
    {
        protected static BitmapImage ConnImage = new BitmapImage(
            new Uri(@"../Resource/conn.png", UriKind.Relative));
        protected static BitmapImage DisConnImage = new BitmapImage(
            new Uri(@"../Resource/disconn.png", UriKind.Relative));

        public DeviceStateView()
        {
            InitializeComponent();

            this.ConnectImage.Source = DeviceStateView.DisConnImage;
        }

        #region Properties and fields
        /// <summary>Property coresponding to Value1 field.</summary>
        public static readonly DependencyProperty Value1Property =
            DependencyProperty.Register(
                "Value1",
                typeof(string),
                typeof(DeviceStateView),
                new PropertyMetadata(""));
        public string Value1
        {
            get { return (string)GetValue(Value1Property); }
            set { SetValue(Value1Property, value); }
        }
        /// <summary>Property coresponding to Unit1 field.</summary>
        public static readonly DependencyProperty Unit1Property =
            DependencyProperty.Register(
                "Unit1",
                typeof(string),
                typeof(DeviceStateView),
                new PropertyMetadata(""));
        public string Unit1
        {
            get { return (string)GetValue(Unit1Property); }
            set { SetValue(Unit1Property, value); }
        }
        /// <summary>Property coresponding to Value2 field.</summary>
        public static readonly DependencyProperty Value2Property =
            DependencyProperty.Register(
                "Value2",
                typeof(string),
                typeof(DeviceStateView),
                new PropertyMetadata(""));
        public string Value2
        {
            get { return (string)GetValue(Value2Property); }
            set { SetValue(Value2Property, value); }
        }
        /// <summary>Property coresponding to Unit2 field.</summary>
        public static readonly DependencyProperty Unit2Property =
            DependencyProperty.Register(
                "Unit2",
                typeof(string),
                typeof(DeviceStateView),
                new PropertyMetadata(""));
        public string Unit2
        {
            get { return (string)GetValue(Unit2Property); }
            set { SetValue(Unit2Property, value); }
        }
        /// <summary>Property coresponding to Value3 field.</summary>
        public static readonly DependencyProperty Value3Property =
            DependencyProperty.Register(
                "Value3",
                typeof(string),
                typeof(DeviceStateView),
                new PropertyMetadata(""));
        public string Value3
        {
            get { return (string)GetValue(Value3Property); }
            set { SetValue(Value3Property, value); }
        }
        /// <summary>Property coresponding to Unit3 field.</summary>
        public static readonly DependencyProperty Unit3Property =
            DependencyProperty.Register(
                "Unit3",
                typeof(string),
                typeof(DeviceStateView),
                new PropertyMetadata(""));
        public string Unit3
        {
            get { return (string)GetValue(Unit3Property); }
            set { SetValue(Unit3Property, value); }
        }
        /// <summary>Property coresponding to DeviceName field.</summary>
        public static readonly DependencyProperty DeviceNameProperty =
            DependencyProperty.Register(
                "DeviceName",
                typeof(string),
                typeof(DeviceStateView),
                new PropertyMetadata(""));
        public string DeviceName
        {
            get { return (string)GetValue(DeviceNameProperty); }
            set { SetValue(DeviceNameProperty, value); }
        }
        /// <summary>Property coresponding to DeviceName field.</summary>
        public static readonly DependencyProperty DevicePortProperty =
            DependencyProperty.Register(
                "DevicePort",
                typeof(string),
                typeof(DeviceStateView),
                new PropertyMetadata(""));
        public string DevicePort
        {
            get { return (string)GetValue(DevicePortProperty); }
            set { SetValue(DevicePortProperty, value); }
        }
        /// <summary>Property coresponding to DeviceName field.</summary>
        public static readonly DependencyProperty IsConnectedProperty =
            DependencyProperty.Register(
                "IsConnected",
                typeof(bool),
                typeof(DeviceStateView),
                new PropertyMetadata(false, IsConnectedChanged));
        public bool IsConnected
        {
            get { return (bool)GetValue(IsConnectedProperty); }
            set { SetValue(IsConnectedProperty, value); }
        }
        #endregion

        #region Event handler
        /// <summary>
        /// Event handler called when the property "IsConnected" is changed.
        /// </summary>
        /// <param name="sender">The DependencyObject on which the property has changed value.</param>
        /// <param name="e">Event data that is issued by any event that tracks changes to the effective value of this property.</param>
        [Browsable(true)]
        [Description("Event handler called when the property \"IsConnected\" is changed.")]
        public static void IsConnectedChanged(
            DependencyObject sender,
            DependencyPropertyChangedEventArgs e)
        {
            DeviceStateView DstView = sender as DeviceStateView;
            bool NewValue = (bool)e.NewValue;
            if (NewValue)
            {
                DstView.ConnectImage.Source = DeviceStateView.ConnImage;
            }
            else
            {
                DstView.ConnectImage.Source = DeviceStateView.DisConnImage;
            }
        }
        #endregion
    }
}
