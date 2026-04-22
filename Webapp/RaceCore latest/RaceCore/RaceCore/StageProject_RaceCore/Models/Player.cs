namespace StageProject_RaceCore.Models
{
    public class Player
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public ICollection<PlayerSelection> Selections { get; set; } = new List<PlayerSelection>();
        public ICollection<DraftTurn> DraftTurns { get; set; } = new List<DraftTurn>();
        public ICollection<PlayerPoints> PlayerPoints { get; set; } = new List<PlayerPoints>();
    }
}