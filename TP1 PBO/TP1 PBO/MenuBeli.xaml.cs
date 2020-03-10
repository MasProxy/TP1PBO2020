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
    /// Interaction logic for MenuBeli.xaml
    /// </summary>
    public partial class MenuBeli : UserControl
    {
        Barang[] kbarang = new Barang[5];
        public MenuBeli()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            /*Proses inisialisasi array of object*/
            kbarang[0] = new Barang();
            kbarang[0].NamaBarang = "O Dango";
            kbarang[0].Jenis = "Makanan";
            kbarang[0].Harga = 10000;
            kbarang[0].Id = 1;

            kbarang[1] = new Barang();
            kbarang[1].NamaBarang = "Ya Hoodie Black";
            kbarang[1].Jenis = "Baju";
            kbarang[1].Harga = 250000;
            kbarang[1].Id = 2;

            kbarang[2] = new Barang();
            kbarang[2].NamaBarang = "Playstation 4";
            kbarang[2].Jenis = "Elektronik";
            kbarang[2].Harga = 4000000;
            kbarang[2].Id = 3;

            kbarang[3] = new Barang();
            kbarang[3].NamaBarang = "Green Beans Soup";
            kbarang[3].Jenis = "Makanan";
            kbarang[3].Harga = 15000;
            kbarang[3].Id = 4;

            kbarang[4] = new Barang();
            kbarang[4].NamaBarang = "Nintendo Switch";
            kbarang[4].Jenis = "Elektronik";
            kbarang[4].Harga = 35000000;
            kbarang[4].Id = 5;

            

            int i = 0;
            //String test = "coeg";

            /*
            for (i=0;i<5;i++){
                
                System.Windows.Controls.Label lb = new Label();
                System.Windows.Controls.Button btn = new Button();
                System.Windows.Controls.Image img = new Image();
                System.Windows.Controls.StackPanel sp = new StackPanel();
                btn.Name = "Btn" + i.ToString();
                btn.Content = "Beli";
                btn.Width = 100;
                btn.Height = 20;
                sp.Margin = new Thickness(10, 0, 0, 10);
                lb.Name = "Label" + i.ToString();
                lb.Content= kbarang[i].NamaBarang;
                
                img.Name = "Img" + i.ToString();
                img.Width = 100;
                img.Height = 100;
                Uri alamat = new Uri((i+1).ToString()+".jpg", UriKind.Relative);
                img.Source = new BitmapImage(alamat);
                sp.Children.Add(img);
                sp.Children.Add(lb);
                sp.Children.Add(btn);

                WP.Children.Add(sp);
            }*/
            
            foreach (var item in kbarang)//proses foreach barang
            {
                /*Membuat elemen secara dinamis*/
                System.Windows.Controls.Label lb = new Label();
                System.Windows.Controls.Button btn = new Button();
                System.Windows.Controls.Image img = new Image();
                System.Windows.Controls.StackPanel sp = new StackPanel();
                btn.Name = "Btn" + i.ToString();
                btn.Content = "Beli";
                btn.Width = 100;
                btn.Height = 20;

                sp.Margin = new Thickness(10, 0, 0, 10);
                lb.Name = "Label" + i.ToString();
                lb.Content = kbarang[i].NamaBarang;

                //proses meload gambar sesuai dengan indeks
                img.Name = "Img" + i.ToString();
                img.Width = 100;
                img.Height = 100;
                Uri alamat = new Uri((i + 1).ToString() + ".jpg", UriKind.Relative);
                img.Source = new BitmapImage(alamat);

                /*Pemasangan elemen yang sudah dibuat kedalam panel*/
                sp.Children.Add(img);
                sp.Children.Add(lb);
                sp.Children.Add(btn);

                WP.Children.Add(sp);
                i++;
            }

        }

        private void btn_Cari_Click(object sender, RoutedEventArgs e)
        {
            String Jenis = CBJenis.Text;
            int min = 0;
            int max = 0;
            if (CB_Harga.Text == "100rb-200rb")
            {
                min = 100000;
                max = 200000;
            }
            if (CB_Harga.Text=="200rb-500rb") {
                min = 200000;
                max = 500000;
            }
            if (CB_Harga.Text == "500rb-1jt")
            {
                min = 500000;
                max = 1000000;
            }

            int i = 0;

            foreach (var item in kbarang)
            {
                System.Windows.Controls.Label lb = new Label();
                System.Windows.Controls.Button btn = new Button();
                System.Windows.Controls.Image img = new Image();
                System.Windows.Controls.StackPanel sp = new StackPanel();
                btn.Name = "Btn" + i.ToString();
                btn.Content = "Beli";
                btn.Width = 100;
                btn.Height = 20;
                sp.Margin = new Thickness(10, 0, 0, 10);
                lb.Name = "Label" + i.ToString();
                lb.Content = kbarang[i].NamaBarang;

                img.Name = "Img" + i.ToString();
                img.Width = 100;
                img.Height = 100;
                Uri alamat = new Uri((i + 1).ToString() + ".jpg", UriKind.Relative);
                img.Source = new BitmapImage(alamat);
                sp.Children.Add(img);
                sp.Children.Add(lb);
                sp.Children.Add(btn);

                WP.Children.Add(sp);
                i++;
            }
        }
    }
}
