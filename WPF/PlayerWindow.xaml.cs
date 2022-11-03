using Library.Models;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF
{

    public partial class PlayerWindow : Window
    {
        private static Player player = new Player();
        private static Match match = new Match();
        private static IRepository repo = RepositoryFactory.GiveThisManARepository();
        private const string IMAGES_DIR = @"C:\Users\38597\Desktop\dotnet\Library\Images\";

        public PlayerWindow(Player p, Match m)
        {
            player = p;
            match = m;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitLabels();
        }

        private void InitLabels()
        {
            System.Drawing.Image img = repo.GetImageForPlayer(player.Name);
            Bitmap bitmap = new Bitmap(img);
            imgPlayer.Background = CreateBrushFromBitmap(bitmap);
            lbPlayerCaptain.Content = player.Captain ? "yes" : "no";
            lbPlayerName.Content = player.Name;
            lbPlayerNumber.Content = player.ShirtNumber;
            lbPlayerPosition.Content = player.Position;
            lbPlayerYC.Content = FindYCNumber();
            lbPlayerGoals.Content = FindGoalNumber();
        }

        private int FindGoalNumber()
        {
            int goals = 0;
            foreach (TeamEvent e in match.HomeTeamEvents)
            {
                if (e.Player == player.Name)
                {
                    if (e.TypeOfEvent == "goal" || e.TypeOfEvent == "goal-penalty")
                    {
                        goals++;
                    }

                }
            }
            foreach (TeamEvent e in match.AwayTeamEvents)
            {
                if (e.Player == player.Name)
                {
                    if (e.TypeOfEvent == "goal" || e.TypeOfEvent == "goal-penalty")
                    {
                        goals++;
                    }

                }
            }
            return goals;
        }


        private int FindYCNumber()
        {

            int yellowCards = 0;
            foreach (TeamEvent e in match.HomeTeamEvents)
            {
                if (e.Player == player.Name)
                {

                    if (e.TypeOfEvent == "yellow-card")
                    {
                        yellowCards++;
                    }
                }
            }
            foreach (TeamEvent e in match.AwayTeamEvents)
            {
                if (e.Player == player.Name)
                {

                    if (e.TypeOfEvent == "yellow-card")
                    {
                        yellowCards++;
                    }
                }
            }
            return yellowCards;
        }

        private System.Windows.Media.Brush CreateBrushFromBitmap(Bitmap bitmap)
        {
            BitmapSource bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(
                bitmap.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            return new ImageBrush(bitmapSource);
        }
    }
}
