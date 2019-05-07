using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Model
{
    public class Violão : InstrumentoMusical, IMelodia, IHarmonia
    {
       public bool TocarAcordes(){
            System.Console.WriteLine("Tocando acorde como (0)", this.GetType().Name);
            return true;
        }
        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo como (0)", this.GetType().Name);
            return true;
        }
    }
}