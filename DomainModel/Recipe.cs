using System;
using System.Collections;
using System.Collections.Generic;

namespace DomainModel
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LiteDescription { get; set; }
        public string CourseOfAction { get; set; }
        public string FinalWords { get; set; }
        public ICollection<Ingredient> Type { get; set; }
    }
}
