using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class Task4Window : Window
    {
        private string secretPassword = "password123";
        private string secretMessage = "Это секретное сообщение!";

        public Task4Window()
        {
            InitializeComponent();
        }

        private void ButtonCheck_Click(object sender, RoutedEventArgs e)
        {
            string enteredPassword = passwordBox.Password;
            if (enteredPassword == secretPassword)
            {
                textBlockMessage.Text = secretMessage;
                passwordBox.Clear();
            }
            else
            {
                MessageBox.Show("Неверный пароль. Попробуйте еще раз.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                passwordBox.Clear();
            }
        }
    }
}