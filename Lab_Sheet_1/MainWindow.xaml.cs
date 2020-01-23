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

namespace Lab_Sheet_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Band> AllBands = new List<Band>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Band b1 = new Band()
            {
                Name = "Arctic Monkeys",

            };
            Band b2 = new Band()
            {
                Name = "The Beatles",

            };
            Band b3 = new Band()
            {
                Name = "BTS",

            };
            Band b4 = new Band()
            {
                Name = "GOT7",

            };
           
        }
    }
}
