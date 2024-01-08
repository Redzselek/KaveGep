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
using System.Threading;
using System.Media;

namespace KaveGep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool ot = false;
        bool tiz = false;
        bool husz = false;
        bool otven = false;
        bool szaz = false;
        bool ketszaz = false;
        int berakottpenz = 0;

        public MainWindow()
        {
            InitializeComponent();
            kvkep.Opacity = 0;
        }

        private void Gomb1_Click(object sender, RoutedEventArgs e)
        {
            
            if (berakottpenz > 120)
            {
                Fizetendo.Text = Convert.ToString(berakottpenz - 120);
                SoundPlayer player = new SoundPlayer(@"sound/kvhang.wav");
                player.Load();
                player.Play();
                Thread.Sleep(10000);
                kvkep.Opacity = 100;
                Visszaad();
            }
        }

        private void Gomb2_Click(object sender, RoutedEventArgs e)
        {
            Fizetendo.Text = Convert.ToString(berakottpenz - 220);
            SoundPlayer player = new SoundPlayer(@"sound/kvhang.wav");
            player.Load();
            player.Play();
            Thread.Sleep(10000);
            kvkep.Opacity = 100;
            Visszaad();
        }

        private void Gomb3_Click(object sender, RoutedEventArgs e)
        {
            Fizetendo.Text = Convert.ToString(berakottpenz - 100);
            SoundPlayer player = new SoundPlayer(@"sound/kvhang.wav");
            player.Load();
            player.Play();
            Thread.Sleep(10000);
            kvkep.Opacity = 100;
            Visszaad();
        }

        private void Gomb4_Click(object sender, RoutedEventArgs e)
        {
            Fizetendo.Text = Convert.ToString(berakottpenz - 155);
            SoundPlayer player = new SoundPlayer(@"sound/kvhang.wav");
            player.Load();
            player.Play();
            Thread.Sleep(10000);
            kvkep.Opacity = 100;
            Visszaad();
        }

        private void PenzNyilas_Click(object sender, RoutedEventArgs e)
        {
            if (ot)
            {
                berakottpenz += 5;
                SoundPlayer player = new SoundPlayer(@"sound/coin.wav");
                player.Load();
                player.Play();
            }
            else if (tiz)
            {
                berakottpenz += 10;
                SoundPlayer player = new SoundPlayer(@"sound/coin.wav");
                player.Load();
                player.Play();
            }
            else if (husz)
            {
                berakottpenz += 20;
                SoundPlayer player = new SoundPlayer(@"sound/coin.wav");
                player.Load();
                player.Play();
            }
            else if (otven)
            {
                berakottpenz += 50;
                SoundPlayer player = new SoundPlayer(@"sound/coin.wav");
                player.Load();
                player.Play();
            }
            else if (szaz)
            {
                berakottpenz += 100;
                SoundPlayer player = new SoundPlayer(@"sound/coin.wav");
                player.Load();
                player.Play();
            }
            else if (ketszaz)
            {
                berakottpenz += 200;
                SoundPlayer player = new SoundPlayer(@"sound/coin.wav");
                player.Load();
                player.Play();
            }
            else
            {
                return;
            }
            Fizetendo.Text = Convert.ToString(berakottpenz);
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Fizetendo.Text = "";
        }

        private void _5ft_Click(object sender, RoutedEventArgs e)
        {
            ot = true;
            tiz = false;
            husz = false;
            otven = false;
            szaz = false;
            ketszaz = false;
        }

        private void _10ft_Click(object sender, RoutedEventArgs e)
        {
            ot = false;
            tiz = true;
            husz = false;
            otven = false;
            szaz = false;
            ketszaz = false;
        }

        private void _20ft_Click(object sender, RoutedEventArgs e)
        {
            ot = false;
            tiz = false;
            husz = true;
            otven = false;
            szaz = false;
            ketszaz = false;
        }

        private void _50ft_Click(object sender, RoutedEventArgs e)
        {
            ot = false;
            tiz = false;
            husz = false;
            otven = true;
            szaz = false;
            ketszaz = false;
        }

        private void _100ft_Click(object sender, RoutedEventArgs e)
        {
            ot = false;
            tiz = false;
            husz = false;
            otven = false;
            szaz = true;
            ketszaz = false;
        }

        private void _200ft_Click(object sender, RoutedEventArgs e)
        {
            ot = false;
            tiz = false;
            husz = false;
            otven = false;
            szaz = false;
            ketszaz = true;
        }

        private void kvkep_MouseUp(object sender, MouseButtonEventArgs e)
        {
            kvkep.Opacity = 0;
        }
        public void Visszaad()
        {
            do
            {

            } while (Convert.ToInt32(Fizetendo.Text) != 0);
        }
    }
}
