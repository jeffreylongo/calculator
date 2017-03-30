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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Jeff's First Calculator";
        }
        //this is the top text input box. 
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var input1 = Console.ReadLine();
        }
        //this is the bottom text input box
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            var input2 = Console.ReadLine();
        }
        //this is my + button 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
        //this is my - button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        //this is my * button
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
        //this is my / button 
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
        //this is my % button
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
}
