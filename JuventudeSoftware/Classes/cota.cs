using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.Classes
{
    
    class Cota:ComandosMySql
    {
       
        public void selecionarMeses(Campo c)
        {
            //string[] mes = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Octubro", "Novembro", "Dezembro" };
            //c.m = new StringBuilder();
            string selectIdNome = "Select id_membro from tb_membros where nome='" + c.nome + "'";
            this.executarSqlReaderMembro(selectIdNome);
            string selectMeses = "Select tb_mes.mes from tb_cota inner join tb_mes on tb_cota.id_mes = tb_mes.id_mes where tb_mes.id_membro =" + idMembro + "";
            this.executarSqlReaderCotas(selectMeses);
           /* if (meses.Count == 0)
            {
                    c.m.Append(" ");
 
            }
            for (int i = 0; i < mes.Length; i++)
            {
                for (int j = 0; j < meses.Count; j++)
                {

                }
            }*/
        }
        public void inserirCotas(string[] m,Campo c)
        {
            
            string sqlMembro = "Select id_membro from tb_membros where nome='" + c.nome + "'";
            this.executarSqlReaderMembro(sqlMembro);
            string sqlValores = "Select total_pago from tb_cota where id_membro='" + idMembro + "'";
            this.BuscaTotalPago(sqlValores);

            for(int i=0;i<m.Length;i++)
            {
                if(m[i]!=null)
                {
                    string sqlinsere = "Insert into tb_mes(id_membro,mes)Values('" + idMembro + "','" + m[i] + "')";
                    this.executarComando(sqlinsere);                    
                }
            }
            for (int i = 0; i < m.Length; i++)
            {

                if (m[i] != null)
                {
                    string sqlIdMes = "Select id_mes from tb_mes where mes='" + m[i] + "'and id_membro='" + idMembro + "'";
                    this.BuscaIdMeses(sqlIdMes);
                   // MessageBox.Show("OK1");
                }
            }

            totalp += c.total_apagar;
            for (int i = 0; i < idMeses.Count; i++)
            {
                //MessageBox.Show("OK2");
                if (idMeses[i].ToString() != null)
                {
                   // MessageBox.Show("OK3");
                    string sqlCotas = "Insert into tb_cota(id_membro,id_mes,total_apagar,total_pago,troco,total,data_pagamento,estadop)Values('" + idMembro + "','" + idMeses[i] + "','" + c.total_apagar + "','" + c.total_pago + "','" + c.troco + "','" + totalp + "','" + c.data_pagamento + "','" + c.estadoP + "')";
                    this.executarComando(sqlCotas);
                   // MessageBox.Show("OK4");
                }
            }
        }
        public DataTable mostrar_Cotas()
        {
           
                DataTable tabela = new DataTable();

                string sql = "Select tb_membros.nome,tb_mes.mes,total_apagar,total_pago,troco,total,DATE_FORMAT(data_pagamento,'%Y-%m-%d'),estadop,DATE_FORMAT(data_atualC,'%Y-%m-%d %h:%i')from tb_cota inner join tb_membros on tb_membros.id_membro=tb_cota.id_membro inner join tb_mes on tb_mes.id_mes = tb_cota.id_mes";
                tabela = this.mostrar_tudo(sql);
                return tabela;
         
        }
        public DataTable pesquisarCotas(Campo c)
        {
            if (c.pesquisaNome != "" || c.pesquisaNome != "Pesquisa por nome")
            {
                DataTable tb = new DataTable();
                string sql = "Select tb_membros.nome,tb_mes.mes,total_apagar,total_pago,troco,total,DATE_FORMAT(data_pagamento,'%Y-%m-%d'),estadop,DATE_FORMAT(data_atualC,'%Y-%m-%d %h:%i')from tb_cota inner join tb_membros on tb_membros.id_membro=tb_cota.id_membro inner join tb_mes on tb_mes.id_mes = tb_cota.id_mes where tb_membros.nome Like '%" + @c.pesquisaNome + "%'";
                tb = this.mostrar_tudo(sql);
                return tb;
            }
            else
            {
                return mostrar_Cotas();
            }
        }
        public void apagar_cota(Campo c)
        {
            try
            {
                string selecionarMembro = "Select id_membro from tb_membros where nome='" + c.nome + "'";
                this.executarSqlReaderMembro(selecionarMembro);
                string sqlapagarCota = "Delete from tb_cota where id_membro='" + idMembro + "'";
                this.executarComando(sqlapagarCota);
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message);
            }
        }
        public void vCota(Campo c)
        {
            try
            {
                string selecionarMembro = "Select id_membro from tb_membros where nome='" + c.nome + "'";
                this.executarSqlReaderMembro(selecionarMembro);
                string selecionarMes = "Select mes from tb_mes where id_membro='" + idMembro + "'";
                this.executarSqlReaderCotas(selecionarMes);
                
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message);
            }
        }
        public string buscarCargo(Campo c)
        {
            string selecionarid = "Select id_membro from tb_membros where nome='" + c.nome + "'";
            this.executarSqlReaderMembro(selecionarid);
            string selecionarCargo = "Select id_cargo from tb_membros where id_membro='" + idMembro + "'";
            this.executarSqlReaderAlternativoCargo(selecionarCargo);
            string selecionarCargoN = "Select cargo from tb_cargo where id_cargo='" + idCargo + "'";
            return this.buscarCargo(selecionarCargoN);
        }
         public string buscarComissao(Campo c)
        {
            string selecionarid = "Select id_membro from tb_membros where nome='" + c.nome + "'";
            this.executarSqlReaderMembro(selecionarid);
            string selecionarComissao = "Select id_comissao from tb_membros where id_membro='" + idMembro + "'";
            this.executarSqlReaderAlternativoComissao(selecionarComissao);
            string selecionarComissaoN = "Select comissao from tb_comissao where id_comissao='" + idComissao + "'";
            return this.buscarComissao(selecionarComissaoN);
          
        }
         public string buscarClasse(Campo c)
         {
             string selecionarid = "Select id_membro from tb_membros where nome='" + c.nome + "'";
             this.executarSqlReaderMembro(selecionarid);
             string selecionarClasse = "Select classe from tb_membros where id_membro='" + idMembro + "'";
            return this.buscarClasse(selecionarClasse);
         }
         public string retornaCotas(Campo c)
         {
             string selecionarMembro = "Select id_membro from tb_membros where nome='" + c.nome + "'";
             this.executarSqlReaderMembro(selecionarMembro);
             string selecionarMes = "Select mes from tb_mes where id_membro='" + idMembro + "'";
             return this.executarSqlReaderCota(selecionarMes);
         }
            
        
    }
}
