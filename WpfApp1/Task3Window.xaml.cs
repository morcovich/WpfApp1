using System;
using System.Windows;

namespace WpfApp1
{
    public partial class Task3Window : Window
    {
        public Task3Window()
        {
            InitializeComponent();
        }

        private void ButtonCheck_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(textBoxNumber.Text, out int number))
            {
                if (number >= 0 && number <= 100)
                {
                    string result = CheckRange(number);
                    textBlockResult.Text = result;
                }
                else
                {
                    textBlockResult.Text = "Число должно быть от 0 до 100.";
                }
            }
            else
            {
                textBlockResult.Text = "Некорректный ввод. Пожалуйста, введите целое число.";
            }
        }

        private string CheckRange(int number)
        {
            if (number >= 0 && number <= 14) return "Число принадлежит промежутку [0 - 14]";
            if (number >= 15 && number <= 35) return "Число принадлежит промежутку [15 - 35]";
            if (number >= 36 && number <= 50) return "Число принадлежит промежутку [36 - 50]";
            if (number >= 51 && number <= 100) return "Число принадлежит промежутку [51 - 100]";
            return "Число не принадлежит ни одному из промежутков.";
        }
    }
}