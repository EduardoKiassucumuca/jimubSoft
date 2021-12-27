using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
    class SMS
    {
        ComandosMySql comandoSql = new ComandosMySql();
        public DataTable dadosSMS()
        {
            DataTable tabela = new DataTable();
            string str = "Select id_membro,nome,alcunha,telefone1 From tb_membros";
            tabela = comandoSql.mostrar_tudo(str);
            return tabela;
        }

        public DataTable pesquisaPersonalisada(Campo c)
        {
            DataTable tb = new DataTable();

            if(c.pesqPersonalisada.Equals("Base"))
            {
                
                string strBase = "Select id_membro,nome,alcunha,telefone1 From tb_membros inner join tb_cargo on tb_membros.id_cargo = tb_cargo.id_cargo Where cargo = 'Base'";
                tb = comandoSql.mostrar_tudo(strBase);
                return tb;
            }
            else if (c.pesqPersonalisada.Equals("Corpo directivo"))
            {
               
                string strCD = "Select id_membro,nome,alcunha,telefone1 From tb_membros inner join tb_cargo on tb_membros.id_cargo = tb_cargo.id_cargo Where cargo != 'Base'";
                tb = comandoSql.mostrar_tudo(strCD);
                return tb;
            }
            else if (c.pesqPersonalisada.Equals("Adolescentes"))
            {
                string sqlAdolescente = "Select id_membro,nome,alcunha,telefone1 From tb_membros WHERE idade BETWEEN 12 and 17 ORDER BY id_membro ASC";
                tb = comandoSql.mostrar_tudo(sqlAdolescente);
                return tb;
            }
            else if (c.pesqPersonalisada.Equals("Jovens"))
            {
                string sqlJovem = "Select id_membro,nome,alcunha,telefone1 From tb_membros WHERE idade BETWEEN 18 and 25 ORDER BY id_membro ASC";
                tb = comandoSql.mostrar_tudo(sqlJovem);
                return tb;
            }
            else if (c.pesqPersonalisada.Equals("Masculino"))
            {

                string strMasc = "Select id_membro,nome,alcunha,telefone1 From tb_membros Where sexo = 'Masculino'";
                tb = comandoSql.mostrar_tudo(strMasc);
                return tb;
            }
            else if (c.pesqPersonalisada.Equals("Feminino"))
            {

                string strFem = "Select id_membro,nome,alcunha,telefone1 From tb_membros Where sexo = 'Feminino'";
                tb = comandoSql.mostrar_tudo(strFem);
                return tb;
            }
            else if (c.pesqPersonalisada.Equals("Catecumeno"))
            {

                string strCatecumeno = "Select id_membro,nome,alcunha,telefone1 From tb_membros Where cat_membro = 'Catecumeno'";
                tb = comandoSql.mostrar_tudo(strCatecumeno);
                return tb;
            }
            else if (c.pesqPersonalisada.Equals("Aprova"))
            {

                string strAprova = "Select id_membro,nome,alcunha,telefone1 From tb_membros Where cat_membro = 'Aprova'";
                tb = comandoSql.mostrar_tudo(strAprova);
                return tb;
            }
            else if (c.pesqPersonalisada.Equals("Efectivo"))
            {

                string strEfectivo = "Select id_membro,nome,alcunha,telefone1 From tb_membros Where cat_membro = 'Efectivo'";
                tb = comandoSql.mostrar_tudo(strEfectivo);
                return tb;
            }
            else if (c.pesqPersonalisada.Equals("Coral dos Adolescentes"))
            {

                string strAdolescente = "Select id_membro,nome,alcunha,telefone1 From tb_membros Where grupo = 'Coral Dos Adolescentes'";
                tb = comandoSql.mostrar_tudo(strAdolescente);
                return tb;
            }
            else if (c.pesqPersonalisada.Equals("Tudizole"))
            {

                string strTudizole = "Select id_membro,nome,alcunha,telefone1 From tb_membros Where grupo = 'Tudizole'";
                tb = comandoSql.mostrar_tudo(strTudizole);
                return tb;
            }
            else
            {
                return dadosSMS();
            }
        }
        public DataTable pesquisarBairro(Campo c)
        {
            if (c.pesquisaBairro != "" || c.pesquisaBairro != "Pesquisa por bairro")
            {
                DataTable tb = new DataTable();
                string sqlBairro = "Select id_membro,nome,alcunha,telefone1 From tb_membros inner join tb_morada on tb_membros.id_morada = tb_morada.id_morada WHERE bairro LIKE   '%" + @c.pesquisaBairro + "%'";
                tb = comandoSql.mostrar_tudo(sqlBairro);
                return tb;
            }
            else
            {
                return dadosSMS();
            }
        }
        public DataTable pesquisarComissao(Campo c)
        {
            DataTable tb = new DataTable();
            string strComissao = "Select id_membro,nome,alcunha,telefone1 From tb_membros inner join tb_comissao on tb_membros.id_comissao = tb_comissao.id_comissao Where comissao='" + c.comissao + "'";
            tb = comandoSql.mostrar_tudo(strComissao);
            return tb;

        }
        public DataTable pesquisarClasse(Campo c)
        {
            DataTable tb = new DataTable();
            string strClasse = "Select id_membro,nome,alcunha,telefone1 From tb_membros Where classe='" + c.classe + "'";
            tb = comandoSql.mostrar_tudo(strClasse);
            return tb;

        }
    }
}
