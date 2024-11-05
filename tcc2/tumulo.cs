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
    public partial class frmTumulo : Form
    {
        Informacoes info = new Informacoes();

        public frmTumulo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            string sql = @"INSERT INTO Tumulo(Nome,Endereco,Cidade,Bairro,CEP,Estado,Telefone,Celular)"
                       + "VALUES ('"
                       + txtResponsavelTumulo.Text + "', '"
                       + txtEndereco.Text + "', '"
                       + txtCidade.Text + "', '"
                       + txtBairro.Text + "', '"
                       + mskCEP.Text + "', '"
                       + cmbEstado.Text + "', '"
                       + mskTelefone.Text + "', '"
                       + mskCelular.Text + "')";

            //String StringDeConexao = @"Data Source=PC6\SQLEXPRESS; Initial Catalog=tcc;
                                      //Integrated Security = True";
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = info.StringDeConexao;
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;
            cn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString());
            }
            finally
            {
                cn.Close();
            }
            
        }

        private void tumulo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarTumulo();
        }

        private void EditarTumulo()
        {

            txtResponsavelTumulo.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtCidade.ReadOnly = false;
            txtBairro.ReadOnly = false;
            mskCEP.ReadOnly = false;
            mskTelefone.ReadOnly = false;
            mskCelular.ReadOnly = false;
            btnSalvarTumulo.Enabled = false;
            btnSalvarTumulo.Visible = false;
            btnNovoTumulo.Enabled = false;
            btnGravarTumulo.Visible = true;
            btnGravarTumulo.Enabled = true;
            lblGravarTumulo.Visible = true;
            txtResponsavelTumulo.Focus();

            ltbResponsavelTumulo.Visible = false;
            txtResponsavelTumulo.Enabled = true;
            txtEndereco.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            mskCEP.Enabled = true;
            cmbEstado.Enabled = true;
            mskTelefone.Enabled = true;
            mskCelular.Enabled = true;

            
            btnEditarTumulo.Visible = false;
            lblEditarTumulo.Visible = false;
            btnExcluirTumulo.Visible = true;
            lblExcluirTumulo.Visible = true;
            
        }

        private void frmSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Deseja realmente sair? Os dados digitados não serão salvos.", "", MessageBoxButtons.YesNo) == DialogResult.No))
            {
                e.Cancel = true;
            }
        }

        private void btnNovoTumulo_Click(object sender, EventArgs e)
        {
            NovoTumulo();
        }

        
        private void NovoTumulo()
        {
            ltbResponsavelTumulo.Visible = false;
            txtCodigoTumulo.Text = "";
            txtCodigoTumulo.ReadOnly = false;
            txtResponsavelTumulo.Text = "";
            txtResponsavelTumulo.ReadOnly = false;
            txtEndereco.Text = "";
            txtEndereco.ReadOnly = false;
            txtCidade.Text = "";
            txtCidade.ReadOnly = false;
            txtBairro.Text = "";
            txtBairro.ReadOnly = false;
            mskCEP.Text = "";
            mskCEP.ReadOnly = false;
            cmbEstado.Text = "";
            cmbEstado.Enabled = true;
            mskCelular.Text = "";
            mskCelular.ReadOnly = false;
            mskTelefone.Text = "";
            mskTelefone.ReadOnly = false;
            txtResponsavelTumulo.Focus();
        }

        private void btnPesquisarTumulo_Click(object sender, EventArgs e)
        {
            txtPesquisaTumulo.Visible = true;
            txtPesquisaTumulo.ReadOnly = false;
            ltbCodigoTumulo.Visible = true;
            ltbResponsavelTumulo.Visible = true;
            btnSalvarTumulo.Enabled = false;
            btnEditarTumulo.Enabled = false;
            btnGravarTumulo.Enabled = false;
            btnNovoTumulo.Visible = false;
            btnPesquisarTumulo.Enabled = false;
            btnCancelarTumulo.Visible = true;
            btnCancelarTumulo.Enabled = true;
            lblCancelarTumulo.Visible = true;
            txtResponsavelTumulo.Enabled = false;
            txtEndereco.Enabled = false;
            txtCidade.Enabled = false;
            txtBairro.Enabled = false;
            mskCEP.Enabled = false;
            mskTelefone.Enabled = false;
            mskCelular.Enabled = false;
            txtPesquisaTumulo.Focus();
        }

        private void txtPesquisaTumulo_TextChanged(object sender, EventArgs e)
        {
            ltbCodigoTumulo.Items.Clear();
            ltbResponsavelTumulo.Items.Clear();
            
                String sql = "select * from Tumulo where Nome like '%" + txtPesquisaTumulo.Text + "%'";
                //String StringDeConexao = @"Data Source=PC6\SQLEXPRESS; Initial Catalog=tcc;
                                        //Integrated Security = True";
                SqlConnection con = new SqlConnection(info.StringDeConexao);
                SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                // cmd.CommandType = CommandType.Text;
                SqlDataAdapter reader = new SqlDataAdapter(cmd);

                //Estrutura da tabela
                var objDataTable = new DataTable();

                // Preencher com a estrutura do select enviado com as tuplas = linha do sql
                reader.Fill(objDataTable);

                // Cria lista
                List<string> ListaDeDados = new List<string>();
                List<string> ListaDeDados2 = new List<string>();

                // Percorrer as linhas do datatable para adicionar na lista
                foreach (DataRow dataRow in objDataTable.Rows)
                {
                    // Adiciona na lista Especificando a coluna
                    string informação = dataRow["codigo"].ToString();
                    ListaDeDados.Add(informação);
                    string informação2 = dataRow["nome"].ToString();
                    ListaDeDados2.Add(informação2);
                }
                for (int i = 0; i < ListaDeDados.Count(); i++)
                {
                    ltbCodigoTumulo.Items.Add(ListaDeDados[i]);
                    ltbResponsavelTumulo.Items.Add(ListaDeDados2[i]);
                }
            }
            catch (Exception ex)
            {
                //Trata exceção
                throw ex;
            }
            finally
            {
                con.Close();
            }
        
        }

        private void btnCancelarTumulo_Click(object sender, EventArgs e)
        {
            txtResponsavelTumulo.Enabled = true;
            txtEndereco.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            mskCEP.Enabled = true;
            mskTelefone.Enabled = true;
            mskCelular.Enabled = true;
            btnCancelarTumulo.Visible = false;
            ltbCodigoTumulo.Visible = false;
            ltbResponsavelTumulo.Visible = false;
            lblCancelarTumulo.Visible = false;
            btnNovoTumulo.Visible = true;
            btnNovoTumulo.Enabled = true;
            lblNovoTumulo.Visible = true;
            btnSalvarTumulo.Enabled = true;
            btnPesquisarTumulo.Enabled = true;
            txtCodigoTumulo.Enabled = true;
            txtPesquisaTumulo.Clear();
            btnEditarTumulo.Enabled = false;
            btnGravarTumulo.Visible = false;
            lblGravarTumulo.Visible = false;
            btnSalvarTumulo.Visible = true;
            btnSalvarTumulo.Enabled = true;
            lblSalvarTumulo.Visible = true;

            btnEditarTumulo.Visible = true;
            lblEditarTumulo.Visible = true;
            btnExcluirTumulo.Visible = false;
            lblExcluirTumulo.Visible = false;

            txtResponsavelTumulo.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            mskCEP.Clear();
            cmbEstado.SelectedIndex = 0;
            mskTelefone.Clear();
            mskCelular.Clear();
            txtCodigoTumulo.Clear();
        }

        private void btnGravarTumulo_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE Tumulo "
               + "SET Nome = '"
               + txtResponsavelTumulo.Text + "', "
               + "Endereco = '"
               + txtEndereco.Text + "', "
               + "Cidade = '"
               + txtCidade.Text + "', "
               + "Bairro = '"
               + txtBairro.Text + "', "
               + "CEP = '"
               + mskCEP.Text + "', "
               + "Estado = '"
               + cmbEstado.Text + "', "
               + "Telefone = '"
               + mskTelefone.Text + "', "
               + "Celular = '"
               + mskCelular.Text + "' "
               + "WHERE codigo = "
               + txtCodigoTumulo.Text;


            //String StringDeConexao = @"Data Source=PC6\SQLEXPRESS; Initial Catalog=tcc;
                                      //Integrated Security = True";
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = info.StringDeConexao;
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;
            cn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao alterar o cadastro!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString());
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnEditarTumulo_Click(object sender, EventArgs e)
        {
            EditarTumulo();
        }

        private void ltbCodigoTumulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String codigo = ltbCodigoTumulo.Text;
            String sql = "select * from Tumulo where codigo = " + codigo;
            //String StringDeConexao = @"Data Source=PC6\SQLEXPRESS; Initial Catalog=tcc;
                                        //Integrated Security = True";
            SqlConnection con = new SqlConnection(info.StringDeConexao);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtCodigoTumulo.Text = reader[0].ToString();
                    txtResponsavelTumulo.Text = reader[1].ToString();
                    txtEndereco.Text = reader[2].ToString();
                    txtCidade.Text = reader[3].ToString();
                    txtBairro.Text = reader[4].ToString();
                    mskCEP.Text = reader[5].ToString();
                    cmbEstado.Text = reader[6].ToString();
                    mskTelefone.Text = reader[7].ToString();
                    mskCelular.Text = reader[8].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Erro!!!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            btnEditarTumulo.Enabled = true;
            ltbCodigoTumulo.Visible = false;
            ltbResponsavelTumulo.Visible = false;
            txtPesquisaTumulo.Visible = false;
            txtCodigoTumulo.Enabled = false;
            btnCancelarTumulo.Enabled = true;
            cmbEstado.Enabled = false;

        }

        private void btnExcluirTumulo_Click(object sender, EventArgs e)
        {

            string sql = "DELETE FROM Tumulo WHERE codigo=" + int.Parse(txtCodigoTumulo.Text) + "";


            //String StringDeConexao = @"Data Source=PC6\SQLEXPRESS; Initial Catalog=tcc;
                                      //Integrated Security = True";
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = info.StringDeConexao;
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;
            cn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastro excluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao excluir o cadastro!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString());
            }
            finally
            {
                cn.Close();
            }

            txtCodigoTumulo.Clear();
            txtResponsavelTumulo.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            mskCEP.Clear();
            cmbEstado.SelectedIndex = 0;
            mskTelefone.Clear();
            mskCelular.Clear();
        }
         
    }
}
