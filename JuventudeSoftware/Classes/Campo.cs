using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes
{
    public class Campo
    {
        //Dados do login
        public string usuario,user_acesso,cargo2;
        private int id_user,id_user_acesso;
        public Boolean verifica;
        
        public string erro;
       // public string exito;
        //public StringBuilder m;
        private string senha,senha2;

        // Dados de logs
        public string descricao_log, data_log,hora_log;

        public int get_id_user_acessor()
        {
            return this.id_user_acesso;
        }

        public void set_id_user_acesso(int ID)
        {
            this.id_user_acesso = ID;
        }
        public int get_Iduser()
        {
            return this.id_user;
        }

        public void set_Iduser(int ID)
        {
            this.id_user = ID;
        }
        public string get_senha()
        {
            return this.senha;
        }

        public void set_senha(string novaSenha)
        {
            this.senha = novaSenha;
        }
        public string get_senha2()
        {
            return this.senha2;
        }

        public void set_senha2(string novaSenha)
        {
            this.senha2 = novaSenha;
        }

        //Dados dos membros
        public string nome,exito, bairro, rua, alcunha, descricao, bi_cedula, identificacao, pesquisaFase, pesquisaNome, pesquisaBairro, cat_membro, cargo, classe, sexo, estado_civil, grupo, estado, comissao, img, data_nascimento, data_ingresso, data_pagamento, estadoP,email,facebook,escola,ramo, profissao,areaFormacao,nivelEscolar,pai,mae,igrejAnterior,opfuncaoFuturo,sobreJuventude,como_ingressou,presenca,motivo_ausencia;
        public int telefone1, idade, telefone2, ano1, mes1, dia1, ano2, mes2, dia2, total_apagar, total_pago, troco;

        // Dados das actividades
        private String comissaoEncarregue, tema, objectivo, orador,estado_actividade,local_actividade, data_actividade, hora;
        public int hour, minute,qtd_homem,qtd_mulher;
        private int id_actividade;

        // Dados de envio de sms
        public string pesqPersonalisada;

        //Dados das actividades
        public void setId_actividade(int id)
        {
            this.id_actividade = id;
        }

        public int getID_actividade()
        {
            return this.id_actividade;
        }
        public void setComissaoEncarregue(String comissaoEncarregue)
        {
            this.comissaoEncarregue = comissaoEncarregue;
        }

        public String getComissaoEncarregue()
        {
            return this.comissaoEncarregue;
        }
        public void setTema(String tema)
        {
            this.tema = tema;
        }

        public String getTema()
        {
            return this.tema;
        }

        public void setObjectivo(String objectivo)
        {
            this.objectivo = objectivo;
        }

        public String getObjectivo()
        {
            return this.objectivo;
        }
   
        public void setOrador(String orador)
        {
            this.orador = orador;
        }

        public String getOrador()
        {
            return this.orador;
        }

        public void setEstadoActividade(String estado)
        {
            this.estado_actividade = estado;
        }

        public String getEstadoActividade()
        {
            return this.estado_actividade;
        }

        public void setLocalActividade(String local)
        {
            this.local_actividade = local;
        }

        public String getLocalActividade()
        {
            return this.local_actividade;
        }

        public void setdatActividade(String data)
        {
            this.data_actividade = data;
        }

        public String getDatActividade()
        {
            return this.data_actividade;
        }

        public void setHorActividade(String hora)
        {
            this.hora = hora;
        }

        public String gethorActividade()
        {
            return this.hora;
        }


        //Dados do patrimonio

        public string material, estado_conservacao;
        public int qtd;
        private int id_patrimonio;
        public void set_idPatrimonio(int id)
        {
            this.id_patrimonio = id;
        }
        public int get_idPatrimonio()
        {
            return this.id_patrimonio;
        }


    }
}
