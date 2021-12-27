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
    public partial class form_altera_patrimonio : Form
    {
        private Campo campo;
        public form_altera_patrimonio(Campo campo)
        {
            this.campo = campo;
            InitializeComponent();
        }

        Usuario us = new Usuario();
        Patrimonio patrimonio = new Patrimonio();
        private void form_altera_patrimonio_Load(object sender, EventArgs e)
        {
            linkUsuario.Enabled = us.nivelDeAcesso(this.campo);
            labelUsuario.Text = this.campo.user_acesso;
            this.listar_patrimonio();
            this.colunnas();

            textMaterial.Text = this.campo.material;
            maskedTextBox1.Text = this.campo.qtd.ToString();
            comboBoxComissao.Text = this.campo.comissao;
            comboBoxEstado.Text = this.campo.estado_conservacao;

        

        }
        private void colunnas()
        {
            dataGridView1.Columns[0].HeaderText = "#ID";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].HeaderText = "Comissão";
            dataGridView1.Columns[1].Width = 315;
            dataGridView1.Columns[2].HeaderText = "Mateial/Descricao";
            dataGridView1.Columns[2].Width = 400;
            dataGridView1.Columns[3].HeaderText = "Qtd";
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].HeaderText = "Estado";
            dataGridView1.Columns[4].Width = 185;
        }
        private void listar_patrimonio()
        {
            dataGridView1.DataSource = patrimonio.seleciona_patrimonio();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            campo.material = textMaterial.Text;
            campo.qtd = int.Parse(maskedTextBox1.Text);
            campo.comissao = comboBoxComissao.Text;
            campo.estado_conservacao = comboBoxEstado.Text;
            patrimonio.valida_patrimonio(this.campo);

            if (this.campo.verifica)
            {
                patrimonio.altera_patrimonio(this.campo);
                labelSucesso.Text = this.campo.exito;
                this.listar_patrimonio();
                this.colunnas();
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            patrimonio.desativar_letras(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            new form_titulo2(this.dataGridView1, null, patrimonio).Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.campo.comissao = comboBox1.Text;
            this.dataGridView1.DataSource = patrimonio.pesquisarComissao(this.campo);
        }
 

        private void comboBoxPesqEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.campo.estado_conservacao = comboBoxPesqEstado.Text;
            this.dataGridView1.DataSource = patrimonio.pesquisarEstado(this.campo);
        }

        private void textPesquisaMaterial_TextChanged(object sender, EventArgs e)
        {
            this.campo.material = textPesquisaMaterial.Text;
            this.dataGridView1.DataSource = patrimonio.pesquisarMaterial(this.campo);
        }
    }
}
