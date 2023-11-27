using System;
using System.Collections.Generic;
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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Class1
        {
            public string Cost { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public Class1( string Name, string Cost, string Description)
            {
                this.Cost = Cost;
                this.Name = Name;
                this.Description = Description;

            }
        }

        public MainWindow()
        {
            List<Class1> ser = new List<Class1>();

            InitializeComponent();
            lv_Service.ItemsSource = ser;
            ser.Add(new Class1("Рекламный баннер от топ-дизайнера", "130000 рублей", "Мастер в создании рекламных баннеров косметики, продуктовых магазинов"));
            ser.Add(new Class1("Рекламный баннер от милого дизайнера", "100000 рублей", "Мастер по баннерам зоопарков"));
            ser.Add(new Class1("Рекламный баннер от стажёра", "5000 рублей", "Берёт дёшево, делает качественно"));
            ser.Add(new Class1("Рекламный баннер от прохожего", "1000 рублей", "Баннер-сюрприз"));
        }

        private void btn_Order_Click(object sender, RoutedEventArgs e)
        {
            var i = lv_Service.SelectedItem;
            if (i != null)
            {
                MessageBox.Show("Вы записаны на услугу!");
            }
        }
    }
}