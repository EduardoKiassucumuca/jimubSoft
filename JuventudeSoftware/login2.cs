using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.Classes;


namespace WindowsFormsApplication1
{
    public partial class login2 : Form
    {
        public login2()
        {
            InitializeComponent();
        }
            Usuario acessar = new Usuario();
            Campo campo = new Campo();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login2_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user_lower, senha_lower;
            campo.user_acesso = textUser.Text;

            campo.set_senha(textSenha.Text);

            string[] words = {"create", "delete", "drop", "insert", "select", "into", "update", "set", "from", "alter", "table","from","where","as","values","table"};

            user_lower = textUser.Text.ToLower();
            senha_lower = textSenha.Text.ToLower();

            if (words.Contains(user_lower) || words.Contains(senha_lower))
            {
                labelErro.Text = "Usuário ou senha inválidas";
            }

            if (textUser.Text.Equals(""))
            {
                label1.Text = "";
                labelErro.Text = "Preencha o campo \"usuário\"";
            }
            else if (textSenha.Text.Equals(""))
            {
                label1.Text = "";
                labelErro.Text = "Preencha o campo \"senha\"";
            }
            else
            {
                acessar.login(campo);

                if (campo.verifica == true)
                {
                    campo.user_acesso = textUser.Text;
                    this.Visible = false;
                    Menu mn = new Menu(campo);
                    mn.ShowDialog();
                }
                else if (campo.verifica == false)
                {
                    label1.Visible = false;
                    labelErro.Text = Convert.ToString(campo.erro);
                    labelError.Visible = true;
                }
            }
        }

        private void textUser_TextChanged(object sender, EventArgs e)
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
