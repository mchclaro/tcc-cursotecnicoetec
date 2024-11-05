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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            //Cria o objeto do tipo frmSplash, com o nome de Splash
            frmSplash Splash = new frmSplash();
            //Coloca a visibilidade do formulario principal com o mesmo valor da variavel
            //que esta no frmSplash, ou seja, visible = false, colocando o formulario oculto
            this.Visible = Splash.visivel;
            //chama o objeto Splash para aparecer na tela
            //ATENÇÃOOOOOOOO
            //Neste momento os códigos executados estão todos no frmSplas
            //Voltando a executar a linha a baixo, somente quando o frmSplash fechar
            Splash.ShowDialog();
            //Após o frmSplash fechar,volta a executar esta linha, e agora como a variavel
            //visivel esta como "true", o formulario aparece na estla
            this.Visible = Splash.visivel;

        }
        
    
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Deseja realmente sair?", "", MessageBoxButtons.YesNo) == DialogResult.No))
            {
                e.Cancel = true;
            }
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            
            //Criar o objeto 
            frmTumulo Tumulo = new frmTumulo();
            //Liga o objeto ajuda ao MDI
            Tumulo.MdiParent = this.MdiParent;
            //Mostra o form (Objeto)
            Tumulo.ShowDialog();
        }

        private void btnDefunto_Click(object sender, EventArgs e)
        {
            //Criar o objeto 
            frmDefunto Defunto = new frmDefunto();
            //Liga o objeto ajuda ao MDI
            Defunto.MdiParent = this.MdiParent;
            //Mostra o form (Objeto)
            Defunto.ShowDialog();
            
        }

        private void btnPesquisaGeral_Click(object sender, EventArgs e)
        {
            //Criar o objeto 
            frmTipoPesquisa TipoPesquisa = new frmTipoPesquisa();
            //Liga o objeto ajuda ao MDI
            TipoPesquisa.MdiParent = this.MdiParent;
            //Mostra o form (Objeto)
            TipoPesquisa.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            //Criar o objeto 
            frmCategoria Categoria = new frmCategoria();
            //Liga o objeto ajuda ao MDI
            Categoria.MdiParent = this.MdiParent;
            //Mostra o form (Objeto)
            Categoria.ShowDialog();
        }

        private void lblPesquisaGeral_Click(object sender, EventArgs e)
        {

        }

      
    }
}
