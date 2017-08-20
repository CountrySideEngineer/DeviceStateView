using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace DeviceStateView.ViewModel
{
    public class DeviceStateViewModel : ViewModelBase
    {
        #region Constructors and the Finalizer
        /// <summary>
        /// Constructor
        /// </summary>
        public DeviceStateViewModel()
        {
            this.Init();
        }
        #endregion

        #region Property and field
        protected string _DeviceName;
        public string DeviceName
        {
            get { return this._DeviceName; }
            set
            {
                if (this.IsConnected)
                {
                    this._DeviceName = value;
                    this.RaisePropertyChanged("DeviceName");
                }
            }
        }
        protected string _DevicePort;
        public string DevicePort
        {
            get { return this._DevicePort; }
            set
            {
                if (this.IsConnected)
                {
                    this._DevicePort = value;
                    this.RaisePropertyChanged("DevicePort");
                }
            }
        }

        protected string _Value1;
        public string Value1
        {
            get { return this._Value1; }
            set
            {
                if (this.IsConnected)
                {
                    this._Value1 = value;
                    this.RaisePropertyChanged("Value1");
                }
            }
        }
        protected string _Value2;
        public string Value2
        {
            get { return this._Value2; }
            set
            {
                if (this.IsConnected)
                {
                    this._Value2 = value;
                    this.RaisePropertyChanged("Value2");
                }
            }
        }
        protected string _Value3;
        public string Value3
        {
            get { return this._Value3; }
            set
            {
                if (this.IsConnected)
                {
                    this._Value3 = value;
                    this.RaisePropertyChanged("Value3");
                }
            }
        }
        protected string _Unit1;
        public string Unit1
        {
            get { return this._Unit1; }
            set
            {
                if (this.IsConnected)
                {
                    this._Unit1 = value;
                    this.RaisePropertyChanged("Unit1");
                }
            }
        }
        protected string _Unit2;
        public string Unit2
        {
            get { return this._Unit2; }
            set
            {
                if (this.IsConnected)
                {
                    this._Unit2 = value;
                    this.RaisePropertyChanged("Unit2");
                }
            }
        }
        protected string _Unit3;
        public string Unit3
        {
            get { return this._Unit3; }
            set
            {
                if (this.IsConnected)
                {
                    this._Unit3 = value;
                    this.RaisePropertyChanged("Unit3");
                }
            }
        }
        protected bool _IsConnected;
        public bool IsConnected
        {
            get { return this._IsConnected; }
            set
            {
                if ((this._IsConnected == true) && (value == false))
                {
                    /*
                     *  When disconnected, the device information must be reset.
                     */
                    this.Clear();
                }
                this._IsConnected = value;
                this.RaisePropertyChanged("IsConnected");
            }
        }
        #endregion

        #region Other methods and private properties in calling order
        /// <summary>
        /// Initialize device information.
        /// </summary>
        protected void Init()
        {
            this.Clear();

            this.IsConnected = false;
        }
        /// <summary>
        /// Clear parameters bound to views.
        /// </summary>
        protected void Clear()
        {
            this.DeviceName = "";
            this.DevicePort = "";

            this.Value1 = "";
            this.Value2 = "";
            this.Value3 = "";
            this.Unit1 = "";
            this.Unit2 = "";
            this.Unit3 = "";
        }
        #endregion
    }
}
