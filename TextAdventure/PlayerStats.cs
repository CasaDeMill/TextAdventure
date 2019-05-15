namespace TextAdventure
{
    public class PlayerStats
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Item[] Items { get; set; }
        public PlayerStats(string name, int health, Item[] items)
        {
            Name = name;
            Health = health;
            Items = items;
        }
    }
}