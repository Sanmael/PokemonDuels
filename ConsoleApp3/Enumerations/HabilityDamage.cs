using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Enumerations
{
    public enum FireSkillDamage
    {
        BolaDeFogo = 10,
        LancaChamas = 20,
        CaudaDeFogo = 30,
        ExplosaoDeFogo = 40,
        ChamaFulgurante = 50,
        CorrenteDeFogo = 60
    }

    public enum PlantSkillDamage
    {
        ChicoteDeTrepadeira = 10,
        SementeSangueSuga = 20,
        RaizForte = 30,
        FloresSono = 40,
        FolhaNavalha = 50,
        PóDeSono= 60
    }

    public enum EarthSkillDamage
    {
        Terremoto = 10,
        Avalanche = 20,
        LamaToxica = 30,
        PedraAfunda = 40,
        MuroDePedra = 50,
        SoproDeAreia =60
    }

    public enum WaterSkillDamage
    {
        JatoDagua = 10,
        HidroBomba = 20,
        Mergulho = 30,
        RaioAurora = 40,
        Cascata = 50,
        TornadoDeAgua= 60
    }
}
