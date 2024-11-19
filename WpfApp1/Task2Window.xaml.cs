using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class Task2Window : Window
    {
        public Task2Window()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(textBoxOperand1.Text, out double operand1) ||
                !double.TryParse(textBoxOperand2.Text, out double operand2))
            {
                MessageBox.Show("Некорректный ввод чисел. Пожалуйста, введите числа.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string sign = textBoxSign.Text;
            double result = 0;
            bool error = false;

            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        error = true;
                        MessageBox.Show("Деление на ноль невозможно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        result = operand1 / operand2;
                    }
                    break;
                default:
                    error = true;
                    MessageBox.Show("Неверный знак операции.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }

            if (!error)
            {
                textBlockResult.Text = $"Результат: {result}";
            }
        }
    }
}