using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1
{
    
    public partial class Login : Form
    {
      

        public Login()
        {
            InitializeComponent();
        }
        Usuario acessar = new Usuario();
        Campo campo = new Campo();

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
         
        }

    

        private void rectangleShape3_Click(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            campo.usuario = textUser.Text;
           
            campo.set_senha(textSenha.Text);

            acessar.login(campo);

            if (campo.verifica == true)
            {
                campo.user_acesso = textUser.Text;
                this.Visible = false;
                Menu mn = new Menu(campo);
                mn.ShowDialog();
            }
            else if(campo.verifica == false)
            {
                label1.Visible = false;
               labelErro.Text = Convert.ToString(campo.erro);
               labelError.Visible = true;
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            acessar.desativar_caracteres(e);
        }

        private void textSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            acessar.desativar_caracteres(e);
        }
    }
}
