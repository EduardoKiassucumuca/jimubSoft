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
    public partial class form_relatorio_patrimonio : Form
    {
        private Patrimonio patrimonio;
        public form_relatorio_patrimonio(Patrimonio p)
        {
            this.patrimonio = p;
            InitializeComponent();
        }

        private void form_relatorio_patrimonio_Load(object sender, EventArgs e)
        {
            RelatorioPatrimonioBindingSource.DataSource = this.patrimonio.get_patrimonio();
            this.reportViewer1.RefreshReport();
        }
    }
}
