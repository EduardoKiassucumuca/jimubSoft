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
    public partial class form_presenca : Form
    {
        private Campo campo;
        public form_presenca(Campo campo)
        {
            this.campo = campo;
            InitializeComponent();
        }

        Actividade actividade = new Actividade();
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Quantidade de homens") || textBox1.Text.Equals(""))
            {
                MessageBox.Show("Preencha o campo 1", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox2.Text.Equals("Quantidade de mulheres") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Preencha o campo 2", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.campo.qtd_homem = Convert.ToInt32(textBox1.Text);
                this.campo.qtd_mulher = Convert.ToInt32(textBox2.Text);
                actividade.inserirActividade(this.campo);
                if(!this.campo.exito.Equals(""))
                {
                    MessageBox.Show(this.campo.exito, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
                new frm_actividades(this.campo).Show();
            }
        }
    }
}
