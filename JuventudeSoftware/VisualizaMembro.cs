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
    public partial class VisualizaMembro : Form
    {
        private Campo c;
        public VisualizaMembro(Campo campo)
        {
            InitializeComponent();
            this.c = campo;
        }

        Campo campo = new Campo();
        Membro executa = new Membro();
        Validacao validar = new Validacao();
        Cota cotas = new Cota();
        Usuario us = new Usuario();
        private void estatistica()
        {
            /*labelTMV.Text = executa.totalMembros().ToString();
            label2.Text = executa.totalAdolescentes().ToString();
            labelJovens.Text = executa.totalJovens().ToString();
            labelHomem.Text = executa.totalHomens().ToString();
            labelMulheres.Text = executa.totalMulheres().ToString();
            labelSolteiro.Text = executa.totalSolteiro().ToString();
            labelCasados.Text = executa.totalCasados().ToString();
            labelDivorviados.Text = executa.totalDivorciado().ToString();
            labelViuvos.Text = executa.totalViuvo().ToString();
            labelBase.Text = executa.totalBase().ToString();
            labelCD.Text = executa.totalCD().ToString();
            labelTD.Text = executa.totalTudizole().ToString();
            labelADO.Text = executa.totalCoral().ToString();
            labelCat.Text = executa.totalCatecumeno().ToString();
            labelEfect.Text = executa.totalEfectivo().ToString();
            labelAp.Text = executa.totalAprova().ToString();
            labelFal.Text = executa.totalEstadoF().ToString();
            labelTC.Text = executa.totalTransferidos().ToString();
            labelNovoM.Text = executa.totalNovosMembros().ToString();*/
        }
        private void VisualizaMembro_Load(object sender, EventArgs e)
        {
            listar_membros();
            colunas();
            //estatistica();
            labelTMV.Text = executa.totalMembros().ToString();
            button10.Enabled = us.nivelDeAcesso(this.c);
            labelUsuario.Text = this.c.user_acesso;
               

        
             
        }
        private void colunas()
        {
            dataGridView1.Columns[0].HeaderText = "Nome";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].HeaderText = "Alcunha";
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].HeaderText = "Telefone 1";
            dataGridView1.Columns[2].Width = 78;
            dataGridView1.Columns[3].HeaderText = "Telefone 2";
            dataGridView1.Columns[3].Width = 78;
            dataGridView1.Columns[4].HeaderText = "Idade";
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].HeaderText = "Sexo";
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].HeaderText = "Bairro";
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].HeaderText = "Rua";
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].HeaderText = "Descrição";
            dataGridView1.Columns[8].Width = 170;
            dataGridView1.Columns[9].HeaderText = "Estado Civil";
            dataGridView1.Columns[9].Width = 80;
            dataGridView1.Columns[10].HeaderText = "Identificação";
            dataGridView1.Columns[10].Width = 85;
            dataGridView1.Columns[11].HeaderText = "Pai";
            dataGridView1.Columns[11].Width = 150;
            dataGridView1.Columns[12].HeaderText = "Mãe";
            dataGridView1.Columns[12].Width = 150;
            dataGridView1.Columns[13].HeaderText = "Email";
            dataGridView1.Columns[13].Width = 100;
            dataGridView1.Columns[14].HeaderText = "Facebook";
            dataGridView1.Columns[14].Width = 100;
            //dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].HeaderText = "Área de formação";
            dataGridView1.Columns[15].Width = 150;
            dataGridView1.Columns[16].HeaderText = "Nível Escolar";
            dataGridView1.Columns[16].Width = 135;
            dataGridView1.Columns[17].HeaderText = "Escola";
            dataGridView1.Columns[17].Width = 100;
            //dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].HeaderText = "Profissão";
            dataGridView1.Columns[18].Width = 100;
            dataGridView1.Columns[19].HeaderText = "Cargo";
            dataGridView1.Columns[19].Width = 165;
            dataGridView1.Columns[20].HeaderText = "Comissão";
            dataGridView1.Columns[20].Width = 170;
            dataGridView1.Columns[21].HeaderText = "Grupo";
            dataGridView1.Columns[21].Width = 120;
            dataGridView1.Columns[22].HeaderText = "Data de nascimento";
            dataGridView1.Columns[22].Width = 150;
            dataGridView1.Columns[23].HeaderText = "Categoria de membro";
            dataGridView1.Columns[23].Width = 150;
            dataGridView1.Columns[24].HeaderText = "Classe";
            dataGridView1.Columns[24].Width = 200;
            dataGridView1.Columns[25].HeaderText = "Data de ingresso";
            dataGridView1.Columns[25].Width = 120;
            dataGridView1.Columns[26].HeaderText = "Como Ingressou";
            dataGridView1.Columns[26].Width = 100;
            dataGridView1.Columns[27].HeaderText = "Presença";
            dataGridView1.Columns[27].Width = 100;
            dataGridView1.Columns[28].HeaderText = "Motivo";
            dataGridView1.Columns[28].Width = 100;
            dataGridView1.Columns[29].HeaderText = "Igreja Anterior";
            dataGridView1.Columns[29].Width = 170;
            dataGridView1.Columns[30].HeaderText = "Função à exercer";
            dataGridView1.Columns[30].Width = 185;
            dataGridView1.Columns[31].HeaderText = "Descrição da organização";
            dataGridView1.Columns[31].Width = 205;
            dataGridView1.Columns[32].HeaderText = "Estado";
            dataGridView1.Columns[32].Width = 50;
            dataGridView1.Columns[33].HeaderText = "Data atual";
            dataGridView1.Columns[33].Width = 150;
            // dataGridView1.Columns[19].Visible = false;


        }
        private void listar_membros()
        {
            dataGridView1.DataSource = executa.mostrar_membros();
        }


        private void comboBoxFase_SelectedIndexChanged(object sender, EventArgs e)
        {
            campo.pesquisaFase = comboBoxFase.Text;
            dataGridView1.DataSource = executa.pesquisarFase(campo);
        }

        private void textPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            campo.pesquisaNome = textPesquisaNome.Text;
            dataGridView1.DataSource = executa.pesquisarNome(campo);
        }

        private void textPesquisaBairro_TextChanged(object sender, EventArgs e)
        {
            campo.pesquisaBairro = textPesquisaBairro.Text;
            dataGridView1.DataSource = executa.pesquisarBairro(campo);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            
            this.c.nome = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.c.alcunha = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.c.telefone1 = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[2].Value.ToString());
            this.c.telefone2 = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[3].Value.ToString());
            this.c.idade = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[4].Value.ToString());
            this.c.sexo = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            this.c.bairro = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            this.c.rua = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            this.c.descricao = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            this.c.estado_civil = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            this.c.bi_cedula = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            this.c.pai = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            this.c.mae = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            this.c.email = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            this.c.facebook = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            this.c.areaFormacao = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
            this.c.nivelEscolar = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            this.c.escola = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            this.c.profissao = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
            this.c.cargo = this.dataGridView1.CurrentRow.Cells[19].Value.ToString();
            this.c.comissao = this.dataGridView1.CurrentRow.Cells[20].Value.ToString();
            this.c.grupo = this.dataGridView1.CurrentRow.Cells[21].Value.ToString();
            this.c.data_nascimento = this.dataGridView1.CurrentRow.Cells[22].Value.ToString();
            this.c.cat_membro = this.dataGridView1.CurrentRow.Cells[23].Value.ToString();
            this.c.classe = this.dataGridView1.CurrentRow.Cells[24].Value.ToString();
            this.c.data_ingresso = this.dataGridView1.CurrentRow.Cells[25].Value.ToString();
            this.c.igrejAnterior = this.dataGridView1.CurrentRow.Cells[26].Value.ToString();
            this.c.opfuncaoFuturo = this.dataGridView1.CurrentRow.Cells[27].Value.ToString();
            this.c.sobreJuventude = this.dataGridView1.CurrentRow.Cells[28].Value.ToString();
            this.c.estado = this.dataGridView1.CurrentRow.Cells[29].Value.ToString();

            new Alterar_Membro(this.c).Show();
            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                campo.nome = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                /*campo.bairro = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                campo.cargo = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
                campo.comissao = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();*/
                executa.apagar_membro(campo);
                listar_membros();
                estatistica();
                MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visualizar_membro visualiza = new Visualizar_membro();
            visualiza.labelNomeR.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            visualiza.labelAlcunhaR.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            visualiza.labelTelefone1R.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            visualiza.labelTelefone2R.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            visualiza.labelIdadeR.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            visualiza.labelSexoR.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            visualiza.labelBairroR.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            visualiza.labelRuaR.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            visualiza.labelDescricaoR.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            visualiza.labelEstadoCR.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            visualiza.labelIdentificacaoR.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            visualiza.labelCargoR.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            visualiza.labelComissaoR.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            visualiza.labelGrupoR.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            visualiza.labelDataNascimentoR.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            visualiza.labelCatMembroR.Text = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
            visualiza.labelClasseR.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            visualiza.pictureBoxFotoR.ImageLocation = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            visualiza.labelDataIngressoR.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
           // visualiza.labelEstadoR.Text = this.dataGridView1.CurrentRow.Cells[19].Value.ToStrC:\Users\Lucy kiassucumuca\Documents\JimubSoft\JuventudeSoftware\Cadastro_user.csing();
            visualiza.ShowDialog();
        }

        private void pagarCotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cotas frm_cotas = new Cotas();
            frm_cotas.labelNomeR.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            campo.nome = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm_cotas.labelCargoR.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frm_cotas.labelClasseR.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            frm_cotas.labelComissaoR.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            cotas.selecionarMeses(campo);
        }

        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelTMV_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Membros mb = new Membros(this.c);
            mb.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Visualizar_membro vm = new Visualizar_membro();
            vm.ShowDialog();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            login.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_sms sms = new form_sms(this.c);
            sms.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Membros membro = new Membros(this.c);
            membro.Show();
        }

        private void labelTC_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelFal_Click(object sender, EventArgs e)
        {

        }

        private void btn_exportarTabela_Click(object sender, EventArgs e)
        {
            Membro dadosEstatistico = new Membro();
           
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

                dadosEstatistico.addOutrosDados(estatistica);

                form_estatistica fm_estatistica = new form_estatistica(dadosEstatistico);
                fm_estatistica.Show();
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelCat_Click(object sender, EventArgs e)
        {

        }

        private void labelADO_Click(object sender, EventArgs e)
        {

        }

        private void btn_exportarTudo_Click(object sender, EventArgs e)
        {
            form_tituloEmTabela form_titulo = new form_tituloEmTabela(dataGridView1, executa, 2);
            form_titulo.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            new Cadastro_user(this.c).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Menu(this.c).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new frm_actividades(this.c).Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            new form_patrimonio(this.c).Show();
        }

        private void labelTM_Click(object sender, EventArgs e)
        {

        }

        private void labelTMV_Click_1(object sender, EventArgs e)
        {

        }
    }
}
