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
    public partial class MatchControl : UserControl
    {
        private Match match = new Match();
        public MatchControl(Match m)
        {
            InitializeComponent();
            match = m;
        }

        private void MatchControl_Load(object sender, EventArgs e)
        {
            lblLocation.Text = match.Location;
            lblAttendance.Text = match.Attendance.ToString();
            lblAwayTeam.Text = match.AwayTeam.Code;
            lblHomeTeam.Text = match.HomeTeam.Code;


        }
    }
}
