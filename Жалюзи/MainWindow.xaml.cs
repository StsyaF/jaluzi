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

namespace Жалюзи
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cb.Items.Add("Пластик");
            cb.Items.Add("Аллюминий");
        }

        //Константы цен на пластик и аллюминий 
        int pl = 50;
        int al = 100; 
        //***********************


        int menu = 0;
        int razmer;
        int pr;
        int st; 
        int v;
        int ch; 


        private void btnVvod_Click(object sender, RoutedEventArgs e)
        {
            v = Convert.ToInt32(txtV.Text);
           ch = Convert.ToInt32(txtCh.Text);

            if (menu == 0)
            {
               

                if (lb.SelectedIndex == 0)
                {
                    pr = pl; 
                }
                if (lb.SelectedIndex == 1)
                {
                    pr = al;
                }
                
            }

            else
            {

                if (cb.SelectedIndex == 0)
                {
                    pr = pl;
                }
                if (cb.SelectedIndex == 1)
                {
                    pr = al;
                }


            }

            lblpr.Content = Convert.ToString(pr);
            razmer = ch * v;
            lblRazmer.Content = Convert.ToString(v) + " см. х " + Convert.ToString(ch) + " см.";

            st = pr * razmer;
            lblSt.Content = Convert.ToString(st);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            menu = 0;

            cb.Visibility = Visibility.Hidden;
            lb.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            menu = 1;

            cb.Visibility = Visibility.Visible;
            lb.Visibility = Visibility.Hidden;
        }
    }
}
