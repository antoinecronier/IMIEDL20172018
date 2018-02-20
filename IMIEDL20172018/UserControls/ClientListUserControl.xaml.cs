using ProjectModel.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logique d'interaction pour ClientListUserControl.xaml
    /// </summary>
    public partial class ClientListUserControl : UserControl
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        #endregion

        #region properties
        public ListView ItemsList { get; set; }
        public ObservableCollection<Client> Obs { get; set; }
        #endregion

        #region constructor
        public ClientListUserControl()
        {
            this.InitializeComponent();
            Obs = new ObservableCollection<Client>();
            this.itemsList.ItemsSource = Obs;
            //this.ItemsList = this.itemsList;
        }
        #endregion

        #region methods
        /// <summary>
        /// Current list for User items.
        /// </summary>
        public void LoadItems(List<Client> items)
        {
            Obs.Clear();
            foreach (var item in items)
            {
                Obs.Add(item);
            }
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion


    }
}
