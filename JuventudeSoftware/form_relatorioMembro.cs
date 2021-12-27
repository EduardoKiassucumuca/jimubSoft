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
    public partial class form_relatorioMembro : Form
    {
        Membro membro;
       
        public form_relatorioMembro(Membro membro)
        {
            InitializeComponent();
            this.membro = membro;
        }



        private void form_relatorioMembro_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            RelatorioMembroBindingSource.DataSource = this.membro.getDados();

        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
