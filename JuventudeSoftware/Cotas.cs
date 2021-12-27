using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1
{
    public partial class Cotas : Form
    {
        public Cotas()
        {
            InitializeComponent();
        }
        Campo campo = new Campo();
        Membro executa = new Membro();
        Validacao validar = new Validacao();
        Cota cotas = new Cota();
        //int total=0;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void textPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            campo.pesquisaNome = textPesquisaNome.Text;
            dataGridView1.DataSource = cotas.pesquisarCotas(campo);
        }

        private void comboBoxFase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Membros m = new Membros(this.campo);
            m.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login log = new Login();
            log.ShowDialog();
        }
        public void totalCotas(int total=0)
        {
            total = total + 200;
            textBoxtt.Text = Convert.ToString(total);
        }
        public void retirarValor(int total=0)
        {
            total = total - 200;
            textBoxtt.Text = Convert.ToString(total);
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonFev_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.verificaValor(e);
        }

        private void Cotas_Load(object sender, EventArgs e)
        {
            listar_Cotas();
            colunas();
            
        }

        private void radioButtonjan_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void radioButtonFev_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void radioButtonMa_MouseClick(object sender, MouseEventArgs e)
        {
        
        }

        private void radioButtonAb_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void radioButtonAb_CheckedChanged(object sender, EventArgs e)
        {
            //radioButtonMa.Checked = true;
        }

        private void labelTpR_Click(object sender, EventArgs e)
        {
          
        }
        private void colunas()
        {
            dataGridView1.Columns[0].HeaderText = "Nome";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].HeaderText = "Meses Pago";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].HeaderText = "Total Devido";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].HeaderText = "Total Pago";
            dataGridView1.Columns[3].Width = 128;
            dataGridView1.Columns[4].HeaderText = "Troco";
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].HeaderText = "Total";
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].HeaderText = "Data do pagamento";
            dataGridView1.Columns[6].Width = 150;
            dataGridView1.Columns[7].HeaderText = "Estado";
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.Columns[8].HeaderText = "Data Atual";
            dataGridView1.Columns[8].Width = 150;
 
        }
        private void listar_Cotas()
        {
            dataGridView1.DataSource = cotas.mostrar_Cotas();
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            DateTimePicker date = new DateTimePicker();
            string dat = date.Value.ToString("yyyy-MM-dd");
            int anop = dateTimePicker1.Value.Year;
            int mesp = dateTimePicker1.Value.Month;
            int diap = dateTimePicker1.Value.Day;
            string[] mes=new string[12];

         if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true) && (checkBoxJun.Enabled == false && checkBoxJun.Checked == true) && (checkBoxJulh.Enabled == false && checkBoxJulh.Checked == true) && (checkBoxAgo.Enabled == false && checkBoxAgo.Checked == true) && (checkBoxSet.Enabled == false && checkBoxSet.Checked == true) && (checkBoxOct.Enabled == false && checkBoxOct.Checked == true) && (checkBoxNov.Enabled == false && checkBoxNov.Checked == true)&&  (checkBoxDez.Enabled == false && checkBoxDez.Checked == true))
         {
             mes[0] = "Janeiro";
             mes[1] = "Fevereiro";
             mes[2] = "Março";
             mes[3] = "Abril";
             mes[4] = "Maio";
             mes[5] = "Junho";
             mes[6] = "Julho";
             mes[7] = "Agosto";
             mes[8] = "Setembro";
             mes[9] = "Octubro";
             mes[10] = "Novembro";
             mes[11] = "Dezembro";
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true) && (checkBoxJun.Enabled == false && checkBoxJun.Checked == true) && (checkBoxJulh.Enabled == false && checkBoxJulh.Checked == true) && (checkBoxAgo.Enabled == false && checkBoxAgo.Checked == true) && (checkBoxSet.Enabled == false && checkBoxSet.Checked == true) && (checkBoxOct.Enabled == false && checkBoxOct.Checked == true) && (checkBoxNov.Enabled == false && checkBoxNov.Checked == true))
         {
             mes[0] = "Janeiro";
             mes[1] = "Fevereiro";
             mes[2] = "Março";
             mes[3] = "Abril";
             mes[4] = "Maio";
             mes[5] = "Junho";
             mes[6] = "Julho";
             mes[7] = "Agosto";
             mes[8] = "Setembro";
             mes[9] = "Octubro";
             mes[10] = "Novembro";
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true) && (checkBoxJun.Enabled == false && checkBoxJun.Checked == true) && (checkBoxJulh.Enabled == false && checkBoxJulh.Checked == true) && (checkBoxAgo.Enabled == false && checkBoxAgo.Checked == true) && (checkBoxSet.Enabled == false && checkBoxSet.Checked == true) && (checkBoxOct.Enabled == false && checkBoxOct.Checked == true))
         {

             mes[0] = "Janeiro";
             mes[1] = "Fevereiro";
             mes[2] = "Março";
             mes[3] = "Abril";
             mes[4] = "Maio";
             mes[5] = "Junho";
             mes[6] = "Julho";
             mes[7] = "Agosto";
             mes[8] = "Setembro";
             mes[9] = "Octubro";
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true) && (checkBoxJun.Enabled == false && checkBoxJun.Checked == true) && (checkBoxJulh.Enabled == false && checkBoxJulh.Checked == true) && (checkBoxAgo.Enabled == false && checkBoxAgo.Checked == true) && (checkBoxSet.Enabled == false && checkBoxSet.Checked == true))
         {
             mes[0] = "Janeiro";
             mes[1] = "Fevereiro";
             mes[2] = "Março";
             mes[3] = "Abril";
             mes[4] = "Maio";
             mes[5] = "Junho";
             mes[6] = "Julho";
             mes[7] = "Agosto";
             mes[8] = "Setembro";
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true) && (checkBoxJun.Enabled == false && checkBoxJun.Checked == true) && (checkBoxJulh.Enabled == false && checkBoxJulh.Checked == true) && (checkBoxAgo.Enabled == false && checkBoxAgo.Checked == true))
         {
             mes[0] = "Janeiro";
             mes[1] = "Fevereiro";
             mes[2] = "Março";
             mes[3] = "Abril";
             mes[4] = "Maio";
             mes[5] = "Junho";
             mes[6] = "Julho";
             mes[7] = "Agosto";
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true) && (checkBoxJun.Enabled == false && checkBoxJun.Checked == true) && (checkBoxJulh.Enabled == false && checkBoxJulh.Checked == true))
         {
             mes[0] = "Janeiro";
             mes[1] = "Fevereiro";
             mes[2] = "Março";
             mes[3] = "Abril";
             mes[4] = "Maio";
             mes[5] = "Junho";
             mes[6] = "Julho";
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true)&&(checkBoxJun.Enabled == false && checkBoxJun.Checked == true))
         {
             mes[0] = "Janeiro";
             mes[1] = "Fevereiro";
             mes[2] = "Março";
             mes[3] = "Abril";
             mes[4] = "Maio";
             mes[5] = "Junho";
         
        }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true))
         {
             mes[0] = "Janeiro";
             mes[1] = "Fevereiro";
             mes[2] = "Março";
             mes[3] = "Abril";
             mes[4] = "Maio";
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true))
         {
             mes[0] = "Janeiro";
             mes[1] = "Fevereiro";
             mes[2] = "Março";
             mes[3] = "Abril";
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == true))
         {
             mes[0] = "Janeiro";
             mes[1] = "Fevereiro";
             mes[2] = "Março";
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true))
         {
             mes[0] = "Janeiro";
             mes[1] = "Fevereiro";
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true))
         {
             mes[0] = "Janeiro";
         }
         else if (textValor.Text == "" || textValor.Text == "Valor")
         { MessageBox.Show("Preencha o valor"); }
         else if (comboBoxEstado.Text == "Estado")
         { MessageBox.Show("Preencha o estado"); }
        
        
         string datap = Convert.ToString(anop + "-" + mesp + "-" + diap);
         campo.nome = labelNomeR.Text;
         campo.total_apagar =Convert.ToInt32(textBoxtt.Text);
         campo.total_pago =Convert.ToInt32(textValor.Text);
         campo.troco = Convert.ToInt32(textBoxTroco.Text);
         campo.data_pagamento = datap;
         campo.estadoP = comboBoxEstado.Text;
         cotas.inserirCotas(mes,campo);
         labelSucesso.Text = "Dados inseridos com sucesso";
         listar_Cotas();


        }

     private void checkBoxJan_CheckedChanged(object sender, EventArgs e)
     {
         if (checkBoxJan.Enabled == true && checkBoxJan.Checked == true)
         {
             totalCotas(Convert.ToInt32(textBoxtt.Text));
             checkBoxFev.Enabled = true;
             checkBoxJan.Enabled = false;
         }

     }

     private void checkBoxFev_CheckedChanged(object sender, EventArgs e)
     {
         if (checkBoxFev.Enabled == true && checkBoxFev.Checked == true)
         {
             totalCotas(Convert.ToInt32(textBoxtt.Text));
             checkBoxMa.Enabled = true;
             checkBoxFev.Enabled = false;
         }
         
     }

     private void checkBoxMa_CheckedChanged(object sender, EventArgs e)
     {
         if (checkBoxMa.Enabled == true && checkBoxMa.Checked == true)
         {
             totalCotas(Convert.ToInt32(textBoxtt.Text));
             checkBoxAbr.Enabled = true;
             checkBoxMa.Enabled = false;
             
         }
        
    
     }

     private void checkBoxAbr_CheckedChanged(object sender, EventArgs e)
     {
         if (checkBoxAbr.Enabled == true && checkBoxAbr.Checked == true)
         {
             totalCotas(Convert.ToInt32(textBoxtt.Text));
             checkBoxMai.Enabled = true;
             checkBoxAbr.Enabled = false;
             
         }
         
     }

     private void checkBoxMai_CheckedChanged(object sender, EventArgs e)
     {
         if (checkBoxMai.Enabled == true && checkBoxMai.Checked == true)
         {
             totalCotas(Convert.ToInt32(textBoxtt.Text));
             checkBoxJun.Enabled = true;
             checkBoxMai.Enabled = false;
         }
        
     }

     private void checkBoxJun_CheckedChanged(object sender, EventArgs e)
     {
         if (checkBoxJun.Enabled == true && checkBoxJun.Checked == true)
         {
             totalCotas(Convert.ToInt32(textBoxtt.Text));
             checkBoxJulh.Enabled = true;
             checkBoxJun.Enabled = false;
         }
       
     }

     private void checkBoxJulh_CheckedChanged(object sender, EventArgs e)
     {
         if (checkBoxJulh.Enabled == true && checkBoxJulh.Checked == true)
         {
             totalCotas(Convert.ToInt32(textBoxtt.Text));
             checkBoxAgo.Enabled = true;
             checkBoxJulh.Enabled = false;

         }
        
     }

     private void checkBoxAgo_CheckedChanged(object sender, EventArgs e)
     {
         if (checkBoxAgo.Enabled == true && checkBoxAgo.Checked == true)
         {
             totalCotas(Convert.ToInt32(textBoxtt.Text));
             checkBoxSet.Enabled = true;
             checkBoxAgo.Enabled = false;
         }
       
     }

     private void checkBoxSet_CheckedChanged(object sender, EventArgs e)
     {
         if (checkBoxSet.Enabled == true && checkBoxSet.Checked == true)
         {
             totalCotas(Convert.ToInt32(textBoxtt.Text));
             checkBoxOct.Enabled = true;
             checkBoxSet.Enabled = false;
         }
        
     }

     private void checkBoxOct_CheckedChanged(object sender, EventArgs e)
     {
         if (checkBoxOct.Enabled == true && checkBoxOct.Checked == true)
         {
             totalCotas(Convert.ToInt32(textBoxtt.Text));
             checkBoxNov.Enabled = true;
             checkBoxOct.Enabled = false;
         }
        
     }

     private void checkBoxNov_CheckedChanged(object sender, EventArgs e)
     {
         if (checkBoxNov.Enabled == true && checkBoxNov.Checked == true)
         {
             totalCotas(Convert.ToInt32(textBoxtt.Text));
             checkBoxDez.Enabled = true;
             checkBoxNov.Enabled = false;
         }
         
     }

     private void checkBoxDez_CheckedChanged(object sender, EventArgs e)
     {
         if (checkBoxDez.Enabled == true && checkBoxDez.Checked == true)
         {

             totalCotas(Convert.ToInt32(textBoxtt.Text));
             checkBoxDez.Enabled = false;
             checkBoxDez.Checked = true;

         }
        
     }

     private void button10_Click(object sender, EventArgs e)
     {
         if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true) && (checkBoxJun.Enabled == false && checkBoxJun.Checked == true) && (checkBoxJulh.Enabled == false && checkBoxJulh.Checked == true) && (checkBoxAgo.Enabled == false && checkBoxAgo.Checked == true) && (checkBoxSet.Enabled == false && checkBoxSet.Checked == true) && (checkBoxOct.Enabled == false && checkBoxOct.Checked == true) && (checkBoxNov.Enabled == false && checkBoxNov.Checked == true) && (checkBoxDez.Enabled == false && checkBoxDez.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxDez.Enabled = true;
             checkBoxDez.Checked = false;
         }

         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true) && (checkBoxJun.Enabled == false && checkBoxJun.Checked == true) && (checkBoxJulh.Enabled == false && checkBoxJulh.Checked == true) && (checkBoxAgo.Enabled == false && checkBoxAgo.Checked == true) && (checkBoxSet.Enabled == false && checkBoxSet.Checked == true) && (checkBoxOct.Enabled == false && checkBoxOct.Checked == true) && (checkBoxNov.Enabled == false && checkBoxNov.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxNov.Enabled = true;
             checkBoxNov.Checked = false;
             checkBoxDez.Enabled = false;
             checkBoxDez.Checked = false;
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true) && (checkBoxJun.Enabled == false && checkBoxJun.Checked == true) && (checkBoxJulh.Enabled == false && checkBoxJulh.Checked == true) && (checkBoxAgo.Enabled == false && checkBoxAgo.Checked == true) && (checkBoxSet.Enabled == false && checkBoxSet.Checked == true) && (checkBoxOct.Enabled == false && checkBoxOct.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxOct.Enabled = true;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Enabled = false;
             checkBoxDez.Checked = false;
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true)&&(checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true) && (checkBoxJun.Enabled == false && checkBoxJun.Checked == true) && (checkBoxJulh.Enabled == false && checkBoxJulh.Checked == true) && (checkBoxAgo.Enabled == false && checkBoxAgo.Checked == true) && (checkBoxSet.Enabled == false && checkBoxSet.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxSet.Enabled = true;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Enabled = false;
             checkBoxDez.Checked = false;
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true)&&(checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true) && (checkBoxJun.Enabled == false && checkBoxJun.Checked == true) && (checkBoxJulh.Enabled == false && checkBoxJulh.Checked == true) && (checkBoxAgo.Enabled == false && checkBoxAgo.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxAgo.Enabled = true;
             checkBoxAgo.Checked = false;
             checkBoxSet.Enabled = false;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Enabled = false;
             checkBoxDez.Checked = false;
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true)&&(checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true) && (checkBoxJun.Enabled == false && checkBoxJun.Checked == true) && (checkBoxJulh.Enabled == false && checkBoxJulh.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxJulh.Enabled = true;
             checkBoxJulh.Checked = false;
             checkBoxAgo.Enabled = false;
             checkBoxAgo.Checked = false;
             checkBoxSet.Enabled = false;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Enabled = false;
             checkBoxDez.Checked = false;
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true)&&(checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true) && (checkBoxJun.Enabled == false && checkBoxJun.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxJun.Enabled = true;
             checkBoxJun.Checked = false;
             checkBoxJulh.Enabled = false;
             checkBoxJulh.Checked = false;
             checkBoxAgo.Enabled = false;
             checkBoxAgo.Checked = false;
             checkBoxSet.Enabled = false;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Enabled = false;
             checkBoxDez.Checked = false;
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true)&&(checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxMai.Enabled = true;
             checkBoxMai.Checked = false;
             checkBoxJun.Enabled = false;
             checkBoxJun.Checked = false;
             checkBoxJulh.Enabled = false;
             checkBoxJulh.Checked = false;
             checkBoxAgo.Enabled = false;
             checkBoxAgo.Checked = false;
             checkBoxSet.Enabled = false;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Enabled = false;
             checkBoxDez.Checked = false;
        }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
           
             checkBoxAbr.Enabled = true;
             checkBoxAbr.Checked = false;
             checkBoxMai.Enabled = false;
             checkBoxMai.Checked = false;
             checkBoxJun.Enabled = false;
             checkBoxJun.Checked = false;
             checkBoxJulh.Enabled = false;
             checkBoxJulh.Checked = false;
             checkBoxAgo.Enabled = false;
             checkBoxAgo.Checked = false;
             checkBoxSet.Enabled = false;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Enabled = false;
             checkBoxDez.Checked = false;
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true)&&(checkBoxMa.Enabled == false && checkBoxMa.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
            
             checkBoxMa.Enabled = true;
             checkBoxMa.Checked = false;
             checkBoxAbr.Enabled = false;
             checkBoxAbr.Checked = false;
             checkBoxMai.Enabled = false;
             checkBoxMai.Checked = false;
             checkBoxJun.Enabled = false;
             checkBoxJun.Checked = false;
             checkBoxJulh.Enabled = false;
             checkBoxJulh.Checked = false;
             checkBoxAgo.Enabled = false;
             checkBoxAgo.Checked = false;
             checkBoxSet.Enabled = false;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Enabled = false;
             checkBoxDez.Checked = false;
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxFev.Enabled = true;
             checkBoxFev.Checked = false;
             checkBoxMa.Enabled = false;
             checkBoxMa.Checked = false;
             checkBoxAbr.Enabled = false;
             checkBoxAbr.Checked = false;
             checkBoxMai.Enabled = false;
             checkBoxMai.Checked = false;
             checkBoxJun.Enabled = false;
             checkBoxJun.Checked = false;
             checkBoxJulh.Enabled = false;
             checkBoxJulh.Checked = false;
             checkBoxAgo.Enabled = false;
             checkBoxAgo.Checked = false;
             checkBoxSet.Enabled = false;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Enabled = false;
             checkBoxDez.Checked = false;
         }
         else if ((checkBoxJan.Enabled == false && checkBoxJan.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxJan.Enabled = true;
             checkBoxJan.Checked = false;
             checkBoxFev.Enabled = false;
             checkBoxFev.Checked = false;
             checkBoxMa.Enabled = false;
             checkBoxMa.Checked = false;
             checkBoxAbr.Enabled = false;
             checkBoxAbr.Checked = false;
             checkBoxMai.Enabled = false;
             checkBoxMai.Checked = false;
             checkBoxJun.Enabled = false;
             checkBoxJun.Checked = false;
             checkBoxJulh.Enabled = false;
             checkBoxJulh.Checked = false;
             checkBoxAgo.Enabled = false;
             checkBoxAgo.Checked = false;
             checkBoxSet.Enabled = false;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Enabled = false;
             checkBoxDez.Checked = false;
         }
         else if ((checkBoxJan.Enabled == true && checkBoxJan.Checked == false) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == false) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == false) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == false) && (checkBoxMai.Enabled == false && checkBoxMai.Checked == false) && (checkBoxJun.Enabled == false && checkBoxJun.Checked == false) && (checkBoxJulh.Enabled == false && checkBoxJulh.Checked == false) && (checkBoxAgo.Enabled == false && checkBoxAgo.Checked == false) && (checkBoxSet.Enabled == false && checkBoxSet.Checked == false) && (checkBoxOct.Enabled == false && checkBoxOct.Checked == false) && (checkBoxNov.Enabled == false && checkBoxNov.Checked == false))
         {
             retirarValor(200);
         }
         else if ((checkBoxJan.Enabled == false && pictureBoxJan.Visible == true) && (checkBoxFev.Enabled == false && pictureBoxFev.Visible == true) && (checkBoxMa.Enabled == false && pictureBoxMa.Visible == true) && (checkBoxAbr.Enabled == false && pictureBoxAbr.Visible == true) && (checkBoxMai.Enabled == false && pictureBoxMai.Visible == true) && (checkBoxJun.Enabled == false && pictureBoxJun.Visible == true) && (checkBoxJulh.Enabled == false && pictureBoxJulh.Visible == true) && (checkBoxAgo.Enabled == false && pictureBoxAgo.Visible == true) && (checkBoxSet.Enabled == false && pictureBoxSet.Visible == true) && (checkBoxOct.Enabled == false && pictureBoxOct.Visible==true) && (checkBoxNov.Enabled == false && pictureBoxNov.Visible == true)&&(checkBoxDez.Enabled == false && pictureBoxDez.Visible == true))
         {
             textValor.Enabled = false;
             dateTimePicker1.Enabled = false;
             comboBoxEstado.Enabled = false;
             MessageBox.Show("Informação", "Todos os mêses estão pagos para o irmão " + labelNomeR.Text + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
         else if ((checkBoxJan.Enabled == false && pictureBoxJan.Visible == true) && (checkBoxFev.Enabled == false && pictureBoxFev.Visible == true) && (checkBoxMa.Enabled == false && pictureBoxMa.Visible == true) && (checkBoxAbr.Enabled == false && pictureBoxAbr.Visible == true) && (checkBoxMai.Enabled == false && pictureBoxMai.Visible == true) && (checkBoxJun.Enabled == false && pictureBoxJun.Visible == true) && (checkBoxJulh.Enabled == false && pictureBoxJulh.Visible == true) && (checkBoxAgo.Enabled == false && pictureBoxAgo.Visible == true) && (checkBoxSet.Enabled == false && pictureBoxSet.Visible == true) && (checkBoxOct.Enabled == false && pictureBoxOct.Visible == true) && (checkBoxNov.Enabled == false && pictureBoxNov.Visible == true) && (checkBoxDez.Enabled == false && checkBoxDez.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxDez.Checked = false;
             checkBoxDez.Enabled = true;
         }
         else if ((checkBoxJan.Enabled == false && pictureBoxJan.Visible == true) && (checkBoxFev.Enabled == false && pictureBoxFev.Visible == true) && (checkBoxMa.Enabled == false && pictureBoxMa.Visible == true) && (checkBoxAbr.Enabled == false && pictureBoxAbr.Visible == true) && (checkBoxMai.Enabled == false && pictureBoxMai.Visible == true) && (checkBoxJun.Enabled == false && pictureBoxJun.Visible == true) && (checkBoxJulh.Enabled == false && pictureBoxJulh.Visible == true) && (checkBoxAgo.Enabled == false && pictureBoxAgo.Visible == true) && (checkBoxSet.Enabled == false && pictureBoxSet.Visible == true) && (checkBoxOct.Enabled == false && pictureBoxOct.Visible == true) && (checkBoxNov.Enabled == false && checkBoxNov.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxNov.Enabled = true;
             checkBoxNov.Checked = false;
             checkBoxDez.Checked = false;
             checkBoxDez.Enabled = false;
         }
         else if ((checkBoxJan.Enabled == false && pictureBoxJan.Visible == true) && (checkBoxFev.Enabled == false && pictureBoxFev.Visible == true) && (checkBoxMa.Enabled == false && pictureBoxMa.Visible == true) && (checkBoxAbr.Enabled == false && pictureBoxAbr.Visible == true) && (checkBoxMai.Enabled == false && pictureBoxMai.Visible == true) && (checkBoxJun.Enabled == false && pictureBoxJun.Visible == true) && (checkBoxJulh.Enabled == false && pictureBoxJulh.Visible == true) && (checkBoxAgo.Enabled == false && pictureBoxAgo.Visible == true) && (checkBoxSet.Enabled == false && pictureBoxSet.Visible == true) && (checkBoxOct.Enabled == false && checkBoxOct.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxOct.Enabled = true;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Checked = false;
             checkBoxDez.Enabled = false;
         }
         else if ((checkBoxJan.Enabled == false && pictureBoxJan.Visible == true) && (checkBoxFev.Enabled == false && pictureBoxFev.Visible == true) && (checkBoxMa.Enabled == false && pictureBoxMa.Visible == true) && (checkBoxAbr.Enabled == false && pictureBoxAbr.Visible == true) && (checkBoxMai.Enabled == false && pictureBoxMai.Visible == true) && (checkBoxJun.Enabled == false && pictureBoxJun.Visible == true) && (checkBoxJulh.Enabled == false && pictureBoxJulh.Visible == true) && (checkBoxAgo.Enabled == false && pictureBoxAgo.Visible == true) && (checkBoxSet.Enabled == false && checkBoxSet.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxSet.Enabled = true;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Checked = false;
             checkBoxDez.Enabled = false;
         }
         else if ((checkBoxJan.Enabled == false && pictureBoxJan.Visible == true) && (checkBoxFev.Enabled == false && pictureBoxFev.Visible == true) && (checkBoxMa.Enabled == false && pictureBoxMa.Visible == true) && (checkBoxAbr.Enabled == false && pictureBoxAbr.Visible == true) && (checkBoxMai.Enabled == false && pictureBoxMai.Visible == true) && (checkBoxJun.Enabled == false && pictureBoxJun.Visible == true) && (checkBoxJulh.Enabled == false && pictureBoxJulh.Visible == true) && (checkBoxAgo.Enabled == false && checkBoxAgo.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxAgo.Enabled = true;
             checkBoxAgo.Checked = false;
             checkBoxSet.Enabled = false;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Checked = false;
             checkBoxDez.Enabled = false;
         }
         else if ((checkBoxJan.Enabled == false && pictureBoxJan.Visible == true) && (checkBoxFev.Enabled == false && pictureBoxFev.Visible == true) && (checkBoxMa.Enabled == false && pictureBoxMa.Visible == true) && (checkBoxAbr.Enabled == false && pictureBoxAbr.Visible == true) && (checkBoxMai.Enabled == false && pictureBoxMai.Visible == true) && (checkBoxJun.Enabled == false && pictureBoxJun.Visible == true) && (checkBoxJulh.Enabled == false && checkBoxJulh.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxJulh.Enabled = true;
             checkBoxJulh.Checked = false;
             checkBoxAgo.Enabled = false;
             checkBoxAgo.Checked = false;
             checkBoxSet.Enabled = false;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Checked = false;
             checkBoxDez.Enabled = false;
         }
         else if ((checkBoxJan.Enabled == false && pictureBoxJan.Visible == true) && (checkBoxFev.Enabled == false && pictureBoxFev.Visible == true) && (checkBoxMa.Enabled == false && pictureBoxMa.Visible == true) && (checkBoxAbr.Enabled == false && pictureBoxAbr.Visible == true) && (checkBoxMai.Enabled == false && pictureBoxMai.Visible == true) && (checkBoxJun.Enabled == false && checkBoxJun.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxJun.Enabled = true;
             checkBoxJun.Checked = false;
             checkBoxJulh.Enabled = false;
             checkBoxJulh.Checked = false;
             checkBoxAgo.Enabled = false;
             checkBoxAgo.Checked = false;
             checkBoxSet.Enabled = false;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Checked = false;
             checkBoxDez.Enabled = false;
         }
         else if ((checkBoxJan.Enabled == false && pictureBoxJan.Visible == true) && (checkBoxFev.Enabled == false && pictureBoxFev.Visible == true) && (checkBoxMa.Enabled == false && pictureBoxMa.Visible == true) && (checkBoxAbr.Enabled == false && checkBoxAbr.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxAbr.Enabled = true;
             checkBoxAbr.Checked = false;
             checkBoxMai.Enabled = false;
             checkBoxMai.Checked = false;
             checkBoxJun.Enabled = false;
             checkBoxJun.Checked = false;
             checkBoxJulh.Enabled = false;
             checkBoxJulh.Checked = false;
             checkBoxAgo.Enabled = false;
             checkBoxAgo.Checked = false;
             checkBoxSet.Enabled = false;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Checked = false;
             checkBoxDez.Enabled = false;
         }
         else if ((checkBoxJan.Enabled == false && pictureBoxJan.Visible == true) && (checkBoxFev.Enabled == false && pictureBoxFev.Visible == true) && (checkBoxMa.Enabled == false && checkBoxMa.Checked == true))
         {
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxMa.Enabled = true;
             checkBoxMa.Checked = false;
             checkBoxAbr.Enabled = false;
             checkBoxAbr.Checked = false;
             checkBoxMai.Enabled = false;
             checkBoxMai.Checked = false;
             checkBoxJun.Enabled = false;
             checkBoxJun.Checked = false;
             checkBoxJulh.Enabled = false;
             checkBoxJulh.Checked = false;
             checkBoxAgo.Enabled = false;
             checkBoxAgo.Checked = false;
             checkBoxSet.Enabled = false;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Checked = false;
             checkBoxDez.Enabled = false;
         }
         else if ((checkBoxJan.Enabled == false && pictureBoxJan.Visible == true) && (checkBoxFev.Enabled == false && checkBoxFev.Checked == true)){
             retirarValor(Convert.ToInt32(textBoxtt.Text));
             checkBoxFev.Enabled = true;
             checkBoxFev.Checked = false;
             checkBoxMa.Enabled = false;
             checkBoxMa.Checked = false;
             checkBoxAbr.Enabled = false;
             checkBoxAbr.Checked = false;
             checkBoxMai.Enabled = false;
             checkBoxMai.Checked = false;
             checkBoxJun.Enabled = false;
             checkBoxJun.Checked = false;
             checkBoxJulh.Enabled = false;
             checkBoxJulh.Checked = false;
             checkBoxAgo.Enabled = false;
             checkBoxAgo.Checked = false;
             checkBoxSet.Enabled = false;
             checkBoxSet.Checked = false;
             checkBoxOct.Enabled = false;
             checkBoxOct.Checked = false;
             checkBoxNov.Enabled = false;
             checkBoxNov.Checked = false;
             checkBoxDez.Checked = false;
             checkBoxDez.Enabled = false;
         }
         
     }

     private void textBox2_TextChanged(object sender, EventArgs e)
     {
         
     }

     private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
     {
         int valor = 0;
         valor = Convert.ToInt32(textValor.Text) - Convert.ToInt32(textBoxtt.Text);
         textBoxTroco.Text = Convert.ToString(valor);
     }

     private void buttonCancelar_Click(object sender, EventArgs e)
     {
         textValor.Text = "Valor";
         textBoxTroco.Text = "Troco";
         comboBoxEstado.Text = "Estado";
     }

     private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
     {
         if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
         {
             campo.nome = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
             cotas.apagar_cota(campo);
             listar_Cotas();
             MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
     }

     private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
     {
         Visualiza_Cota vc = new Visualiza_Cota();
         vc.labelNomeR.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
         campo.nome = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
         vc.labelCargoR.Text = cotas.buscarCargo(campo);
         vc.labelClasseR.Text = cotas.buscarClasse(campo);
         vc.labelComissaoR.Text = cotas.buscarComissao(campo);
         vc.labelMesesR.Text = cotas.retornaCotas(campo);
         vc.labelTotalR.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
         vc.ShowDialog();
         //vc.labelDataPagamentoR.Text = this.dataGridView1.CurrentRow.Cells[6].ToString();
     }

     private void pagarCotasToolStripMenuItem_Click(object sender, EventArgs e)
     {

     }
   }
}
