using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Enumerations
{
    public enum PokemonType
    {
        Fire = 0,
        Water = 1,
        Rock = 2,
        Plant = 3
    }
    public enum FireSkill
    {
        BolaDeFogo = 0,
        LancaChamas = 1,
        CaudaDeFogo = 2,
        ExplosaoDeFogo = 3,
        ChamaFulgurante = 4,
        CorrenteDeFogo = 5
    }

    public enum PlantSkill
    {
        ChicoteDeTrepadeira = 0,
        SementeSangueSuga = 1,
        RaizForte = 2,
        FloresSono = 3,
        FolhaNavalha = 4,
        PóDeSono = 5
    }

    public enum EarthSkill
    {
        Terremoto = 0,
        Avalanche = 1,
        LamaToxica = 2,
        PedraAfunda = 3,
        MuroDePedra = 4,
        SoproDeAreia = 5
    }

    public enum WaterSkill
    {
        JatoDagua = 0,
        HidroBomba = 1,
        Mergulho = 2,
        RaioAurora = 3,
        Cascata = 4,
        TornadoDeAgua = 5
    }
}
