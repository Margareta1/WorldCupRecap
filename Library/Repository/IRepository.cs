namespace Library.Repository
{
    using Library.Models;
    using System.Drawing;

    public interface IRepository
    {
        public IList<Team> GetWomensTeams();
        public IList<Team> GetMensTeams();
        public IList<TeamResult> GetResultsForTeam(int idTeam, Cup cup);
        public IList<GroupResult> GetResultsForGroup(int idGroup, Cup cup);
        public void SetSettings(Settings s);
        public Settings GetSettings();
        public Image GetImageForPlayer(string playerName);
        public void SetImageForPlayer(string playerName, Image image);
        public IList<Match> GetMatches(Cup cup);
        bool HasSettings();
        Image GetImage(string imgPath);
        public IList<Player> GetPlayersForTeam(Cup cup, int id);

    }
}
