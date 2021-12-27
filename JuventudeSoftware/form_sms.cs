using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1
{
    public partial class form_sms : Form
    {
        private Campo campo;
        public form_sms(Campo campo)
        {
            InitializeComponent();
            this.campo = campo;
        }

        SMS sms = new SMS();
        Campo c = new Campo();
        Usuario us = new Usuario();
        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VisualizaMembro vm = new VisualizaMembro(this.campo);
            vm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_sms sms = new form_sms(this.campo);
            sms.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            login.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            new form_patrimonio(this.campo).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new frm_actividades(this.campo).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Membros membro = new Membros(this.campo);
            membro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Cadastro_user(this.campo).Show();
        }
        private void form_sms_Load(object sender, EventArgs e)
        {
            listar_dados();
            colunas();
            button2.Enabled = us.nivelDeAcesso(this.campo);
            labelUsuario.Text = this.campo.user_acesso;

            
        }

        private void colunas()
        {

             dataGridView1.Columns[0].HeaderText = "#ID";
             dataGridView1.Columns[0].Width = 100;
             dataGridView1.Columns[1].HeaderText = "Nome";
             dataGridView1.Columns[1].Width = 260;
             dataGridView1.Columns[2].HeaderText = "Alcunha";
             dataGridView1.Columns[2].Width = 100;
             dataGridView1.Columns[3].HeaderText = "Telefone";
             dataGridView1.Columns[3].Width = 100;
         
        }
      
        private void listar_dados()
        {
            this.dataGridView1.DataSource = sms.dadosSMS();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxPersonalizado_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.pesqPersonalisada = comboBoxPersonalizado.Text;
            this.dataGridView1.DataSource = sms.pesquisaPersonalisada(c);
        }

        private void textPesquisaBairro_TextChanged(object sender, EventArgs e)
        {
            c.pesquisaBairro = textPesquisaBairro.Text;
            this.dataGridView1.DataSource = sms.pesquisarBairro(c);
        }

        private void comboBoxComissao_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.comissao = comboBoxComissao.Text;
            this.dataGridView1.DataSource = sms.pesquisarComissao(c);
        }

        private void comboBoxClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.classe = comboBoxClasse.Text;
            this.dataGridView1.DataSource = sms.pesquisarClasse(c);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            /*
            ArrayList sucesso = new ArrayList();
            ArrayList erro = new ArrayList();

            if (textSms.Text.Equals("Escrever a mensagem aqui...") || textSms.Text.Equals(""))
            {
                MessageBox.Show("Prencha a mensagem!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (DataGridViewRow linha in dataGridView1.Rows)
                {
                    if (ProduTivaSMS.SMS.EnviarSMS(linha.Cells[3].Value.ToString(), textSms.Text))
                    {
                        sucesso.Add(" A Mensagem para o/a \"" + linha.Cells[2].Value.ToString() + "\"  foi enviada com sucesso");
                    }
                    else
                    {
                        erro.Add(" A Mensagem para o/a \"" + linha.Cells[2].Value.ToString() + "\"  não foi enviada com sucesso");
                    }
                }

                foreach (String erros in erro)
                {
                    listBox1.Items.Add(erros);
                }
                foreach (String suc in sucesso)
                {
                    listBox2.Items.Add(suc);
                }
            }*/
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Menu(this.campo).Show();
        }
    }
}
