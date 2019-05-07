using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Model
{
    public class Tambores : InstrumentoMusical, IPercussao
    {
                public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo Ritmo como (0)", this.GetType().Name);
            return true;
        }
    }
}