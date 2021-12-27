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
    public partial class form_analisaEstado : Form
    {
        private Campo c;
        public form_analisaEstado(Campo campo)
        {
            this.c = campo;
            InitializeComponent();
        }
        Actividade actividade = new Actividade();

        private void form_analisaEstado_Load(object sender, EventArgs e)
        {
            labelTema.Text = this.c.getTema();
            labelComissao.Text = this.c.getComissaoEncarregue();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            actividade.alteraEstadoPlan(this.c);
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            label3.Text = "Preencha os campos abaixo!";
            buttonGuardar.Visible = false;
            buttonCancelar.Visible = false;

            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Quantidade de homens") || textBox1.Text.Equals(""))
            {
                MessageBox.Show("Preencja o primeiro campo!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox2.Text.Equals("Quantidade de mulheres") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Preencja o segundo campo!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.c.qtd_homem = Convert.ToInt32(textBox1.Text);
                this.c.qtd_mulher = Convert.ToInt32(textBox2.Text);

                actividade.alteraEstadoPlan2(this.c);
                this.Close();
            }
        }
    }
}
