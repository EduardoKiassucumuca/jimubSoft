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
    public partial class form_alteraUsuario : Form
    {
        private Campo campo;
        public form_alteraUsuario(Campo campo)
        {
            InitializeComponent();
            this.campo = campo;
        }

        Usuario us = new Usuario();
       
        private void form_alteraUsuario_Load(object sender, EventArgs e)
        {
            
            linkUsuario.Enabled = us.nivelDeAcesso(this.campo);
            comboBoxCargo.Text = this.campo.cargo;
            textUsuario.Text = this.campo.usuario;
            textSenha.Text = this.campo.get_senha();
            textSenha2.Text = textSenha.Text;
            us.usuario_anterior = this.campo.usuario;
            us.cargo_anterior = this.campo.cargo;
            us.senha_anterior = this.campo.get_senha();
            lista_usuarios();
            colunas();
            labelUsuario.Text = this.campo.user_acesso;
        }
        private void colunas()
        {
            dataGridView1.Columns[0].HeaderText = "#ID";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderText = "Usuário";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Senha";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].HeaderText = "Cargo";
            dataGridView1.Columns[3].Width = 150;

        }

        private void lista_usuarios()
        {
            dataGridView1.DataSource = us.mostrarUsuarios();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            us.selectUser(this.campo);
            campo.usuario = textUsuario.Text;
            campo.set_senha(textSenha.Text);
            campo.set_senha2(textSenha2.Text);
            campo.cargo = comboBoxCargo.Text;

            if (textUsuario.Text.Equals(""))
            {
                MessageBox.Show("Preencha o \"Usuário\"", "Informação: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textSenha.Text.Equals(""))
            {
                MessageBox.Show("Preencha a \"Senha\"", "Informação: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBoxCargo.Text.Equals(""))
            {
                MessageBox.Show("Preencha o \"Cargo\"", "Informação: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(textSenha.Text.Equals(textSenha2.Text)))
            {
                MessageBox.Show("As senhas não correspondem", "Informação: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                us.alterar_usuario(campo, dataGridView1);
                labelSucesso.Text = campo.exito;
                lista_usuarios();
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.campo.cargo = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.campo.usuario = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.campo.set_senha(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            this.campo.set_senha2(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            this.Close();
            new form_alteraUsuario(this.campo).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Menu(this.campo);
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            new VisualizaMembro(this.campo).Show();
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
            new login2().Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Tens a certeza que pretendes eliminar?","Confirmação",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                campo.set_Iduser(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                us.eliminarUsuario(campo);
                lista_usuarios();
                MessageBox.Show("Registro eliminado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
