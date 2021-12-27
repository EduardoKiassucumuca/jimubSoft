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
   public class Patrimonio
    {
        private ComandosMySql comandoMysql;
        private List<RelatorioPatrimonio> rePatrimonio;
        public Patrimonio()
        {
            this.comandoMysql = new ComandosMySql();
            this.rePatrimonio = new List<RelatorioPatrimonio>();
        }

        public void add_patrimonio(RelatorioPatrimonio dados)
        {
            this.rePatrimonio.Add(dados);
        }

        public List<RelatorioPatrimonio> get_patrimonio()
        {
            return this.rePatrimonio;
        }
        public void valida_patrimonio(Campo c)
        {
            if(c.material.Equals("Descrição/Material") || c.material.Equals(""))
            {
                c.verifica = false;
                MessageBox.Show("Preencha a \" Descrição/Material\"","Informação",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if(c.qtd.ToString().Equals("00") || c.qtd.ToString().Equals(""))
            {
                c.verifica = false;
                MessageBox.Show("Preencha a \" Qtd\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(c.comissao.Equals("Comissão") || c.comissao.Equals(""))
            {
                c.verifica = false;
                MessageBox.Show("Preencha a \" Comissão\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(c.estado_conservacao.Equals("Estado") || c.estado_conservacao.Equals(""))
            {
                c.verifica = false;
                MessageBox.Show("Preencha o \" Estado\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                c.verifica = true;
            }
        }

        public void desativar_letras(KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void inserirPatrimonio(Campo c)
        {

            try
            {
                //buscando...

                String sqlcomissao = "Select id_comissao From tb_comissao Where comissao ='" + c.comissao + "';";
                this.comandoMysql.executarSqlReaderAlternativoComissao(sqlcomissao);

                //inserindo...
                int total = c.qtd_homem + c.qtd_mulher;
                String sqlinseir = "Insert into tb_patrimonio(id_comissao,descricao,quantidade,estado)Values('" + this.comandoMysql.idComissao + "','" + c.material + "','" + c.qtd + "','" + c.estado_conservacao +"')";
                this.comandoMysql.executarComando(sqlinseir);
                c.exito = "Registro guardado com sucesso";
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message);
            }
        }

        public DataTable seleciona_patrimonio()
        {
            string str_patrimonio = "Select id_patrimonio,tb_comissao.comissao,descricao,quantidade,estado From tb_patrimonio inner join tb_comissao on tb_patrimonio.id_comissao = tb_comissao.id_comissao";
            return this.comandoMysql.mostrar_tudo(str_patrimonio);
        }

        public DataTable pesquisarComissao(Campo c)
        {
            if (c.comissao.Equals("Todas"))
                return this.seleciona_patrimonio();

            DataTable tb = new DataTable();
            string str_patrimonio = "Select id_patrimonio,tb_comissao.comissao,descricao,quantidade,estado From tb_patrimonio inner join tb_comissao on tb_patrimonio.id_comissao = tb_comissao.id_comissao Where tb_comissao.comissao='" + c.comissao + "'";
            tb = this.comandoMysql.mostrar_tudo(str_patrimonio);
            return tb;

        }
        public DataTable pesquisarEstado(Campo c)
        {
            if (c.estado_conservacao.Equals("Todos"))
                return this.seleciona_patrimonio();

            DataTable tb = new DataTable();
            string str_patrimonio = "Select id_patrimonio,tb_comissao.comissao,descricao,quantidade,estado From tb_patrimonio inner join tb_comissao on tb_patrimonio.id_comissao = tb_comissao.id_comissao Where estado='" + c.estado_conservacao + "'";
            tb = this.comandoMysql.mostrar_tudo(str_patrimonio);
            return tb;

        }
        public DataTable pesquisarMaterial(Campo c)
        {
            if (!c.material.Equals("") || !c.material.Equals("Pesquisa por material"))
            {
                DataTable tb = new DataTable();
                string sqlMaterial = "Select id_patrimonio,tb_comissao.comissao,descricao,quantidade,estado From tb_patrimonio inner join tb_comissao on tb_patrimonio.id_comissao = tb_comissao.id_comissao WHERE descricao LIKE '%" + @c.material + "%'";
                tb = this.comandoMysql.mostrar_tudo(sqlMaterial);
                return tb;
            }
            else
            {
                return this.seleciona_patrimonio();
            }
        }
        public void eliminar_patrimonio(Campo c)
        {
            string str_patrimonio = "Delete From tb_patrimonio Where id_patrimonio = " + c.get_idPatrimonio() + "";
            this.comandoMysql.executarComando(str_patrimonio);
        }

        public void altera_patrimonio(Campo c)
        {
            try
            {
                //buscando...

                String sqlcomissao = "Select id_comissao From tb_comissao Where comissao ='" + c.comissao + "';";
                this.comandoMysql.executarSqlReaderAlternativoComissao(sqlcomissao);

                //alterando...
                string sqlalterar = "Update tb_patrimonio Set id_comissao='" + this.comandoMysql.idComissao + "',descricao='" + c.material + "',quantidade='" + c.qtd + "',estado='" + c.estado_conservacao + "' Where id_patrimonio=" + c.get_idPatrimonio() + ""; 
                this.comandoMysql.executarComando(sqlalterar);
                c.exito = "Registro alterado com sucesso";
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message);
            }
        }
    }
}
