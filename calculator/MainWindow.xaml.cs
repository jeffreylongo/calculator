using System;
using System.Collections.Generic;
using System.IO;
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
        string memoryPath = "memory.txt"; 
        //this is my + button 
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            double output = Int32.Parse(input1.Text) + Int32.Parse(input2.Text);
            Answer.Content = output.ToString();
        }
        //this is my - button
        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            double output = Int32.Parse(input1.Text) - Int32.Parse(input2.Text);
            Answer.Content = output.ToString();
        }
        //this is my * button
        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            double output = Int32.Parse(input1.Text) * Int32.Parse(input2.Text);
            Answer.Content = output.ToString();
        }
        //this is my / button 
        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            double output = Int32.Parse(input1.Text) / Int32.Parse(input2.Text);
            Answer.Content = output.ToString();
        }
        //this is my % button
        private void Percentage_Click(object sender, RoutedEventArgs e)
        {
            double output = Int32.Parse(input1.Text) % Int32.Parse(input2.Text);
            Answer.Content = output.ToString();
        }
        //this is my memory store button
        private void Memory_Store_Click(object sender, RoutedEventArgs e)
        {
            using (var writer = new StreamWriter(memoryPath))
            {
                writer.WriteLine(Answer.Content);
            }
        }
        //memory recall button
        private void Memory_Recall_Click(object sender, RoutedEventArgs e)
        {
            using (var reader = new StreamReader(memoryPath))
            {
                var input= reader.ReadLine();
                Answer.Content = Int32.Parse(input);
            }
        }
        //memory clear button
        private void Memory_Clear_Click(object sender, RoutedEventArgs e)
        {
            using (var writer = new StreamWriter(memoryPath))
            {
                writer.WriteLine("");
            }
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content += "9";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content += "8";
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content += "7";
        }
    }
}
