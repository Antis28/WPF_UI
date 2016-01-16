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

namespace Lesson1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click( object sender, RoutedEventArgs e )
        {
            string login = "Antis";
            string pass = "149";

            if( loginField.Text == login && passField.Text == pass )
            {
                MessageBox.Show( "Поздравляяю логин и пароль верен!!!" );
            } else if( loginField.Text == login && passField.Text != pass )
            {
                MessageBox.Show( "Возможно не верен пароль, попробуйте еще раз." );
            } else
            {
                MessageBox.Show( "Кажется я вас не знаю, вы точно правильно ввели логин?" );
            }
        }
    }
}
