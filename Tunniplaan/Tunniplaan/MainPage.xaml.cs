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
        Label Pon, Vt, Sr, tset, pjat, FamImjaGruppa, Russkij, Seti, MobRaz, Translog, ProfIng, Estlang, OS, Translog1, Keemia, OS1, Seti1, ProfIng1, Keemia1, MobRaz1;
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
                BackgroundColor = Color.White;
            }
            //Фамилия и имя и группа.
            FamImjaGruppa = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = "Эрик Борисенко LOGITpv19", FontSize = 30 };
            grid.Children.Add(FamImjaGruppa, 0, 0);
            Grid.SetColumnSpan(FamImjaGruppa, 11);

            //Понедельник.
            Pon = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = "Понедельник       ", FontSize = 15 };
            grid.Children.Add(Pon, 0, 1);
            Grid.SetColumnSpan(Pon, 2);
         
            //Вторник.
            Vt = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = "Вторник      ", FontSize = 15 };
            grid.Children.Add(Vt, 0, 2);
            Grid.SetColumnSpan(Vt, 2);
            
            //Среда.
            Sr = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = "Среда      ", FontSize = 15 };
            grid.Children.Add(Sr, 0, 3);
            Grid.SetColumnSpan(Sr, 2);

            //Четверг.
            tset = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = "Четверг      ", FontSize = 15 };
            grid.Children.Add(tset, 0, 4);
            Grid.SetColumnSpan(tset, 2);
          
            //Пятница.
            pjat = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = "Пятница     ", FontSize = 15 };
            grid.Children.Add(pjat, 0, 5);
            Grid.SetColumnSpan(pjat, 2);

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
            Grid.SetColumnSpan(Seti, 2);
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += (s, e) =>
            {
                Seti = (Label)s;
                MoreInfo1();
            };

            //Понедельник Мобильная разработка.
            MobRaz = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Blue, Text = "Моб. Разработка", FontSize = 15 };
            grid.Children.Add(MobRaz, 7, 1);
            Grid.SetColumnSpan(MobRaz, 3);
            var tap2 = new TapGestureRecognizer();
            tap2.Tapped += (s, e) =>
            {
                MobRaz = (Label)s;
                MoreInfo2();
            };

            //Вторник Транспортная логистика.
            Translog = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightCoral, Text = "Трансп. Лог.      ", FontSize = 15 };
            grid.Children.Add(Translog, 2, 2);
            Grid.SetColumnSpan(Translog, 3);
            var tap3 = new TapGestureRecognizer();
            tap3.Tapped += (s, e) =>
            {
                Translog = (Label)s;
                MoreInfo3();
            };

            //Вторник Проф. Англ.
            ProfIng = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = "Проф. Англ.", FontSize = 15 };
            grid.Children.Add(ProfIng, 6, 2);
            Grid.SetColumnSpan(ProfIng, 2);
            var tap4 = new TapGestureRecognizer();
            tap4.Tapped += (s, e) =>
            {
                ProfIng = (Label)s;
                MoreInfo4();
            };

            //Вторник Эст. Язык.
            Estlang = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Pink, Text = "Эст. Яз.", FontSize = 15 };
            grid.Children.Add(Estlang, 8, 2);
            Grid.SetColumnSpan(Estlang, 2);
            var tap5 = new TapGestureRecognizer();
            tap5.Tapped += (s, e) =>
            {
                Estlang = (Label)s;
                MoreInfo5();
            };
            //Среда ОС.
            OS = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Purple, Text = "Операционная Система", FontSize = 15 };
            grid.Children.Add(OS, 2, 3);
            Grid.SetColumnSpan(OS, 3);
            var tap6 = new TapGestureRecognizer();
            tap6.Tapped += (s, e) =>
            {
                OS = (Label)s;
                MoreInfo6();
            };
            //Среда Транспортная логистика.
            Translog1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightCoral, Text = "Трансп. Лог.                      ", FontSize = 15 };
            grid.Children.Add(Translog1, 5, 3);
            Grid.SetColumnSpan(Translog1, 5);
            var tap7 = new TapGestureRecognizer();
            tap7.Tapped += (s, e) =>
            {
                Translog1 = (Label)s;
                MoreInfo7();
            };
            //Среда Химия.
            Keemia = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Purple, Text = "Химия", FontSize = 15 };
            grid.Children.Add(Keemia, 10, 3);
             Grid.SetColumnSpan(Keemia, 1);
            var tap8 = new TapGestureRecognizer();
            tap8.Tapped += (s, e) =>
            {
                Keemia = (Label)s;
                MoreInfo8();
            };

            //Четверг ОС.
            OS1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Purple, Text = "Операционная Система", FontSize = 15 };
            grid.Children.Add(OS1, 2, 4);
             Grid.SetColumnSpan(OS1, 3);
            var tap9 = new TapGestureRecognizer();
            tap9.Tapped += (s, e) =>
            {
                OS1 = (Label)s;
                MoreInfo9();
            };

            //Четверг Сети.
            Seti1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Beige, Text = "Построение Сетей", FontSize = 15 };
            grid.Children.Add(Seti1, 6, 4);
            Grid.SetColumnSpan(Seti1, 2);
            var tap10 = new TapGestureRecognizer();
            tap10.Tapped += (s, e) =>
            {
                Seti1 = (Label)s;
                MoreInfo10();
            };

            //Четверг Проф. Англ.
            ProfIng1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = "Проф. Англ.", FontSize = 15 };
            grid.Children.Add(ProfIng1, 8, 4);
            Grid.SetColumnSpan(ProfIng1, 2);
            var tap11 = new TapGestureRecognizer();
            tap11.Tapped += (s, e) =>
            {
                ProfIng1 = (Label)s;
                MoreInfo11();
            };
            //Пятница Химия.
            Keemia1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Purple, Text = "Химия", FontSize = 15 };
            grid.Children.Add(Keemia1, 2, 5);
            Grid.SetColumnSpan(Keemia1, 1);
            var tap12 = new TapGestureRecognizer();
            tap12.Tapped += (s, e) =>
            {
                Keemia1 = (Label)s;
                MoreInfo12();
            };

            //Мобильная разработка.
            MobRaz1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Blue, Text = "Моб. Разработка", FontSize = 15 };
            grid.Children.Add(MobRaz1, 4, 5);
            Grid.SetColumnSpan(MobRaz1, 3);
            var tap13 = new TapGestureRecognizer();
            tap13.Tapped += (s, e) =>
            {
                MobRaz1 = (Label)s;
                MoreInfo13();
            };
            Russkij.GestureRecognizers.Add(tap);
            Seti.GestureRecognizers.Add(tap1);
            MobRaz.GestureRecognizers.Add(tap2);
            Translog.GestureRecognizers.Add(tap3);
            ProfIng.GestureRecognizers.Add(tap4);
            Estlang.GestureRecognizers.Add(tap5);
            OS.GestureRecognizers.Add(tap6);
            Translog1.GestureRecognizers.Add(tap7);
            Keemia.GestureRecognizers.Add(tap8);
            OS1.GestureRecognizers.Add(tap9);
            Seti1.GestureRecognizers.Add(tap10);
            ProfIng1.GestureRecognizers.Add(tap11);
            Keemia1.GestureRecognizers.Add(tap12);
            MobRaz1.GestureRecognizers.Add(tap13);
            Content = grid;

        }
        public async void MoreInfo()
        {
            await DisplayAlert("Подробная информация", "Кабинет B221, Людмила Михайловна", "Закрыть");
        }
        public async void MoreInfo1()
        {
            await DisplayAlert("Подробная информация", "Кабинет A123, Михаил Агапов", "Закрыть");
        }
        public async void MoreInfo2()
        {
            await DisplayAlert("Подробная информация", "Кабинет E07, Марина Олейник", "Закрыть");
        }
        public async void MoreInfo3()
        {
            await DisplayAlert("Подробная информация", "Кабинет B002, Яянус Крулль", "Закрыть");
        }
        public async void MoreInfo4()
        {
            await DisplayAlert("Подробная информация", "Кабинет , B242,Юлия Воронецкая", "Закрыть");
        }
        public async void MoreInfo5()
        {
            await DisplayAlert("Подробная информация", "Кабинет , B242, Алина Ляневали-Тоотс", "Закрыть");
        }
        public async void MoreInfo6()
        {
            await DisplayAlert("Подробная информация", "Кабинет , A243, Лури Шкарбанова", "Закрыть");
        }
        public async void MoreInfo7()
        {
            await DisplayAlert("Подробная информация", "Кабинет , B003, Яянус Крулль", "Закрыть");
        }
        public async void MoreInfo8()
        {
            await DisplayAlert("Подробная информация", "Кабинет , B144, Светлана Песецкая", "Закрыть");
        }
        public async void MoreInfo9()
        {
            await DisplayAlert("Подробная информация", "Кабинет , A243, Лури Шкарбанова", "Закрыть");
        }
        public async void MoreInfo10()
        {
            await DisplayAlert("Подробная информация", "Кабинет A123, Михаил Агапов", "Закрыть");
        }
        public async void MoreInfo11()
        {
            await DisplayAlert("Подробная информация", "Кабинет , B242, Юлия Воронецкая", "Закрыть");
        }
        public async void MoreInfo12()
        {
            await DisplayAlert("Подробная информация", "Кабинет , B144, Светлана Песецкая", "Закрыть");
        }
        public async void MoreInfo13()
        {
            await DisplayAlert("Подробная информация", "Кабинет E07, Марина Олейник", "Закрыть");
        }
    }
}
