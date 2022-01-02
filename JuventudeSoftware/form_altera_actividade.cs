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
    public partial class form_altera_actividade : Form
    {
        private Campo c;

        public form_altera_actividade(Campo campo)
        {
            this.c = campo;
            InitializeComponent();
        }

        Usuario us = new Usuario();
        Campo campo = new Campo();
        Actividade actividade = new Actividade();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new VisualizaMembro(this.c).Show();
        }

        private void button10_Click(object sender, EventArgs e)
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

        private void colunas()
        {

            dataGridView1.Columns[0].HeaderText = "#ID";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderText = "O QUE";
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[2].HeaderText = "QUANDO";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].HeaderText = "ONDE";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].HeaderText = "ORADOR";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].HeaderText = "OBJECTIVO";
            dataGridView1.Columns[5].Width = 400;
            dataGridView1.Columns[6].HeaderText = "QUEM";
            dataGridView1.Columns[6].Width = 120;
            dataGridView1.Columns[7].HeaderText = "HORA";
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[8].HeaderText = "ESTADO";
            dataGridView1.Columns[8].Width = 120;
            dataGridView1.Columns[9].HeaderText = "OBSERVAÇÃO";
            dataGridView1.Columns[9].Width = 220;
        }

        private void listarActividades()
        {

            dataGridView1.DataSource = actividade.selecionarActividades();
        }

        private void form_altera_actividade_Load(object sender, EventArgs e)
        {
            this.listarActividades();
            this.colunas();

            comboBoxComissao.Text = this.c.getComissaoEncarregue();
            textBoxOrador.Text = this.c.getOrador();
            textBoxTema.Text = this.c.getTema();
            comboBoxEstado.Text = this.c.getEstadoActividade();
            richTextBoxObjectivo.Text = this.c.getObjectivo();
            richTextBoxObs.Text = this.c.getOBSActividade();
            textBoxLocal.Text = this.c.getLocalActividade();
            dateTimePicker1.Text = this.c.getDatActividade();
            maskedTextBoxHora.Text = this.c.gethorActividade();
            linkUsuario.Enabled = us.nivelDeAcesso(this.c);
            labelUsuario.Text = this.c.user_acesso;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                campo.setId_actividade(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                actividade.eliminarActividade(campo);
                this.listarActividades();
                MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if(comboBoxEstado.SelectedItem.Equals("Realizada"))
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else
            {
                textBox1.Text = textBox2.Text = "0";
                
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            DateTimePicker formatarData = new DateTimePicker();
            this.c.setComissaoEncarregue(comboBoxComissao.Text);
            this.c.setTema(textBoxTema.Text);
            this.c.setObjectivo(richTextBoxObjectivo.Text);
            this.c.setOrador(textBoxOrador.Text);
            this.c.setEstadoActividade(comboBoxEstado.Text);
            this.c.setLocalActividade(textBoxLocal.Text);
            this.c.setOBSactividade(richTextBoxObs.Text);

            String dataFormatada = formatarData.Value.ToString("yyyy-MM-dd");
            int ano = dateTimePicker1.Value.Year;
            int mes = dateTimePicker1.Value.Month;
            int dia = dateTimePicker1.Value.Day;
            String data = ano + "-" + mes + "-" + dia;
            this.c.ano1 = ano;
            this.c.mes1 = mes;
            this.c.dia1 = dia;

            this.c.setdatActividade(data);
            string hora = maskedTextBoxHora.Text.Substring(0, 2);
            string minuto = maskedTextBoxHora.Text.Substring(3);
            this.c.hour = Convert.ToInt32(hora);
            this.c.minute = Convert.ToInt32(minuto);
            this.c.setHorActividade(maskedTextBoxHora.Text);
            actividade.validaActividade(this.c);

            if (this.c.verifica == true)
            {
                if (comboBoxComissao.FindStringExact(comboBoxComissao.Text) == -1)
                {
                    MessageBox.Show("A Comissão selecionada não existe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (comboBoxEstado.FindStringExact(comboBoxEstado.Text) == -1)
                {
                    MessageBox.Show("O estado selecionada não existe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    actividade.alterarActividade(this.c);
                    labelSucesso.Text = this.c.exito;
                    listarActividades();
                    colunas();
                    
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            campo.setComissaoEncarregue(comboBox1.Text);
            this.dataGridView1.DataSource = actividade.pesquisarComissao(campo);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            campo.setEstadoActividade(comboBox2.Text);
            this.dataGridView1.DataSource = actividade.pesqEstadoActividade(campo);
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.c.setId_actividade(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            this.c.setComissaoEncarregue(this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
            this.c.setOrador(this.dataGridView1.CurrentRow.Cells[4].Value.ToString());
            this.c.setTema(this.dataGridView1.CurrentRow.Cells[2].Value.ToString());
            this.c.setEstadoActividade(this.dataGridView1.CurrentRow.Cells[5].Value.ToString());
            this.c.setObjectivo(this.dataGridView1.CurrentRow.Cells[3].Value.ToString());
            this.c.setLocalActividade(this.dataGridView1.CurrentRow.Cells[6].Value.ToString());
            this.c.setdatActividade(this.dataGridView1.CurrentRow.Cells[7].Value.ToString());
            this.c.setHorActividade(this.dataGridView1.CurrentRow.Cells[8].Value.ToString());
            this.c.qtd_homem = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[9].Value.ToString());
            this.c.qtd_mulher = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[10].Value.ToString());
            this.Close();
            new form_altera_actividade(this.c).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new form_titulo2(this.dataGridView1, actividade, null).Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            campo.setComissaoEncarregue(comboBox1.Text);
            this.dataGridView1.DataSource = actividade.pesquisarComissao(campo);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            campo.setMesActividade(comboBox3.Text);
            this.dataGridView1.DataSource = actividade.pesquisarPorMes(campo);
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            campo.setEstadoActividade(comboBox2.Text);
            this.dataGridView1.DataSource = actividade.pesqEstadoActividade(campo);
        }
    }
}
