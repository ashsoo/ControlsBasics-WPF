using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            Window1 navigatesWindow = new Window1();
            navigatesWindow.ShowDialog();
        }

        private void Req_Click(object sender, RoutedEventArgs e)
        {
            Req_win navigatesWindow2 = new Req_win();
            navigatesWindow2.ShowDialog();
        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            MainWindow navigatesWindow = new MainWindow();
            navigatesWindow.ShowDialog();
        }
    }
}
