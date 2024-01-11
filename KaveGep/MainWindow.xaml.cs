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
            kvkep.Visibility = Visibility.Hidden;
        }

        private async void Gomb1_Click(object sender, RoutedEventArgs e)
        {

            if (berakottpenz >= 120 && !kvkep.IsVisible)
            {
                berakottpenz -= 120;
                Fizetendo.Text = Convert.ToString(berakottpenz);
                Visszaad();
                SoundPlayer player = new SoundPlayer(@"sound/kvhang.wav");
                player.Load();
                player.Play();
                await Task.Delay(10000);
                kvkep.Visibility = Visibility.Visible;
            }
            else if (kvkep.IsVisible)
            {
                MessageBox.Show("Van még kitöltött kávé a gépben", "Hiba");
            }
            else
            {
                MessageBox.Show("Nincs elég pénzed, tegyél be még többet", "Hiba");
            }
        }
        
        private async void Gomb2_Click(object sender, RoutedEventArgs e)
        {
            if (berakottpenz >= 220 && !kvkep.IsVisible)
            {   
                berakottpenz -= 220;
                Fizetendo.Text = Convert.ToString(berakottpenz);
                SoundPlayer player = new SoundPlayer(@"sound/kvhang.wav");
                player.Load();
                player.Play();
                await Task.Delay(10000);
                kvkep.Visibility = Visibility.Visible;
                Visszaad();
            }
            else if (kvkep.IsVisible)
            {
                MessageBox.Show("Van még kitöltött kávé a gépben", "Hiba");
            }
            else
            {
                MessageBox.Show("Nincs elég pénzed, tegyél be még többet", "Hiba");
            }
        }

        private async void Gomb3_Click(object sender, RoutedEventArgs e)
        {
            if (berakottpenz >= 100 && !kvkep.IsVisible)
            {
                berakottpenz -= 100;
                Fizetendo.Text = Convert.ToString(berakottpenz);
                SoundPlayer player = new SoundPlayer(@"sound/kvhang.wav");
                player.Load();
                player.Play();
                await Task.Delay(10000);
                kvkep.Visibility = Visibility.Visible;
                Visszaad();
            }
            else if (kvkep.IsVisible)
            {
                MessageBox.Show("Van még kitöltött kávé a gépben", "Hiba");
            }
            else
            {
                MessageBox.Show("Nincs elég pénzed, tegyél be még többet", "Hiba");
            }
        }

        private async void Gomb4_Click(object sender, RoutedEventArgs e)
        {
            if (berakottpenz >= 155 && !kvkep.IsVisible)
            {   
                berakottpenz -= 155; 
                Fizetendo.Text = Convert.ToString(berakottpenz);
                SoundPlayer player = new SoundPlayer(@"sound/kvhang.wav");
                player.Load();
                player.Play();
                await Task.Delay(10000);
                kvkep.Visibility = Visibility.Visible;
                Visszaad();
            }
            else if (kvkep.IsVisible)
            {
                MessageBox.Show("Van még kitöltött kávé a gépben", "Hiba");
            }
            else
            {
                MessageBox.Show("Nincs elég pénzed, tegyél be még többet", "Hiba");
            }
        }

        private void PenzNyilas_Click(object sender, RoutedEventArgs e)
        {
            if (ot)
            {
                berakottpenz += 5;
                Fizetendo.Text = Convert.ToString(berakottpenz);
                SoundPlayer player = new SoundPlayer(@"sound/coin.wav");
                player.Load();
                player.Play();
            }
            else if (tiz)
            {
                berakottpenz += 10;
                Fizetendo.Text = Convert.ToString(berakottpenz);
                SoundPlayer player = new SoundPlayer(@"sound/coin.wav");
                player.Load();
                player.Play();
            }
            else if (husz)
            {
                berakottpenz += 20;
                Fizetendo.Text = Convert.ToString(berakottpenz);
                SoundPlayer player = new SoundPlayer(@"sound/coin.wav");
                player.Load();
                player.Play();
            }
            else if (otven)
            {
                berakottpenz += 50;
                Fizetendo.Text = Convert.ToString(berakottpenz);
                SoundPlayer player = new SoundPlayer(@"sound/coin.wav");
                player.Load();
                player.Play();
            }
            else if (szaz)
            {
                berakottpenz += 100;
                Fizetendo.Text = Convert.ToString(berakottpenz);
                SoundPlayer player = new SoundPlayer(@"sound/coin.wav");
                player.Load();
                player.Play();
            }
            else if (ketszaz)
            {
                berakottpenz += 200;
                Fizetendo.Text = Convert.ToString(berakottpenz);
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
            Visszaad();
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
        public async void Visszaad()
        {
            while (berakottpenz != 0)
            {
                if (!((berakottpenz - 200) <= 0))
                {
                    berakottpenz -= 200;
                    Fizetendo.Text = Convert.ToString(berakottpenz);
                    await Task.Delay(250);
                }
                else if (!((berakottpenz - 100) <= 0))
                {
                    berakottpenz -= 100;
                    Fizetendo.Text = Convert.ToString(berakottpenz);
                    await Task.Delay(250);
                }
                else if (!((berakottpenz - 50) <= 0))
                {
                    berakottpenz -= 50;
                    Fizetendo.Text = Convert.ToString(berakottpenz);
                    await Task.Delay(250);
                }
                else if (!((berakottpenz - 20) <= 0))
                {
                    berakottpenz -= 20;
                    Fizetendo.Text = Convert.ToString(berakottpenz);
                    await Task.Delay(250);
                }
                else if (!((berakottpenz - 10) <= 0))
                {
                    berakottpenz -= 10;
                    Fizetendo.Text = Convert.ToString(berakottpenz);
                    await Task.Delay(250);
                }
                else if (!((berakottpenz - 5) <= 0) || berakottpenz == 5)
                {
                    berakottpenz -= 5;
                    Fizetendo.Text = Convert.ToString(berakottpenz);
                    await Task.Delay(250);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
