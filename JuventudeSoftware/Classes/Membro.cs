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
    public class Membro:ComandosMySql
    {
        private List<RelatorioMembro> dados_report;
        private List<Estatistica> estatistica;

        public Membro()
        {
            this.dados_report = new List<RelatorioMembro>();
            this.estatistica = new List<Estatistica>();
        }

        public void addOutrosDados(Estatistica dados)
        {
            this.estatistica.Add(dados);
        }

        public List<Estatistica> getOutrosDados()
        {
            return this.estatistica;
        }
        public void addDados(RelatorioMembro dados)
        {
            this.dados_report.Add(dados);
        }

        public List<RelatorioMembro> getDados()
        {
            return this.dados_report;
        }

        public void inserir(Campo c)
        {

            try
            {             
                /*string selecionarFiliacao = "Select id_filiacao,pai,mae from tb_filiacao";
                this.executarfiliacao(selecionarFiliacao,c);

               string strMorada = "Select * From tb_morada where bairro='" + c.bairro + "'and descricao_casa='" + c.descricao + "' and rua='" + c.rua + "'";
                this.executarSqlReaderMorada(strMorada, c);
                string AlteraMorada = "Update tb_morada Set bairro='" + c.bairro + "',rua='" + c.rua + "',descricao_casa='" + c.descricao + "' Where id_morada =" + idMorada + "";
                this.executarComando(AlteraMorada);*/
           
                    string comandoSqlMorada = "Insert into tb_morada(bairro,rua,descricao_casa)Values('" + c.bairro + "','" + c.rua + "','" + c.descricao + "')";
                    this.executarComando(comandoSqlMorada);
                    string comandoSqlFiliacao = "Insert into tb_filiacao(pai,mae)Values('" + c.pai + "','" + c.mae + "')";
                    this.executarComando(comandoSqlFiliacao);

                string select_morada = "Select Max(id_morada) as id_morada from tb_morada;";
                this.executarSqlReaderAlternativoMorada(select_morada);
                string select_filiacao = "Select Max(id_filiacao) as id_filiacao from tb_filiacao;";
                this.executarSqlfiliacao(select_filiacao);

                //buscando e inserindo...

                string selecionarCargo = "Select id_cargo from tb_cargo where cargo='" + c.cargo + "'";
                this.executarSqlReaderAlternativoCargo(selecionarCargo);
                string selecionarComissao = "Select id_comissao from tb_comissao where comissao='" + c.comissao + "'";
                this.executarSqlReaderAlternativoComissao(selecionarComissao);


                string inserirMembros = "Insert Into tb_membros(nome,alcunha,telefone1,telefone2,idade,sexo,id_morada,estado_civil,BI_Cedula,id_filiacao,email,facebook,areaFormacao,nivelEscolar,escola,ramo,profissao,id_cargo,id_comissao,grupo,data_nascimento,cat_membro,classe,imagem,data_emissao,como_ingressou,presenca,motivo,igreja_Anterior,funcaoA_Exercer,descricao_Organizacao,estado)Values('" + c.nome + "','" + c.alcunha + "','" + c.telefone1 + "','" + c.telefone2 + "','" + c.idade + "','" + c.sexo + "','" + idMorada + "','" + c.estado_civil + "','" + c.bi_cedula + "','" + idFiliacao + "','" + c.email + "','" + c.facebook + "','" + c.areaFormacao + "','" + c.nivelEscolar + "','" + c.escola + "','" + c.ramo + "','" + c.profissao + "','" + idCargo + "','" + idComissao + "','" + c.grupo + "','" + c.data_nascimento + "','" + c.cat_membro + "','" + c.classe + "','" + c.img + "','" + c.data_ingresso + "','" + c.como_ingressou + "','" + c.presenca + "','" + c.motivo_ausencia + "','" + c.igrejAnterior + "','" + c.opfuncaoFuturo + "','" + c.sobreJuventude + "','" + c.estado + "')";
                this.executarComando(inserirMembros);
                c.exito = "O " + c.nome + " foi inserido com sucesso";
               
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message); 
            }

        }
        public DataTable mostrar_membros()
        {
            DataTable tabela = new DataTable();
           
            string sql = "Select nome,alcunha,telefone1,telefone2,idade,sexo,tb_morada.bairro,tb_morada.rua,tb_morada.descricao_casa,estado_civil,BI_Cedula,tb_filiacao.pai,tb_filiacao.mae,email,facebook,areaFormacao,nivelEscolar,escola,profissao,tb_cargo.cargo,tb_comissao.comissao,grupo,DATE_FORMAT(data_nascimento,'%d/%m/%Y'),cat_membro,classe,data_emissao,como_ingressou,presenca,motivo,igreja_Anterior,FuncaoA_Exercer,descricao_Organizacao,estado,DATE_FORMAT(data_atual,'%Y-%m-%d %h:%i') From tb_membros INNER JOIN tb_filiacao on tb_membros.id_filiacao = tb_filiacao.id_filiacao INNER JOIN tb_morada on tb_membros.id_morada = tb_morada.id_morada INNER JOIN tb_cargo on tb_membros.id_cargo = tb_cargo.id_cargo INNER JOIN tb_comissao on tb_membros.id_comissao = tb_comissao.id_comissao Where tb_membros.status=1 ORDER BY nome ASC";
            tabela = this.mostrar_tudo(sql);
            return tabela;

        }
        public DataTable pesquisarFase(Campo c)
        {
            DataTable tb = new DataTable();
            if (c.pesquisaFase == "Adolescentes")
            {
                string sqlAdolescente = "Select nome,alcunha,telefone1,telefone2,idade,sexo,tb_morada.bairro,tb_morada.rua,tb_morada.descricao_casa,estado_civil,BI_Cedula,tb_filiacao.pai,tb_filiacao.mae,email,facebook,areaFormacao,nivelEscolar,escola,profissao,tb_cargo.cargo,tb_comissao.comissao,grupo,DATE_FORMAT(data_nascimento,'%d/%m/%Y'),cat_membro,classe,data_emissao,como_ingressou,presenca,motivo,igreja_Anterior,FuncaoA_Exercer,descricao_Organizacao,estado,DATE_FORMAT(data_atual,'%Y-%m-%d %h:%i') From tb_membros INNER JOIN tb_filiacao on tb_membros.id_filiacao = tb_filiacao.id_filiacao INNER JOIN tb_morada on tb_membros.id_morada = tb_morada.id_morada INNER JOIN tb_cargo on tb_membros.id_cargo = tb_cargo.id_cargo INNER JOIN tb_comissao on tb_membros.id_comissao = tb_comissao.id_comissao WHERE idade BETWEEN 12 and 17 ORDER BY nome ASC";
                tb = this.mostrar_tudo(sqlAdolescente);
                return tb;
            }
            else if (c.pesquisaFase == "Jovens")
            {
                string sqlJovem = "Select nome,alcunha,telefone1,telefone2,idade,sexo,tb_morada.bairro,tb_morada.rua,tb_morada.descricao_casa,estado_civil,BI_Cedula,tb_filiacao.pai,tb_filiacao.mae,email,facebook,areaFormacao,nivelEscolar,escola,profissao,tb_cargo.cargo,tb_comissao.comissao,grupo,DATE_FORMAT(data_nascimento,'%d/%m/%Y'),cat_membro,classe,data_emissao,como_ingressou, presenca,motivo,igreja_Anterior,FuncaoA_Exercer,descricao_Organizacao,estado,DATE_FORMAT(data_atual,'%Y-%m-%d %h:%i') From tb_membros INNER JOIN tb_filiacao on tb_membros.id_filiacao = tb_filiacao.id_filiacao INNER JOIN tb_morada on tb_membros.id_morada = tb_morada.id_morada INNER JOIN tb_cargo on tb_membros.id_cargo = tb_cargo.id_cargo INNER JOIN tb_comissao on tb_membros.id_comissao = tb_comissao.id_comissao WHERE idade BETWEEN 18 and 25 ORDER BY nome ASC";
                tb = this.mostrar_tudo(sqlJovem);
                return tb;
            }
            else
            {
                return mostrar_membros();
            }
        }
        public DataTable pesquisarNome(Campo c)
        {
            if (c.pesquisaNome != "" || c.pesquisaNome != "Pesquisa por nome")
            {
                DataTable tb = new DataTable();
                string sqlNome = "Select nome,alcunha,telefone1,telefone2,idade,sexo,tb_morada.bairro,tb_morada.rua,tb_morada.descricao_casa,estado_civil,BI_Cedula,tb_filiacao.pai,tb_filiacao.mae,email,facebook,areaFormacao,nivelEscolar,escola,profissao,tb_cargo.cargo,tb_comissao.comissao,grupo,DATE_FORMAT(data_nascimento,'%d/%m/%Y'),cat_membro,classe,data_emissao,como_ingressou, presenca,motivo,igreja_Anterior,FuncaoA_Exercer,descricao_Organizacao,estado,DATE_FORMAT(data_atual,'%Y-%m-%d %h:%i') From tb_membros INNER JOIN tb_filiacao on tb_membros.id_filiacao = tb_filiacao.id_filiacao INNER JOIN tb_morada on tb_membros.id_morada = tb_morada.id_morada INNER JOIN tb_cargo on tb_membros.id_cargo = tb_cargo.id_cargo INNER JOIN tb_comissao on tb_membros.id_comissao = tb_comissao.id_comissao WHERE nome LIKE '%" + @c.pesquisaNome + "%'";
                tb = this.mostrar_tudo(sqlNome);
                return tb;
            }
            else
            {
                return mostrar_membros();
            }
        }
        
        public DataTable pesquisarBairro(Campo c)
        {
            if (c.pesquisaBairro != "" || c.pesquisaBairro != "Pesquisa por bairro")
            {
                DataTable tb = new DataTable();
                string sqlBairro = "Select nome,alcunha,telefone1,telefone2,idade,sexo,tb_morada.bairro,tb_morada.rua,tb_morada.descricao_casa,estado_civil,BI_Cedula,tb_filiacao.pai,tb_filiacao.mae,email,facebook,areaFormacao,nivelEscolar,escola,profissao,tb_cargo.cargo,tb_comissao.comissao,grupo,DATE_FORMAT(data_nascimento,'%d/%m/%Y'),cat_membro,classe,data_emissao,como_ingressou, presenca,motivo,igreja_Anterior,FuncaoA_Exercer,descricao_Organizacao,estado,DATE_FORMAT(data_atual,'%Y-%m-%d %h:%i') From tb_membros INNER JOIN tb_filiacao on tb_membros.id_filiacao = tb_filiacao.id_filiacao INNER JOIN tb_morada on tb_membros.id_morada = tb_morada.id_morada INNER JOIN tb_cargo on tb_membros.id_cargo = tb_cargo.id_cargo INNER JOIN tb_comissao on tb_membros.id_comissao = tb_comissao.id_comissao WHERE bairro LIKE   '%" + @c.pesquisaBairro + "%'";
                tb = this.mostrar_tudo(sqlBairro);
                return tb;
            }
            else
            {
                return mostrar_membros();
            }
        }

        public void apagar_membro(Campo c)
        {
            try
            {
                /*string selecionarMorada = "Select id_morada from tb_morada where bairro='" + c.bairro + "'";
                this.executarSqlReaderAlternativoMorada(selecionarMorada);
                string selecionarCargo = "Select id_cargo from tb_cargo where cargo='" + c.cargo + "'";
                this.executarSqlReaderAlternativoCargo(selecionarCargo);
                string selecionarComissao = "Select id_comissao from tb_comissao where comissao='" + c.comissao + "'";
                this.executarSqlReaderAlternativoComissao(selecionarComissao);

                string sqlapagarMorada = "Delete from tb_morada where id_morada='" + idMorada + "'";
                this.executarComando(sqlapagarMorada);
                string sqlapagarCargo = "Delete from tb_cargo where id_cargo='" + idCargo + "'";
                this.executarComando(sqlapagarCargo);
                string sqlapagarComissao = "Delete from tb_comissao where id_comissao='" + idComissao + "'";
                this.executarComando(sqlapagarComissao);*/
                string sqlapagarMembro = "Delete from tb_membros where nome='" + c.nome + "'";
                this.executarComando(sqlapagarMembro);
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: " + erro.Message);
            }
        }

        public string RetornarImagem(Campo c)
        {
            string sqlFoto = "Select imagem from tb_membros where nome='" + c.nome + "'";
            return this.executarComandoSqlFoto(sqlFoto);
        }
      /*  public string RetornarData(campos c)
        {
            string sqlData = "Select data_nascimento from tb_membros where nome='" + c.nome + "'";
            return this.executarComandoSqlData(sqlData);
        }*/
        
         public void Selecionar_Campos(Campo c)
        {
            try
            {
                
                string selecionarMorada = "Select tb_morada.id_morada from tb_morada inner join tb_membros on tb_morada.id_morada = tb_membros.id_morada where bairro='" + c.bairro + "';";
                this.executarSqlReaderAlternativoMorada(selecionarMorada);
               
                string selecionarFiliacao = "Select tb_filiacao.id_filiacao from tb_filiacao inner join tb_membros on tb_filiacao.id_filiacao = tb_membros.id_filiacao where pai='" + c.pai + "';";
                this.executarSqlfiliacao(selecionarFiliacao);
              
                string sqlMembro = "Select id_membro from tb_membros where nome='" + c.nome + "';";
                this.executarSqlReaderMembro(sqlMembro);
              
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: 1" + erro.Message);
            }
        }
        public void alterar_membro(Campo c)
        {
            try
            {
               
                string AlteraMorada = "Update tb_morada Set bairro='" + c.bairro + "',rua='" + c.rua + "',descricao_casa='" + c.descricao + "' Where id_morada =" + idMorada + "";
                this.executarComando(AlteraMorada);
                
                string selecionarCargo = "Select id_cargo from tb_cargo where cargo='" + c.cargo + "';";
                this.executarSqlReaderAlternativoCargo(selecionarCargo);
               
                string selecionarComissao = "Select id_comissao from tb_comissao where comissao='" + c.comissao + "';";
                this.executarSqlReaderAlternativoComissao(selecionarComissao);
              
                string strFiliacao = "Update tb_filiacao Set pai='" + c.pai + "',mae='" + c.mae + "' Where id_filiacao = " + idFiliacao + ";";
                this.executarComando(strFiliacao);
                
                string AlteraMembro = "UPDATE tb_membros set nome='" + c.nome + "',alcunha='" + c.alcunha + "',telefone1='" + c.telefone1 + "',telefone2='" + c.telefone2 + "',idade='" + c.idade + "',sexo='" + c.sexo + "',estado_civil='" + c.estado_civil + "',BI_Cedula='" + c.bi_cedula + "',email='" + c.email + "',facebook='" + c.facebook + "',areaFormacao='" + c.areaFormacao + "',nivelEscolar='" + c.nivelEscolar + "',escola='" + c.escola + "',profissao='" + c.profissao + "',id_cargo='" + idCargo + "',id_comissao='" + idComissao + "',grupo='" + c.grupo + "',data_nascimento='" + c.data_nascimento + "',cat_membro='" + c.cat_membro + "',classe='" + c.classe + "',imagem='" + c.img + "',data_emissao='" + c.data_ingresso + "',igreja_Anterior='" + c.igrejAnterior + "',funcaoA_Exercer='" + c.opfuncaoFuturo + "',descricao_Organizacao='" + c.sobreJuventude + "',estado='" + c.estado + "' where id_membro =" + idMembro + ";";
                this.executarComando(AlteraMembro);
                c.exito = "Registro alterado com sucesso";
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Error: Ocorreu um erro ao editar!!!" + erro.Message);
            }
        }

        public int totalMembrosMascReal()
        {
            string Sqltotal = "select count(*) from tb_membros where sexo = 'Masculino' and presenca in('Presente','Regular')";
            return this.QTD(Sqltotal);
        }
       
        public int totalMembrosFemReal()
        {
            string Sqltotal = "select count(*) from tb_membros where sexo = 'Feminino' and presenca in('Presente','Regular')";
            return this.QTD(Sqltotal);
        }
        public int totalMembrosReal()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca in('Presente','Regular')";
            return this.QTD(Sqltotal);
        }
        public int totalMembrosFemFisico()
        {
            string Sqltotal = "select count(*) from tb_membros where sexo = 'Feminino' and presenca in('Presente','Regular','Irregular','Ausente','Desaparecido','Afastou-se')";
            return this.QTD(Sqltotal);
        }
        public int totalMembrosMascFisico()
        {
            string Sqltotal = "select count(*) from tb_membros where sexo = 'Masculino' and presenca in('Presente','Regular','Irregular','Ausente','Desaparecido','Afastou-se')";
            return this.QTD(Sqltotal);
        }
        public int totalMembrosFisico()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca in('Presente','Regular','Irregular','Ausente','Desaparecido','Afastou-se')";
            return this.QTD(Sqltotal);
        }

        public int totaljovensMascVindosDaClasseInfantil()
        {
            string Sqltotal = "select count(*) from tb_membros where como_ingressou = 'Vindo da classe infantil' and sexo = 'Masculino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensFemVindosDaClasseInfantil()
        {
            string Sqltotal = "select count(*) from tb_membros where como_ingressou = 'Vindo da classe infantil' and sexo = 'Feminino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensVindosDaClasseInfantil()
        {
            string Sqltotal = "select count(*) from tb_membros where como_ingressou = 'Vindo da classe infantil';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensMascEvangelizado()
        {
            string Sqltotal = "select count(*) from tb_membros where como_ingressou = 'Evangelizado' and sexo = 'Masculino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensFemEvangelizado()
        {
            string Sqltotal = "select count(*) from tb_membros where como_ingressou = 'Evangelizado' and sexo = 'Feminino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensEvangelizado()
        {
            string Sqltotal = "select count(*) from tb_membros where como_ingressou = 'Evangelizado';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensMascVindoVoluntariamente()
        {
            string Sqltotal = "select count(*) from tb_membros where como_ingressou = 'Voluntariamente' and sexo = 'Masculino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensFemVindoVoluntariamente()
        {
            string Sqltotal = "select count(*) from tb_membros where como_ingressou = 'Voluntariamente' and sexo = 'Feminino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensVindoVoluntariamente()
        {
            string Sqltotal = "select count(*) from tb_membros where como_ingressou = 'Voluntariamente';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensMascEncaminhadoOja()
        {
            string Sqltotal = "select count(*) from tb_membros where estado = 'Encaminhado a oja' and sexo = 'Masculino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensFemEncaminhadoOja()
        {
            string Sqltotal = "select count(*) from tb_membros where estado = 'Encaminhado a oja' and sexo = 'Feminino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensEncaminhadoOja()
        {
            string Sqltotal = "select count(*) from tb_membros where estado = 'Encaminhado a oja';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensMascAfastaram()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca = 'Afastou-se' and sexo = 'Masculino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensFemAfastaram()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca = 'Afastou-se' and sexo = 'Feminino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensAfastaram()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca = 'Afastou-se';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensMascFalecidos()
        {
            string Sqltotal = "select count(*) from tb_membros where estado = 'Falcido' and sexo = 'Masculino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensFemFalecidos()
        {
            string Sqltotal = "select count(*) from tb_membros where estado = 'Falcido' and sexo = 'Feminino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensFalecidos()
        {
            string SqlTOtal = "select count(*) from tb_membros where estado ='Falcido'";
            return this.QTD(SqlTOtal);
        }

        public int totaljovensMascAusentesRazaoTrabalho()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca = 'Ausente' and motivo in('Estudo','Trabalho') and sexo = 'Masculino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensFemAusentesRazaoTrabalho()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca = 'Ausente' and motivo in('Estudo','Trabalho') and sexo = 'Feminino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensAusentesRazaoTrabalho()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca = 'Ausente' and motivo in('Estudo','Trabalho');";
            return this.QTD(Sqltotal);
        }

        public int totaljovensMascAusentesRazaoSaude()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca = 'Ausente' and (motivo = 'Saúde') and sexo = 'Masculino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensFemAusentesRazaoSaude()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca = 'Ausente' and (motivo = 'Saúde') and sexo = 'Feminino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensAusentesRazaoSaude()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca = 'Ausente' and (motivo = 'Saúde');";
            return this.QTD(Sqltotal);
        }

        public int totaljovensMascAusentesRazaoDisciplinares()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca = 'Ausente' and (motivo = 'Disciplinares') and sexo = 'Masculino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensFemAusentesRazaoDisciplinares()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca = 'Ausente' and (motivo = 'Disciplinares') and sexo = 'Feminino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensAusentesRazaoDisciplinares()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca = 'Ausente' and (motivo = 'Disciplinares');";
            return this.QTD(Sqltotal);
        }

        public int totaljovensMascAusentesRazaoDesconhecidas()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca = 'Ausente' and (motivo = 'Desconhecido') and sexo = 'Masculino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensFemAusentesRazaoDesconhecidas()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca = 'Ausente' and (motivo = 'Desconhecido') and sexo = 'Feminino';";
            return this.QTD(Sqltotal);
        }

        public int totaljovensAusentesRazaoDesconhecidas()
        {
            string Sqltotal = "select count(*) from tb_membros where presenca = 'Ausente' and (motivo = 'Desconhecido');";
            return this.QTD(Sqltotal);
        }
        public int totalMembros()
        {
            string Sqltotal = "select count(*) from tb_membros";  
 
            return this.QTD(Sqltotal);
        }

        public int totalAdolescentesMasc()
        {
            string Sqltotal = "select count(*) from tb_membros where idade between '12' and '17' and sexo = 'Masculino'";

            return this.QTD(Sqltotal);
        }

        public int totalAdolescentesFem()
        {
            string Sqltotal = "select count(*) from tb_membros where idade between '12' and '17' and sexo = 'Feminino'";

            return this.QTD(Sqltotal);
        }

        public int totalAdolescentes()
        {
            string Sqltotal = "select count(*) from tb_membros where idade between '12' and '17'";

            return this.QTD(Sqltotal);
        }

        public int totalJovensMasc()
        {
            string SqlTOtal = "select count(*) from tb_membros where idade between '18' and '25' and sexo = 'Masculino'";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensFem()
        {
            string SqlTOtal = "select count(*) from tb_membros where idade between '18' and '25' and sexo = 'Feminino'";
            return this.QTD(SqlTOtal);
        }

        public int totalJovens()
        {
            string SqlTOtal = "select count(*) from tb_membros where idade between '18' and '25'";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensEAdolescentes()
        {
            string SqlTOtal = "SELECT count(*) from tb_membros where idade in(12,13,14,15,16,17,18,19,20,21,22,23,24,25);";
            return this.QTD(SqlTOtal);
        }
        public int totalHomens()
        {
            string SqlTOtal = "select count(*) from tb_membros where sexo ='Masculino'";
            return this.QTD(SqlTOtal);
        }
        public int totalMulheres()
        {
            string SqlTOtal = "select count(*) from tb_membros where sexo ='Feminino'";
            return this.QTD(SqlTOtal);
        }
        public int totalSolteiro()
        {
            string SqlTOtal = "select count(*) from tb_membros where estado_civil in('Solteiro','Solteira')";
            return this.QTD(SqlTOtal);
        }
        public int totalMascSolteiro()
        {
            string SqlTOtal = "select count(*) from tb_membros where sexo = 'Masculino' and estado_civil ='Solteiro';";
            return this.QTD(SqlTOtal);
        }
        public int totalFemSolteiro()
        {
            string SqlTOtal = "select count(*) from tb_membros where sexo = 'Feminino' and estado_civil ='Solteira';";
            return this.QTD(SqlTOtal);
        }

        public int totalFemCasada()
        {
            string SqlTOtal = "select count(*) from tb_membros where sexo = 'Feminino' and estado_civil ='Casada';";
            return this.QTD(SqlTOtal);
        }

        public int totalMascCasado()
        {
            string SqlTOtal = "select count(*) from tb_membros where sexo = 'Masculino' and estado_civil ='Casado';";
            return this.QTD(SqlTOtal);
        }

        public int totalCasados()
        {
            string SqlTOtal = "select count(*) from tb_membros where estado_civil in('Casado','Casada');";
            return this.QTD(SqlTOtal);
        }

        public int totalCasadosEsolteiros()
        {
            string SqlTOtal = "select count(*) from tb_membros where estado_civil in('Casado','Casada','Solteiro','Solteira');";
            return this.QTD(SqlTOtal);
        }
        public int totalDivorciado()
        {
            string SqlTOtal = "select count(*) from tb_membros where estado_civil ='Divorciado'";
            return this.QTD(SqlTOtal);
        }
        public int totalViuvo()
        {
            string SqlTOtal = "select count(*) from tb_membros where estado_civil ='Viúvo'";
            return this.QTD(SqlTOtal);
        }
        public int totalBase()
        {
            string SqlTOtal = "select count(*) from tb_cargo  where cargo ='Base'";
            return this.QTD(SqlTOtal);
        }
        public int totalCD()
        {
            string SqlTOtal = "select count(*) from tb_cargo where cargo !='Base'";
            return this.QTD(SqlTOtal);
        }
        public int totalTudizole()
        {
            string SqlTOtal = "select count(*) from tb_membros where grupo ='Tudizole'";
            return this.QTD(SqlTOtal);
        }
        public int totalCoral()
        {
            string SqlTOtal = "select count(*) from tb_membros where grupo ='Coral Dos Adolescentes'";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensCatecumenoMasc()
        {
            string SqlTOtal = "select count(*) from tb_membros where cat_membro ='Catecumeno' and sexo = 'Masculino'";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensCatecumenoFem()
        {
            string SqlTOtal = "select count(*) from tb_membros where cat_membro ='Catecumeno' and sexo = 'Feminino'";
            return this.QTD(SqlTOtal);
        }
        public int totalJovensCatecumeno()
        {
            string SqlTOtal = "select count(*) from tb_membros where cat_membro ='Catecumeno'";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensAprovaMasc()
        {
            string SqlTOtal = "select count(*) from tb_membros where cat_membro ='Aprova' and sexo = 'Masculino'";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensAprovaFem()
        {
            string SqlTOtal = "select count(*) from tb_membros where cat_membro ='Aprova' and sexo = 'Feminino'";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensAprova()
        {
            string SqlTOtal = "select count(*) from tb_membros where cat_membro ='Aprova'";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensEfectivoMasc()
        {
            string SqlTOtal = "select count(*) from tb_membros where cat_membro ='Efectivo' and sexo = 'Masculino'";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensEfectivoFem()
        {
            string SqlTOtal = "select count(*) from tb_membros where cat_membro ='Efectivo' and sexo = 'Feminino'";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensEfectivo()
        {
            string SqlTOtal = "select count(*) from tb_membros where cat_membro ='Efectivo'";
            return this.QTD(SqlTOtal);
        }
        public int totalJovensCategoria_membros()
        {
            string SqlTOtal = "SELECT count(*) from tb_membros where cat_membro in('Catecumeno','Aprova','Efectivo');";
            return this.QTD(SqlTOtal);
        }
        public int totalJovensMascEnsinoPrimario()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Masculino' and nivelEscolar = 'Ensino Primário';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensFemEnsinoPrimario()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Feminino' and nivelEscolar = 'Ensino Primário';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensEnsinoPrimario()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE nivelEscolar = 'Ensino Primário';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensMascEnsinoSecundario()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Masculino' and nivelEscolar = 'Ensino Secundário';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensFemEnsinoSecundario()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Feminino' and nivelEscolar = 'Ensino Secundário';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensEnsinoSecundario()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE nivelEscolar = 'Ensino Secundário';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensMascEnsinoMedio()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Masculino' and nivelEscolar = 'Ensino Médio';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensFemEnsinoMedio()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Feminino' and nivelEscolar = 'Ensino Médio';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensEnsinoMedio()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE nivelEscolar = 'Ensino Médio';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensMascEnsinoSuperior()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Masculino' and nivelEscolar = 'Ensino Superior';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensFemEnsinoSuperior()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Feminino' and nivelEscolar = 'Ensino Superior';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensEnsinoSuperior()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE nivelEscolar = 'Ensino Superior';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensMascLicenciatura()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Masculino' and nivelEscolar = 'Licenciatura';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensFemLicenciatura()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Feminino' and nivelEscolar = 'Licenciatura';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensLicenciatura()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE nivelEscolar = 'Licenciatura';";
            return this.QTD(SqlTOtal);
        }

       

        public int totalJovensGrauEscolaridade()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE nivelEscolar in('Ensino Primário','Ensino Secundário','Ensino Médio','Ensino Superior','Licenciatura')";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensFuncionario()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE ramo = 'Funcionário';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensFemFuncionario()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Feminino' and ramo = 'Funcionário';";
            return this.QTD(SqlTOtal);
        }
        public int totalJovensMascFuncionario()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Masculino' and ramo = 'Funcionário';";
            return this.QTD(SqlTOtal);
        }
        public int totalJovensMascEducacao()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Masculino' and ramo = 'Educação';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensFemEducacao()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Masculino' and ramo = 'Educação';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensRamoEducacao()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE ramo = 'Educação';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensMascRamoSaude()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Masculino' and ramo = 'Saúde';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensFemRamoSaude()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Feminino' and ramo = 'Saúde';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensRamoSaude()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE ramo = 'Saúde';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensMascServicoMilitar()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Masculino' and ramo = 'Militar/Policia';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensFemServicoMilitar()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Feminino' and ramo = 'Militar/Policia';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensServicoMilitar()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE ramo = 'Militar/Policia';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensMascSomenteEstudante()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Masculino' and ramo = 'Nenhum';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensFemEstudante()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Feminino' and ramo = 'Nenhum';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovenSomenteEstudante()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE ramo = 'Nenhum';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensServicoReligioso()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE ramo = 'Religioso';";
            return this.QTD(SqlTOtal);
        }
        public int totalJovensMascServicoReligioso()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Masculino' and ramo = 'Religioso';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensFemServicoReligioso()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Feminino' and ramo = 'Religioso';";
            return this.QTD(SqlTOtal);
        }

        public int totalJovensFemRamoComercio()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Feminino' and ramo = 'Comércio';";
            return this.QTD(SqlTOtal);
        }
        public int totalJovensMascRamoComercio()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE sexo = 'Masculino' and ramo = 'Comércio';";
            return this.QTD(SqlTOtal);
        }
        public int totalJovensRamoComercio()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE ramo = 'Comércio';";
            return this.QTD(SqlTOtal);
        }
        public int totalJovensOcupacional()
        {
            string SqlTOtal = "SELECT count(*) FROM tb_membros WHERE ramo in('Funcionário','Educação','Saúde','Religioso','Comércio','Militar/Policia','Nenhum');";
            return this.QTD(SqlTOtal);
        }
       

        public int totalTransferidos()
        {
            string SqlTOtal = "select count(*) from tb_membros where (ABS(TIMESTAMPDIFF(MONTH,data_emissao,CURRENT_DATE)) <='6') and (idade between '12' and '25')";
            return this.QTD(SqlTOtal);
        }
        public int totalNovosMembros()
        {
            string SqlTOtal = "select count(*) from tb_membros where ABS(TIMESTAMPDIFF(YEAR,data_emissao,CURRENT_DATE))<='1';";
            return this.QTD(SqlTOtal);
        }
    }
}
