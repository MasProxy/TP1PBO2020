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

namespace TP1_PBO
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

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            //pengecekan akun
            if ((text_Password.Password.ToString()=="pbo123"))
            {
                Window1 Menubeli = new Window1();
                Menubeli.Show();
                this.Close();
            }
            else {//apabila akun salah
                MessageBox.Show("Maaf Akun Anda Tidak Valid");
            }
        }
    }
}
