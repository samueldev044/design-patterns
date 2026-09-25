using System;
using System.Collections.Generic;
using System.Text;

namespace iteradorpoosamuelhenao
{
    public class Cancion
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }

        public Cancion(string titulo, string artista)
        {
            Titulo = titulo;
            Artista = artista;
        }
    }
}
