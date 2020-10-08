using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tunniplaan
{
    public partial class MainPage : ContentPage
    {
        Label Russkij, Seti, MobRaz, Translog, ProfIng, Estlang, OS, Translog1, Keemia, OS1, Seti1, ProfIng1, Keemia1, MobRaz1;
        public MainPage()
            
        {
            Grid grid = new Grid();
            for (int i = 0; i < 10; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }
            for (int i = 0; i < 5; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }
            {
                BackgroundColor = Color.LightSalmon;
            }
            //Понедельник Русский язык.
            Russkij = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGreen, Text = "Русский и литература", FontSize = 15 };
            grid.Children.Add(Russkij, 2, 1);
            Grid.SetColumnSpan(Russkij, 2);
            var tap = new TapGestureRecognizer();
            tap.Tapped += (s, e) =>
            {
                Russkij = (Label)s;
                MoreInfo();
            };
            //Понедельник Сети.
            Seti = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Beige, Text = "Построение Сетей", FontSize = 15 };
            grid.Children.Add(Seti, 4, 1);
            // Grid.SetColumnSpan(Seti, 3);

            //Понедельник Мобильная разработка.
            MobRaz = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Blue, Text = "Моб. Разработка", FontSize = 15 };
            grid.Children.Add(MobRaz, 7, 1);
            // Grid.SetColumnSpan(MobRaz, 1);

            //Вторник Транспортная логистика.
            Translog = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightCoral, Text = "Трансп. Лог.", FontSize = 15 };
            grid.Children.Add(Translog, 2, 2);
            // Grid.SetColumnSpan(Translog, 1);

            //Вторник Проф. Англ.
            ProfIng = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = "Проф. Англ.", FontSize = 15 };
            grid.Children.Add(ProfIng, 6, 2);
            // Grid.SetColumnSpan(ProfIng, 1);

            //Вторник Эст. Язык.
            Estlang = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Pink, Text = "Эст. Яз.", FontSize = 15 };
            grid.Children.Add(Estlang, 2, 2);
            // Grid.SetColumnSpan(Estlang, 1);

            //Среда ОС.
            OS = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Purple, Text = "Операционная Система", FontSize = 15 };
            grid.Children.Add(OS, 2, 3);
            // Grid.SetColumnSpan(OS, 1);

            //Среда Транспортная логистика.
            Translog1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightCoral, Text = "Трансп. Лог.", FontSize = 15 };
            grid.Children.Add(Translog1, 5, 3);
            // Grid.SetColumnSpan(Translog1, 1);

            //Среда Химия.
            Keemia = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Purple, Text = "Химия", FontSize = 15 };
            grid.Children.Add(Keemia, 10, 3);
            // Grid.SetColumnSpan(Keemia, 1);

            //Четверг ОС.
            OS1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Purple, Text = "Операционная Система", FontSize = 15 };
            grid.Children.Add(OS1, 2, 4);
            // Grid.SetColumnSpan(OS1, 1);

            //Четверг Сети.
            Seti1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Beige, Text = "Построение Сетей", FontSize = 15 };
            grid.Children.Add(Seti1, 6, 4);
            // Grid.SetColumnSpan(Seti1, 1);

            //Четверг Проф. Англ.
            ProfIng1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = "Проф. Англ.", FontSize = 15 };
            grid.Children.Add(ProfIng1, 8, 4);
           // Grid.SetColumnSpan(ProfIng1, 1);

            //Пятница Химия.
            Keemia1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Purple, Text = "Химия", FontSize = 15 };
            grid.Children.Add(Keemia1, 2, 5);
           // Grid.SetColumnSpan(Keemia1, 1);

            //Мобильная разработка.
            MobRaz1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Blue, Text = "Моб. Разработка", FontSize = 15 };
            grid.Children.Add(MobRaz1, 4, 5);
           // Grid.SetColumnSpan(MobRaz1, 1);

            Russkij.GestureRecognizers.Add(tap);
            Content = grid;

        }
        public async void MoreInfo()
        {
            await DisplayAlert("Подробная информация", "Кабинет B221, Людмила Михайловна", "Закрыть");
        }

    }
}
