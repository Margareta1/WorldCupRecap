using Library.Models;
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
    public partial class EntryForm : Form
    {
        private Settings settings = new Settings();
        public EntryForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnEN.Checked)
            {
                settings.LanguageChoice = Language.English;
            }
            else
            {
                settings.LanguageChoice = Language.Croatian;
            }

            if (btnWomen.Checked)
            {
                settings.CupChoice = Cup.Female;
            }
            else
            {
                settings.CupChoice = Cup.Male;
            }
            this.Hide();
            (new ChooseFavoriteTeamForm(settings)).Show();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
