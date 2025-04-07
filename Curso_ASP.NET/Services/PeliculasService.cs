using Curso_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Curso_ASP.NET.Scripts
{
    public class PeliculasService
    {
        public Pelicula ObternerPelicula()
        {
            return new Pelicula()
            {
                Titulo = "Octavio el Dev",
                Duracion = 120,
                Pais = "Chile",
                Publicacion = DateTime.Now
            };

        
        }
        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Octavio el Dev",
                Duracion = 120,
                Pais = "Chile",
                Publicacion = DateTime.Now
            };
            var pelicula2 = new Pelicula()
            {
                Titulo = "Octavio el Dev 2",
                Duracion = 120,
                Pais = "Chile",
                Publicacion = DateTime.Now
            };
            var pelicula3 = new Pelicula()
            {
                Titulo = "Octavio el Dev 3",
                Duracion = 120,
                Pais = "Chile",
                Publicacion = DateTime.Now
            };
            return new List<Pelicula>
            {
                pelicula1,
                pelicula2,
                pelicula3
            };
        }
    }
}