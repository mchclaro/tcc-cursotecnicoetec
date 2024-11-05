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
    public partial class frmPesquisaDefunto : Form
    {
        Informacoes info = new Informacoes();
        public frmPesquisaDefunto()
        {
            InitializeComponent();
        }

        private void frmPesquisaDefunto_Load(object sender, EventArgs e)
        {
            carregaDGV(@"select codigo as 'Código:', Nome as 'Nome:', DataDeNascimento as 'Data de Nascimento:', 
                        DataDeEnterro as 'Data de Enterro:', Idade as 'Idade:', DataDeFalecimento as 'Data de Falecimento', 
						Sexo as 'Sexo:', Naturalidade as 'Naturalidade:', Cemiterio as 'Cemitério:', Seccao as 'Secção', 
                        NumeroDoTumulo as 'Número do Túmulo:', CausaDaMorte as 'Causa da Morte:', NomeResponsavel
                        as 'Nome Reponsável:', Funeraria as 'Funeraria:'from Defunto");
            dgvDefunto.ReadOnly = true;
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
                dgvDefunto.DataSource = ds;
                dgvDefunto.DataMember = ds.Tables[0].TableName;
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

        private void txtPesquisaGeralDefunto_TextChanged(object sender, EventArgs e)
        {
            carregaDGV(@"select codigo as 'Código:', Nome as 'Nome:', DataDeNascimento as 'Data de Nascimento:', 
                        DataDeEnterro as 'Data de Enterro:', Idade as 'Idade:', DataDeFalecimento as 'Data de Falecimento', 
						Sexo as 'Sexo:', Naturalidade as 'Naturalidade:', Cemiterio as 'Cemitério:', Seccao as 'Secção', 
                        NumeroDoTumulo as 'Número do Túmulo:', CausaDaMorte as 'Causa da Morte:', NomeResponsavel
                        as 'Nome Reponsável:', Funeraria as 'Funeraria:' from Defunto where Nome like '%" +
                        txtPesquisaGeralDefunto.Text + "%' " + " or DataDeNascimento like '%" + txtPesquisaGeralDefunto.Text + "%'"
                        + " or DataDeNascimento like '%" + txtPesquisaGeralDefunto.Text + "%'"
                        + " or DataDeEnterro like '%" + txtPesquisaGeralDefunto.Text + "%'"
                        + " or Idade like '%" + txtPesquisaGeralDefunto.Text + "%'"
                        + " or DataDeFalecimento like '%" + txtPesquisaGeralDefunto.Text + "%'"
                        + " or Sexo like '%" + txtPesquisaGeralDefunto.Text + "%'"
                        + " or Naturalidade like '%" + txtPesquisaGeralDefunto.Text + "%'"
                        + " or Cemiterio like '%" + txtPesquisaGeralDefunto.Text + "%'"
                        + " or Seccao like '%" + txtPesquisaGeralDefunto.Text + "%'"
                        + " or NumeroDoTumulo like '%" + txtPesquisaGeralDefunto.Text + "%'"
                        + " or CausaDaMorte like '%" + txtPesquisaGeralDefunto.Text + "%'"
                        + " or NomeResponsavel like '%" + txtPesquisaGeralDefunto.Text + "%'"
                        + " or Funeraria like '%" + txtPesquisaGeralDefunto.Text + "%'"

                         );
        }

        private void dgvDefunto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
