using System;

namespace Heroes.Api.Contracts.Models
{
    public class HeroItem
    {
        public string Name { get; set; }
        public string[] Powers { get; set; }
        public bool HasCape { get; set; }
        public DateTime Created { get; set; }
        public bool IsAlive { get; set; }
        public Category Category { get; set; }
    }

    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string[] Powers { get; set; }
        public bool HasCape { get; set; }
        public DateTime Created { get; set; }
        public bool IsAlive { get; set; }
        public Category Category { get; set; }
    }

    public enum Category
    {
        Anime,
        Comic,
        History,
        Mythology
    }
}