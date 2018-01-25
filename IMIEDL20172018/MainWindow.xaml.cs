using IMIEDL20172018.Models;
using IMIEDL20172018.Views;
using System;
using System.Collections.Generic;
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

namespace IMIEDL20172018
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Client c1 = new Client();
            c1.Firstname = "toto";
            c1.Lastname = "tata";
            c1.Money = 100;
            ClientUC.CurrentClient = c1;

            Task.Factory.StartNew(() =>
            {
                Client client = new Client();
                client.Firstname = "coucou";
                ClientUC.CurrentClient = client;
            });

            btnNavigate.Click += BtnNavigate_Click;
        }

        private void BtnNavigate_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Page1();
        }
    }
}
