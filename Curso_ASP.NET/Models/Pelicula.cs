﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Curso_ASP.NET.Models
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public DateTime Publicacion { get; set; }
        public string Pais { get; set; }
    }
}