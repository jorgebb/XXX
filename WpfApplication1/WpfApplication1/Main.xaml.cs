using System;
using System.Collections.Generic;
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

namespace CODEONE
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// Versão 3.0
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // ALTERADO
            // Alterado no master
        }

     
     

        private void MouseEnter1(object sender, MouseEventArgs e)
        {
            System.Windows.Shapes.Path b = (System.Windows.Shapes.Path)sender;
            b.Fill = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            
            label1.Content = b.Name.Replace("_", " ");
        }

        

       
       
    }
}
