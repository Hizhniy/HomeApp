using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HomeApp.Pages
{
    class LoadingPage : ContentPage
    {
        public LoadingPage()
        {
            // Объявим новый текстовый элемент
            Label header = new Label() { Text = $"Запуск вашего первого приложения{Environment.NewLine} на Xamarin..." };

            // Здесь можно сразу установить стили и шрифт
            header.Opacity = 0;
            header.HorizontalTextAlignment = TextAlignment.Center;
            header.VerticalTextAlignment = TextAlignment.Center;
            header.FontSize = 21;
            // Можем даже задать анимацию
            header.FadeTo(1, 3000);

            // Инициализация свойства Content новым элементом.
            Content = header;
        }
    }

    class SpanPage : ContentPage
    {
        public SpanPage()
        {
            // Инициализация объекта
            Label label = new Label()
            {
                FontSize = 16,
                Padding = new Thickness(30, 24, 30, 0),
                FormattedText = new FormattedString()
                {
                    Spans =
               {
                   new Span() { Text = "Learn more at " },
                   new Span() { Text = "https://aka.ms/xamarin-quickstart", FontAttributes = FontAttributes.Bold }
               }
                }
            };

            // Добавление на страницу
            Content = label;
        }
    }
}
