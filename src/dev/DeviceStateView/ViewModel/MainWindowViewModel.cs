using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceStateView.ViewModel
{
    using DeviceStateView.Command;
    using System.Windows;

    /// <summary>
    /// ViewModel class for MainWindow view.
    /// </summary>
    public class MainWindowViewModel : ViewModelBase
    {
        #region Constructors and the Finalizer
        public MainWindowViewModel()
        {
            this.Init();
        }
        #endregion

        #region Public properties
        protected string _InputValue1;
        public string InputValue1
        {
            get { return this._InputValue1; }
            set
            {
                this._InputValue1 = value;
                this.DevStateViewModel.Value1 = value;
                this.RaisePropertyChanged("InputValue1");
            }
        }
        protected string _InputUnit1;
        public string InputUnit1
        {
            get { return this._InputUnit1; }
            set
            {
                this._InputUnit1 = value;
                this.DevStateViewModel.Unit1 = value;
                this.RaisePropertyChanged("InputUnit1");
            }
        }
        protected string _InputValue2;
        public string InputValue2
        {
            get { return this._InputValue2; }
            set
            {
                this._InputValue2 = value;
                this.DevStateViewModel.Value2 = value;
                this.RaisePropertyChanged("InputValue2");
            }
        }
        protected string _InputUnit2;
        public string InputUnit2
        {
            get { return this._InputUnit2; }
            set
            {
                this._InputUnit2 = value;
                this.DevStateViewModel.Unit2 = value;
                this.RaisePropertyChanged("InputUnit2");
            }
        }
        protected string _InputValue3;
        public string InputValue3
        {
            get { return this._InputValue3; }
            set
            {
                this._InputValue3 = value;
                this.DevStateViewModel.Value3 = value;
                this.RaisePropertyChanged("InputValue3");
            }
        }
        protected string _InputUnit3;
        public string InputUnit3
        {
            get { return this._InputUnit3; }
            set
            {
                this._InputUnit3 = value;
                this.DevStateViewModel.Unit3 = value;
                this.RaisePropertyChanged("InputUnit3");
            }
        }

        protected DeviceStateViewModel _DevStateViewModel;
        public DeviceStateViewModel DevStateViewModel
        {
            get
            {
                if (null == this._DevStateViewModel)
                {
                    this._DevStateViewModel = new DeviceStateViewModel();
                }
                return this._DevStateViewModel;
            }
            set
            {
                this._DevStateViewModel = value;
                this.RaisePropertyChanged("DevStateViewModel");
            }
        }

        /// <summary>
        /// Delegate command to change connection state of DeviceStateViewModel.
        /// </summary>
        protected DelegateCommand _StateChangeCommand;
        public DelegateCommand StateChangeCommand
        {
            get
            {
                if (null == this._StateChangeCommand)
                {
                    this._StateChangeCommand = new DelegateCommand(
                            this.StateChangeCommandExecute, CanStateChangeCommandExecute);
                }
                return this._StateChangeCommand;
            }
        }

        /// <summary>
        /// Body of command to change the Property "IsConnected" when 
        /// </summary>
        public void StateChangeCommandExecute()
        {
            if (this.DevStateViewModel.IsConnected)
            {
                this.DevStateViewModel.IsConnected = false;
            }
            else
            {
                this.DevStateViewModel.IsConnected = true;
                this.Init();
            }
        }
        public bool CanStateChangeCommandExecute() { return true; }
        #endregion

        #region Other methods and private properties in calling order
        /// <summary>
        /// Initialize parameters.
        /// </summary>
        public void Init()
        {
            this.InputValue1 = "0";
            this.InputValue2 = "0";
            this.InputValue3 = "0";
            this.InputUnit1 = "%";
            this.InputUnit2 = "-";
            this.InputUnit3 = @"\";
        }
        #endregion
    }
}
