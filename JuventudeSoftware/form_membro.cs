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
    public partial class Membros : Form
    {
        private Campo c,campo;
        
        public Membros(Campo ca)
        {
            InitializeComponent();
            this.c = ca;
            campo = this.c;
        }

       
        Membro executa = new Membro();
        Validacao validar = new Validacao();
        Cota cotas = new Cota();
        Usuario us = new Usuario();
        private void textBI_TextChanged(object sender, EventArgs e)
        {
        }

    

    

   

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void colunas()
        {/*
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
            dataGridView1.Columns[11].HeaderText = "Cargo";
            dataGridView1.Columns[11].Width = 100;
            dataGridView1.Columns[12].HeaderText = "Comissão";
            dataGridView1.Columns[12].Width = 100;
            dataGridView1.Columns[13].HeaderText = "Grupo";
            dataGridView1.Columns[13].Width = 100;
            dataGridView1.Columns[14].HeaderText = "Data De Nascimento";
            dataGridView1.Columns[14].Width = 100;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].HeaderText = "Categoria De Membro";
            dataGridView1.Columns[15].Width = 150;
            dataGridView1.Columns[16].HeaderText = "Classe";
            dataGridView1.Columns[16].Width = 100;
            dataGridView1.Columns[17].HeaderText = "Imagem";
            dataGridView1.Columns[17].Width = 100;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].HeaderText = "Data de emissão na juventude";
            dataGridView1.Columns[18].Width = 175;
            dataGridView1.Columns[19].HeaderText = "Estado";
            dataGridView1.Columns[19].Width = 65;
            dataGridView1.Columns[20].HeaderText = "Data Atual";
            dataGridView1.Columns[20].Width = 120;*/
           
           // dataGridView1.Columns[19].Visible = false;
            

        }
        private void listar_membros()
        {
            //dataGridView1.DataSource = executa.mostrar_membros();
        }

        private void colocarDeVolta()
        {
            textNome.Text = "Nome";
            textBairro.Text = "Bairro";
            textRua.Text = "Rua";
            textPhone1.Text = "920000000";
            textPhone2.Text = "990000000";
            textBI.Text = "BI/cedula";
            textDescricao.Text = "Descrição ou numero da casa";
            comboBoxCat.Text = "Categoria de membro";
            comboBoxClasse.Text = "Classes";
            dateTimePicker1.Value = DateTime.Now.Date;
            dateTimePicker2.Value = DateTime.Now.Date;
            comboBoxSexo.Text = "Sexo";
            textEmail.Text = "Email";
            textFace.Text = "Facebook";
            textNEscolar.Text = "Nível Escolar";
            textEscola.Text = "Escola";
            textArFormacao.Text = "Área de formação";
            textProfi.Text = "Profissão";
            textPai.Text = "Pai";
            textMae.Text = "Mae";
            comboBoxE_civil.Text = "Estado Civil";
            comboBoxGrupo.Text = "Grupo";
            comboBoxestado.Text = "Estado";
            comboBoxCargo.Text = "Cargo";
            comboBoxComissao.Text = "Comissão";
            comboBoxIdent.Text = "Identificação";
            textAlcunha.Text = "Alcunha";
            textIgrejaAnt.Text = "Igreja Anterior";
            textFuncaoIgreja.Text = "Deseja exercer alguma função na igreja?qual?";
            richTextOpiniao.Text = "O que achas da organização?";
            //labelExito.Text = " ";
            pictureBoxFoto.Image = WindowsFormsApplication1.Properties.Resources.images;
        }
       



        private void textAlcunha_TextChanged(object sender, EventArgs e)
        {

        }
        private void textAlcunha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar.verificaTexto(e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Membros_Load(object sender, EventArgs e)
        {
            button11.Enabled = us.nivelDeAcesso(this.c);
            button12.Enabled = us.nivelDeAcesso(this.c);
            listar_membros();
            colunas();
            labelUsuario.Text = this.c.user_acesso;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* campo.pesquisaFase = comboBoxFase.Text;
            dataGridView1.DataSource = executa.pesquisarFase(campo);*/
        }

        private void textPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            /*campo.pesquisaNome = textPesquisaNome.Text;
            dataGridView1.DataSource = executa.pesquisarNome(campo);*/
        }

        private void textPesquisaBairro_TextChanged(object sender, EventArgs e)
        {
           /* campo.pesquisaBairro = textPesquisaBairro.Text;
            dataGridView1.DataSource = executa.pesquisarBairro(campo);*/
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* this.Visible = false;
         
            Alterar_Membro alteraMembro = new Alterar_Membro();
            alteraMembro.textNome.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
          
            alteraMembro.textAlcunha.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            alteraMembro.textPhone1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            alteraMembro.textPhone2.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            alteraMembro.comboBoxSexo.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            alteraMembro.textBairro.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            alteraMembro.textRua.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            alteraMembro.textDescricao.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            alteraMembro.comboBoxE_civil.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            alteraMembro.textBI.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            alteraMembro.comboBoxCargo.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            alteraMembro.comboBoxComissao.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            alteraMembro.comboBoxGrupo.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            alteraMembro.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            alteraMembro.comboBoxCat.Text = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
            alteraMembro.comboBoxClasse.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            alteraMembro.pictureBoxFoto.ImageLocation = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            alteraMembro.dateTimePicker2.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
            alteraMembro.comboBoxestado.Text = this.dataGridView1.CurrentRow.Cells[19].Value.ToString();
          
            alteraMembro.ShowDialog();*/
        }

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            /*if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
            campo.nome = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            campo.bairro = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            campo.cargo = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            campo.comissao = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            executa.apagar_membro(campo);
            listar_membros();
            MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
           

        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            
            Visualizar_membro visualiza = new Visualizar_membro();
            visualiza.labelNomeR.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            visualiza.labelAlcunhaR.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            visualiza.labelTelefone1R.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            visualiza.labelTelefone2R.Text= this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
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
            visualiza.labelEstadoR.Text = this.dataGridView1.CurrentRow.Cells[19].Value.ToString();
            visualiza.ShowDialog();*/
        }

        private void pagarCotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            this.Visible = false;
            Cotas frm_cotas = new Cotas();
            frm_cotas.labelNomeR.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            campo.nome = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm_cotas.labelCargoR.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frm_cotas.labelClasseR.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            frm_cotas.labelComissaoR.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            cotas.selecionarMeses(campo);
          
            if (cotas.meses[0] == "Janeiro" && cotas.meses[1] == "Fevereiro" && cotas.meses[2] == "Março" && cotas.meses[3] == "Abril" && cotas.meses[4] == "Maio" && cotas.meses[5] == "Junho" && cotas.meses[6] == "Julho" && cotas.meses[7] == "Agosto" && cotas.meses[8] == "Setembro" && cotas.meses[9] == "Octubro" && cotas.meses[10] == "Novembro" &&cotas.meses[11] == "Dezembro")
            {
                frm_cotas.checkBoxJan.Enabled = false;
                frm_cotas.pictureBoxJan.Visible = true;
                frm_cotas.checkBoxFev.Enabled = false;
                frm_cotas.pictureBoxFev.Visible = true;
                frm_cotas.checkBoxMa.Enabled = false;
                frm_cotas.pictureBoxMa.Visible = true;
                frm_cotas.checkBoxAbr.Enabled = false;
                frm_cotas.pictureBoxAbr.Visible = true;
                frm_cotas.checkBoxMai.Enabled = false;
                frm_cotas.pictureBoxMai.Visible = true;
                frm_cotas.checkBoxJun.Enabled = false;
                frm_cotas.pictureBoxJun.Visible = true;
                frm_cotas.checkBoxJulh.Enabled = false;
                frm_cotas.pictureBoxJulh.Visible = true;
                frm_cotas.checkBoxAgo.Enabled = false;
                frm_cotas.pictureBoxAgo.Visible = true;
                frm_cotas.checkBoxSet.Enabled = false;
                frm_cotas.pictureBoxSet.Visible = true;
                frm_cotas.checkBoxOct.Enabled = false;
                frm_cotas.pictureBoxOct.Visible = true;
                frm_cotas.checkBoxNov.Enabled = false;
                frm_cotas.pictureBoxNov.Visible = true;
                frm_cotas.checkBoxDez.Enabled = false;
                frm_cotas.pictureBoxDez.Visible = true;
            }
            else if (cotas.meses[0] == "Janeiro"&&cotas.meses[1] == "Fevereiro" && cotas.meses[2] == "Março" && cotas.meses[3] == "Abril" && cotas.meses[4] == "Maio" && cotas.meses[5] == "Junho" && cotas.meses[6] == "Julho" && cotas.meses[7] == "Agosto" && cotas.meses[8] == "Setembro" && cotas.meses[9] == "Octubro" && cotas.meses[10] == "Novembro")
            {
                frm_cotas.checkBoxJan.Enabled = false;
                frm_cotas.pictureBoxJan.Visible = true;
                frm_cotas.checkBoxFev.Enabled = false;
                frm_cotas.pictureBoxFev.Visible = true;
                frm_cotas.checkBoxMa.Enabled = false;
                frm_cotas.pictureBoxMa.Visible = true;
                frm_cotas.checkBoxAbr.Enabled = false;
                frm_cotas.pictureBoxAbr.Visible = true;
                frm_cotas.checkBoxMai.Enabled = false;
                frm_cotas.pictureBoxMai.Visible = true;
                frm_cotas.checkBoxJun.Enabled = false;
                frm_cotas.pictureBoxJun.Visible = true;
                frm_cotas.checkBoxJulh.Enabled = false;
                frm_cotas.pictureBoxJulh.Visible = true;
                frm_cotas.checkBoxAgo.Enabled = false;
                frm_cotas.pictureBoxAgo.Visible = true;
                frm_cotas.checkBoxSet.Enabled = false;
                frm_cotas.pictureBoxSet.Visible = true;
                frm_cotas.checkBoxOct.Enabled = false;
                frm_cotas.pictureBoxOct.Visible = true;
                frm_cotas.checkBoxNov.Enabled = false;
                frm_cotas.pictureBoxNov.Visible = true;
                frm_cotas.checkBoxDez.Enabled = true;
            }
            else if (cotas.meses[0] == "Janeiro" && cotas.meses[1] == "Fevereiro" && cotas.meses[2] == "Março" && cotas.meses[3] == "Abril" && cotas.meses[4] == "Maio" && cotas.meses[5] == "Junho" && cotas.meses[6] == "Julho" && cotas.meses[7] == "Agosto" && cotas.meses[8] == "Setembro" && cotas.meses[9] == "Octubro" )
            {
                frm_cotas.checkBoxJan.Enabled = false;
                frm_cotas.pictureBoxJan.Visible = true;
                frm_cotas.checkBoxFev.Enabled = false;
                frm_cotas.pictureBoxFev.Visible = true;
                frm_cotas.checkBoxMa.Enabled = false;
                frm_cotas.pictureBoxMa.Visible = true;
                frm_cotas.checkBoxAbr.Enabled = false;
                frm_cotas.pictureBoxAbr.Visible = true;
                frm_cotas.checkBoxMai.Enabled = false;
                frm_cotas.pictureBoxMai.Visible = true;
                frm_cotas.checkBoxJun.Enabled = false;
                frm_cotas.pictureBoxJun.Visible = true;
                frm_cotas.checkBoxJun.Enabled = false;
                frm_cotas.pictureBoxJulh.Visible = true;
                frm_cotas.checkBoxAgo.Enabled = false;
                frm_cotas.pictureBoxAgo.Visible = true;
                frm_cotas.checkBoxSet.Enabled = false;
                frm_cotas.pictureBoxSet.Visible = true;
                frm_cotas.checkBoxOct.Enabled = false;
                frm_cotas.pictureBoxOct.Visible = true;
                frm_cotas.checkBoxNov.Enabled = true;
                frm_cotas.checkBoxDez.Enabled = false;
               
                
            }
          
            else if (cotas.meses[0] == "Janeiro" && cotas.meses[1] == "Fevereiro" && cotas.meses[2] == "Março" && cotas.meses[3] == "Abril" && cotas.meses[4] == "Maio" && cotas.meses[5] == "Junho" && cotas.meses[6] == "Julho" && cotas.meses[7] == "Agosto" && cotas.meses[8] == "Setembro")
            {
                frm_cotas.checkBoxJan.Enabled = false;
                frm_cotas.pictureBoxJan.Visible = true;
                frm_cotas.checkBoxFev.Enabled = false;
                frm_cotas.pictureBoxFev.Visible = true;
                frm_cotas.checkBoxMa.Enabled = false;
                frm_cotas.pictureBoxMa.Visible = true;
                frm_cotas.checkBoxAbr.Enabled = false;
                frm_cotas.pictureBoxAbr.Visible = true;
                frm_cotas.checkBoxMai.Enabled = false;
                frm_cotas.pictureBoxMai.Visible = true;
                frm_cotas.checkBoxJun.Enabled = false;
                frm_cotas.pictureBoxJun.Visible = true;
                frm_cotas.checkBoxJulh.Enabled = false;
                frm_cotas.pictureBoxJulh.Visible = true;
                frm_cotas.checkBoxAgo.Enabled = false;
                frm_cotas.pictureBoxAgo.Visible = true;
                frm_cotas.checkBoxSet.Enabled = false;
                frm_cotas.pictureBoxSet.Visible = true;
                frm_cotas.checkBoxOct.Enabled = false;
                frm_cotas.checkBoxNov.Enabled = false;
                frm_cotas.checkBoxDez.Enabled = false;
            
              
            }
            else if (cotas.meses[0] == "Janeiro" && cotas.meses[1] == "Fevereiro" && cotas.meses[2] == "Março" && cotas.meses[3] == "Abril" && cotas.meses[4] == "Maio" && cotas.meses[5] == "Junho" && cotas.meses[6] == "Julho" && cotas.meses[7] == "Agosto")
            {
                frm_cotas.checkBoxJan.Enabled = false;
                frm_cotas.pictureBoxJan.Visible = true;
                frm_cotas.checkBoxFev.Enabled = false;
                frm_cotas.pictureBoxFev.Visible = true;
                frm_cotas.checkBoxMa.Enabled = false;
                frm_cotas.pictureBoxMa.Visible = true;
                frm_cotas.checkBoxAbr.Enabled = false;
                frm_cotas.pictureBoxAbr.Visible = true;
                frm_cotas.checkBoxMai.Enabled = false;
                frm_cotas.pictureBoxMai.Visible = true;
                frm_cotas.checkBoxJun.Enabled = false;
                frm_cotas.pictureBoxJun.Visible = true;
                frm_cotas.checkBoxJulh.Enabled = false;
                frm_cotas.pictureBoxJulh.Visible = true;
                frm_cotas.checkBoxAgo.Enabled = false;
                frm_cotas.pictureBoxAgo.Visible = true;
                frm_cotas.checkBoxSet.Enabled = true;
                frm_cotas.checkBoxOct.Enabled = false;
                frm_cotas.checkBoxNov.Enabled = false;
                frm_cotas.checkBoxDez.Enabled = false;
               
               
            }
            else if (cotas.meses[0] == "Janeiro" && cotas.meses[1] == "Fevereiro" && cotas.meses[2] == "Março" && cotas.meses[3] == "Abril" && cotas.meses[4] == "Maio" && cotas.meses[5] == "Junho" && cotas.meses[6] == "Julho")
            {
                frm_cotas.checkBoxJan.Enabled = false;
                frm_cotas.pictureBoxJan.Visible = true;
                frm_cotas.checkBoxFev.Enabled = false;
                frm_cotas.pictureBoxFev.Visible = true;
                frm_cotas.checkBoxMa.Enabled = false;
                frm_cotas.pictureBoxMa.Visible = true;
                frm_cotas.checkBoxAbr.Enabled = false;
                frm_cotas.pictureBoxAbr.Visible = true;
                frm_cotas.checkBoxMai.Enabled = false;
                frm_cotas.pictureBoxMai.Visible = true;
                frm_cotas.checkBoxJun.Enabled = false;
                frm_cotas.pictureBoxJun.Visible = true;
                frm_cotas.checkBoxJulh.Enabled = false;
                frm_cotas.pictureBoxJulh.Visible = true;
                frm_cotas.checkBoxAgo.Enabled = true;
                frm_cotas.checkBoxSet.Enabled = false;
                frm_cotas.checkBoxOct.Enabled = false;
                frm_cotas.checkBoxNov.Enabled = false;
                frm_cotas.checkBoxDez.Enabled = false;
                
            }
            else if (cotas.meses[0] == "Janeiro" && cotas.meses[1] == "Fevereiro" && cotas.meses[2] == "Março" && cotas.meses[3] == "Abril" && cotas.meses[4] == "Maio" && cotas.meses[5] == "Junho")
            {
                frm_cotas.checkBoxJan.Enabled = false;
                frm_cotas.pictureBoxJan.Visible = true;
                frm_cotas.checkBoxFev.Enabled = false;
                frm_cotas.pictureBoxFev.Visible = true;
                frm_cotas.checkBoxMa.Enabled = false;
                frm_cotas.pictureBoxMa.Visible = true;
                frm_cotas.checkBoxAbr.Enabled = false;
                frm_cotas.pictureBoxAbr.Visible = true;
                frm_cotas.checkBoxMai.Enabled = false;
                frm_cotas.pictureBoxMai.Visible = true;
                frm_cotas.checkBoxJun.Enabled = false;
                frm_cotas.pictureBoxJun.Visible = true;
                frm_cotas.checkBoxJulh.Enabled = true;
                frm_cotas.checkBoxAgo.Enabled = false;
                frm_cotas.checkBoxSet.Enabled = false;
                frm_cotas.checkBoxOct.Enabled = false;
                frm_cotas.checkBoxNov.Enabled = false;
                frm_cotas.checkBoxDez.Enabled = false;
               
               
                
            }
            else if (cotas.meses[0] == "Janeiro" && cotas.meses[1] == "Fevereiro" && cotas.meses[2] == "Março" && cotas.meses[3] == "Abril" && cotas.meses[4] == "Maio")
            {
                frm_cotas.checkBoxJan.Enabled = false;
                frm_cotas.pictureBoxJan.Visible = true;
                frm_cotas.checkBoxFev.Enabled = false;
                frm_cotas.pictureBoxFev.Visible = true;
                frm_cotas.checkBoxMa.Enabled = false;
                frm_cotas.pictureBoxMa.Visible = true;
                frm_cotas.checkBoxAbr.Enabled = false;
                frm_cotas.pictureBoxAbr.Visible = true;
                frm_cotas.checkBoxMai.Enabled = false;
                frm_cotas.pictureBoxMai.Visible = true;
                frm_cotas.checkBoxJun.Enabled = true;
                frm_cotas.checkBoxJulh.Enabled = false;
                frm_cotas.checkBoxAgo.Enabled = false;
                frm_cotas.checkBoxSet.Enabled = false;
                frm_cotas.checkBoxOct.Enabled = false;
                frm_cotas.checkBoxNov.Enabled = false;
                frm_cotas.checkBoxDez.Enabled = false;
              
            }
            else if (cotas.meses[0] == "Janeiro" && cotas.meses[1] == "Fevereiro" && cotas.meses[2] == "Março" && cotas.meses[3] == "Abril")
            {
                frm_cotas.checkBoxJan.Enabled = false;
                frm_cotas.pictureBoxJan.Visible = true;
                frm_cotas.checkBoxFev.Enabled = false;
                frm_cotas.pictureBoxFev.Visible = true;
                frm_cotas.checkBoxMa.Enabled = false;
                frm_cotas.pictureBoxMa.Visible = true;
                frm_cotas.checkBoxAbr.Enabled = false;
                frm_cotas.pictureBoxAbr.Visible = true;
                frm_cotas.checkBoxMai.Enabled = false;
                frm_cotas.checkBoxJun.Enabled = false;
                frm_cotas.checkBoxJulh.Enabled = false;
                frm_cotas.checkBoxAgo.Enabled = false;
                frm_cotas.checkBoxSet.Enabled = false;
                frm_cotas.checkBoxOct.Enabled = false;
                frm_cotas.checkBoxNov.Enabled = false;
                frm_cotas.checkBoxDez.Enabled = false;
          
               
            }
            else if (cotas.meses[0] == "Janeiro" && cotas.meses[1] == "Fevereiro" && cotas.meses[2] == "Março")
            {
                frm_cotas.checkBoxJan.Enabled = false;
                frm_cotas.pictureBoxJan.Visible = true;
                frm_cotas.checkBoxFev.Enabled = false;
                frm_cotas.pictureBoxFev.Visible = true;
                frm_cotas.checkBoxMa.Enabled = false;
                frm_cotas.pictureBoxMa.Visible = true;
                frm_cotas.checkBoxAbr.Enabled = true;
                frm_cotas.checkBoxMai.Enabled = false;
                frm_cotas.checkBoxJun.Enabled = false;
                frm_cotas.checkBoxJulh.Enabled = false;
                frm_cotas.checkBoxAgo.Enabled = false;
                frm_cotas.checkBoxSet.Enabled = false;
                frm_cotas.checkBoxOct.Enabled = false;
                frm_cotas.checkBoxNov.Enabled = false;
                frm_cotas.checkBoxDez.Enabled = false;

     
            }
            else if (cotas.meses[0] == "Janeiro" && cotas.meses[1] == "Fevereiro")
            {
                frm_cotas.checkBoxJan.Enabled = false;
                frm_cotas.pictureBoxJan.Visible = true;
                frm_cotas.checkBoxFev.Enabled = false;
                frm_cotas.pictureBoxFev.Visible = true;
                frm_cotas.checkBoxMa.Enabled = true;
                frm_cotas.checkBoxAbr.Enabled = false;
                frm_cotas.checkBoxMai.Enabled = false;
                frm_cotas.checkBoxJun.Enabled = false;
                frm_cotas.checkBoxJulh.Enabled = false;
                frm_cotas.checkBoxAgo.Enabled = false;
                frm_cotas.checkBoxSet.Enabled = false;
                frm_cotas.checkBoxOct.Enabled = false;
                frm_cotas.checkBoxNov.Enabled = false;
                frm_cotas.checkBoxDez.Enabled = false;
  
               
            }
            else if (cotas.meses[0] == "Janeiro")
            {
                frm_cotas.checkBoxJan.Enabled = false;
                frm_cotas.pictureBoxJan.Visible = true;
                frm_cotas.checkBoxMa.Enabled = false;
                frm_cotas.checkBoxAbr.Enabled = false;
                frm_cotas.checkBoxMai.Enabled = false;
                frm_cotas.checkBoxJun.Enabled = false;
                frm_cotas.checkBoxJulh.Enabled = false;
                frm_cotas.checkBoxAgo.Enabled = false;
                frm_cotas.checkBoxSet.Enabled = false;
                frm_cotas.checkBoxOct.Enabled = false;
                frm_cotas.checkBoxNov.Enabled = false;
                frm_cotas.checkBoxDez.Enabled = false;
            }
            else
            {
                frm_cotas.checkBoxJan.Enabled = true;
                frm_cotas.checkBoxFev.Enabled = false;
                frm_cotas.checkBoxMa.Enabled = false;
                frm_cotas.checkBoxAbr.Enabled = false;
                frm_cotas.checkBoxMai.Enabled = false;
                frm_cotas.checkBoxJun.Enabled = false;
                frm_cotas.checkBoxJulh.Enabled = false;
                frm_cotas.checkBoxAgo.Enabled = false;
                frm_cotas.checkBoxSet.Enabled = false;
                frm_cotas.checkBoxOct.Enabled = false;
                frm_cotas.checkBoxNov.Enabled = false;
                frm_cotas.checkBoxDez.Enabled = false; 
            }
            frm_cotas.ShowDialog();*/
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VisualizaMembro vm = new VisualizaMembro(this.c);
            vm.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            int resultadoSexo = 0,resultadoIdentificacao=0,resultadoEstado_civil=0,resultadoCat_membro=0,resultadoGrupo=0,resultadoComissao=0,resultadoEstado=0,resultadoClasse=0,resultadoCargo=0;

            int idade = 0;
            DateTimePicker date = new DateTimePicker();
            string dt = date.Value.ToString("yyyy-MM-dd");
            dt = dateTimePicker1.Value.ToString();
            campo.ano1 = dateTimePicker1.Value.Year;
            campo.mes1 = dateTimePicker1.Value.Month;
            campo.dia1 = dateTimePicker1.Value.Day;
            string data1 = Convert.ToString(campo.ano1 + "-" + campo.mes1 + "-" + campo.dia1);
            string dt2 = date.Value.ToString("yyyy-MM-dd");
            dt2 = dateTimePicker2.Value.ToString();
            campo.ano2 = dateTimePicker2.Value.Year;
            campo.mes2 = dateTimePicker2.Value.Month;
            campo.dia2 = dateTimePicker2.Value.Day;
            string data2 = Convert.ToString(campo.ano2 + "-" + campo.mes2 + "-" + campo.dia2);
            idade = DateTime.Now.Year - dateTimePicker1.Value.Year;
        
            campo.nome = textNome.Text;
            campo.alcunha = textAlcunha.Text;
            campo.idade = Convert.ToInt32(idade);
            campo.bairro = textBairro.Text;
            campo.rua = textRua.Text;
            campo.descricao = textDescricao.Text;
            campo.telefone1 = Convert.ToInt32(textPhone1.Text);
            campo.telefone2 = Convert.ToInt32(textPhone2.Text);
            campo.bi_cedula = textBI.Text;
            campo.email = textEmail.Text;
            campo.facebook = textFace.Text;
            campo.nivelEscolar = textNEscolar.Text;
            campo.areaFormacao = textArFormacao.Text;
            campo.profissao = textProfi.Text;
            campo.escola = textEscola.Text;
            campo.pai = textPai.Text;
            campo.mae = textMae.Text;
            campo.igrejAnterior = textIgrejaAnt.Text;
            campo.opfuncaoFuturo = textFuncaoIgreja.Text;
            campo.sobreJuventude = richTextOpiniao.Text;
            campo.cat_membro = comboBoxCat.Text;

            campo.classe = comboBoxClasse.Text;
            campo.sexo = comboBoxSexo.Text;
            campo.data_nascimento = data1;
            campo.data_ingresso = data2;
            campo.identificacao = comboBoxIdent.Text;
            campo.estado = comboBoxestado.Text;
            campo.estado_civil = comboBoxE_civil.Text;
            campo.cargo = comboBoxCargo.Text;
            campo.comissao = comboBoxComissao.Text;
            campo.grupo = comboBoxGrupo.Text;
            campo.img = @"//fotos_jimub//" + pictureBoxFoto.ImageLocation;
            campo.como_ingressou = comboBoxComo_ingressou.Text;
            campo.presenca = comboBoxPresenca.Text;
            campo.motivo_ausencia = comboBoxMotivo.Text;
            campo.ramo = comboBoxRamo.Text;

            resultadoSexo = comboBoxSexo.FindStringExact(comboBoxSexo.Text);
            resultadoIdentificacao = comboBoxIdent.FindStringExact(comboBoxIdent.Text);
            resultadoEstado_civil = comboBoxE_civil.FindStringExact(comboBoxE_civil.Text);
            resultadoCat_membro = comboBoxCat.FindStringExact(comboBoxCat.Text);
            resultadoGrupo = comboBoxGrupo.FindStringExact(comboBoxGrupo.Text);
            resultadoComissao = comboBoxComissao.FindStringExact(comboBoxComissao.Text);
            resultadoEstado = comboBoxestado.FindStringExact(comboBoxestado.Text);
            resultadoClasse = comboBoxClasse.FindStringExact(comboBoxClasse.Text);
            resultadoCargo = comboBoxCargo.FindStringExact(comboBoxCargo.Text);

            validar.validarMembro(campo);

           

                if (campo.verifica == true)
                {

                if (resultadoIdentificacao == -1 && comboBoxIdent.Text!="Identificação")
                {
                    MessageBox.Show("A Identificação selecionada não existe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (resultadoSexo == -1)
                {
                    MessageBox.Show("O Sexo selecionado não existe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (resultadoEstado_civil == -1 && !comboBoxE_civil.Text.Equals("Estado Civil"))
                {
                    MessageBox.Show("O Estado civil selecionado não existe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (resultadoCat_membro == -1 && !comboBoxCat.Text.Equals("Categoria de membro"))
                {
                    MessageBox.Show("A Categoria selecionado não existe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (resultadoGrupo == -1 && !comboBoxGrupo.Text.Equals("Grupo"))
                {
                    MessageBox.Show("O Grupo selecionado não existe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (resultadoComissao == -1 && !comboBoxComissao.Text.Equals("Comissão"))
                {
                    MessageBox.Show("A comissão selecionado não existe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (resultadoEstado == -1)
                {
                    MessageBox.Show("O Estado selecionado não existe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (resultadoClasse == -1 && !comboBoxClasse.Text.Equals("Classes"))
                {
                    MessageBox.Show("A Classe selecionado não existe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (resultadoCargo == -1)
                {
                    MessageBox.Show("O Cargo selecionado não existe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    executa.inserir(campo);
                    labelExito.Text = campo.exito;
                    //MessageBox.Show(campo.exito);
                    colocarDeVolta();
                }
            }
            
        }

        private void textNome_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           // validar.verificaTexto(e);
        }

        private void textAlcunha_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textAlcunha_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //validar.verificaTexto(e);
        }

        private void textPai_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar.verificaTexto(e);
        }

        private void textMae_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar.verificaTexto(e);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            colocarDeVolta();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Membros membro = new Membros(this.c);
            membro.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            VisualizaMembro vm = new VisualizaMembro(this.c);
            vm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            form_sms sms = new form_sms(this.c);
            sms.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new frm_actividades(this.c).Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            new login2().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            new form_patrimonio(this.c).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            new Cadastro_user(this.c).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Menu(this.c).Show();
        }

        private void textPhone1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            new form_log().ShowDialog();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            //fazendo o upload
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imglocation = dialog.FileName.ToString();
                pictureBoxFoto.ImageLocation = imglocation;
                textBoxLink.Text = imglocation;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPresenca_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxPresenca.SelectedItem.ToString() == "Presente" || comboBoxPresenca.SelectedItem.ToString() == "Regular")
            {
                comboBoxMotivo.Enabled = false;
                comboBoxMotivo.Text = "";
            }
            else
            {
                comboBoxMotivo.Enabled = true;
                comboBoxMotivo.Text = "Motivo";
                
            }
        }

        private void comboBoxMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textPai_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPresenca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxE_civil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
