using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Model
{
    public class Contrabaixo : InstrumentoMusical, IPercussao, IHarmonia, IMelodia
    {
               public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo Ritmo como (0)", this.GetType().Name);
            return true;
        }

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