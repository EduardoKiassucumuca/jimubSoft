using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using WindowsFormsApplication1.Classes;


namespace WindowsFormsApplication1
{
    public partial class Cadastro_user : Form
    {

        private Campo campo;

        public Cadastro_user(Campo campo)
        {
            InitializeComponent();
            this.campo = campo;
        }

        Campo c = new Campo();
        Usuario usuario = new Usuario();

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void button10_Click(object sender, EventArgs e)
        {

            campo.usuario = textUsuario.Text;
            campo.set_senha(textSenha.Text);
            campo.set_senha2(textSenha2.Text);
            campo.cargo = comboBoxCargo.Text;

            if (usuario.validaUsuario(campo, dataGridView1))
            {
                usuario.registrarUsuario(campo);
                labelSucesso.Text = campo.exito;
                lista_usuarios();
            }
        }

        private void limpar()
        {
            comboBoxCargo.Text = "Cargo";
            textUsuario.Text = "Usuário";
            textSenha.Text = "Senha";
            textSenha2.Text = "Senha";
            labelSucesso.Text = "";
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.limpar();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_user_Load(object sender, EventArgs e)
        {
            lista_usuarios();
            colunas();
            linkUsuario.Enabled = usuario.nivelDeAcesso(this.campo);
            button12.Enabled = usuario.nivelDeAcesso(this.campo);
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
            dataGridView1.DataSource = usuario.mostrarUsuarios();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            this.campo.set_Iduser(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            this.campo.cargo = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.campo.usuario = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.campo.set_senha(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            this.campo.set_senha2(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            this.Close();
            new form_alteraUsuario(this.campo).Show();

        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Membros membro = new Membros(this.campo);
            membro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
          
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            login2 login = new login2();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_actividades form_actividades = new frm_actividades(this.campo);
            form_actividades.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            form_sms sms = new form_sms(this.campo);
            sms.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VisualizaMembro vm = new VisualizaMembro(this.campo);
            vm.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Membros membro = new Membros(this.campo);
            membro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Menu(this.campo).Show();
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkUsuario_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            campo.usuario = textPesquisaUser.Text;
            dataGridView1.DataSource = usuario.pesquisaUsuario(campo);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                campo.set_Iduser( Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                usuario.eliminarUsuario(campo);
                lista_usuarios();
                MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textSenha2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            new form_log().ShowDialog();
        }
    }
}
