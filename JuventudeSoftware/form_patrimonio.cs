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
    public partial class form_patrimonio : Form
    {
        private Campo campo;
        public form_patrimonio(Campo campo)
        {
            InitializeComponent();
            this.campo = campo;
        }
        Usuario us = new Usuario();
        Patrimonio patrimonio = new Patrimonio();
        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void form_patrimonio_Load(object sender, EventArgs e)
        {
            linkUsuario.Enabled = us.nivelDeAcesso(this.campo);
            labelUsuario.Text = this.campo.user_acesso;
         
            this.listar_patrimonio();
            this.colunnas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Menu(this.campo).Show();
        }

        private void linkUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            new Cadastro_user(this.campo).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new Membros(this.campo).Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            new form_sms(this.campo).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new frm_actividades(this.campo).Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            new form_patrimonio(this.campo).Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
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
        private void limpar()
        {
            textMaterial.Text = "Descrição/Material";
            maskedTextBox1.Text = "00";
            comboBoxComissao.Text = "Comissão";
            comboBoxEstado.Text = "Estado";
            labelSucesso.Text = "";

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.limpar();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            this.campo.material = textMaterial.Text;
            this.campo.qtd = int.Parse(maskedTextBox1.Text);
            this.campo.comissao = comboBoxComissao.Text;
            this.campo.estado_conservacao = comboBoxEstado.Text;
            patrimonio.valida_patrimonio(this.campo);

            if(this.campo.verifica)
            {
                patrimonio.inserirPatrimonio(this.campo);
                labelSucesso.Text = this.campo.exito;
                this.listar_patrimonio();
                this.colunnas();
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            patrimonio.desativar_letras(e);
        }

        private void textPesquisaMaterial_TextChanged(object sender, EventArgs e)
        {
            this.campo.material = textPesquisaMaterial.Text;
            this.dataGridView1.DataSource = patrimonio.pesquisarMaterial(this.campo);
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                this.campo.set_idPatrimonio(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                patrimonio.eliminar_patrimonio(this.campo);               
                MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.campo.set_idPatrimonio(int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            this.campo.material = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.campo.qtd = int.Parse(this.dataGridView1.CurrentRow.Cells[3].Value.ToString());
            this.campo.comissao = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.campo.estado_conservacao = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.Close();
            new form_altera_patrimonio(this.campo).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new form_titulo2(this.dataGridView1,null,patrimonio).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            new VisualizaMembro(this.campo).Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
