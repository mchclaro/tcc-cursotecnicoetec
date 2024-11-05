using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcc2
{
    public partial class frmSplash : Form
    {
        public bool visivel = false;
        Informacoes info = new Informacoes();
        public frmSplash()
        {
            InitializeComponent();
            
        }

        //int Carregando = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void lblCarregando_Click(object sender, EventArgs e)
        {

        }

        public bool VerificaLogin()
        {
            bool result = false;
            //String StringDeConexao = @"Data Source=PC6\SQLEXPRESS;Initial Catalog= tcc;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = info.StringDeConexao;

            try
            {
                String ComandoSQL = @"select * from Usuario where nome= '" + txtUsuario.Text +
                            "' and senha = '" + txtSenha.Text + "' ";
                SqlCommand cmd = new SqlCommand(ComandoSQL, con);
                con.Open();
               SqlDataReader dados = cmd.ExecuteReader();
                result = dados.HasRows;

            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
           
            if (txtUsuario.Text != null)
            {
               this.visivel = true;
               this.Close();            
            }
            else
            {
                MessageBox.Show("Usuario e/ou senha incorretos");
            }
        }

        
        
        private void picSplash2_Click(object sender, EventArgs e)
        {

        }

        private void picSplash1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

    }
}

