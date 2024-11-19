using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfApp1
{
    public partial class Task1Window : Window
    {
        private Dictionary<string, string> weatherWords = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) //Case-insensitive
        {
            {"солнце", "sun"}, {"дождь", "rain"}, {"снег", "snow"}, {"ветер", "wind"},
            {"туман", "fog"}, {"облачно", "cloudy"}, {"ясно", "clear"}, {"холодно", "cold"},
            {"тепло", "warm"}, {"жарко", "hot"}
        };

        public Task1Window()
        {
            InitializeComponent();
        }

        private void ButtonTranslate_Click(object sender, RoutedEventArgs e)
        {
            string word = textBoxWord.Text.Trim(); // Trim whitespace

            if (string.IsNullOrEmpty(word))
            {
                textBlockTranslation.Text = "Пожалуйста, введите слово.";
                return;
            }

            if (weatherWords.ContainsKey(word))
            {
                textBlockTranslation.Text = $"Перевод: {weatherWords[word]}";
            }
            else
            {
                textBlockTranslation.Text = "Такого слова нет в словаре.";
            }
        }
    }
}