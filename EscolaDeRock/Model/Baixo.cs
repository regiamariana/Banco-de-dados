using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Model
{
    public class Baixo : InstrumentoMusical, IPercussao, IHarmonia
    {

        public bool TocarAcordes(){
            System.Console.WriteLine("Tocando acorde como (0)", this.GetType().Name);
            return true;
        }

        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo Ritmo como (0)", this.GetType().Name);
            return true;
        }

        public void FazerTumDum(){}
    }
}