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
    public partial class frm_actividades : Form
    {
        private Campo c;
        public frm_actividades(Campo campo)
        {
            InitializeComponent();
            this.c = campo;
        }

        Campo campo = new Campo();
        Actividade actividade = new Actividade();
        Usuario us = new Usuario();
        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.c.setId_actividade( Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
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
        private void colunas()
        {

            dataGridView1.Columns[0].HeaderText = "#ID";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].HeaderText = "Comissão";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Tema";
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].HeaderText = "Objectivo";
            dataGridView1.Columns[3].Width = 400;
            dataGridView1.Columns[4].HeaderText = "Orador";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].HeaderText = "Estado";
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].HeaderText = "Local da actividade";
            dataGridView1.Columns[6].Width = 200;
            dataGridView1.Columns[7].HeaderText = "Data da actividade";
            dataGridView1.Columns[7].Width = 180;
            dataGridView1.Columns[8].HeaderText = "Hora da actividade";
            dataGridView1.Columns[8].Width = 130;
            dataGridView1.Columns[9].HeaderText = "Quantidade de homens";
            dataGridView1.Columns[9].Width = 170;
            dataGridView1.Columns[10].HeaderText = "Quantidade de mulheres";
            dataGridView1.Columns[10].Width = 170;
            dataGridView1.Columns[11].HeaderText = "Quantidade total";
            dataGridView1.Columns[11].Width = 130;
        }

        private void listarActividades()
        {
          
            dataGridView1.DataSource = actividade.selecionarActividades();
        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //int comissao = 0, estado = 0;
            DateTimePicker formatarData = new DateTimePicker(); 
            this.c.setComissaoEncarregue(comboBoxComissao.Text);
            this.c.setTema(textBoxTema.Text);
            this.c.setObjectivo(richTextBoxObjectivo.Text);
            this.c.setOrador(textBoxOrador.Text);
            this.c.setEstadoActividade(comboBoxEstado.Text);
            this.c.setLocalActividade(textBoxLocal.Text);
            String dataFormatada = formatarData.Value.ToString("yyyy-MM-dd");
            int ano = dateTimePicker1.Value.Year;
            int mes = dateTimePicker1.Value.Month;
            int dia = dateTimePicker1.Value.Day;
            String data = ano + "-" + mes + "-" + dia;
            this.c.ano1 = ano;
            this.c.mes1 = mes;
            this.c.dia1 = dia;

            this.c.setdatActividade(data);
            string hora = maskedTextBoxHora.Text.Substring(0,2);
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


                    if (comboBoxEstado.Text.Equals("Realizada"))
                    {

                        this.Close();
                        new form_presenca(this.c).Show();
                    }
                    else
                    {
                        actividade.inserirActividade(this.c);
                        labelExito.Text = this.c.exito;
                        listarActividades();
                        colunas();
                    }
                }
            }
        }

        private void comboBoxVcSecretario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_actividades_Load(object sender, EventArgs e)
        {
         
            listarActividades();
            colunas();

            linkUsuario.Enabled = us.nivelDeAcesso(this.c);
            labelUsuario.Text = this.c.user_acesso;

          
            string dataFormatada = DateTime.Now.Date.ToString("yyyy-MM-dd");
             
           

            foreach(DataGridViewRow linha in dataGridView1.Rows)
            {
               
                if(linha.Cells[5].Value.ToString().Equals("Planificada") && ((Convert.ToInt32(linha.Cells[7].Value.ToString().Substring(0,2)) <= Convert.ToInt32(dataFormatada.Substring(2,2))) || (Convert.ToInt32(linha.Cells[7].Value.ToString().Substring(3, 2)) <= Convert.ToInt32(dataFormatada.Substring(5,2))) || (Convert.ToInt32(dataFormatada.Substring(6, 2)) <= Convert.ToInt32(dataFormatada.Substring(8,2)))))
                {
                    this.c.setId_actividade(Convert.ToInt32(linha.Cells[0].Value.ToString()));
                    this.c.setTema(linha.Cells[2].Value.ToString());
                    this.c.setComissaoEncarregue(linha.Cells[1].Value.ToString());
                  
                    new form_analisaEstado(this.c).ShowDialog();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            campo.setComissaoEncarregue(comboBox1.Text);
            this.dataGridView1.DataSource =  actividade.pesquisarComissao(campo);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            campo.setEstadoActividade(comboBox2.Text);
            this.dataGridView1.DataSource = actividade.pesqEstadoActividade(campo);
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

        private void limpar()
        {
            comboBoxComissao.Text = "Comissão encarregada da actividade";
            textBoxOrador.Text = "Orador";
            textBoxTema.Text = "Tema";
            richTextBoxObjectivo.Text = "Objectivo...";
            comboBoxEstado.Text = "Estado da actividade";
            textBoxLocal.Text = "Local da actividade";
            dateTimePicker1.Text = DateTime.Now.Date.ToString();
            maskedTextBoxHora.Text = "00:00";
            labelExito.Text = "";
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.limpar();
        }

        private void comboBoxComissao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new form_titulo2(this.dataGridView1,actividade,null).Show();
        }
    }
}
