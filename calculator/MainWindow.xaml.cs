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

        //this is my + button 
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(input1.Text) + Int32.Parse(input2.Text);
            Answer.Content = output.ToString();
        }
        //this is my - button
        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(input1.Text) - Int32.Parse(input2.Text);
            Answer.Content = output.ToString();
        }
        //this is my * button
        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(input1.Text) * Int32.Parse(input2.Text);
            Answer.Content = output.ToString();
        }
        //this is my / button 
        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(input1.Text) / Int32.Parse(input2.Text);
            Answer.Content = output.ToString();
        }
        //this is my % button
        private void Percentage_Click(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(input1.Text) % Int32.Parse(input2.Text);
            Answer.Content = output.ToString();
        }
    }
}
