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
    public partial class form_relatorio_actividade : Form
    {
        private Actividade actividade;
        public form_relatorio_actividade(Actividade act)
        {
            this.actividade = act;
            InitializeComponent();
        }

        private void form_relatorio_actividade_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
            RelatorioActividadeBindingSource.DataSource = this.actividade.get_actividade();
        }
    }
}
