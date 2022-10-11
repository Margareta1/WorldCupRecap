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

    
    public partial class ChangeLanguageForm : Form
    {
        private static RepositoryFactory rf = new RepositoryFactory();
        private static IRepository repo = rf.GiveThisManARepository();

        public ChangeLanguageForm()
        {
            InitializeComponent();
            
        }

        private void ChangeLanguageForm_Load(object sender, EventArgs e)
        {
            InitLabel();
        }

        private void InitLabel()
        {
            var settings = repo.GetSettings();
            if (settings.LanguageChoice==Language.English)
            {
                lblSwitch.Text = "Switch to HR?";
            }
            else
            {
                lblSwitch.Text = "Switch to EN?";
            }

            
        }
    }
}
