using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1
{
    public partial class form_tituloEmTabela : Form
    {
        DataGridView tabela;
        Membro dadosEstatistico;
        int btn;
        public form_tituloEmTabela(DataGridView tabela, int btn)
        {
            InitializeComponent();
            this.tabela = tabela;
            this.btn = btn;
        }
        public form_tituloEmTabela(DataGridView tabela, Membro dadosEstatistico, int btn)
        {
            InitializeComponent();
            this.tabela = tabela;
            this.dadosEstatistico = dadosEstatistico;
            this.btn = btn;
        }
        private void exportarTabela(DataGridView datagridview)
        {
            Membro membro = new Membro();

            foreach (DataGridViewRow linha in datagridview.Rows)
            {

                RelatorioMembro dados = new RelatorioMembro()
                {

                    nome = linha.Cells[0].Value.ToString(),
                    alcunha = linha.Cells[1].Value.ToString(),
                    telefone1 = Convert.ToInt32(linha.Cells[2].Value.ToString()),
                    telefone2 = Convert.ToInt32(linha.Cells[3].Value.ToString()),
                    idade = Convert.ToInt32(linha.Cells[4].Value.ToString()),
                    bairro = linha.Cells[6].Value.ToString(),
                    rua = linha.Cells[7].Value.ToString(),
                    descricao_casa = linha.Cells[8].Value.ToString(),
                    facebook = linha.Cells[14].Value.ToString(),
                    titulo = textBox1.Text

            };

             
                membro.addDados(dados);

            }
           
            this.Close();
            new form_relatorioMembro(membro).Show();

        }
        private void exportarEstatistica(DataGridView datagridview,Membro dadosEstatistico)
        {
            Membro membro = new Membro();

            foreach (DataGridViewRow linha in datagridview.Rows)
            {
                Estatistica estatistica = new Estatistica()
                {
                    qtdJovensVindoClasseInfantil = dadosEstatistico.totaljovensVindosDaClasseInfantil(),
                    qtdJovensMascVindoClasseInfantil = dadosEstatistico.totaljovensMascVindosDaClasseInfantil(),
                    qtdJovensFemVindoClasseInfantil = dadosEstatistico.totaljovensFemVindosDaClasseInfantil(),
                    qtdJovensEvangelizados = dadosEstatistico.totaljovensEvangelizado(),
                    qtdJovensMascEvangelizados = dadosEstatistico.totaljovensMascEvangelizado(),
                    qtdJovensFemEvangelizados = dadosEstatistico.totaljovensFemEvangelizado(),
                    qtdJovensVoluntariamente = dadosEstatistico.totaljovensVindoVoluntariamente(),
                    qtdJovensMascVoluntariamente = dadosEstatistico.totaljovensMascVindoVoluntariamente(),
                    qtdJovensFemVoluntariamente = dadosEstatistico.totaljovensFemVindoVoluntariamente(),
                    qtdJovensEncaminhadoOja = dadosEstatistico.totaljovensEncaminhadoOja(),
                    qtdJovensMascEncaminhadoOja = dadosEstatistico.totaljovensMascEncaminhadoOja(),
                    qtdJovensFemcEncaminhadoOja = dadosEstatistico.totaljovensFemEncaminhadoOja(),
                    qtdJovensAfastaram = dadosEstatistico.totaljovensAfastaram(),
                    qtdJovensMascafastaram = dadosEstatistico.totaljovensMascAfastaram(),
                    qtdJovensFemAfastaram = dadosEstatistico.totaljovensFemAfastaram(),
                    qtdJovensFalecidos = dadosEstatistico.totaljovensFalecidos(),
                    qtdJovensMascFalecidos = dadosEstatistico.totaljovensMascFalecidos(),
                    qtdJovensFemFalecidos = dadosEstatistico.totaljovensFemFalecidos(),
                    totalMembroMascReal = dadosEstatistico.totalMembrosMascReal(),
                    totalMembroFemReal = dadosEstatistico.totalMembrosFemReal(),
                    totalMembroReal = dadosEstatistico.totalMembrosMascReal(),
                    qtdJovensAusenteEscola = dadosEstatistico.totaljovensAusentesRazaoTrabalho(),
                    qtdJovensMascAusenteEscola = dadosEstatistico.totaljovensMascAusentesRazaoTrabalho(),
                    qtdJovensFemAusenteEscola = dadosEstatistico.totaljovensFemAusentesRazaoTrabalho(),
                    qtdJovensMascAusenteSaude = dadosEstatistico.totaljovensMascAusentesRazaoSaude(),
                    qtdJovensFemAusenteSaude = dadosEstatistico.totaljovensFemAusentesRazaoSaude(),
                    qtdJovensAusenteSaude = dadosEstatistico.totaljovensAusentesRazaoSaude(),
                    qtdJovensMascAusenteDisciplinares = dadosEstatistico.totaljovensMascAusentesRazaoDisciplinares(),
                    qtdJovensAusenteDesconhecidas = dadosEstatistico.totaljovensAusentesRazaoDesconhecidas(),
                    qtdJovensMascAusenteDesconhecidas = dadosEstatistico.totaljovensMascAusentesRazaoDesconhecidas(),
                    qtdJovensFemAusenteDesconhecidas = dadosEstatistico.totaljovensFemAusentesRazaoDesconhecidas(),
                    totalMembroFisico = dadosEstatistico.totalMembrosFisico(),
                    totalMembroFemFisico = dadosEstatistico.totalMembrosFemFisico(),
                    totalMembroMascFisico = dadosEstatistico.totalMembrosMascFisico(),
                    qtdJovens = dadosEstatistico.totalJovens(),
                    qtdJovensMasc = dadosEstatistico.totalJovensMasc(),
                    qtdJovensFem = dadosEstatistico.totalJovensFem(),
                    qtdAdolescentes = dadosEstatistico.totalAdolescentes(),
                    qtdAdolescentesFem = dadosEstatistico.totalAdolescentesFem(),
                    qtdAdolescentesMasc = dadosEstatistico.totalAdolescentesMasc(),
                    qtdAdolescentesEjovens = dadosEstatistico.totalJovensEAdolescentes(),
                    qtdCatecumenoMasc = dadosEstatistico.totalJovensCatecumenoMasc(),
                    qtdCatecumenoFem = dadosEstatistico.totalJovensCatecumenoFem(),
                    qtdCatecumeno = dadosEstatistico.totalJovensCatecumeno(),
                    qtdAprova = dadosEstatistico.totalJovensAprova(),
                    qtdAprovaFem = dadosEstatistico.totalJovensAprovaFem(),
                    qtdAprovaMasc = dadosEstatistico.totalJovensAprovaMasc(),
                    qtdEfectivo = dadosEstatistico.totalJovensEfectivo(),
                    qtdEfectivoFem = dadosEstatistico.totalJovensEfectivoFem(),
                    qtdEfectivoMasc = dadosEstatistico.totalJovensEfectivoMasc(),
                    qtdCategoriaMembro = dadosEstatistico.totalJovensCategoria_membros(),
                    qtdJovensEnsinoPrimario = dadosEstatistico.totalJovensEnsinoPrimario(),
                    qtdJovensMascEnsinoPrimario = dadosEstatistico.totalJovensMascEnsinoPrimario(),
                    qtdJovensFemEnsinoPrimario = dadosEstatistico.totalJovensFemEnsinoPrimario(),
                    qtdJovensEnsinoSecundario = dadosEstatistico.totalJovensEnsinoSecundario(),
                    qtdJovensMascEnsinoSecundario = dadosEstatistico.totalJovensMascEnsinoSecundario(),
                    qtdJovensFemEnsinoSecundario = dadosEstatistico.totalJovensFemEnsinoSecundario(),
                    qtdJovensEnsinoMedio = dadosEstatistico.totalJovensEnsinoMedio(),
                    qtdJovensMascEnsinoMedio = dadosEstatistico.totalJovensMascEnsinoMedio(),
                    qtdJovensFemEnsinoMedio = dadosEstatistico.totalJovensFemEnsinoMedio(),
                    qtdJovensEnsinoSuperior = dadosEstatistico.totalJovensEnsinoSuperior(),
                    qtdJovensFemEnsinoSuperior = dadosEstatistico.totalJovensFemEnsinoSuperior(),
                    qtdJovensMascEnsinoSuperior = dadosEstatistico.totalJovensMascEnsinoSuperior(),
                    qtdJovensLicenciados = dadosEstatistico.totalJovensLicenciatura(),
                    qtdJovensMascLicenciados = dadosEstatistico.totalJovensMascLicenciatura(),
                    qtdJovensFemLicenciados = dadosEstatistico.totalJovensFemLicenciatura(),
                    qtdJovensGrauEscolaridade = dadosEstatistico.totalJovensGrauEscolaridade(),
                    qtdJovensMascFuncionario = dadosEstatistico.totalJovensMascFuncionario(),
                    qtdJovensFemFuncionario = dadosEstatistico.totalJovensFemFuncionario(),
                    qtdJovensFuncionario = dadosEstatistico.totalJovensFuncionario(),
                    qtdJovensRamoEducacao = dadosEstatistico.totalJovensRamoEducacao(),
                    qtdJovensMascRamoEducacao = dadosEstatistico.totalJovensMascEducacao(),
                    qtdJovensFemRamoEducacao = dadosEstatistico.totalJovensFemEducacao(),
                    qtdJovensRamoSaude = dadosEstatistico.totalJovensRamoSaude(),
                    qtdJovensMascRamoSaude = dadosEstatistico.totalJovensMascRamoSaude(),
                    qtdJovensFemRamoSaude = dadosEstatistico.totalJovensFemRamoSaude(),
                    qtdJovensFemRamoMilitar = dadosEstatistico.totalJovensFemServicoMilitar(),
                    qtdJovensMascRamoMilitar = dadosEstatistico.totalJovensMascServicoMilitar(),
                    qtdJovensRamoMilitar = dadosEstatistico.totalJovensServicoMilitar(),
                    qtdJovensFemRamoReligioso = dadosEstatistico.totalJovensFemServicoReligioso(),
                    qtdJovensMascRamoReligioso = dadosEstatistico.totalJovensMascServicoReligioso(),
                    qtdJovensRamoReligioso = dadosEstatistico.totalJovensServicoReligioso(),
                    qtdJovensFemRamoComercio = dadosEstatistico.totalJovensFemRamoComercio(),
                    qtdJovensMascRamoComercio = dadosEstatistico.totalJovensMascRamoComercio(),
                    qtdJovensRamoComercio = dadosEstatistico.totalJovensRamoComercio(),
                    qtdJovensSomenteEstudantes = dadosEstatistico.totalJovenSomenteEstudante(),
                    qtdJovensMascSomenteEstudantes = dadosEstatistico.totalJovensMascSomenteEstudante(),
                    qtdJovensFemSomenteEstudantes = dadosEstatistico.totalJovensFemEstudante(),
                    qtdJovensOcupacional = dadosEstatistico.totalJovensOcupacional(),
                    qtdJovensCasado = dadosEstatistico.totalCasados(),
                    qtdJovensMascCasado = dadosEstatistico.totalMascCasado(),
                    qtdJovensFemCasado  = dadosEstatistico.totalFemCasada(),
                    qtdJovensSolteiro = dadosEstatistico.totalSolteiro(),
                    qtdJovensMascSolteiro = dadosEstatistico.totalMascSolteiro(),
                    qtdJovensFemSolteiro = dadosEstatistico.totalFemSolteiro(),
                    qtdJovensCasadoESolteiro = dadosEstatistico.totalCasadosEsolteiros()
                };

                membro.addOutrosDados(estatistica);
            }
            new form_estatistica(membro).Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            this.Close();

            if (this.btn == 1)
            {
                
                exportarEstatistica(this.tabela, this.dadosEstatistico);

            }
            else if(this.btn == 2)
            {
               // exportarTudo(this.tabela, this.dadosEstatistico);
            }
        }

        private void form_tituloEmTabela_Load(object sender, EventArgs e)
        {

        }
    }
}
