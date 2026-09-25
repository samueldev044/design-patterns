using iteradorpoosamuelhenao;

class Program
{
    static void Main()
    {
        
        Playlist miMixtape = new Playlist();
        miMixtape.AgregarCancion(new Cancion("Bohemian Rhapsody", "Queen"));
        miMixtape.AgregarCancion(new Cancion("Hotel California", "Eagles"));
        miMixtape.AgregarCancion(new Cancion("De Música Ligera", "Soda Stereo"));

       
        Console.WriteLine("--- Mis Canciones ---");
        foreach (Cancion cancion in miMixtape)
        {
            Console.WriteLine($"Título: {cancion.Titulo} | Artista: {cancion.Artista}");
        }
    }
}

