using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.Net;

namespace WindowsFormsApplication1.Classes
{
    public class ComandosMySql
    {
      
        private MySqlConnection con;
        public MySqlCommand comando;
        public MySqlDataReader morada;
        public MySqlDataReader filiacao;
        public string idComissao,id_usuario,bairro,rua,descricao_casa;
        public string idCargo,idCargo2;
        public string idMorada;
        public string idMembro;
        public string idFiliacao,pai,mae;
        public string usuario;
        public int totalp=0,achei=0,achei2=0;
        public string[] meses;
        public string mes;
        public ArrayList idMeses; 
        private string senha;
        private int id_user;
        public string cargo;


        public int get_idUser()
        {
            return this.id_user;
        }

        public void set_idUser(int id_user)
        {
            this.id_user = id_user;
        }
        public string get_senha()
        {
            return this.senha;
        }

        public void set_senha(string novaSenha)
        {
            this.senha = novaSenha;
        }
      

        public MySqlConnection get_conexao()
        { 
            return con; 
        }

        public void set_conexao(MySqlConnection conecta)
        { 
            this.con = conecta; 
        }
       


        //Criando a conexão com o banco de dados.
        public MySqlConnection conexao()
        {
            string nome = Dns.GetHostName();

            IPAddress[] ip = Dns.GetHostAddresses(nome);

            //MessageBox.Show(ip[1].ToString());

            try
            {
                con = new MySqlConnection("SERVER=" + ip[1].ToString() + ";port=3306;DATABASE=jimub;UID=root;");
                con.Open();
               
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: Erro ao criar a conexão, " + erro.Message + MessageBoxIcon.Error);
            }
            return con;
          
        }

        //Exacutando comandos Sql

        public void executarComando(string comandoSql)
        {
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                
                comando.ExecuteNonQuery();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
            }

            conexao().Close();
        }

        public void executarComandoSqlReader(string comandoSql)
        {
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    this.set_idUser(Convert.ToInt32(dr.GetString("id_user")));
                    usuario = dr.GetString("user");
                    set_senha(dr.GetString("senha"));
                    cargo = dr.GetString("cargo");
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
            }
            conexao().Close();
        }
        public void executarSqlReaderAlternativoMorada(string comandoSql)
        {
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();
                
                while (dr.Read())
                {
                    idMorada = dr.GetString("id_morada");
       
                   
                }
                
            }

            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
            }

            conexao().Close();
        }
        public void executarSqlReaderMorada(string comandoSql,Campo c)
        {
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    
                    bairro = dr.GetString("bairro");
                    rua = dr.GetString("rua");
                    descricao_casa = dr.GetString("descricao_casa");
                    idMorada = dr.GetString("id_morada");

                }


            }

            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
            }
            conexao().Close();
        }
        public void executarSqlReaderAlternativoCargo(string comandoSql)
        {
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    idCargo = dr.GetString("id_cargo");

                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
            }
            conexao().Close();
        }
        public void executarSqlReaderCargo(string comandoSql)
        {
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    idCargo2 = dr.GetString("id_cargo");

                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
            }
            conexao().Close();
        }
        public void executarSqlReaderAlternativoComissao(string comandoSql)
        {
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                     idComissao = dr.GetString("id_comissao");

                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
            }
            conexao().Close();
        }
        public DataTable mostrar_tudo(string mostra)
        {
            DataTable tabela = new DataTable();
            
            MySqlDataAdapter sql_adaptar = new MySqlDataAdapter(mostra, conexao());
            MySqlCommandBuilder criar = new MySqlCommandBuilder(sql_adaptar);
            sql_adaptar.Fill(tabela);
            conexao().Close();
            return tabela;

        }
        public string executarComandoSqlFoto(string comandoSql)
        {
            string link = "";
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    link = dr.GetString("imagem");
                    
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
            }
            conexao().Close();
            return link;
        }
       /* public string executarComandoSqlData(string comandoSql)
        {
            string data = "";
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    data = dr.GetString("data_nascimento");

                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
            }
            return data;
        }*/
        public void executarSqlReaderMembro(string comandoSql)
        {
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    idMembro = dr.GetString("id_membro");

                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
            }
            conexao().Close();
        }
        public void executarSqlfiliacao(string comandoSql)
        {
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();
               

                while (dr.Read())
                {
                    idFiliacao = dr.GetString("id_filiacao");

                }
                filiacao = dr;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
            }
            conexao().Close();
        }
        public void executarfiliacao(string comandoSql,Campo c)
        {
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();


                while (dr.Read())
                {
                    idFiliacao = dr.GetString("id_filiacao");
                    pai = dr.GetString("pai");
                    mae = dr.GetString("mae");
                    if (pai.Equals(c.pai) && mae.Equals(c.mae))
                        achei = 1;


                }
                filiacao = dr;
               
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
            }
            conexao().Close();
        }
        public void executarSqlReaderCotas(string comandoSql)
        {
            int i=0;
            meses = new string[12];
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    meses[i]= dr.GetString("mes");
                    i += 1;
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error:1" + erro.Message);
            }
            conexao().Close();
        }
        public void BuscaTotalPago(string comandoSql)
        {
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    totalp +=Convert.ToInt32(dr.GetString("total_pago"));

                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error:2" + erro.Message);
            }
            conexao().Close();
        }
        public void BuscaIdMeses(string comandoSql)
        {

            idMeses = new ArrayList();

            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    idMeses.Add(Convert.ToInt32(dr.GetString("id_mes")));


                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: 3" + erro.Message);
            }
            conexao().Close();
        }
        
            public string executarSqlReaderCota(string comandoSql)
            {
                mes = null;
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    mes+=dr.GetString("mes") + ", ";

                }
                conexao().Close();
                return mes;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
                conexao().Close();
            }
         
           
            return null;
        }
            public string buscarCargo(string comandoSql)
            {
                try
                {
                    comando = new MySqlCommand(comandoSql, conexao());
                    MySqlDataReader dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                        return dr.GetString("cargo");

                    }
                conexao().Close();
            }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
                    conexao().Close();
            }
      
                return null;
            }
            public string buscarClasse(string comandoSql)
            {
                try
                {
                    comando = new MySqlCommand(comandoSql, conexao());
                    MySqlDataReader dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                    conexao().Close();
                    return dr.GetString("classe");

                    }
                
            }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
                    conexao().Close();
                }
       

                return null;
            }
            public string buscarComissao(string comandoSql)
            {
                try
                {
                    comando = new MySqlCommand(comandoSql, conexao());
                    MySqlDataReader dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                    
                    return dr.GetString("comissao");

                    }
                }
                catch (MySqlException erro)
                {
                conexao().Close();
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
                }
            finally
            {
                conexao().Close();
            }
                return null;
            }
             public int QTD(string comandoSql)
            {
                try
                {
                    comando = new MySqlCommand(comandoSql, conexao());
                    return Convert.ToInt32(comando.ExecuteScalar());
                   
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
                }
            finally
            {
                conexao().Close();
            }
                return -1;
            }
        public void selecionar_IDusuario(string comandoSql)
        {
            try
            {
                comando = new MySqlCommand(comandoSql, conexao());
                MySqlDataReader dr = comando.ExecuteReader();

                while(dr.Read())
                {
                    id_usuario = dr.GetString("id_user");
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
            }
            conexao().Close();
        }
    }
    }

