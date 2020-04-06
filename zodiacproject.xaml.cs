using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zodiac
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class zodiacproject : ContentPage
    {
        Frame frame;
        ImageButton img;
        ImageButton img1;
        ImageButton img2;
        ImageButton img3;
        ImageButton img4;
        ImageButton img5;
        ImageButton img6;
        ImageButton img7;
        ImageButton img8;
        ImageButton img9;
        ImageButton img10;
        ImageButton img11;
        Switch switch1;
        public zodiacproject()
        {
            //   InitializeComponent();
            BackgroundColor = Color.Black;
            //            InitializeComponent();
            Grid grid = new Grid
            {
                RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(4, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
            },
                ColumnDefinitions =
            {
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
            }
            };

            frame = new Frame
            {
                BorderColor = Color.Aquamarine,
                BackgroundColor = Color.Aquamarine,
                CornerRadius = 30,
                Margin = 3
            };

            frame.Content = new Label { Text = "Пожалуйста, выберите знак зодиака", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), BackgroundColor = Color.Black, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center, TextColor = Color.Yellow };


            img = new ImageButton { Source = "imagez.PNG", Aspect = Aspect.AspectFill, Margin = 5 };
            img1 = new ImageButton { Source = "imagearies.PNG", Aspect = Aspect.AspectFill, Margin = 5 };
            img2 = new ImageButton { Source = "zodiacc.PNG", Aspect = Aspect.AspectFill, Margin = 5 };
            img3 = new ImageButton { Source = "zodiaccc.PNG", Aspect = Aspect.AspectFill, Margin = 5 };

            img4 = new ImageButton { Source = "zodiacx.PNG", Aspect = Aspect.AspectFill, Margin = 5 };
            img5 = new ImageButton { Source = "zodiaccx.PNG", Aspect = Aspect.AspectFill, Margin = 5 };
            img6 = new ImageButton { Source = "zodiacccx.PNG", Aspect = Aspect.AspectFill, Margin = 5 };
            img7 = new ImageButton { Source = "zodiaccccx.PNG", Aspect = Aspect.AspectFill, Margin = 5 };

            img8 = new ImageButton { Source = "zodiacy.PNG", Aspect = Aspect.AspectFill, Margin = 5 };
            img9 = new ImageButton { Source = "zodiaccy.PNG", Aspect = Aspect.AspectFill, Margin = 5 };
            img10 = new ImageButton { Source = "zodiacccy.PNG", Aspect = Aspect.AspectFill, Margin = 5 };
            img11 = new ImageButton { Source = "zodiaccccy.PNG", Aspect = Aspect.AspectFill, Margin = 5 };

            switch1 = new Switch
            {
                IsToggled = false,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            switch1.Toggled += Switch1_Toggled;


            grid.Children.Add(img, 0, 0);
            grid.Children.Add(img4, 0, 1);
            grid.Children.Add(img8, 0, 2);

            grid.Children.Add(img1, 1, 0);
            grid.Children.Add(img5, 1, 1);
            grid.Children.Add(img9, 1, 2);

            grid.Children.Add(img2, 2, 0);
            grid.Children.Add(img6, 2, 1);
            grid.Children.Add(img10, 2, 2);

            grid.Children.Add(img3, 3, 0);
            grid.Children.Add(img7, 3, 1);
            grid.Children.Add(img11, 3, 2);

            grid.Children.Add(switch1, 0, 5);
            Grid.SetColumnSpan(switch1, 4);

            grid.Children.Add(frame, 0, 3);
            Grid.SetColumnSpan(frame, 4);
            Grid.SetRowSpan(frame, 2);
            frame.PropertyChanged += frarmepropertychanged;
            img.Clicked += onimgclicked;
            img1.Clicked += onimg1clicked;
            img2.Clicked += onimg2clicked;
            img3.Clicked += onimg3clicked;
            img4.Clicked += onimg4clicked;
            img5.Clicked += onimg5clicked;
            img6.Clicked += onimg6clicked;
            img7.Clicked += onimg7clicked;
            img8.Clicked += onimg8clicked;
            img9.Clicked += onimg9clicked;
            img10.Clicked += onimg10clicked;
            img11.Clicked += onimg11clicked;


            Content = grid;
        }

        private void frarmepropertychanged(object sender, PropertyChangedEventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void Switch1_Toggled(object sender, ToggledEventArgs e)
        {
            // throw new NotImplementedException();

        }
        string aquarius = "Вы выбрали знак зодиака: Водолей" +
                        "\n Значение Знака: Человек, держащий два сосуда - с живой и мертвой водой" +
                        "\n Водолей Даты: 21 Января – 18 Февраля" +
                        "\n Тип Знака: Воздух – Фиксированный – Положительный" +
                        "\n Планета Водолея: Уран";
        private void onimg11clicked(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (switch1.IsToggled == true)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = aquarius +
                        "\n Счастливый Цвет: Синий, Сине-зеленый, Серый, Черный" +
                        "\n Счастливый День: Воскресенье и Суббота" +
                        "\n Счастливые Числа: 4, 8, 13, 17, 22, 26",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }
            if (switch1.IsToggled == false)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = aquarius,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }

        }
        string capricorn = "Вы выбрали знак зодиака: Козерог" +
                        "\n Значение Знака: Горный козел поднимающийся в гору, указывает на стремление возвыситься" +
                        "\n Козерог Даты: 22 Декабря – 20 Января" +
                        "\n Тип Знака: Земля – Кардинальный – Отрицательный" +
                        "\n Планета Козерога: Сатурн";
        private void onimg10clicked(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (switch1.IsToggled == true)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = capricorn +
                        "\n Счастливые Цвет: Коричневый, Сталь, Серый, Черный" +
                        "\n Счастливый День: Суббота" +
                        "\n Счастливые Числа: 1, 4, 8, 10, 13, 17, 19, 22, 26",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }
            if (switch1.IsToggled == false)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = capricorn,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }


        }
        string sagittarius = "Вы выбрали знак зодиака: Стрелец" +
                        "\n Значение Знака: Кентавр, символизирует сочетание духовности и консерватизма" +
                        "\n Стрелец Даты: 23 Ноября – 21 Декабря" +
                        "\n Тип Знака: Огонь – Мутабельный – Положительный" +
                        "\n Планета Стрельца: Юпитер";
        private void onimg9clicked(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (switch1.IsToggled == true)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = sagittarius +
                        "\n Счастливый Цвет: Фиолетовый, Красный, Розовый" +
                        "\n Счастливый День: Четверг" +
                        "\n Счастливые Числа: 3, 12, 21, 30",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }

            if (switch1.IsToggled == false)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = sagittarius,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }

        }
        string scorpio = "Вы выбрали знак зодиака: Скорпион" +
                "\n Значение Знака: Скорпион - говорит о сильном и раздражительном характере" +
                "\n Скорпион Даты: 24 Октября – 22 Ноября" +
                "\n Тип Знака: Вода – Фиксированный – Отрицательный" +
                "\n Планета Скорпиона: Плутон";
        private void onimg8clicked(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (switch1.IsToggled == true)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = scorpio +
                    "\n Счастливый Цвет: Алый, Красный" +
                    "\n Счастливый День: Вторник" +
                    "\n Счастливые Числа: 9, 18, 27, 36, 45, 54, 63, 72, 81, 90",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }

            if (switch1.IsToggled == false)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = scorpio,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }
        }
        string libra = "Вы выбрали знак зодиака: Весы" +
                        "\n Значение Знака: Уравновешенные весы" +
                        "\n Весы Даты: 23 Сентября – 23 Октября" +
                        "\n Тип Знака: Воздух – Кардинальный – Положительный" +
                        "\n Планета Весов: Венера";
        private void onimg7clicked(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (switch1.IsToggled == true)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = libra +
                        "\n Счастливый Цвет: Синий, Зеленый" +
                        "\n Счастливый День: Пятница" +
                        "\n Счастливые Числа: 6, 15, 24, 33, 42, 51, 60",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }
            if (switch1.IsToggled == false)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = libra,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }


        }
        string virgo = "Вы выбрали знак зодиака: Дева" +
                        "\n Значение Знака: Дева (ангел) с непорочной натурой" +
                        "\n Дева Даты: 24 Августа – 22 Сентября" +
                        "\n Тип Знака: Земля – Мутабельный – Отрицательный" +
                        "\n Планета Девы: Меркурий";
        private void onimg6clicked(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (switch1.IsToggled == true)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = virgo +
                        "\n Счастливый Цвет: Синий, Сине-зеленый, Серый, Черный" +
                        "\n Счастливый День: Воскресенье и Суббота" +
                        "\n Счастливые Числа: 4, 8, 13, 17, 22, 26",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }
            if (switch1.IsToggled == false)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = virgo,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }

        }
        string lion = "Вы выбрали знак зодиака: Лев" +
                    "\n Значение Знака: Гордый лев - царь зверей" +
                    "\n Лев Даты: 23 Июля – 23 Августа" +
                    "\n Тип Знака: Огонь – Фиксированный – Положительный" +
                    "\n Пл  анета Льва: Солнце";
        private void onimg5clicked(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (switch1.IsToggled == false)
            {
                frame.Content = new Label
                {

                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = lion,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))


                };
            }
            if (switch1.IsToggled == true)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = lion +
                "\n Счастливый Цвет: Золотой, Оранжевый, Белый, Красный" +
                "\n Счастливый День: Воскресенье" +
                "\n Счастливые Числа: 1, 4, 10, 13, 19, 22",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))


                };
            }
        }
        string cancer = "Вы выбрали знак зодиака: Рак" +
                    "\n Значение Знака: Рак (краб) - символ попятного движения, консерватизма и традиций, дома и семьи" +
                    "\n Рак Даты: 22 Июня – 22 Июля" +
                    "\n Тип Знака: Вода – Кардинальный – Отрицательный" +
                    "\n Планета Рака: Луна";
        private void onimg4clicked(object sender, EventArgs e)
        {
            //  throw new NotImplementedException();
            if (switch1.IsToggled == true)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = cancer +
                    "\n Счастливый Цвет: Оранжевый, Белый" +
                    "\n Счастливый День: Понедельник, Четверг" +
                    "\n Счастливые Числа: 2, 7, 11, 16, 20, 25",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }
            if (switch1.IsToggled == false)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = cancer,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }

        }
        string twins = "Вы выбрали знак зодиака: Близнецы" +
                  "\n Значение Знака: Двое близнецов или пара влюбленных - указывает на способность к общению" +
                  "\n Близнецы Даты: 22 Мая – 21 Июня" +
                  "\n Тип Знака: Воздух – Мутабельный – Положительный" +
                  "\n Планета Близнецов: Меркурий";
        private void onimg3clicked(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (switch1.IsToggled == true)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = twins +
                        "\n Счастливый Цвет: Оранжевый, Желтый" +
                        "\n Счастливый День: Среда" +
                        "\n Счастливые Числа: 5, 14, 23, 32, 41, 50",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }
            if (switch1.IsToggled == false)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = twins,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }
        }


        string calf = "Вы выбрали знак зодиака: Телец" +
                        "\n Значение Знака: Бык или буйвол - говорит о внутренней силе и выносливости" +
                        "\n Телец Даты: 21 Апреля – 21 Мая" +
                        "\n Тип Знака: Земля – Фиксированный – Отрицательный" +
                        "\n Планета Тельца: Венера";
        private void onimg2clicked(object sender, EventArgs e)
        {
            //  throw new NotImplementedException();

            if (switch1.IsToggled == true)
            {
                frame.Content = new Label
                {

                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = calf +
                        "\n Счастливый Цвет: Синий, Сине-зеленый" +
                        "\n Счастливый День: Пятница, Понедельник" +
                        "\n Счастливые Числа: 6, 15, 24, 33, 42, 51",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }
            if (switch1.IsToggled == false)
            {
                frame.Content = new Label
                {

                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = calf,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }

        }

        string oven = "Вы выбрали знак зодиака: Овен" +
                    "\n Значение Знака: Баран - указывает на дух соперничества" +
                    "\n Овен Даты: 21 Марта – 20 Апреля" +
                    "\n Тип Знака: Огонь – Кардинальный – Положительный" +
                    "\n Планета Овна: Марс";
        private void onimg1clicked(object sender, EventArgs e)
        {
            // throw new NotImplementedException();

            if (switch1.IsToggled == true)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = oven +
                        "\n Счастливый Цвет: Красный" +
                        "\n Счастливый День: Вторник" +
                        "\n Счастливые Числа: 9, 18, 27, 36, 45, 54, 63, 72",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }
            if (switch1.IsToggled == false)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = oven,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                };
            }
        }

        string fish1 = "Вы выбрали знак зодиака: Рыбы" +
               "\n  Рыбы Даты: 19 Февраля – 20 Марта" +
               "\n Тип Знака: Вода – Мутабельный – Отрицательный" +
               "\n Планета Рыб: Нептун";
        private void onimgclicked(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (switch1.IsToggled == true)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = fish1 +

                    "\n Счастливый Цвет: Сиреневый, Лиловый, Пурпурный, Фиолетовый, Морской Зеленый" +
                    "\n Счастливый День: Четверг и Понедельник" +
                    "\n Счастливые Числа: 3, 7, 12, 16, 21, 25, 30, 34, 43, 52",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                };
            }

            if (switch1.IsToggled == false)
            {
                frame.Content = new Label
                {
                    TextColor = Color.Yellow,
                    BackgroundColor = Color.Black,
                    Text = fish1,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                };
            }

        }


    }
}