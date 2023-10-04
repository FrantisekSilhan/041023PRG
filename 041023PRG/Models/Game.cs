namespace _041023PRG.Models
{
    internal class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Development> Developments { get; set; }
    }
}
