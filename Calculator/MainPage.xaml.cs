using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Calculator
{
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = Int32.Parse(firstTextBox.Text);
            int secondNumber = Int32.Parse(secondTextBox.Text);
            int result = firstNumber + secondNumber;
            resultTextBlock.Text = "Result: " + result.ToString();
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = Int32.Parse(firstTextBox.Text);
            int secondNumber = Int32.Parse(secondTextBox.Text);
            int result = firstNumber - secondNumber;
            resultTextBlock.Text = "Result: " + result.ToString();
        }

        private void multiplicationButton_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = Int32.Parse(firstTextBox.Text);
            int secondNumber = Int32.Parse(secondTextBox.Text);
            int result = firstNumber * secondNumber;
            resultTextBlock.Text = "Result: " + result.ToString();
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = Int32.Parse(firstTextBox.Text);
            int secondNumber = Int32.Parse(secondTextBox.Text);
            int result = firstNumber / secondNumber;
            resultTextBlock.Text = "Result: " + result.ToString();
        }
    }
}
