﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaX.Core.Model
{
    public class Actor 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string DOB { get; set; }
        public string Bio { get; set; }
        public virtual ICollection<Movie> Movie { get; set; }

    }
}