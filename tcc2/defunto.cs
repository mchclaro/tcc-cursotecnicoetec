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
    public partial class frmDefunto : Form
    {
        Informacoes info = new Informacoes();

        public frmDefunto()
        {
            InitializeComponent();
        }

        private void Defunto_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarDefunto_Click(object sender, EventArgs e)
        {

            string sql = @"INSERT INTO Defunto(Nome,DataDeNascimento,DataDeEnterro,Idade,DataDeFalecimento,
                                           Sexo,Naturalidade,Cemiterio,Seccao,NumeroDoTumulo,CausaDaMorte,NomeResponsavel,
                                                Funeraria)"     
                       + "VALUES ('"
                       + txtNomeDefunto.Text + "', '"
                       + mskDataDeNascimento.Text + "', '"
                       + mskDataDeEnterro.Text + "', '"
                       + txtIdade.Text + "', '"
                       + mskDataDeFalecimento.Text + "', '"
                       + txtSexo.Text + "', '"
                       + txtNaturalidade.Text + "', '"
                       + txtCemiterio.Text + "', '"
                       + txtSeccao.Text + "', '"
                       + txtNumeroDoTumulo.Text + "', '"
                       + txtCausaDaMorte.Text + "', '"
                       + txtNomeResponsavel.Text + "', '"
                       + txtFuneraria.Text + "')";

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

        private void lblNumerodoTumulo_Click(object sender, EventArgs e)
        {

        }

        private void lblCausaDaMorte_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarDefunto_Click(object sender, EventArgs e)
        {
            EditarDefunto();
        }

        
        private void EditarDefunto()
        {
            txtNomeDefunto.ReadOnly = false;
            mskDataDeNascimento.ReadOnly = false;
            mskDataDeEnterro.ReadOnly = false;
            txtIdade.ReadOnly = false;
            mskDataDeFalecimento.ReadOnly = false;
            txtSexo.ReadOnly = false;
            txtNaturalidade.ReadOnly = false;
            txtCemiterio.ReadOnly = false;
            txtSeccao.ReadOnly = false;
            txtNumeroDoTumulo.ReadOnly = false;
            txtCausaDaMorte.ReadOnly = false;
            txtNomeResponsavel.ReadOnly = false;
            txtFuneraria.ReadOnly = false;
            txtNomeDefunto.Enabled = true;

            ltbNomeDefunto.Visible = false;
            mskDataDeNascimento.Enabled = true;
            mskDataDeEnterro.Enabled = true;
            txtIdade.Enabled = true;
            mskDataDeFalecimento.Enabled = true;
            txtSexo.Enabled = true;
            txtNaturalidade.Enabled = true;
            txtCemiterio.Enabled = true;
            txtSeccao.Enabled = true;
            txtNumeroDoTumulo.Enabled = true;
            txtCausaDaMorte.Enabled = true;
            txtNomeResponsavel.Enabled = true;
            txtFuneraria.Enabled = true;
            btnEditarDefunto.Visible = false;
            lblEditarDefunto.Visible = false;
            btnExcluirDefunto.Visible = true;
            lblExcluirDefunto.Visible = true;

            btnGravarDefunto.Visible = true;
            btnGravarDefunto.Enabled = true;
            lblGravarDefunto.Visible = true;
            lblGravarDefunto.Enabled = true;
            btnSalvarDefunto.Visible = false;
            lblSalvarTumulo.Visible = false;
            btnNovoDefunto.Enabled = false;
            lblNovoDefunto.Visible = false;
            btnCancelarDefunto.Visible = true;
            btnCancelarDefunto.Enabled = true;
            lblCancelarDefunto.Visible = true;
            lblCancelarDefunto.Enabled = true;
            txtNomeDefunto.Focus();

        }

        private void mskDataDeEnterro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Deseja realmente sair? Os dados digitados não serão salvos.", "", MessageBoxButtons.YesNo) == DialogResult.No))
            {
                e.Cancel = true;
            }
        }

        private void NovoDefunto()
        {
            ltbNomeDefunto.Visible = false;
            txtCodigoDefunto.Text = "";
            txtCodigoDefunto.ReadOnly = false;
            txtNomeDefunto.Text = "";
            txtNomeDefunto.ReadOnly = false;
            mskDataDeNascimento.Text = "";
            mskDataDeNascimento.ReadOnly = false;
            mskDataDeEnterro.Text = "";
            mskDataDeEnterro.ReadOnly = false;
            txtIdade.Text = "";
            txtIdade.ReadOnly = false;
            mskDataDeFalecimento.Text = "";
            mskDataDeFalecimento.ReadOnly = false;
            txtSexo.Text = "";
            txtSexo.Enabled = true;
            txtNaturalidade.Text = "";
            txtNaturalidade.ReadOnly = false;
            txtCemiterio.Text = "";
            txtCemiterio.ReadOnly = false;
            txtSeccao.Text = "";
            txtSeccao.ReadOnly = false;
            txtNumeroDoTumulo.Text = "";
            txtNumeroDoTumulo.ReadOnly = false;
            txtCausaDaMorte.Text = "";
            txtCausaDaMorte.ReadOnly = false;
            txtNomeResponsavel.Text = "";
            txtNomeResponsavel.ReadOnly = false;
            txtFuneraria.Text = "";
            txtFuneraria.ReadOnly = false;
            txtNomeDefunto.Focus();
        }

        private void btnNovoDefunto_Click(object sender, EventArgs e)
        {
            NovoDefunto();
        }

        private void btnPesquisarDefunto_Click(object sender, EventArgs e)
        {
            txtPesquisaDefunto.Visible = true;
            txtPesquisaDefunto.ReadOnly = false;
            ltbCodigoDefunto.Visible = true;
            ltbNomeDefunto.Visible = true;
            btnSalvarDefunto.Enabled = false;
            btnEditarDefunto.Enabled = false;
            btnGravarDefunto.Enabled = false;
            btnNovoDefunto.Visible = false;
            btnPesquisarDefunto.Enabled = false;
            btnCancelarDefunto.Visible = true;
            btnCancelarDefunto.Enabled = true;
            lblCancelarDefunto.Visible = true;
            txtNomeDefunto.Enabled = false;
            mskDataDeNascimento.Enabled = false;
            mskDataDeEnterro.Enabled = false;
            txtIdade.Enabled = false;
            mskDataDeFalecimento.Enabled = false;
            txtSexo.Enabled = false;
            txtNaturalidade.Enabled = false;
            txtCemiterio.Enabled = false;
            txtSeccao.Enabled = false;
            txtNumeroDoTumulo.Enabled = false;
            txtCausaDaMorte.Enabled = false;
            txtNomeResponsavel.Enabled = false;
            txtFuneraria.Enabled = false;
            txtPesquisaDefunto.Focus();

            
        }

        private void txtPesquisaDefunto_TextChanged(object sender, EventArgs e)
        {
            ltbCodigoDefunto.Items.Clear();
            ltbNomeDefunto.Items.Clear();

            String sql = "select * from Defunto where Nome like '%" + txtPesquisaDefunto.Text + "%'";
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
                    ltbCodigoDefunto.Items.Add(ListaDeDados[i]);
                    ltbNomeDefunto.Items.Add(ListaDeDados2[i]);
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

        private void btnCancelarDefunto_Click(object sender, EventArgs e)
        {
            txtCodigoDefunto.Enabled = true;
            txtNomeDefunto.Enabled = true;
            mskDataDeNascimento.Enabled = true;
            mskDataDeEnterro.Enabled = true;
            txtIdade.Enabled = true;
            mskDataDeFalecimento.Enabled = true;
            txtSexo.Enabled = true;
            txtNaturalidade.Enabled = true;
            txtCemiterio.Enabled = true;
            txtSeccao.Enabled = true;
            txtNumeroDoTumulo.Enabled = true;
            txtCausaDaMorte.Enabled = true;
            txtNomeResponsavel.Enabled = true;
            txtFuneraria.Enabled = true;
            txtCodigoDefunto.Focus();
            btnCancelarDefunto.Visible = false;
            ltbCodigoDefunto.Visible = false;
            ltbNomeDefunto.Visible = false;
            lblCancelarDefunto.Visible = false;
            btnNovoDefunto.Visible = true;
            btnNovoDefunto.Enabled = true;
            lblNovoDefunto.Visible = true;
            btnSalvarDefunto.Enabled = true;
            btnPesquisarDefunto.Enabled = true;
            txtPesquisaDefunto.Clear();
            txtPesquisaDefunto.Visible = false;
            txtNomeDefunto.Focus();
            btnGravarDefunto.Visible = false;
            lblGravarDefunto.Visible = false;
            btnSalvarDefunto.Visible = true;
            lblSalvarTumulo.Visible = true;
            btnEditarDefunto.Enabled = false;

            btnEditarDefunto.Visible = true;
            lblEditarDefunto.Visible = true;
            btnExcluirDefunto.Visible = false;
            lblExcluirDefunto.Visible = false;

            txtNomeDefunto.Clear();
            mskDataDeNascimento.Clear();
            mskDataDeEnterro.Clear();
            txtIdade.Clear();
            mskDataDeFalecimento.Clear();
            txtSexo.Clear();
            txtNaturalidade.Clear();
            txtCemiterio.Clear();
            txtSeccao.Clear();
            txtNumeroDoTumulo.Clear();
            txtCausaDaMorte.Clear();
            txtNomeResponsavel.Clear();
            txtFuneraria.Clear();
            txtCodigoDefunto.Clear();
            
        }

        private void btnGravarDefunto_Click(object sender, EventArgs e)
        {

            string sql = @"UPDATE DEFUNTO "
               + "SET Nome = '"
               + txtNomeDefunto.Text + "', "
               + "DataDeNascimento = '"
               + mskDataDeNascimento.Text + "', "
               + "DataDeEnterro = '"
               + mskDataDeEnterro.Text + "', "
               + "Idade = '"
               + txtIdade.Text + "', "
               + "DataDeFalecimento = '"
               + mskDataDeFalecimento.Text + "', "
               + "Sexo = '"
               + txtSexo.Text + "', "
               + "Naturalidade = '"
               + txtNaturalidade.Text + "', "
               + "Cemiterio = '"
               + txtCemiterio.Text + "', "
               + "Seccao = '"
               + txtSeccao.Text + "', "
               + "NumeroDoTumulo = '"
               + txtNumeroDoTumulo.Text + "', "
               + "CausaDaMorte = '"
               + txtCausaDaMorte.Text + "', "
               + "NomeResponsavel = '"
               + txtNomeResponsavel.Text + "', "
               + "Funeraria = '"
               + txtFuneraria.Text + "' "
               + "WHERE codigo = "
               + txtCodigoDefunto.Text;


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

        private void ltbCodigoDefunto_SelectedIndexChanged(object sender, EventArgs e)
        {
            String codigo = ltbCodigoDefunto.Text;
            String sql = "select * from Defunto where codigo = " + codigo;
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
                    txtCodigoDefunto.Text = reader[0].ToString();
                    txtNomeDefunto.Text = reader[1].ToString();
                    mskDataDeNascimento.Text = reader[2].ToString();
                    mskDataDeEnterro.Text = reader[3].ToString();
                    txtIdade.Text = reader[4].ToString();
                    mskDataDeFalecimento.Text = reader[5].ToString();
                    txtSexo.Text = reader[6].ToString();
                    txtNaturalidade.Text = reader[7].ToString();
                    txtCemiterio.Text = reader[8].ToString();
                    txtSeccao.Text = reader[9].ToString();
                    txtNumeroDoTumulo.Text = reader[10].ToString();
                    txtCausaDaMorte.Text = reader[11].ToString();
                    txtNomeResponsavel.Text = reader[12].ToString();
                    txtFuneraria.Text = reader[13].ToString();

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

            btnEditarDefunto.Enabled = true;
            ltbCodigoDefunto.Visible = false;
            ltbNomeDefunto.Visible = false;
            txtPesquisaDefunto.Visible = false;
            txtCodigoDefunto.Enabled = false;
            btnCancelarDefunto.Enabled = true;

            /*txtNomeDefunto.Enabled = true;
            mskDataDeNascimento.Enabled = true;
            mskDataDeEnterro.Enabled = true;
            txtIdade.Enabled = true;
            mskDataDeFalecimento.Enabled = true;
            txtSexo.Enabled = true;
            txtNaturalidade.Enabled = true;
            txtCemiterio.Enabled = true;
            txtSeccao.Enabled = true;
            txtNumeroDoTumulo.Enabled = true;
            txtCausaDaMorte.Enabled = true;
            txtNomeResponsavel.Enabled = true;
            txtFuneraria.Enabled = true; */
        }

        private void lblSecção_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirDefunto_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Defunto WHERE codigo=" + int.Parse(txtCodigoDefunto.Text) + "";


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

            txtCodigoDefunto.Clear();
            txtNomeDefunto.Clear();
            mskDataDeNascimento.Clear();
            mskDataDeEnterro.Clear();
            txtIdade.Clear();
            mskDataDeFalecimento.Clear();
            txtSexo.Clear();
            txtNaturalidade.Clear();
            txtCemiterio.Clear();
            txtSeccao.Clear();
            txtNumeroDoTumulo.Clear();
            txtCausaDaMorte.Clear();
            txtNomeResponsavel.Clear();
            txtFuneraria.Clear();
        }

        private void lblExcluirDefunto_Click(object sender, EventArgs e)
        {

        }
    }
}
