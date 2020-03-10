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

namespace TP1_PBO
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MenuBeli kmenubeli = new MenuBeli();
            frame.Content = kmenubeli;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //untuk kembali ke menu login
            this.Hide();
            MainWindow login = new MainWindow();
            login.Show();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            frame.Content=null;//menghapus konten di frame
            frame.NavigationService.RemoveBackEntry();//menghapus history frame
            //memanggil menubeli
            MenuBeli kmenubeli = new MenuBeli();
            frame.Content = kmenubeli;//dimasukan ke dalam frame
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tokopedia.com/masproxy?source=universe&st=product");//untuk membuka link dari button menu katalog
        }
    }
}
