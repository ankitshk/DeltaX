using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaX.Core.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public int ActorId { get; set; }
        public int ProducerId { get; set; }
        public string Name { get; set; }
        public string YearOfRelease { get; set; }
        public string Plot { get; set; }
        public string Image { get; set; }
        public virtual ICollection<MoviesActors> MoviesActors { get; set; }
        public virtual  Producer Producers { get; set; }
    }
}
