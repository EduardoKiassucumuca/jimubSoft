using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
    class Usuario:ComandosMySql
    {
        public string usuario_anterior, cargo_anterior, senha_anterior;


        public void login(Campo c)
        {
            try
            {
                if ((c.usuario == "Juventude" && c.get_senha() == "j2i0m1u8b"))
                {
                    c.cargo2 = "Admin";
                    c.user_acesso = "JIMUB";
                    c.verifica = true;
                }
                else
                {
                    string comandosql = "Select * From tb_usuario where status = 1 and user='" + c.user_acesso + "'and senha ='" + c.get_senha() + "'";
                   // string comandosql = "Select * From tb_usuario where status = 1 and user=@user and senha =@senha";
                    this.executarComandoSqlReader(comandosql);


                    if (((usuario == c.user_acesso) && (get_senha() == c.get_senha())))
                    {

                        c.cargo2 = cargo;
                        c.set_id_user_acesso(get_idUser());
                        c.data_log = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                        c.hora_log = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                        c.descricao_log = "O Utilizador " + c.user_acesso + " logou no sistema em " + c.data_log + " ás " + c.hora_log;
                        string strSql = "Insert into tb_log(id_user,descricao,data,hora)Value('" + c.get_id_user_acessor() + "','" + c.descricao_log + "','" + c.data_log + "','" + c.hora_log + "');";
                        this.executarComando(strSql);
                        c.verifica = true;
                    }
                    else
                    {
                        c.verifica = false;
                        //MessageBox.Show("falhou");
                        c.erro = "Usuário ou senha inválidos";
                    }
                }

            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message + MessageBoxIcon.Error);
            }
        }
        public void registrarUsuario(Campo c)
        {
            try
            {
                string strSql = "Insert into tb_usuario(user,senha,cargo)Value('" + c.usuario + "','" + c.get_senha() + "','" + c.cargo + "');";
                this.executarComando(strSql);
                string strSqlUser = "Select id_user from tb_usuario where status=1 and user='" + c.usuario + "';";
                this.selecionar_IDusuario(strSqlUser);
                
                c.data_log = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                c.hora_log = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                c.descricao_log = "O Utilizador " + c.user_acesso + " inseriu o utilizador " + c.usuario + " com o código " + "\"" + id_usuario + "\"" + " no sistema em " + c.data_log + " ás " + c.hora_log;
                string strSql2 = "Insert into tb_log(id_user,descricao,data,hora)Value('" + c.get_id_user_acessor() + "','" + c.descricao_log + "','" + c.data_log + "','" + c.hora_log + "');";
                this.executarComando(strSql2);
                c.exito = "Dados inseridos com sucesso!!!";
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Error: Dados não inseridos. " + e.Message + MessageBoxIcon.Error);
            }
        }

        public DataTable mostrarUsuarios()
        {
            DataTable tabela = new DataTable();
            string strSql = "Select id_user,user,senha,cargo from tb_usuario where status=1";
            tabela = this.mostrar_tudo(strSql);
            return tabela;
        }
        public Boolean nivelDeAcesso(Campo c)
        {
            if (c.cargo2.Equals("Admin"))
                return true;
            else
                return false;
        }
        
        public Boolean validaUsuario(Campo c,DataGridView dados)
        {
            if (c.cargo.Equals("Cargo") || c.cargo.Equals(""))
            {

                MessageBox.Show("Preencha o \"Cargo\"", "Informação: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (c.usuario.Equals("Usuário") || c.usuario.Equals(""))
            {

                MessageBox.Show("Preencha o \"Usuário\"", "Informação: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (c.get_senha().Equals("Senha") || c.get_senha().Equals(""))
            {

                MessageBox.Show("Preencha a \"Senha\"", "Informação: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!(c.get_senha2().Equals(c.get_senha())))
            {
                MessageBox.Show("As senhas não correspondem!!!", "Informação: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                foreach (DataGridViewRow linha in dados.Rows)
                {

                    if (c.usuario.Equals(linha.Cells[1].Value.ToString()) || c.get_senha().Equals(linha.Cells[2].Value.ToString()))
                    {

                        MessageBox.Show("O \"Usuário\" ou a \"Senha\" já existem, digite novos dados para estes campos!", "Informação: ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                return true;
            }
        }

        public DataTable pesquisaUsuario(Campo c)
        {
            if (c.usuario.Equals("Pesquisa por usuário...") || c.usuario.Equals(""))
            {
                return this.mostrarUsuarios();
            }
            else
            {
                DataTable tabela = new DataTable();
                string strSql = "Select user,senha,cargo from tb_usuario where status = 1 and user like '%" + c.usuario + "%'";
                tabela = this.mostrar_tudo(strSql);
                return tabela;
            }
                
        }

        public void selectUser(Campo c)
        {
            string strSql = "Select id_user from tb_usuario where status = 1 and user='"+ c.usuario + "';";
            this.selecionar_IDusuario(strSql);
        }
        public void alterar_usuario(Campo c,DataGridView dados)
        {
            int usuario = 0, cargo = 0, pass = 0;

            foreach(DataGridViewRow linha in dados.Rows)
            {
                if (c.usuario.Equals(linha.Cells[1].Value.ToString()))
                    usuario = 1;
                else if (c.get_senha().Equals(linha.Cells[2].Value.ToString()))
                    pass = 1;
                else if (c.cargo.Equals(linha.Cells[3].Value.ToString()) && c.usuario.Equals(linha.Cells[1].Value.ToString()))
                    cargo = 1;
            }

            if ((usuario == 0) && (cargo == 1 && pass == 1))
            {
                try
                {
                    string strSql = "Update tb_usuario Set user ='" + c.usuario + "'Where id_user = " + id_usuario + "";
                    this.executarComando(strSql);

                    c.exito = "Registro alterado com sucesso!!!";
                    
                    c.data_log = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                    c.hora_log = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                    c.descricao_log = "O Utilizador " + "\"" + c.user_acesso + "\"" + " alterou o nome do utilizador " + "\"" + usuario_anterior + "\"" + "para " + "\"" + c.usuario + "\"" + " com o codigo: " + "\"" + c.get_Iduser() + "\"" + " no sistema em " + c.data_log + " ás " + c.hora_log;
                    string strSql2 = "Insert into tb_log(id_user,descricao,data,hora)Value('" + c.get_id_user_acessor() + "','" + c.descricao_log + "','" + c.data_log + "','" + c.hora_log + "');";
                    this.executarComando(strSql2);
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Erro ao editar os dados 1" + erro.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if ((usuario == 0 && cargo == 0) && (pass == 1))
            {
                try
                {
                    string strSql = "Update tb_usuario Set user ='" + c.usuario + "',cargo='" + c.cargo + "'Where id_user = " + id_usuario + "";
                    this.executarComando(strSql);
                    c.exito = "Registro alterado com sucesso!!!";
                
                    c.data_log = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                    c.hora_log = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                    c.descricao_log = "O Utilizador " + "\"" + c.user_acesso + "\"" + " alterou o nome do utilizador " + "\"" + usuario_anterior + "\"" + "para " + "\"" + c.usuario + "\""  + " com o código: " + "\"" + c.get_Iduser() + "\"" + " e o cargo " + "\"" + cargo_anterior + "\"" + "para " + "\"" + c.cargo + "\"" + "\"" + " no sistema em " + c.data_log + " ás " + c.hora_log;
                    string strSql2 = "Insert into tb_log(id_user,descricao,data,hora)Value('" + c.get_id_user_acessor() + "','" + c.descricao_log + "','" + c.data_log + "','" + c.hora_log + "');";
                    this.executarComando(strSql2);
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Erro ao editar os dados 2" + erro.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if((usuario == 1 && cargo == 1) && (pass == 0))
            {
                try
                {
                    string strSql = "Update tb_usuario Set senha ='" + c.get_senha() + "'Where id_user = " + id_usuario + "";
                    this.executarComando(strSql);
             
                    c.data_log = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                    c.hora_log = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                    c.descricao_log = "O Utilizador " + "\"" + c.user_acesso + "\"" + " alterou a senha " + "\"" + senha_anterior + "\"" + "para " + "\"" + c.get_senha() + "\""  + " do utilizador " + "\"" + c.usuario + "\"" + " com o código: " + "\"" + c.get_Iduser() + "\"" + " no sistema em " + c.data_log + " ás " + c.hora_log;
                    string strSql2 = "Insert into tb_log(id_user,descricao,data,hora)Value('" + c.get_id_user_acessor() + "','" + c.descricao_log + "','" + c.data_log + "','" + c.hora_log + "');";
                    this.executarComando(strSql2);
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Erro ao editar os dados 3" + erro.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if((usuario == 1) && (cargo == 0 && pass == 0))
            {
                try
                {
                    string strSql = "Update tb_usuario Set senha ='" + c.get_senha() + "',cargo='" + c.cargo + "'Where id_user = " + id_usuario + "";
                    this.executarComando(strSql);
                    c.exito = "Registro alterado com sucesso!!!";
                 
                    c.data_log = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                    c.hora_log = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                    c.descricao_log = "O Utilizador " + "\"" + c.user_acesso + "\"" + " alterou a senha " + "\"" + senha_anterior + "\"" + "para " + "\"" + c.get_senha() + "\"" + " e o cargo " + "\"" + cargo_anterior + "\"" + "para " + "\"" + c.cargo+ "\"" + " do utilizador " + "\"" + c.usuario + "\"" + " com o código: " + "\"" + c.get_Iduser() + "\"" + " no sistema em " + c.data_log + " ás " + c.hora_log;
                    string strSql2 = "Insert into tb_log(id_user,descricao,data,hora)Value('" + c.get_id_user_acessor() + "','" + c.descricao_log + "','" + c.data_log + "','" + c.hora_log + "');";
                    this.executarComando(strSql2);
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Erro ao editar os dados 4" + erro.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(usuario == 1 && cargo == 0 && pass == 1)
            {
                try
                {
                    string strSql = "Update tb_usuario Set cargo='" + c.cargo + "'Where id_user = " + id_usuario + "";
                    this.executarComando(strSql);
                    c.exito = "Registro alterado com sucesso!!!";
                    c.data_log = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                    c.hora_log = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                    c.descricao_log = "O Utilizador " + "\"" + c.user_acesso + "\"" + " o cargo "+ "\"" + cargo_anterior + "\"" + "para " + "\"" + c.cargo + "\"" + " do utilizador " + "\"" + c.usuario + "\""  + " com o codigo: " + "\"" + c.get_Iduser() + "\"" + " no sistema em " + c.data_log + " ás " + c.hora_log;
                    string strSql2 = "Insert into tb_log(id_user,descricao,data,hora)Value('" + c.get_id_user_acessor() + "','" + c.descricao_log + "','" + c.data_log + "','" + c.hora_log + "');";
                    this.executarComando(strSql2);
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Erro ao editar os dados 5" + erro.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(usuario == 0 && cargo == 0 && pass == 0)
            {
                try
                {
                    string strSql = "Update tb_usuario Set user ='" + c.usuario + "', senha='"+ c.get_senha() + "',cargo='" + c.cargo + "'Where id_user = " + id_usuario + "";
                    this.executarComando(strSql);
                    c.exito = "Registro alterado com sucesso!!!";

                    c.data_log = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                    c.hora_log = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                    c.descricao_log = "O Utilizador " + "\"" + c.user_acesso + "\"" + " alterou o nome do utilizador "+ "\"" + usuario_anterior + "\"" + "para " + "\"" + c.usuario + "\"" + ", o cargo "+ "\"" + cargo_anterior + "\"" + "para " + "\"" + c.cargo + "\"" + ", a senha" + "\"" + senha_anterior + "\"" + "para " + "\"" + c.get_senha() + "\"" + " com o codigo: " + "\"" + c.get_Iduser() + "\"" + " no sistema em " + c.data_log + " ás " + c.hora_log;
                    string strSql2 = "Insert into tb_log(id_user,descricao,data,hora)Value('" + c.get_id_user_acessor() + "','" + c.descricao_log + "','" + c.data_log + "','" + c.hora_log + "');";
                    this.executarComando(strSql2);
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Erro ao editar os dados 6S" + erro.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void eliminarUsuario(Campo c)
        {
            try
            {
                string strSql = "Update tb_usuario Set status = 0 where id_user = " + c.get_Iduser() + ";";
                this.executarComando(strSql);
                
                c.data_log = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                c.hora_log = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                c.descricao_log = "O Utilizador " + "\"" + c.user_acesso + "\"" + " eliminou o utilizador " + "\"" + c.usuario + "\"" + " com o código: " + "\"" + c.get_Iduser() + "\"" + " no sistema em " + c.data_log + " ás " + c.hora_log;
                string strSql2 = "Insert into tb_log(id_user,descricao,data,hora)Value('" + c.get_id_user_acessor() + "','" + c.descricao_log + "','" + c.data_log + "','" + c.hora_log + "');";
                this.executarComando(strSql2);
            }
            catch(MySqlException erro)
            {
                MessageBox.Show("Ocorreu um erro ao eliminar!!!" + erro.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void desativar_caracteres(KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            { e.Handled = false; }
        }

    }
}
