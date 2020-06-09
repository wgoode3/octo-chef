using System.Collections.Generic;

namespace OctoChef.Models
{
    public class Recipe
    {
        public string Title { get; set; }
        public List<string> Ingredients { get; set; }
        public string Instructions { get; set; }

    }
}