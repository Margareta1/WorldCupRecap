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
    public partial class PlayerControl : UserControl
    {
        public PlayerControl player;
        private Player p = new Player();
        private static RepositoryFactory rf = new RepositoryFactory();
        private static IRepository repo = rf.GiveThisManARepository();
        public PlayerControl(Player player)
        {
            InitializeComponent();
            p = player;
        }

        private void PlayerControl_Load(object sender, EventArgs e)
        {

            if (p.Captain)
            {
                lblCaptain.Text = "Captain";
            }
            lblName.Text = p.Name;
            lblNumber.Text = p.ShirtNumber.ToString();
            lblPosition.Text = p.Position;
            pbPlayer.Image = repo.GetImageForPlayer(p.Name);
            pbPlayer.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {

            if (fileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = repo.GetImage(fileDialogPhoto.FileName);
                    pbPlayer.Image = image;
                    repo.SetImageForPlayer(p.Name, image);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
