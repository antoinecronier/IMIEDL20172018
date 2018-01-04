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
        List<String> imageAdress = new List<string>() { "https://www.google.com/images/nav_logo229.png","https://www.3ders.org/images/slug-traq-3d-printed-test-1.png", "https://s3-us-west-1.amazonaws.com/powr/defaults/Siberian-Tiger-Running-Through-Snow-Tom-Brakefield-Getty-Images-200353826-001.jpg" };

        public MainWindow()
        {
            InitializeComponent();

            this.webbrowser.Navigate("https://github.com/antoinecronier/IMIEDL20172018");
            this.combobox.ItemsSource = new List<String>() {"Item1","Item2","Item3"};
            this.sGLabel.Content = "new label from C#";
            this.sGTextBox.FontStyle = FontStyles.Italic;
            this.sGTextBox.AcceptsReturn = true;
            this.checkbox.Checked += Checkbox_Checked;
            this.checkbox.Unchecked += Checkbox_Unchecked;
            this.slider.Maximum = 2;
            this.slider.ValueChanged += Slider_ValueChanged;
            this.image.Source = new BitmapImage(new Uri("https://www.google.com/images/nav_logo229.png"));
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int val = Int32.Parse(this.slider.Value.ToString());
            this.image.Source = new BitmapImage(new Uri(imageAdress.ToArray()[val]));
        }

        private void Checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.mainGrid.Background = new SolidColorBrush(Color.FromRgb(200, 10, 100));
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.mainGrid.Background = new SolidColorBrush(Color.FromRgb(10, 200, 100));
        }
    }
}
