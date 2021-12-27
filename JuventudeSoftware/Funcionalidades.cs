using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class Funcionalidades
    {
        /*
       
        private MySqlConnection con;

    
        
        public void conecta()
        {
            if (con != null)
            
                con.Close();

                try
                {
                    con = new MySqlConnection("SERVER=localhost;DATABASE=juventude;UID=root;");
                    con.Open();
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Erro de conexão com o banco de dados, contacte o administrador: " + erro.Message);
                }
            
        }
        public void logar()
        {
          
            string selecionar = "Select * From usuario Where user='" + usuario + "'and senha='" + pass + "'";
            MySqlCommand comando = new MySqlCommand(selecionar,con);
            MySqlDataReader dados = comando.ExecuteReader();
            while (dados.Read())
            {
                usuario = dados["user"].ToString();
                pass = dados["senha"].ToString();

                if (((usuario == dados["user"].ToString()) && (pass == dados["senha"].ToString())))
                {

                    Login login = new Login();
                    login.Visible = false;
                    Menu f2 = new Menu();
                    f2.Visible = true;
                    
                }

                else
                {
                    MessageBox.Show(" Usuario ou senha invalidos");
                }
            }
            con.Close();
         
        }*/
        
    }
}
