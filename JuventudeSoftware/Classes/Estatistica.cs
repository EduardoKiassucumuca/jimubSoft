using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes
{
    public class Estatistica
    {
        public String nome { get; set; }
        public String alcunha { get; set; }
        public int telefone1 { get; set; }
        public int telefone2 { get; set; }
        public int idade { get; set; }
        public String bairro { get; set; }
        public String estado_civil { get; set; }
        public String cargo { get; set; }
        public String comissao { get; set; }
        public String grupo { get; set; }
        public String categoria_membro { get; set; }
        public String classe { get; set; }
        public String data_ingresso { get; set; }
        public String igreja_anterior { get; set; }
        public String estado { get; set; }

        public int qtdJovensMascVindoClasseInfantil { get; set; }
        public int qtdJovensFemVindoClasseInfantil { get; set; }
        public int qtdJovensVindoClasseInfantil { get; set; }
        public int qtdJovensMascEvangelizados { get; set; }
        public int qtdJovensFemEvangelizados { get; set; }
        public int qtdJovensEvangelizados { get; set; }
        public int qtdJovensMascVoluntariamente { get; set; }
        public int qtdJovensFemVoluntariamente { get; set; }
        public int qtdJovensVoluntariamente { get; set; }
        public int qtdJovensMascEncaminhadoOja { get; set; }
        public int qtdJovensFemcEncaminhadoOja { get; set; }
        public int qtdJovensEncaminhadoOja { get; set; }
        public int qtdJovensMascTransferidos { get; set; }
        public int qtdJovensFemTransferidos { get; set; }
        public int qtdJovensTransferidos { get; set; }
        public int qtdJovensMascafastaram { get; set; }
        public int qtdJovensFemAfastaram { get; set; }
        public int qtdJovensAfastaram { get; set; }
        public int qtdJovensMascFalecidos { get; set; }
        public int qtdJovensFemFalecidos { get; set; }
        public int qtdJovensFalecidos { get; set; }
        public int qtdJovensMascAusenteEscola { get; set; }
        public int qtdJovensFemAusenteEscola { get; set; }
        public int qtdJovensAusenteEscola { get; set; }
        public int qtdJovensMascAusenteSaude { get; set; }
        public int qtdJovensFemAusenteSaude { get; set; }
        public int qtdJovensAusenteSaude { get; set; }
        public int qtdJovensMascAusenteDisciplinares { get; set; }
        public int qtdJovensFemAusenteDisciplinares { get; set; }
        public int qtdJovensAusenteDisciplinares { get; set; }
        public int qtdJovensMascAusenteDesconhecidas { get; set; }
        public int qtdJovensFemAusenteDesconhecidas { get; set; }
        public int qtdJovensAusenteDesconhecidas { get; set; }
        public int qtdJovensMasc { get; set; }
        public int qtdJovensFem { get; set; }
        public int qtdJovens { get; set; }
        public int qtdAdolescentesMasc { get; set; }
        public int qtdAdolescentesFem { get; set; }
        public int qtdAdolescentes { get; set; }
        public int qtdAdolescentesEjovens { get; set; }
        public int qtdCatecumenoMasc { get; set; }
        public int qtdCatecumenoFem { get; set; }
        public int qtdCatecumeno { get; set; }
        public int qtdAprovaMasc { get; set; }
        public int qtdAprovaFem { get; set; }
        public int qtdAprova { get; set; }
        public int qtdEfectivoMasc { get; set; }
        public int qtdEfectivoFem { get; set; }
        public int qtdEfectivo { get; set; }
        public int qtdCategoriaMembro { get; set; }
        public int qtdJovensMascEnsinoPrimario { get; set; }
        public int qtdJovensFemEnsinoPrimario { get; set; }
        public int qtdJovensEnsinoPrimario { get; set; }
        public int qtdJovensMascEnsinoSecundario { get; set; }
        public int qtdJovensFemEnsinoSecundario { get; set; }
        public int qtdJovensEnsinoSecundario { get; set; }
        public int qtdJovensMascEnsinoMedio { get; set; }
        public int qtdJovensFemEnsinoMedio { get; set; }
        public int qtdJovensEnsinoMedio { get; set; }
        public int qtdJovensMascEnsinoSuperior { get; set; }
        public int qtdJovensFemEnsinoSuperior { get; set; }
        public int qtdJovensEnsinoSuperior { get; set; }
        public int qtdJovensMascLicenciados { get; set; }
        public int qtdJovensFemLicenciados { get; set; }
        public int qtdJovensLicenciados { get; set; }
        public int qtdJovensGrauEscolaridade { get; set; }
        public int qtdJovensMascFuncionario { get; set; }
        public int qtdJovensFemFuncionario { get; set; }
        public int qtdJovensFuncionario { get; set; }
        public int qtdJovensRamoEducacao { get; set; }
        public int qtdJovensMascRamoEducacao { get; set; }
        public int qtdJovensFemRamoEducacao { get; set; }
        public int qtdJovensMascRamoSaude { get; set; }
        public int qtdJovensFemRamoSaude { get; set; }
        public int qtdJovensRamoSaude { get; set; }
        public int qtdJovensRamoMilitar { get; set; }
        public int qtdJovensMascRamoMilitar { get; set; }
        public int qtdJovensFemRamoMilitar { get; set; }
        public int qtdJovensRamoReligioso { get; set; }
        public int qtdJovensMascRamoReligioso { get; set; }
        public int qtdJovensFemRamoReligioso { get; set; }
        public int qtdJovensRamoComercio { get; set; }
        public int qtdJovensMascRamoComercio { get; set; }
        public int qtdJovensFemRamoComercio { get; set; }
        public int qtdJovensMascSomenteEstudantes { get; set; }
        public int qtdJovensFemSomenteEstudantes { get; set; }
        public int qtdJovensSomenteEstudantes { get; set; }
        public int qtdJovensOcupacional { get; set; }
        public int totalMembroMascReal { get; set; }
        public int totalMembroFemReal { get; set; }
        public int totalMembroReal { get; set; }
        public int totalMembroMascFisico { get; set; }
        public int totalMembroFemFisico { get; set; }
        public int totalMembroFisico { get; set; }

        public int qtdMembro { get; set; }
        public int qtdJovensMascSolteiro { get; set; }
        public int qtdJovensFemSolteiro { get; set; }
        public int qtdJovensSolteiro { get; set; }
        public int qtdJovensMascCasado { get; set; }
        public int qtdJovensFemCasado { get; set; }
        public int qtdJovensCasado { get; set; }
        public int qtdJovensCasadoESolteiro { get; set; }
        public int qtdHomem { get; set; }
        public int qtdMulher { get; set; }
        public int qtdSolteiro { get; set; }
        public int qtdCasado { get; set; }
        public int qtdViuvo { get; set; }
        public int qtdDivorciado { get; set; }
        public int qtdMembroBase { get; set; }
        public int qtdMembroCD { get; set; }
        public int qtdTudizole { get; set; }
        public int qtdCoralAdolescente{ get; set; }
        public int qtdPreAdolescente { get; set; }
      
        public int qtdNovoMembro { get; set; }
        public int qtdFalecido { get; set; }
        public String titulo { get; set; }
    }
}
