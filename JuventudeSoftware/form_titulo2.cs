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
    public partial class form_titulo2 : Form
    {
        private DataGridView tabela;
        private Actividade actividade;
        private Patrimonio patrimonio;
        public form_titulo2(DataGridView tabela,Actividade actividade,Patrimonio patrimonio)
        {
            this.actividade = actividade;
            this.patrimonio = patrimonio;
            this.tabela = tabela;
            InitializeComponent();
        }

        private void exportar(DataGridView tb)
        {
           

            if (this.actividade != null)
            {


                foreach (DataGridViewRow linha in tb.Rows)
                {

                    RelatorioActividade act = new RelatorioActividade()
                    {
                        comissao = linha.Cells[1].Value.ToString(),
                        tema = linha.Cells[2].Value.ToString(),
                        obejectivo = linha.Cells[3].Value.ToString(),
                        orador = linha.Cells[4].Value.ToString(),
                        estado_actividade = linha.Cells[5].Value.ToString(),
                        local_actividade = linha.Cells[6].Value.ToString(),
                        data_actividade = linha.Cells[7].Value.ToString(),
                        hora_actividade = linha.Cells[8].Value.ToString(),
                        titulo = textBox1.Text
                    };
                    this.actividade.add_actividade(act);
                }
                this.Close();
                new form_relatorio_actividade(this.actividade).Show();
            }
            else if (this.patrimonio != null)
            {
                foreach (DataGridViewRow linha in tb.Rows)
                {
                    RelatorioPatrimonio p = new RelatorioPatrimonio()
                    {
                        comissao = linha.Cells[1].Value.ToString(),
                        material = linha.Cells[2].Value.ToString(),
                        qtd = int.Parse(linha.Cells[3].Value.ToString()),
                        estado = linha.Cells[4].Value.ToString(),
                        titulo = textBox1.Text
                    };
                    this.patrimonio.add_patrimonio(p);

                }
                this.Close();
                new form_relatorio_patrimonio(this.patrimonio).Show();

            }
            else
            {

            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            
            this.exportar(this.tabela);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_titulo2_Load(object sender, EventArgs e)
        {

        }
    }
}
