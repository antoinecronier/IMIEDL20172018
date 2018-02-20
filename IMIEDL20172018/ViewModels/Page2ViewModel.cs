using System;
using IMIEDL20172018.Views;
using System.Collections.Generic;
using ProjectModel.Models;

namespace IMIEDL20172018.ViewModels
{
    internal class Page2ViewModel
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        private Page2 page2;
        #endregion

        #region Attributs
        #endregion

        #region Properties
        #endregion

        #region Constructors
        public Page2ViewModel(Page2 page2)
        {
            this.page2 = page2;
            Init();
            Events();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions

        private void Events()
        {
            this.page2.btnNavigate.Click += BtnNavigate_Click;
        }

        private void BtnNavigate_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow.Instance.CurrentPage = new Page1();
        }

        private void Init()
        {
            List<Client> clients = new List<Client>();
            for (int i = 0; i < 200; i++)
            {
                clients.Add(new Client("fn" + i, "ln" + i, i * i));
            }
            
            this.page2.ClientListUC.LoadItems(clients);
        }
        #endregion

        #region Events
        #endregion


    }
}