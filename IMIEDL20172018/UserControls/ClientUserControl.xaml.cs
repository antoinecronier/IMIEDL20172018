using IMIEDL20172018.Models;
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

namespace IMIEDL20172018.UserControls
{
    /// <summary>
    /// Logique d'interaction pour ClientUserControl.xaml
    /// </summary>
    public partial class ClientUserControl : UserControl, INotifyPropertyChanged
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private Client currentClient;
        #endregion

        #region Properties
        public Client CurrentClient
        {
            get { return currentClient; }
            set {
                currentClient = value;
                OnPropertyChanged("CurrentClient");
            }
        }
        #endregion

        #region Constructors
        public ClientUserControl()
        {
            InitializeComponent();
            DataContext = this;
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
    }
}
