using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication1.Classes
{
   public class Actividade
    {
        private ComandosMySql comandoMysql;
        private List<RelatorioActividade> actividade;
        public Actividade()
        {
            this.comandoMysql = new ComandosMySql();
            this.actividade = new List<RelatorioActividade>();
        }
        //Validações Dos Dados
        //Inserção Dos Dados

        public void add_actividade(RelatorioActividade a)
        {
            this.actividade.Add(a);
        }

        public List<RelatorioActividade> get_actividade()
        {
            return this.actividade;
        }
        public void inserirActividade(Campo c)
        {

            try
            {
                //buscando...
               
                String sqlcomissao = "Select id_comissao From tb_comissao Where comissao ='" + c.getComissaoEncarregue() + "';";
                this.comandoMysql.executarSqlReaderAlternativoComissao(sqlcomissao);

                //inserindo...
                int total = c.qtd_homem + c.qtd_mulher;
                String sqlinseir = "Insert into tb_actividade(id_comissaoR,tema,objectivo,orador,estado,local,data_actividade,hora_actividade,qtd_homem,qtd_mulher,qtd_total)Values('" + this.comandoMysql.idComissao + "','" + c.getTema() + "','" + c.getObjectivo() + "','" + c.getOrador() + "','" + c.getEstadoActividade() + "','" + c.getLocalActividade() + "','" + c.getDatActividade() + "','" + c.gethorActividade() + "','" + c.qtd_homem + "','" + c.qtd_mulher + "','" + total +  "')";
                this.comandoMysql.executarComando(sqlinseir);
                c.exito = "Registro guardado com sucesso";
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message);
            }
        }

        public void alterarActividade(Campo c)
        {

            try
            {
                //buscando...

                String sqlcomissao = "Select id_comissao From tb_comissao Where comissao ='" + c.getComissaoEncarregue() + "';";
                this.comandoMysql.executarSqlReaderAlternativoComissao(sqlcomissao);

                //alterando...
                int total = c.qtd_homem + c.qtd_mulher;
                String sqlalterar = "Update tb_actividade Set id_comissaoR='" + this.comandoMysql.idComissao + "',tema='" + c.getTema() + "',objectivo='" + c.getObjectivo() + "',orador='" + c.getOrador() + "',estado='" + c.getEstadoActividade() + "',local='" + c.getLocalActividade() + "',data_actividade='" + c.getDatActividade() + "',hora_actividade='" + c.gethorActividade() + "',qtd_homem='" + c.qtd_homem + "',qtd_mulher='" + c.qtd_mulher + "',qtd_total='" + total + "' Where id_actividade = " + c.getID_actividade() + "";
                this.comandoMysql.executarComando(sqlalterar);
                c.exito = "Registro alterado com sucesso";
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message);
            }
        }
        public void alteraEstadoPlan(Campo c)
        {
            string strEstado = "Update tb_actividade Set estado ='Não-Realizada' Where id_actividade=" + c.getID_actividade() + "";
            this.comandoMysql.executarComando(strEstado);
            MessageBox.Show("Registro alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void alteraEstadoPlan2(Campo c)
        {
            string strEstado = "Update tb_actividade Set estado = 'Realizada',qtd_homem='" + c.qtd_homem + "',qtd_mulher = '" + c.qtd_mulher + "'Where id_actividade=" + c.getID_actividade() + "";
            this.comandoMysql.executarComando(strEstado);
            MessageBox.Show("Registro alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public DataTable selecionarActividades()
        {
           String strBusca = "Select id_actividade,tb_comissao.comissao,tema,objectivo,orador,estado,local,DATE_FORMAT(data_actividade,'%y-%m-%d'),hora_actividade,qtd_homem,qtd_mulher,qtd_total from tb_actividade inner join tb_comissao on tb_actividade.id_comissaoR = tb_comissao.id_comissao";
            return this.comandoMysql.mostrar_tudo(strBusca);
        }
        public DataTable pesquisarComissao(Campo c)
        {
            if(c.getComissaoEncarregue().Equals("Todas"))
                return this.selecionarActividades();

            DataTable tb = new DataTable();
            string strComissao = "Select id_actividade,tb_comissao.comissao,tema,objectivo,orador,estado,local,DATE_FORMAT(data_actividade,'%y-%m-%d'),hora_actividade,qtd_homem,qtd_mulher,qtd_total from tb_actividade inner join tb_comissao on tb_actividade.id_comissaoR = tb_comissao.id_comissao Where comissao='" + c.getComissaoEncarregue() + "'";
            tb = this.comandoMysql.mostrar_tudo(strComissao);
            return tb;

        }
        public DataTable pesqEstadoActividade(Campo c)
        {
            if (c.getEstadoActividade().Equals("Todos"))
                return this.selecionarActividades();

            DataTable tb = new DataTable();
            string strComissao = "Select id_actividade,tb_comissao.comissao,tema,objectivo,orador,estado,local,DATE_FORMAT(data_actividade,'%y-%m-%d'),hora_actividade,qtd_homem,qtd_mulher,qtd_total from tb_actividade inner join tb_comissao on tb_actividade.id_comissaoR = tb_comissao.id_comissao Where estado ='" + c.getEstadoActividade() + "'";
            tb = this.comandoMysql.mostrar_tudo(strComissao);
            return tb;

        }
        public void eliminarActividade(Campo c)
        {
            try
            {
                string strSql = "Delete from tb_actividade where id_actividade = " + c.getID_actividade() + ";";
                this.comandoMysql.executarComando(strSql);

            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Ocorreu um erro ao eliminar!!!" + erro.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void validaActividade(Campo campo)
        {
           if (campo.getComissaoEncarregue().Equals("Comissão encarregada da actividade") || campo.getComissaoEncarregue().Equals(""))
            {
                campo.verifica = false;
                MessageBox.Show("Preencha a \"comissão\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (campo.getOrador().Equals("Orador") || campo.getOrador().Equals(""))
            {
                campo.verifica = false;
                MessageBox.Show("Preencha o \"Orador\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (campo.getTema().Equals("Tema") || campo.getTema().Equals(""))
            {
                campo.verifica = false;
                MessageBox.Show("Preencha o \"Tema\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (campo.getEstadoActividade().Equals("Estado da actividade") || campo.getEstadoActividade().Equals(""))
            {
                campo.verifica = false;
                MessageBox.Show("Preencha o \"Estado da actividade\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (campo.getObjectivo().Equals("Objectivo...") || campo.getObjectivo().Equals(""))
            {
                campo.verifica = false;
                MessageBox.Show("Preencha o \"Objectivo\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (campo.getLocalActividade().Equals("Local da actividade") || campo.getLocalActividade().Equals(""))
            {
                campo.verifica = false;
                MessageBox.Show("Preencha o \"Local da actividade\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (campo.ano1 == DateTime.Now.Year && campo.mes1 == DateTime.Now.Month && campo.dia1 == DateTime.Now.Day)
            {
                campo.verifica = false;
                MessageBox.Show("Preencha a \"Data da actividade\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (campo.hour == 00 && campo.minute == 00)
            {
                campo.verifica = false;
                MessageBox.Show("Preencha a \"Hora da actividade\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (campo.hour > 23 || campo.minute > 59)
            {
                campo.verifica = false;
                MessageBox.Show("Erro ao digitar a \"Hora da actividade\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (campo.getEstadoActividade().Equals("Realizada"))
            {

                if (campo.ano1 > DateTime.Now.Year)
                {
                    campo.verifica = false;
                    MessageBox.Show("\"Data da actividade não permitida\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((campo.ano1 == DateTime.Now.Year) && (campo.mes1 > DateTime.Now.Month))
                {
                    campo.verifica = false;
                    MessageBox.Show("\"Data da actividade não permitida\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((campo.ano1 == DateTime.Now.Year) && (campo.mes1 == DateTime.Now.Month) && (campo.dia1 > DateTime.Now.Day))
                {
                    campo.verifica = false;
                    MessageBox.Show("\"Data da actividade não permitida\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    campo.verifica = true;
                }
            }
            else if(campo.getEstadoActividade().Equals("Planificada"))
            {

                if (campo.ano1 < DateTime.Now.Year)
                {
                    campo.verifica = false;
                    MessageBox.Show("\"Data da actividade não permitida\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((campo.ano1 == DateTime.Now.Year) && (campo.mes1 < DateTime.Now.Month))
                {
                    campo.verifica = false;
                    MessageBox.Show("\"Data da actividade não permitida\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((campo.ano1 == DateTime.Now.Year) && (campo.mes1 == DateTime.Now.Month) && (campo.dia1 < DateTime.Now.Day))
                {
                    campo.verifica = false;
                    MessageBox.Show("\"Data da actividade não permitida\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    campo.verifica = true;
                }
            }
            else
            {
                campo.verifica = true;
            }

            }
        }
    }

