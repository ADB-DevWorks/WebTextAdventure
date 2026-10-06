namespace WebTextAdventure.Models.Entities
{
    public class Character
    {

        public string? Name { get; private set; }

        // Character stats
        public int HitPoints { get; private set; }
        public Job job { get; private set; }

        public Character(string name, Job job)
        {
            Name = name;
            
        }

        
    }
}
