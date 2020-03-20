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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Window
    {
        public Catalog()
        {
            InitializeComponent();
        }
        private void Singin_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SingIn w1 = new SingIn();
            w1.Show();
        }

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow w1 = new MainWindow();
            w1.Show();
        }

        private void TopButtton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BestProduct w1 = new BestProduct();
            w1.Show();
        }

        private void CatalogButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Catalog w1 = new Catalog();
            w1.Show();
        }

        private void FavoriteButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Favorite w1 = new Favorite();
            w1.Show();
        }

        private void BasketButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ShoppingBasket w1 = new ShoppingBasket();
            w1.Show();
        }
    }
}
