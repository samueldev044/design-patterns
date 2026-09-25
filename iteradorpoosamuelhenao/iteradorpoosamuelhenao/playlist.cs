using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace iteradorpoosamuelhenao
{
    public class Playlist : IEnumerable<Cancion>
    {
        private readonly List<Cancion> _canciones = new();

        public void AgregarCancion(Cancion cancion)
        {
            _canciones.Add(cancion);
        }

       
        public IEnumerator<Cancion> GetEnumerator()
        {
            foreach (var cancion in _canciones)
            {
                yield return cancion;
            }
        }

 
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
