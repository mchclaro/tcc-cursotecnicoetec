using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcc2
{
    public partial class frmTipoPesquisa : Form
    {
        public frmTipoPesquisa()
        {
            InitializeComponent();
        }

        private void btnPesquisaGeralTumulo_Click(object sender, EventArgs e)
        {
            //Criar o objeto 
            frmPesquisaTumulo PesquisaTumulo = new frmPesquisaTumulo();
            //Liga o objeto ajuda ao MDI
            PesquisaTumulo.MdiParent = this.MdiParent;
            //Mostra o form (Objeto)
            PesquisaTumulo.ShowDialog();
        }

        private void btnPesquisaGeralDefunto_Click(object sender, EventArgs e)
        {
            //Criar o objeto 
            frmPesquisaDefunto PesquisaDefunto = new frmPesquisaDefunto();
            //Liga o objeto ajuda ao MDI
            PesquisaDefunto.MdiParent = this.MdiParent;
            //Mostra o form (Objeto)
            PesquisaDefunto.ShowDialog();
        }
    }
}
