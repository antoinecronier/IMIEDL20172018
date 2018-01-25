using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIEDL20172018.Views;
using IMIEDL20172018.Models;

namespace IMIEDL20172018.ViewModels
{
    public class Page1ViewModel
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        private Page1 page1;
        #endregion

        #region Attributs
        #endregion

        #region Properties
        #endregion

        #region Constructors
        public Page1ViewModel(Page1 page1)
        {
            this.page1 = page1;
            Init();
            Events();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        private void Init()
        {
            Client client = new Client();
            client.Firstname = "antoine";
            client.Lastname = "cronier";
            client.Money = 1000000;

            this.page1.ClientUC.CurrentClient = client;
        }

        private void Events()
        {
            this.page1.btnNavigate.Click += BtnNavigate_Click;
        }

        private void BtnNavigate_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
        #endregion

        #region Events
        #endregion


    }
}
