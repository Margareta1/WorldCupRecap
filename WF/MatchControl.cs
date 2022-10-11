using Library.Models;

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
