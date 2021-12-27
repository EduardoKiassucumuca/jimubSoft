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
    public partial class Alterar_Membro : Form
    {
        private Campo c;
        public Alterar_Membro(Campo campo)
        {
            InitializeComponent();
            this.c = campo;
        }
        Campo campo = new Campo();
        Membro executa = new Membro();
        Validacao validar = new Validacao();
        Usuario us = new Usuario();

        private void comboBoxClasse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
        private void textAlcunha_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.verificaTexto(e);
        }

        
      
        private void textNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.verificaTexto(e);
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
           
            executa.Selecionar_Campos(campo);
           
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

   
        }

        private void Alterar_Membro_Load(object sender, EventArgs e)
        {
            linkUsuario.Enabled =  us.nivelDeAcesso(this.c);

            textNome.Text = this.c.nome;
            textBairro.Text = this.c.bairro;
            textRua.Text = this.c.rua;
            textPhone1.Text = this.c.telefone1.ToString();
            textPhone2.Text = this.c.telefone2.ToString();
            comboBoxIdent.Text = this.c.identificacao;
            textBI.Text = this.c.bi_cedula;
            comboBoxSexo.Text = this.c.sexo;
            dateTimePicker1.Text = this.c.data_nascimento;
            textDescricao.Text = this.c.descricao;
            textEmail.Text = this.c.email;
            textFace.Text = this.c.facebook;
            textAlcunha.Text = this.c.alcunha;
            textNEscolar.Text = this.c.nivelEscolar;
            textArFormacao.Text = this.c.areaFormacao;
            textProfi.Text = this.c.profissao;
            textEscola.Text = this.c.escola;
            comboBoxE_civil.Text = this.c.estado_civil;
            textPai.Text = this.c.pai;
            textMae.Text = this.c.mae;
            comboBoxCat.Text = this.c.cat_membro;
            comboBoxGrupo.Text = this.c.grupo;
            comboBoxComissao.Text = this.c.comissao;
            comboBoxestado.Text = this.c.estado;
            comboBoxClasse.Text = this.c.classe;
            comboBoxCargo.Text = this.c.cargo;
            textIgrejaAnt.Text = this.c.igrejAnterior;
            dateTimePicker2.Text = this.c.data_ingresso;
            textFuncaoIgreja.Text = this.c.opfuncaoFuturo;
            richTextOpiniao.Text = this.c.sobreJuventude;
         
            labelUsuario.Text = this.c.user_acesso;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Menu(this.c).Show();
        }

        private void linkUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            new Cadastro_user(this.c).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new Membros(this.c).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            new VisualizaMembro(this.c).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new form_sms(this.c).Show();

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

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
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
            comboBoxE_civil.Text = "Estado Civil";
            comboBoxGrupo.Text = "Grupo";
            comboBoxestado.Text = "Estado";
            comboBoxCargo.Text = "Cargo";
            comboBoxComissao.Text = "Comissão";
            comboBoxIdent.Text = "Identificação";
            textAlcunha.Text = "Alcunha";
            labelExito.Text = " ";
            pictureBoxFoto.Image = WindowsFormsApplication1.Properties.Resources.images;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            colocarDeVolta();
        }

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            executa.Selecionar_Campos(this.c);
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
            campo.img = pictureBoxFoto.ImageLocation;
            validar.validarMembro(campo);

            if (campo.verifica == true)
            {
                executa.alterar_membro(campo);
                labelExito.Text = campo.exito;
                //colocarDeVolta();
            }

        }

        private void textPai_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
