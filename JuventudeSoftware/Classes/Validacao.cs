using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1.Classes
{
    class Validacao
    {
        Regex regBI = new Regex(@"^[0-9]{8}[A-Z]{2}[0-9]{3}$");
        Regex regTelefone = new Regex(@"^[9]{1}[0-9]{8}$");

        public void validarMembro(Campo c)
        {
                string[] numeros = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

            //Match analiseTelefone1 = regTelefone.Match(Convert.ToString(c.telefone1));
            //Match analiseTelefone2 = regTelefone.Match(Convert.ToString(c.telefone2));
            // Match analiseBI = regBI.Match(c.bi_cedula);

            if (c.nome == "" && c.bairro == "" && c.rua == "" && c.descricao == "" && c.telefone1.ToString() == "" && c.cargo == ""  && c.facebook=="" && c.profissao == "" && c.areaFormacao == "" && c.nivelEscolar == "" && c.pai == "" && c.mae == "" && c.cat_membro =="" && c.grupo =="" && c.classe =="" && c.sexo == "" && c.estado == "" && c.estado_civil == "" && c.motivo_ausencia == "" && c.ano1 == DateTime.Now.Year && c.mes1 == DateTime.Now.Month && c.dia1 == DateTime.Now.Day && c.ano2 == DateTime.Now.Year && c.mes2 == DateTime.Now.Month && c.dia2 == DateTime.Now.Day)
            {
                c.verifica = false;
                MessageBox.Show("Preencha os dados", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (c.nome == "Nome Completo" && c.bairro == "Bairro" && c.rua == "Rua" && c.descricao == "Descrição ou numero da casa" && c.cargo == "Cargo" && c.classe == "Classes" && c.sexo == "Sexo" && c.facebook == "Facebook" && c.profissao == "Profissão" && c.areaFormacao == "Área de Formação" && c.nivelEscolar == "Nível Escolar" && c.pai == "Pai" && c.mae == "Mãe" && c.cat_membro == "Categoria de membro" && c.grupo == "Grupo" && c.classe == "Classes" && c.estado == "Estado" && c.motivo_ausencia == "Motivo" && c.ano1 == DateTime.Now.Year && c.mes1 == DateTime.Now.Month && c.dia1 == DateTime.Now.Day && c.ano2 == DateTime.Now.Year && c.mes2 == DateTime.Now.Month && c.dia2 == DateTime.Now.Day && c.como_ingressou == "Como ingressou a organização" && c.presenca == "Frequência nas actividades" && c.motivo_ausencia == "Motivo")
                {
                c.verifica = false;
                MessageBox.Show("Preencha os dados", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
               }
            
                else if (c.nome == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o nome", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (c.bairro == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o bairro", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.rua == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a rua", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
                else if (c.descricao == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a descrição da casa", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.sexo == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o sexo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (c.ano1 == DateTime.Now.Year && c.mes1 == DateTime.Now.Month && c.dia1 == DateTime.Now.Day)
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a data de nascimento", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
              
                else if (c.facebook == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o facebook", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.nivelEscolar == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o nível escolar", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.areaFormacao == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a area de Formação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        
                else if (c.profissao == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a profissão", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.pai == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o pai", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.cat_membro == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a categoria de membro", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            else if (c.grupo == "")
            {
                c.verifica = false;
                MessageBox.Show("Preencha o grupo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (c.classe == "")
            {
                c.verifica = false;
                MessageBox.Show("Preencha a classe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (c.comissao == "")
            {
                c.verifica = false;
                MessageBox.Show("Preencha o comissão", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (c.mae == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o mãe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            else if (c.estado_civil == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o estado civil", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.grupo == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o grupo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.ano2 == DateTime.Now.Year && c.mes2 == DateTime.Now.Month && c.dia2 == DateTime.Now.Day)
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a data de ingresso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (c.estado == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o estado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.cargo == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o cargo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (c.ano2 == DateTime.Now.Year && c.mes2 == DateTime.Now.Month && c.dia2 == DateTime.Now.Day)
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a data de ingresso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.alcunha == "")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a alcunha", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (c.nome == "Nome Completo")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o nome", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (c.bairro == "Bairro")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o bairro", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.rua == "Rua")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a rua", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (c.telefone1 == 920000000)
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o telefone1", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.telefone2 == 990000000)
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o telefone2", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
                else if (c.descricao == "Descrição ou numero da casa")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a descrição da casa", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (c.sexo == "Sexo")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o sexo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               

                else if (c.ano1 == DateTime.Now.Year && c.mes1 == DateTime.Now.Month && c.dia1 == DateTime.Now.Day)
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a data de nascimento", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.facebook == "Facebook")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o facebook", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.nivelEscolar == "Nível Escolar")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o nível escolar", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.areaFormacao == "Área de Formação")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a area de Formação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (c.profissao == "Profissão")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a profissão", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            else if (c.pai == "Pai")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o pai", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.mae == "Mãe")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a mãe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            else if (c.cat_membro == "Categoria de membro")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a categoria de membro", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.grupo == "Grupo")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o grupo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.classe == "Classes")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a classe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.comissao == "Comissão")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o comissão", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            else if (c.estado_civil == "Estado Civil")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o estado civil", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            else if (c.cargo == "Cargo")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha o cargo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (c.ano2 == DateTime.Now.Year && c.mes2 == DateTime.Now.Month && c.dia2 == DateTime.Now.Day)
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a data de ingresso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.alcunha == "Alcunha")
                {
                    c.verifica = false;
                    MessageBox.Show("Preencha a alcunha", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (c.como_ingressou == "Como ingressou a organização")
                {
                    c.verifica = false;
                MessageBox.Show("Preencha o campo \"como ingressou a organização\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }
            else if (c.presenca == "Frequência nas actividades")
                {
                c.verifica = false;
                MessageBox.Show("Preencha o campo \"Presença\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }
            else if (c.motivo_ausencia == "Motivo")
            {
                c.verifica = false;
                MessageBox.Show("Preencha o campo \"Motivo\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (c.ramo == "Ramo Ocupacional" || c.ramo == "")
            {
                c.verifica = false;
                MessageBox.Show("Preencha o campo \"Ramo OcupacionL\"", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                {
                    c.verifica = true;
                    
                }
        }
        public void verificaTexto(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            { e.Handled = true; }
        }
        public void verificaValor(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            { e.Handled = true; }
        }

    }
}
