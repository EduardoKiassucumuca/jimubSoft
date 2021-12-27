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
    public partial class form_estatistica : Form
    {
        Membro membro;
        public form_estatistica(Membro membro)
        {
            InitializeComponent();
            this.membro = membro;
        }

        private void form_estatistica_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            EstatisticaBindingSource.DataSource = this.membro.getOutrosDados();
        }

        private void EstatisticaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
