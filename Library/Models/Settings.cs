namespace Library.Models
{
    public enum Cup
    {
        Female,
        Male
    }
    public enum Language
    {
        Croatian,
        English
    }
    public class Settings
    {
        public Cup CupChoice { get; set; }
        public Language LanguageChoice { get; set; }
        public Team FavoriteTeam { get; set; }
        public IList<Player> FavoritePlayers { get; set; }

    }

}

