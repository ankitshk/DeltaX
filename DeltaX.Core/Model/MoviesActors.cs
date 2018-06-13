using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaX.Core.Model
{
    public class MoviesActors
    {
        public int ActorId { get; set; }
        public Actor Actors { get; set; }

        public int MovieId { get; set; }
        public Movie Movies { get; set; }


    }
}
