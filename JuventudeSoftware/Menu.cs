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
    public partial class Menu : Form
    {
        Campo campo;

        public Menu(Campo campo)
        {
            InitializeComponent();
            timer1.Start();
            this.campo = campo;
        }
        Usuario acessar = new Usuario();
        private void Form2_Load(object sender, EventArgs e)
        {

            linkUsuario.Enabled = acessar.nivelDeAcesso(this.campo);
            button12.Enabled = acessar.nivelDeAcesso(this.campo);
            labelUsuario.Text = this.campo.user_acesso;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cadastro_user ca = new Cadastro_user(this.campo);
            ca.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Membros membro = new Membros(this.campo);
            membro.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            login.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //tempo();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Login log = new Login();
            log.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VisualizaMembro vm = new VisualizaMembro(this.campo);
            vm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Membros membro = new Membros(this.campo);
            membro.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            VisualizaMembro vm = new VisualizaMembro(this.campo);
            vm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_sms sms = new form_sms(this.campo);
            sms.ShowDialog();
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            this.Visible = false;
            login2 login = new login2();
            login.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_actividades form_actividades = new frm_actividades(this.campo);
            form_actividades.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Menu(this.campo).Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
                this.Close();
                new Cadastro_user(this.campo).Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            new form_patrimonio(this.campo).Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            new form_log().Show();
        }

        /*
        private void tempo()
        {
           DateTime tempo = DateTime.Now; 
            tempo.
         }*/



    }
}
