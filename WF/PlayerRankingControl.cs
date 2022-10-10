using Library.Models;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class PlayerRankingControl : UserControl
    {
        public PlayerRankingControl player;
        private Player p = new Player();
        private static RepositoryFactory rf = new RepositoryFactory();
        private static IRepository repo = rf.GiveThisManARepository();
        public PlayerRankingControl(Player player)
        {
            InitializeComponent();
            p = player;
        }

        private void PlayerRankingControl_Load(object sender, EventArgs e)
        {

            pbPlayer.Image = repo.GetImageForPlayer(p.Name);
            pbPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            lblName.Text = p.Name;
            lblGoalsNum.Text = p.GoalNumber.ToString();
            lblYCNumber.Text = p.YellowCardNumber.ToString();
        }
    }
}
