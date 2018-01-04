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
        private MoreAndLess mAl;
        private bool retry = false;
        private String played = "";

        public MainWindow()
        {
            InitializeComponent();
            this.userInput.KeyUp += UserInput_KeyUp;
            mAl = new MoreAndLess();
            InitEvents();
            this.passedValues.Text = played;

            this.toFind.MouseDoubleClick += ToFind_MouseDoubleClick;
        }

        private void UserInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key.Equals(Key.Enter))
            {
                DoMoreAndLess();
            }
        }

        private void InitEvents()
        {
            mAl.Less += MAl_Less;
            mAl.More += MAl_More;
            mAl.Founded += MAl_Founded;
            mAl.Loose += MAl_Loose;
        }

        private void ToFind_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DoMoreAndLess();
        }

        private void DoMoreAndLess()
        {
            if (retry)
            {
                this.toFind.Content = "?";
                this.mAl = new MoreAndLess();
                InitEvents();
                retry = false;
                played = "";
                this.passedValues.Text = played;
            }

            int result;

            if (Int32.TryParse(this.userInput.Text, out result))
            {
                played += " " + this.userInput.Text;
                this.passedValues.Text = played;
                mAl.PlayWPF(result);
            }
            else
            {
                this.toFind.Background = new SolidColorBrush(Color.FromRgb(10, 10, 100));
            }
        }

        private void MAl_Loose(object sender, EventArgs e)
        {
            this.toFind.Content = "You have loose";
            this.toFind.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            this.more.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            this.less.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            retry = true;
        }

        private void MAl_Founded(object sender, EventArgs e)
        {
            this.toFind.Content = "You WIN";
            this.more.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            this.less.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            retry = true;
        }

        private void MAl_More(object sender, EventArgs e)
        {
            this.more.Background = new SolidColorBrush(Color.FromRgb(200, 10, 10));
            this.less.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            this.toFind.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        private void MAl_Less(object sender, EventArgs e)
        {
            this.less.Background = new SolidColorBrush(Color.FromRgb(200, 10, 10));
            this.more.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            this.toFind.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }
    }
}
