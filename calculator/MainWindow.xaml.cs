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
        double num1 = 0;
        double num2 = 0;
        string dotSign = "";
        bool plusClicked = false;
        bool subClicked = false;
        bool multClicked = false;
        bool divClicked = false;

        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Jeff's First Calculator";
        }
        string memoryPath = "memory.txt"; 
        //this is my + button 
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            var rawInput = "";
            //double output = Int32.Parse(input1.Text) + Int32.Parse(input2.Text);
            //Answer.Content = output.ToString();
            rawInput = Convert.ToString(Answer.Content);
            num1 += Convert.ToDouble(rawInput);
            Answer.Content = "0";

            plusClicked = true;
            subClicked = false;
            multClicked = false;
            divClicked = false;
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
        //here are my numbers.  
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

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content += "6";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content += "5";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content += "4";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content += "3";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content += "2";
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content += "1";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content += "0";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content = "0";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //Equal button functions 
        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            double rawInput = 0;
            if (plusClicked == true)
            {
                rawInput = Convert.ToDouble(Answer.Content);
                num2 = num1 + rawInput;
                Answer.Content = num2.ToString();
                num1 = 0;
            }

            

        }
    }
}
