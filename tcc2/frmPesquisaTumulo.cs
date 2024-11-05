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
    public partial class frmPesquisaTumulo : Form
    {
        Informacoes info = new Informacoes();
        public frmPesquisaTumulo()
        {
            InitializeComponent();
        }

        private void frmPesquisaTumulo_Load(object sender, EventArgs e)
        {
            carregaDGV(@"select codigo as 'Código:', Nome as 'Nome:', Endereco as 'Endereço:', Cidade as 'Cidade:',
                                Bairro as 'Bairro:', CEP as 'CEP:', Estado as 'Estado:', Telefone as 'Telefone:',
                                Celular as 'Celular:'                          

                            from Tumulo");
            dgvTumulo.ReadOnly = true;
        }

        public void carregaDGV(String SQL)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = info.StringDeConexao;

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(SQL, cn);
                SqlDataAdapter dados = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dados.Fill(ds);
                dgvTumulo.DataSource = ds;
                dgvTumulo.DataMember = ds.Tables[0].TableName;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void txtPesquisaGeralTumulo_TextChanged(object sender, EventArgs e)
        {
            carregaDGV(@"select codigo as 'Código:', Nome as 'Nome:', Endereco as 'Endereço:', Cidade as 'Cidade:',
                                Bairro as 'Bairro:', CEP as 'CEP:', Estado as 'Estado:', Telefone as 'Telefone:',
                                Celular as 'Celular:' from Tumulo where Nome like '%" + txtPesquisaGeralTumulo.Text + "%' "
                                + " or Endereco like '%" + txtPesquisaGeralTumulo.Text + "%'"
                                + " or Cidade like '%" + txtPesquisaGeralTumulo.Text + "%'"
                                + " or Bairro like '%" + txtPesquisaGeralTumulo.Text + "%'"
                                + " or CEP like '%" + txtPesquisaGeralTumulo.Text + "%'"
                                + " or Estado like '%" + txtPesquisaGeralTumulo.Text + "%'"
                                + " or Telefone like '%" + txtPesquisaGeralTumulo.Text + "%'"
                                + " or Celular like '%" + txtPesquisaGeralTumulo.Text + "%'");
        }

        private void dgvTumulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
